using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Info1
{
    public partial class Computer_Info : Form
    {
        public Computer_Info()
        {
            InitializeComponent();
            txtbox_admin_pass.PasswordChar = '*';
        }

        private void btn_sn_Click(object sender, EventArgs e)
        {
            btn_sn.Text = "SN: "+Tools.GetLocalSN();
        }

        private void btn_ip_Click(object sender, EventArgs e)
        {
            btn_ip.Text = "IP: " + Tools.GetLocalIPAddress();
        }

        private void btn_host_Click(object sender, EventArgs e)
        {
            btn_host.Text = "HOST: " + System.Net.Dns.GetHostName();
        }

        private void btn_mac_wlan_Click(object sender, EventArgs e)
        {
            btn_mac_wlan.Text = "WLAN: " + Tools.GetLocalMac_Wlan();
        }

        private void btn_mac_lan_Click(object sender, EventArgs e)
        {
            btn_mac_lan.Text = "LAN: " + Tools.GetLocalMac_Lan();
        }

        public void btn_dhcp_Click(object sender, EventArgs e)
        {
            string ip = txtbox_dhcp.Text;
            string lan = Tools.GetLocalMac_Lan();
            string wlan = Tools.GetLocalMac_Wlan();
            string host = System.Net.Dns.GetHostName();
            lbl_dhcp_lan.Text = "host " + host + "_LAN { hardware ethernet " + lan + "; fixed-address " + ip + ";}";
            lbl_dhcp_lan.Visible = true;
            lbl_dhcp_wlan.Text = "host " + host + "_WLAN { hardware ethernet " + wlan + "; fixed-address " + ip + ";}";
            lbl_dhcp_wlan.Visible = true;
        }

       

        private void btn_export_Click(object sender, EventArgs e)
        {
            //btn_export.Text=Tools.ExportData();
            btn_dhcp_Click(sender,e);
            Tools.ExportData(lbl_dhcp_lan.Text, lbl_dhcp_wlan.Text,txtbox_nr_inw.Text,txtbox_id.Text);
        }

        private void btn_cpu_Click(object sender, EventArgs e)
        {
            btn_cpu.Text = "CPU: " + Tools.getCPU();
        }

        private void btn_ram_Click(object sender, EventArgs e)
        {
            btn_ram.Text= "RAM: "+Tools.getRAM()+ " GB";
        }

        private void btn_hardrive_Click(object sender, EventArgs e)
        {
            btn_hardrive.Text = Tools.getLocalDisk();
        }

        private void btn_set_host_Click(object sender, EventArgs e)
        {
            Tools.setLocalHostName(txtbox_host.Text);
            btn_host.Text = "HOST: " + System.Net.Dns.GetHostName();
        }

        private void Computer_Info_Load(object sender, EventArgs e)
        {
            if(!Tools.IsAdministrator())
            {
                MessageBox.Show("Not Running as administrator");
            }
            
        }

        private void lbl_dhcp_lan_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lbl_dhcp_lan.Text);
        }

        private void lbl_dhcp_wlan_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lbl_dhcp_wlan.Text);
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            //btn_admin.Text=Tools.SetLocalAdminOn(txtbox_admin_pass.ToString());
            
            if(txtbox_admin_pass.Text!="")
            {
                Tools.SetLocalAdminOn(txtbox_admin_pass.Text);
            }
            else
            {
                MessageBox.Show("Podaj hasło administratora");
            }
            
        }
    }
}
