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
            foreach (NetworkInterface n in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (n.OperationalStatus != OperationalStatus.Up && n.Name.StartsWith("Wi-Fi"))
                {
                    //network card turned off
                    MessageBox.Show("turning on wlan network card");

                    ProcessStartInfo psi = new ProcessStartInfo("netsh", "interface set interface \"" + n.Name + "\" enable");
                    Process p = new Process();
                    p.StartInfo = psi;
                    p.Start();

                }

                if (/*n.OperationalStatus == OperationalStatus.Up  && */ n.Name.StartsWith("Wi-Fi"))
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

        public static string GetLocalMac_Lan()
        {
            string addr = "";
            foreach (NetworkInterface n in NetworkInterface.GetAllNetworkInterfaces())
            {
                /*
                if(/*n.OperationalStatus == OperationalStatus.Down && n.Name.StartsWith("Ethernet"))
                {
                    //network card turned off
                    MessageBox.Show("turning on lan network card");
                    
                    ProcessStartInfo psi = new ProcessStartInfo("netsh", "interface set interface \"" + n.Name + "\" enable");
                    Process p = new Process();
                    p.StartInfo = psi;
                    p.Start();
                    
                }
                */
                if ( n.OperationalStatus == OperationalStatus.Up && n.Name.StartsWith("Ethernet"))
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


            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, "Raport " + System.Net.Dns.GetHostName() + ".xlsx");

            //return userFolderPath;
            // Save the workbook
            workbook.SaveAs(filePath, XlFileFormat.xlOpenXMLWorkbook, Missing.Value,
                Missing.Value, false, false, XlSaveAsAccessMode.xlNoChange,
                XlSaveConflictResolution.xlUserResolution, true, Missing.Value,
                Missing.Value, Missing.Value);
            
            // Close the workbook and release the COM objects
            workbook.Close();
            excel.Quit();
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
            RegistryKey key = Registry.LocalMachine;

            string activeComputerName = "SYSTEM\\CurrentControlSet\\Control\\ComputerName\\ActiveComputerName";
            RegistryKey activeCmpName = key.CreateSubKey(activeComputerName);
            activeCmpName.SetValue("ComputerName", newName);
            activeCmpName.Close();
            string computerName = "SYSTEM\\CurrentControlSet\\Control\\ComputerName\\ComputerName";
            RegistryKey cmpName = key.CreateSubKey(computerName);
            cmpName.SetValue("ComputerName", newName);
            cmpName.Close();
            string _hostName = "SYSTEM\\CurrentControlSet\\services\\Tcpip\\Parameters\\";
            RegistryKey hostName = key.CreateSubKey(_hostName);
            hostName.SetValue("Hostname", newName);
            hostName.SetValue("NV Hostname", newName);
            hostName.Close();
            return true;
        }

        public static bool IsAdministrator() // true when run as admin
        {
            var identity = WindowsIdentity.GetCurrent();
            var principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
    }
}
