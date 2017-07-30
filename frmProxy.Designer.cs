namespace ProxyDevFeeClaymore
{
    partial class frmProxy
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProxy));
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.consoleLog = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReadMe = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBTCDonate = new System.Windows.Forms.TextBox();
            this.txtWallet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.txtPoolHost = new System.Windows.Forms.TextBox();
            this.chkAutoStart = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numPoolPort = new System.Windows.Forms.NumericUpDown();
            this.btnStartProxy = new System.Windows.Forms.Button();
            this.tmStartProxy = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtMyPublicIP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPoolPort)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSave.Location = new System.Drawing.Point(548, 135);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 65);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Proxy Port :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pool Host :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pool Port :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.consoleLog);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 561);
            this.panel1.TabIndex = 8;
            // 
            // consoleLog
            // 
            this.consoleLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consoleLog.Location = new System.Drawing.Point(0, 269);
            this.consoleLog.Name = "consoleLog";
            this.consoleLog.Size = new System.Drawing.Size(665, 292);
            this.consoleLog.TabIndex = 12;
            this.consoleLog.Text = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnReadMe);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.btnStartProxy);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(665, 269);
            this.panel2.TabIndex = 13;
            // 
            // btnReadMe
            // 
            this.btnReadMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnReadMe.Location = new System.Drawing.Point(548, 221);
            this.btnReadMe.Name = "btnReadMe";
            this.btnReadMe.Size = new System.Drawing.Size(109, 36);
            this.btnReadMe.TabIndex = 13;
            this.btnReadMe.Text = "Read Me";
            this.btnReadMe.UseVisualStyleBackColor = true;
            this.btnReadMe.Click += new System.EventHandler(this.btnReadMe_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMyPublicIP);
            this.groupBox1.Controls.Add(this.btnCopy);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtBTCDonate);
            this.groupBox1.Controls.Add(this.txtWallet);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numPort);
            this.groupBox1.Controls.Add(this.txtPoolHost);
            this.groupBox1.Controls.Add(this.chkAutoStart);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numPoolPort);
            this.groupBox1.Location = new System.Drawing.Point(3, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 256);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setting";
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(360, 212);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(48, 23);
            this.btnCopy.TabIndex = 17;
            this.btnCopy.Text = "copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProxyDevFeeClaymore.Properties.Resources.Donate;
            this.pictureBox2.Location = new System.Drawing.Point(424, 157);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProxyDevFeeClaymore.Properties.Resources.bitcoindonate;
            this.pictureBox1.Location = new System.Drawing.Point(13, 187);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(119, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Donate BTC address :";
            // 
            // txtBTCDonate
            // 
            this.txtBTCDonate.Location = new System.Drawing.Point(121, 214);
            this.txtBTCDonate.Name = "txtBTCDonate";
            this.txtBTCDonate.Size = new System.Drawing.Size(233, 20);
            this.txtBTCDonate.TabIndex = 13;
            this.txtBTCDonate.Text = "13bdxNmky97ShCzA3ywZ7zBZiehmk6itLc";
            this.txtBTCDonate.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtBTCDonate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // txtWallet
            // 
            this.txtWallet.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ProxyDevFeeClaymore.Properties.Settings.Default, "WalletAddress", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtWallet.Location = new System.Drawing.Point(122, 102);
            this.txtWallet.Name = "txtWallet";
            this.txtWallet.Size = new System.Drawing.Size(386, 20);
            this.txtWallet.TabIndex = 12;
            this.txtWallet.Text = global::ProxyDevFeeClaymore.Properties.Settings.Default.WalletAddress;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "My wallet address :";
            // 
            // numPort
            // 
            this.numPort.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::ProxyDevFeeClaymore.Properties.Settings.Default, "ListenPort", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numPort.Location = new System.Drawing.Point(121, 18);
            this.numPort.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numPort.Name = "numPort";
            this.numPort.Size = new System.Drawing.Size(120, 20);
            this.numPort.TabIndex = 10;
            this.numPort.Value = global::ProxyDevFeeClaymore.Properties.Settings.Default.ListenPort;
            // 
            // txtPoolHost
            // 
            this.txtPoolHost.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ProxyDevFeeClaymore.Properties.Settings.Default, "PoolHost", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtPoolHost.Location = new System.Drawing.Point(121, 49);
            this.txtPoolHost.Name = "txtPoolHost";
            this.txtPoolHost.Size = new System.Drawing.Size(244, 20);
            this.txtPoolHost.TabIndex = 5;
            this.txtPoolHost.Text = global::ProxyDevFeeClaymore.Properties.Settings.Default.PoolHost;
            // 
            // chkAutoStart
            // 
            this.chkAutoStart.AutoSize = true;
            this.chkAutoStart.Checked = global::ProxyDevFeeClaymore.Properties.Settings.Default.autoStart;
            this.chkAutoStart.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ProxyDevFeeClaymore.Properties.Settings.Default, "autoStart", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkAutoStart.Location = new System.Drawing.Point(122, 156);
            this.chkAutoStart.Name = "chkAutoStart";
            this.chkAutoStart.Size = new System.Drawing.Size(99, 17);
            this.chkAutoStart.TabIndex = 3;
            this.chkAutoStart.Text = "Auto start proxy";
            this.chkAutoStart.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "(Ex.  eth-asia1.nanopool.org)";
            // 
            // numPoolPort
            // 
            this.numPoolPort.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::ProxyDevFeeClaymore.Properties.Settings.Default, "PoolPort", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numPoolPort.Location = new System.Drawing.Point(121, 75);
            this.numPoolPort.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numPoolPort.Name = "numPoolPort";
            this.numPoolPort.Size = new System.Drawing.Size(120, 20);
            this.numPoolPort.TabIndex = 9;
            this.numPoolPort.Value = global::ProxyDevFeeClaymore.Properties.Settings.Default.PoolPort;
            // 
            // btnStartProxy
            // 
            this.btnStartProxy.BackColor = System.Drawing.Color.Green;
            this.btnStartProxy.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnStartProxy.ForeColor = System.Drawing.Color.White;
            this.btnStartProxy.Location = new System.Drawing.Point(548, 15);
            this.btnStartProxy.Name = "btnStartProxy";
            this.btnStartProxy.Size = new System.Drawing.Size(109, 110);
            this.btnStartProxy.TabIndex = 11;
            this.btnStartProxy.Text = "Start Proxy";
            this.btnStartProxy.UseVisualStyleBackColor = false;
            this.btnStartProxy.Click += new System.EventHandler(this.btnStartProxy_Click);
            // 
            // tmStartProxy
            // 
            this.tmStartProxy.Tick += new System.EventHandler(this.tmStartProxy_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // txtMyPublicIP
            // 
            this.txtMyPublicIP.Location = new System.Drawing.Point(122, 128);
            this.txtMyPublicIP.Name = "txtMyPublicIP";
            this.txtMyPublicIP.Size = new System.Drawing.Size(244, 20);
            this.txtMyPublicIP.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "My Public IP :";
            // 
            // frmProxy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 561);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmProxy";
            this.Text = "Proxy DevFee Claymore";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPoolPort)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkAutoStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPoolHost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox consoleLog;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnStartProxy;
        private System.Windows.Forms.NumericUpDown numPort;
        private System.Windows.Forms.NumericUpDown numPoolPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtWallet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBTCDonate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnReadMe;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Timer tmStartProxy;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMyPublicIP;
    }
}

