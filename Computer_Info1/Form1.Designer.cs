namespace Computer_Info1
{
    partial class Computer_Info
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_sn = new System.Windows.Forms.Button();
            this.btn_ip = new System.Windows.Forms.Button();
            this.btn_host = new System.Windows.Forms.Button();
            this.btn_mac_lan = new System.Windows.Forms.Button();
            this.btn_mac_wlan = new System.Windows.Forms.Button();
            this.btn_dhcp = new System.Windows.Forms.Button();
            this.txtbox_dhcp = new System.Windows.Forms.TextBox();
            this.lbl_dhcp_lan = new System.Windows.Forms.Label();
            this.lbl_dhcp_wlan = new System.Windows.Forms.Label();
            this.btn_export = new System.Windows.Forms.Button();
            this.lbl_nr_inw = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txtbox_nr_inw = new System.Windows.Forms.TextBox();
            this.txtbox_id = new System.Windows.Forms.TextBox();
            this.btn_cpu = new System.Windows.Forms.Button();
            this.btn_ram = new System.Windows.Forms.Button();
            this.btn_hardrive = new System.Windows.Forms.Button();
            this.btn_set_host = new System.Windows.Forms.Button();
            this.txtbox_host = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_sn
            // 
            this.btn_sn.Location = new System.Drawing.Point(8, 8);
            this.btn_sn.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sn.Name = "btn_sn";
            this.btn_sn.Size = new System.Drawing.Size(127, 55);
            this.btn_sn.TabIndex = 0;
            this.btn_sn.Text = "Show SN";
            this.btn_sn.UseVisualStyleBackColor = true;
            this.btn_sn.Click += new System.EventHandler(this.btn_sn_Click);
            // 
            // btn_ip
            // 
            this.btn_ip.Location = new System.Drawing.Point(142, 8);
            this.btn_ip.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ip.Name = "btn_ip";
            this.btn_ip.Size = new System.Drawing.Size(127, 55);
            this.btn_ip.TabIndex = 1;
            this.btn_ip.Text = "Show IP";
            this.btn_ip.UseVisualStyleBackColor = true;
            this.btn_ip.Click += new System.EventHandler(this.btn_ip_Click);
            // 
            // btn_host
            // 
            this.btn_host.Location = new System.Drawing.Point(276, 8);
            this.btn_host.Margin = new System.Windows.Forms.Padding(2);
            this.btn_host.Name = "btn_host";
            this.btn_host.Size = new System.Drawing.Size(127, 55);
            this.btn_host.TabIndex = 2;
            this.btn_host.Text = "Show HostName";
            this.btn_host.UseVisualStyleBackColor = true;
            this.btn_host.Click += new System.EventHandler(this.btn_host_Click);
            // 
            // btn_mac_lan
            // 
            this.btn_mac_lan.Location = new System.Drawing.Point(276, 78);
            this.btn_mac_lan.Margin = new System.Windows.Forms.Padding(2);
            this.btn_mac_lan.Name = "btn_mac_lan";
            this.btn_mac_lan.Size = new System.Drawing.Size(127, 55);
            this.btn_mac_lan.TabIndex = 3;
            this.btn_mac_lan.Text = "Show MAC LAN";
            this.btn_mac_lan.UseVisualStyleBackColor = true;
            this.btn_mac_lan.Click += new System.EventHandler(this.btn_mac_lan_Click);
            // 
            // btn_mac_wlan
            // 
            this.btn_mac_wlan.Location = new System.Drawing.Point(142, 78);
            this.btn_mac_wlan.Margin = new System.Windows.Forms.Padding(2);
            this.btn_mac_wlan.Name = "btn_mac_wlan";
            this.btn_mac_wlan.Size = new System.Drawing.Size(127, 55);
            this.btn_mac_wlan.TabIndex = 4;
            this.btn_mac_wlan.Text = "Show MAC WLAN";
            this.btn_mac_wlan.UseVisualStyleBackColor = true;
            this.btn_mac_wlan.Click += new System.EventHandler(this.btn_mac_wlan_Click);
            // 
            // btn_dhcp
            // 
            this.btn_dhcp.Location = new System.Drawing.Point(8, 78);
            this.btn_dhcp.Margin = new System.Windows.Forms.Padding(2);
            this.btn_dhcp.Name = "btn_dhcp";
            this.btn_dhcp.Size = new System.Drawing.Size(127, 55);
            this.btn_dhcp.TabIndex = 5;
            this.btn_dhcp.Text = "Make DHCP Record";
            this.btn_dhcp.UseVisualStyleBackColor = true;
            this.btn_dhcp.Click += new System.EventHandler(this.btn_dhcp_Click);
            // 
            // txtbox_dhcp
            // 
            this.txtbox_dhcp.Location = new System.Drawing.Point(8, 137);
            this.txtbox_dhcp.Margin = new System.Windows.Forms.Padding(2);
            this.txtbox_dhcp.Name = "txtbox_dhcp";
            this.txtbox_dhcp.Size = new System.Drawing.Size(95, 20);
            this.txtbox_dhcp.TabIndex = 6;
            this.txtbox_dhcp.Text = "192.168.";
            // 
            // lbl_dhcp_lan
            // 
            this.lbl_dhcp_lan.AutoSize = true;
            this.lbl_dhcp_lan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_dhcp_lan.Location = new System.Drawing.Point(8, 158);
            this.lbl_dhcp_lan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_dhcp_lan.Name = "lbl_dhcp_lan";
            this.lbl_dhcp_lan.Size = new System.Drawing.Size(35, 13);
            this.lbl_dhcp_lan.TabIndex = 7;
            this.lbl_dhcp_lan.Text = "label1";
            this.lbl_dhcp_lan.Visible = false;
            // 
            // lbl_dhcp_wlan
            // 
            this.lbl_dhcp_wlan.AutoSize = true;
            this.lbl_dhcp_wlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_dhcp_wlan.Location = new System.Drawing.Point(8, 192);
            this.lbl_dhcp_wlan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_dhcp_wlan.Name = "lbl_dhcp_wlan";
            this.lbl_dhcp_wlan.Size = new System.Drawing.Size(35, 13);
            this.lbl_dhcp_wlan.TabIndex = 8;
            this.lbl_dhcp_wlan.Text = "label2";
            this.lbl_dhcp_wlan.Visible = false;
            this.lbl_dhcp_wlan.Click += new System.EventHandler(this.lbl_dhcp_wlan_Click);
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(8, 229);
            this.btn_export.Margin = new System.Windows.Forms.Padding(2);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(127, 55);
            this.btn_export.TabIndex = 9;
            this.btn_export.Text = "Export to Excel";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // lbl_nr_inw
            // 
            this.lbl_nr_inw.AutoSize = true;
            this.lbl_nr_inw.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_nr_inw.Location = new System.Drawing.Point(139, 246);
            this.lbl_nr_inw.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nr_inw.Name = "lbl_nr_inw";
            this.lbl_nr_inw.Size = new System.Drawing.Size(41, 13);
            this.lbl_nr_inw.TabIndex = 10;
            this.lbl_nr_inw.Text = "Nr.Inw:";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_id.Location = new System.Drawing.Point(158, 265);
            this.lbl_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(21, 13);
            this.lbl_id.TabIndex = 11;
            this.lbl_id.Text = "ID:";
            // 
            // txtbox_nr_inw
            // 
            this.txtbox_nr_inw.Location = new System.Drawing.Point(182, 244);
            this.txtbox_nr_inw.Margin = new System.Windows.Forms.Padding(2);
            this.txtbox_nr_inw.Name = "txtbox_nr_inw";
            this.txtbox_nr_inw.Size = new System.Drawing.Size(68, 20);
            this.txtbox_nr_inw.TabIndex = 12;
            // 
            // txtbox_id
            // 
            this.txtbox_id.Location = new System.Drawing.Point(182, 265);
            this.txtbox_id.Margin = new System.Windows.Forms.Padding(2);
            this.txtbox_id.Name = "txtbox_id";
            this.txtbox_id.Size = new System.Drawing.Size(68, 20);
            this.txtbox_id.TabIndex = 13;
            // 
            // btn_cpu
            // 
            this.btn_cpu.Location = new System.Drawing.Point(410, 8);
            this.btn_cpu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cpu.Name = "btn_cpu";
            this.btn_cpu.Size = new System.Drawing.Size(127, 55);
            this.btn_cpu.TabIndex = 14;
            this.btn_cpu.Text = "Show CPU";
            this.btn_cpu.UseVisualStyleBackColor = true;
            this.btn_cpu.Click += new System.EventHandler(this.btn_cpu_Click);
            // 
            // btn_ram
            // 
            this.btn_ram.Location = new System.Drawing.Point(410, 229);
            this.btn_ram.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ram.Name = "btn_ram";
            this.btn_ram.Size = new System.Drawing.Size(127, 55);
            this.btn_ram.TabIndex = 15;
            this.btn_ram.Text = "Show RAM";
            this.btn_ram.UseVisualStyleBackColor = true;
            this.btn_ram.Click += new System.EventHandler(this.btn_ram_Click);
            // 
            // btn_hardrive
            // 
            this.btn_hardrive.Location = new System.Drawing.Point(276, 229);
            this.btn_hardrive.Margin = new System.Windows.Forms.Padding(2);
            this.btn_hardrive.Name = "btn_hardrive";
            this.btn_hardrive.Size = new System.Drawing.Size(127, 55);
            this.btn_hardrive.TabIndex = 16;
            this.btn_hardrive.Text = "Show HardDisk";
            this.btn_hardrive.UseVisualStyleBackColor = true;
            this.btn_hardrive.Click += new System.EventHandler(this.btn_hardrive_Click);
            // 
            // btn_set_host
            // 
            this.btn_set_host.Location = new System.Drawing.Point(410, 78);
            this.btn_set_host.Margin = new System.Windows.Forms.Padding(2);
            this.btn_set_host.Name = "btn_set_host";
            this.btn_set_host.Size = new System.Drawing.Size(127, 55);
            this.btn_set_host.TabIndex = 17;
            this.btn_set_host.Text = "Set HostName";
            this.btn_set_host.UseVisualStyleBackColor = true;
            this.btn_set_host.Click += new System.EventHandler(this.btn_set_host_Click);
            // 
            // txtbox_host
            // 
            this.txtbox_host.Location = new System.Drawing.Point(410, 137);
            this.txtbox_host.Margin = new System.Windows.Forms.Padding(2);
            this.txtbox_host.Name = "txtbox_host";
            this.txtbox_host.Size = new System.Drawing.Size(129, 20);
            this.txtbox_host.TabIndex = 18;
            this.txtbox_host.Text = "HostName";
            // 
            // Computer_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 304);
            this.Controls.Add(this.txtbox_host);
            this.Controls.Add(this.btn_set_host);
            this.Controls.Add(this.btn_hardrive);
            this.Controls.Add(this.btn_ram);
            this.Controls.Add(this.btn_cpu);
            this.Controls.Add(this.txtbox_id);
            this.Controls.Add(this.txtbox_nr_inw);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_nr_inw);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.lbl_dhcp_wlan);
            this.Controls.Add(this.lbl_dhcp_lan);
            this.Controls.Add(this.txtbox_dhcp);
            this.Controls.Add(this.btn_dhcp);
            this.Controls.Add(this.btn_mac_wlan);
            this.Controls.Add(this.btn_mac_lan);
            this.Controls.Add(this.btn_host);
            this.Controls.Add(this.btn_ip);
            this.Controls.Add(this.btn_sn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(557, 343);
            this.Name = "Computer_Info";
            this.Text = "Computer_Info";
            this.Load += new System.EventHandler(this.Computer_Info_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sn;
        private System.Windows.Forms.Button btn_ip;
        private System.Windows.Forms.Button btn_host;
        private System.Windows.Forms.Button btn_mac_lan;
        private System.Windows.Forms.Button btn_mac_wlan;
        private System.Windows.Forms.Button btn_dhcp;
        private System.Windows.Forms.TextBox txtbox_dhcp;
        private System.Windows.Forms.Label lbl_dhcp_lan;
        private System.Windows.Forms.Label lbl_dhcp_wlan;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Label lbl_nr_inw;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txtbox_nr_inw;
        private System.Windows.Forms.TextBox txtbox_id;
        private System.Windows.Forms.Button btn_cpu;
        private System.Windows.Forms.Button btn_ram;
        private System.Windows.Forms.Button btn_hardrive;
        private System.Windows.Forms.Button btn_set_host;
        private System.Windows.Forms.TextBox txtbox_host;
    }
}

