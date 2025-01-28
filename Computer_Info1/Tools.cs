using System;
using System.Windows;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Net;
using System.Management;
using System.Reflection;
using Microsoft.Office.Interop.Excel;
using System.IO;
using Microsoft.Win32;
using System.Security.Principal;
using System.Diagnostics;
using System.DirectoryServices.AccountManagement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Text.RegularExpressions;
//using System.Management.Automation;

namespace Computer_Info1
{
    internal class Tools
    {
        public static string GetLocalIPAddress()
        {
            string localIP;
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            {
                socket.Connect("8.8.8.8", 65530);
                IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                localIP = endPoint.Address.ToString();
            }
            return localIP;
        }

        public static string GetLocalMac_Wlan()
        {
            string addr = "";
            foreach (NetworkInterface n in NetworkInterface.GetAllNetworkInterfaces() )
            {
                //MessageBox.Show(n.Name + " | " + n.OperationalStatus);
                if (/* n.OperationalStatus == OperationalStatus.Up &&*/ n.Name.StartsWith("Wi-Fi") &&
                    n.NetworkInterfaceType==NetworkInterfaceType.Wireless80211 )
                {
                    addr += n.GetPhysicalAddress().ToString();
                    //MessageBox.Show( n.Description + " OperationalStatus: " +n.OperationalStatus);  
                    //MessageBox.Show(n.Name);
                    //break;
                }
                //MessageBox.Show(n.Name);
            }
            string lan = "";
            for (int i = 0; i < addr.Length; i++)
            {
                if (i % 2 == 0 && i > 0)
                {
                    lan += ":";
                }
                lan += addr[i];

            }
            return lan;
        }

        public static string GetLocalMac_Wlan2()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapter");
            ManagementObjectCollection adapters = searcher.Get();

            foreach (ManagementObject adapter in adapters)
            {
                
                    MessageBox.Show("Nazwa: " + adapter["Name"]+ "Typ interfejsu: " + adapter["AdapterType"]
                        + "Status: " + adapter["NetConnectionStatus"] + "MAC: " + adapter["MACAddress"]);  
            }
            //status 0 - network adapter is off
            //status 7 - network adapter is on - can't transfer data
            //status 2 - network adapter id on - can transfer data
            return "0";
        }

        public static string GetLocalMac_Lan()
        {
            string addr = "";
            foreach (NetworkInterface n in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (/* n.OperationalStatus == OperationalStatus.Up && */ n.Name.StartsWith("Ethernet"))
                {
                    addr += n.GetPhysicalAddress().ToString();
                    //MessageBox.Show(n.Name);
                    break;
                }
                //MessageBox.Show(n.Name);
            }
            string lan = "";
            for (int i = 0; i < addr.Length; i++)
            {
                if (i % 2 == 0 && i > 0)
                {
                    lan += ":";
                }
                lan += addr[i];

            }
            return lan;
        }

        public static string GetLocalSN()
        {

            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher("SELECT SerialNumber, SMBIOSBIOSVersion, ReleaseDate FROM Win32_BIOS");

            ManagementObjectCollection information = searcher.Get();
            foreach (ManagementObject obj in information)
            {
                foreach (PropertyData data in obj.Properties)
                {
                    if (data.Name.ToString().StartsWith("SerialN"))
                    {
                        searcher.Dispose();
                        return data.Value.ToString();
                    }
                    //MessageBox.Show(data.Name.ToString() +" "+ data.Value.ToString());
                    //MessageBox.Show(data.Value.ToString() +" | "+data.Name.ToString() );
                }
            }
            searcher.Dispose();
            return "1";
        }

        
        public static void ExportData(string dhcp_lan,string dhcp_wlan, string nr_inw,string id)
        {
           

            // Create a new Excel application instance
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            // Create a new Workbook object
            Workbook workbook = excel.Workbooks.Add();

            // Get the first worksheet
            Worksheet worksheet = (Worksheet)workbook.Worksheets[1];

            // Set the column headers
            worksheet.Cells[1, 1] = "Hostname";
            worksheet.Cells[1, 2] = "SN";
            worksheet.Cells[1, 3] = "MAC LAN";
            worksheet.Cells[1, 4] = "MAC WLAN";
            worksheet.Cells[1, 5] = "IP Address";
            worksheet.Cells[1, 6] = "Nr.Inw";
            worksheet.Cells[1, 7] = "ID";

            
            worksheet.Cells[2, 1] = System.Net.Dns.GetHostName();
            worksheet.Cells[2, 2] = Tools.GetLocalSN();
            worksheet.Cells[2, 3] = Tools.GetLocalMac_Lan();
            worksheet.Cells[2, 4] = Tools.GetLocalMac_Wlan();
            worksheet.Cells[2, 5] = Tools.GetLocalIPAddress();
            worksheet.Cells[2, 6] = nr_inw;
            worksheet.Cells[2, 7] = id;
            worksheet.Cells[4, 1] = dhcp_lan;
            worksheet.Cells[6, 1] = dhcp_wlan;

            //Microsoft.Office.Interop.Excel.Range usedRange = worksheet.UsedRange;
            worksheet.UsedRange.Columns.AutoFit();

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, "Raport " + System.Net.Dns.GetHostName() + ".xlsx");

            //return userFolderPath;
            // Save the workbook

            try
            {
                workbook.SaveAs(filePath, XlFileFormat.xlOpenXMLWorkbook, Missing.Value,
                            Missing.Value, false, false, XlSaveAsAccessMode.xlNoChange,
                            XlSaveConflictResolution.xlUserResolution, true, Missing.Value,
                            Missing.Value, Missing.Value);
                        // Close the workbook and release the COM objects
                workbook.Close();
                excel.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);

        }
        
        public static string getCPU()
        {
            string cpu="";
            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher("SELECT Name from Win32_Processor");
            foreach(ManagementObject obj in searcher.Get() )
            {
                cpu += obj["Name"];
            }
            return cpu;
        }

        public static string getRAM()
        {
            string ram="";
            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher("SELECT * from Win32_ComputerSystem");
            foreach(ManagementObject obj in searcher.Get() )
            {
                double Ram_Bytes = (Convert.ToDouble(obj["TotalPhysicalMemory"]));
                Ram_Bytes/= 1073741824;
                Ram_Bytes=Math.Ceiling(Ram_Bytes);
                ram = (Ram_Bytes).ToString();
            }
            return ram;
        }

        public static string getLocalDisk()
        {
            string drive_info = "Hard Disk: ";
            ManagementObjectSearcher harddisk=
                new ManagementObjectSearcher("SELECT * from win32_DiskDrive");
            foreach (ManagementObject obj in harddisk.Get())
            {
                drive_info += obj["Model"];
                Int64 disk_bytes= Convert.ToInt64(obj["Size"]);
                disk_bytes /= 1073741824;
                drive_info += " Size: " +(disk_bytes).ToString() + "GB";
            }
            return drive_info;
        }

        public static bool setLocalHostName(string newName)
        {
            string domainName = "";
            string domainUser = "";
            string domainPassword = "";
            Form2 credentialsForm=new Form2();
            credentialsForm.ShowDialog();

            if(credentialsForm.Visible==false)
            {
                domainUser = credentialsForm.returnUsername;
                domainPassword = credentialsForm.returnPassword;
            }



            string script = $@"
            $newName = '{newName}'
            $domain = '{domainName}'
            $username = '{domainUser}'
            $password = ConvertTo-SecureString '{domainPassword}' -AsPlainText -Force
            $credential = New-Object System.Management.Automation.PSCredential ($username, $password);
            
            Rename-Computer -NewName $newName -DomainCredential $credential -Force";


            ProcessStartInfo processInfo = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{script}\"",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true

            };
            using (Process process = new Process { StartInfo = processInfo })
            {

                process.Start();

                // Read the output (optional)
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                process.WaitForExit();

                // print the status of command
                if (process.ExitCode != 0) { MessageBox.Show("Exit code = " + process.ExitCode); }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Reboot is required, reboot now ?", "Reboot", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Process.Start("ShutDown", "/r");
                    }
                }
                
            }
            return true;
        }

        public static bool IsAdministrator() // true when run as admin
        {
            var identity = WindowsIdentity.GetCurrent();
            var principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        public static void SetLocalAdminOn(string password)
        {
            // Create a new process
            ProcessStartInfo process = new ProcessStartInfo();

            // set name of process to "WMIC.exe"
            process.FileName = "WMIC.exe";

            // pass rename PC command as argument
            process.Arguments = "useraccount where \"name='Administrator' and domain='" + System.Net.Dns.GetHostName() + "'\" set disabled=false";

            // Run the external process & wait for it to finish
            using (Process proc = Process.Start(process))
            {
                proc.WaitForExit();

                // print the status of command
                if(proc.ExitCode!=0) {MessageBox.Show("Exit code = " + proc.ExitCode); }
                
            }

            string Command = "net user administrator " + password;
            ProcessStartInfo Process2Info;
            Process Process2;

            Process2Info = new ProcessStartInfo("cmd.exe", " /c " + Command);
            Process2Info.UseShellExecute = false;
            Process2Info.CreateNoWindow = true;
            Process2Info.WindowStyle = ProcessWindowStyle.Hidden; 
            
            Process2Info.RedirectStandardOutput = true;
            Process2Info.RedirectStandardError = true;  
            
            Process2 = Process.Start(Process2Info);
            Process2.WaitForExit();
            if (Process2.ExitCode == 0) // success
            {
                //Process2.Close();
                MessageBox.Show(Process2.StandardOutput.ReadLine());
            }
            else // password not set
            {

                MessageBox.Show(Process2.StandardError.ReadLine());
            }
            
        }


        public static string validateHostName(string  hostName)
        {
            if(System.Net.Dns.GetHostName()==hostName)
            {
                return "New hostName can't be the same as current hostName";
            }
            if (string.IsNullOrEmpty(hostName) || hostName.Length > 63)
            {
                return "HostName must have between 1-63 characters";
            }

            // Check if the hostname contains only valid characters
            if (!Regex.IsMatch(hostName, @"^[a-zA-Z0-9-]+$"))
            {
                return "HostName contain invalid characters";
            }

            // Check if the hostname starts or ends with a hyphen
            if (hostName.StartsWith("-") || hostName.EndsWith("-"))
            {
                return "HostName can't start\\end with \'-\'";
            }

            // Check if the hostname consists only of digits
            if (Regex.IsMatch(hostName, @"^\d+$"))
            {
                return "HostName can't be only digits";
            }

            return "OK";
        }

        public static string getManufacturerAndName()
        {

            string hostName= System.Net.Dns.GetHostName();
            string manufacturer="";
            string model="";


            System.Management.SelectQuery query = new System.Management.SelectQuery(@"Select * from Win32_ComputerSystem");

            //initialize the searcher with the query it is supposed to execute
            using (System.Management.ManagementObjectSearcher searcher = new System.Management.ManagementObjectSearcher(query))
            {
                //execute the query
                foreach (System.Management.ManagementObject process in searcher.Get())
                {
                    //print system info
                    process.Get();
                    Console.WriteLine("/*********Operating System Information ***************/");
                    manufacturer = process["Manufacturer"].ToString();
                    model = process["Model"].ToString();
                    Console.WriteLine("{0}{1}", "System Manufacturer:", process["Manufacturer"]);
                    Console.WriteLine("{0}{1}", " System Model:", process["Model"]);


                }
            }

            return manufacturer+model;
        }
    }
}
