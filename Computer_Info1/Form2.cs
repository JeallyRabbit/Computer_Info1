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
    public partial class Form2 : Form
    {

        public string returnUsername { get; set; }
        public string returnPassword { get; set; }

        public string returnDomainName { get; set; }

        public bool credentialsSet { get; set; }

        

        public Form2()
        {
            InitializeComponent();
            txtBox_password.PasswordChar = '●';
            txtBox_username.Select();
            if (System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName != string.Empty)
            {
                this.txtBox_domainName.Text = System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName;
            }
        }
        
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if(txtBox_password.Text.Length>0 && txtBox_username.Text.Length > 0)
            {
                this.returnPassword = txtBox_password.Text;
                this.returnUsername = txtBox_username.Text;
                this.returnDomainName=txtBox_domainName.Text;
                this.credentialsSet= true;
                this.Visible = false;

            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.credentialsSet = false;
            this.Visible = false;
        }
    }
}
