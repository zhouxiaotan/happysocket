namespace happysocket
{
    partial class frmMain
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
            this.btnSend = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoFile = new System.Windows.Forms.RadioButton();
            this.rdoText = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.rdoUdp = new System.Windows.Forms.RadioButton();
            this.rdoTcp = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoNotStop = new System.Windows.Forms.RadioButton();
            this.rdoTimes = new System.Windows.Forms.RadioButton();
            this.numTimes = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlFile = new System.Windows.Forms.Panel();
            this.lblFileName = new System.Windows.Forms.Label();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.rdoFolder = new System.Windows.Forms.RadioButton();
            this.numInterval = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdoNoInterval = new System.Windows.Forms.RadioButton();
            this.rdoInterval = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimes)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSend.Location = new System.Drawing.Point(381, 12);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(80, 30);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.Location = new System.Drawing.Point(172, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(104, 19);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(31, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP ADDRESS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(109, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "  : PORT";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rdoFile
            // 
            this.rdoFile.AutoSize = true;
            this.rdoFile.Location = new System.Drawing.Point(18, 40);
            this.rdoFile.Name = "rdoFile";
            this.rdoFile.Size = new System.Drawing.Size(42, 16);
            this.rdoFile.TabIndex = 4;
            this.rdoFile.Text = "File";
            this.rdoFile.UseVisualStyleBackColor = true;
            this.rdoFile.CheckedChanged += new System.EventHandler(this.rdoFile_CheckedChanged);
            // 
            // rdoText
            // 
            this.rdoText.AutoSize = true;
            this.rdoText.Checked = true;
            this.rdoText.Location = new System.Drawing.Point(18, 18);
            this.rdoText.Name = "rdoText";
            this.rdoText.Size = new System.Drawing.Size(46, 16);
            this.rdoText.TabIndex = 5;
            this.rdoText.TabStop = true;
            this.rdoText.Text = "Text";
            this.rdoText.UseVisualStyleBackColor = true;
            this.rdoText.CheckedChanged += new System.EventHandler(this.rdoText_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox2.Location = new System.Drawing.Point(282, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(79, 19);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "8080";
            // 
            // rdoUdp
            // 
            this.rdoUdp.AutoSize = true;
            this.rdoUdp.Location = new System.Drawing.Point(18, 40);
            this.rdoUdp.Name = "rdoUdp";
            this.rdoUdp.Size = new System.Drawing.Size(46, 16);
            this.rdoUdp.TabIndex = 8;
            this.rdoUdp.Tag = "1";
            this.rdoUdp.Text = "UDP";
            this.rdoUdp.UseVisualStyleBackColor = true;
            // 
            // rdoTcp
            // 
            this.rdoTcp.AutoSize = true;
            this.rdoTcp.Checked = true;
            this.rdoTcp.Location = new System.Drawing.Point(19, 18);
            this.rdoTcp.Name = "rdoTcp";
            this.rdoTcp.Size = new System.Drawing.Size(45, 16);
            this.rdoTcp.TabIndex = 7;
            this.rdoTcp.TabStop = true;
            this.rdoTcp.Tag = "1";
            this.rdoTcp.Text = "TCP";
            this.rdoTcp.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoTcp);
            this.groupBox1.Controls.Add(this.rdoUdp);
            this.groupBox1.Location = new System.Drawing.Point(185, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(114, 64);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Protocal";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoFolder);
            this.groupBox2.Controls.Add(this.rdoText);
            this.groupBox2.Controls.Add(this.rdoFile);
            this.groupBox2.Location = new System.Drawing.Point(33, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(143, 64);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Type";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numTimes);
            this.groupBox3.Controls.Add(this.rdoNotStop);
            this.groupBox3.Controls.Add(this.rdoTimes);
            this.groupBox3.Location = new System.Drawing.Point(308, 62);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(153, 64);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Times";
            // 
            // rdoNotStop
            // 
            this.rdoNotStop.AutoSize = true;
            this.rdoNotStop.Checked = true;
            this.rdoNotStop.Location = new System.Drawing.Point(19, 18);
            this.rdoNotStop.Name = "rdoNotStop";
            this.rdoNotStop.Size = new System.Drawing.Size(68, 16);
            this.rdoNotStop.TabIndex = 7;
            this.rdoNotStop.TabStop = true;
            this.rdoNotStop.Tag = "1";
            this.rdoNotStop.Text = "Not Stop";
            this.rdoNotStop.UseVisualStyleBackColor = true;
            this.rdoNotStop.CheckedChanged += new System.EventHandler(this.rdoNotStop_CheckedChanged);
            // 
            // rdoTimes
            // 
            this.rdoTimes.AutoSize = true;
            this.rdoTimes.Location = new System.Drawing.Point(18, 39);
            this.rdoTimes.Name = "rdoTimes";
            this.rdoTimes.Size = new System.Drawing.Size(54, 16);
            this.rdoTimes.TabIndex = 8;
            this.rdoTimes.Tag = "1";
            this.rdoTimes.Text = "Times";
            this.rdoTimes.UseVisualStyleBackColor = true;
            this.rdoTimes.CheckedChanged += new System.EventHandler(this.rdoTimes_CheckedChanged);
            // 
            // numTimes
            // 
            this.numTimes.Enabled = false;
            this.numTimes.Location = new System.Drawing.Point(79, 38);
            this.numTimes.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numTimes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTimes.Name = "numTimes";
            this.numTimes.Size = new System.Drawing.Size(62, 19);
            this.numTimes.TabIndex = 9;
            this.numTimes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 139);
            this.panel1.TabIndex = 11;
            // 
            // pnlFile
            // 
            this.pnlFile.Controls.Add(this.txtFile);
            this.pnlFile.Controls.Add(this.lblFileName);
            this.pnlFile.Controls.Add(this.btnSelect);
            this.pnlFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFile.Location = new System.Drawing.Point(5, 144);
            this.pnlFile.Name = "pnlFile";
            this.pnlFile.Size = new System.Drawing.Size(772, 25);
            this.pnlFile.TabIndex = 12;
            this.pnlFile.Visible = false;
            // 
            // lblFileName
            // 
            this.lblFileName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblFileName.Location = new System.Drawing.Point(0, 0);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(93, 25);
            this.lblFileName.TabIndex = 0;
            this.lblFileName.Text = "File Name";
            this.lblFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFile
            // 
            this.txtFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFile.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtFile.Location = new System.Drawing.Point(93, 0);
            this.txtFile.Multiline = true;
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(599, 25);
            this.txtFile.TabIndex = 2;
            // 
            // btnSelect
            // 
            this.btnSelect.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSelect.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSelect.Location = new System.Drawing.Point(692, 0);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(80, 25);
            this.btnSelect.TabIndex = 11;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // txtContent
            // 
            this.txtContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContent.Location = new System.Drawing.Point(5, 169);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(772, 233);
            this.txtContent.TabIndex = 13;
            // 
            // rdoFolder
            // 
            this.rdoFolder.AutoSize = true;
            this.rdoFolder.Location = new System.Drawing.Point(78, 18);
            this.rdoFolder.Name = "rdoFolder";
            this.rdoFolder.Size = new System.Drawing.Size(55, 16);
            this.rdoFolder.TabIndex = 6;
            this.rdoFolder.Text = "Folder";
            this.rdoFolder.UseVisualStyleBackColor = true;
            this.rdoFolder.CheckedChanged += new System.EventHandler(this.rdoFolder_CheckedChanged);
            // 
            // numInterval
            // 
            this.numInterval.Enabled = false;
            this.numInterval.Location = new System.Drawing.Point(25, 38);
            this.numInterval.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numInterval.Name = "numInterval";
            this.numInterval.Size = new System.Drawing.Size(67, 19);
            this.numInterval.TabIndex = 10;
            this.numInterval.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 12);
            this.label4.TabIndex = 12;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdoNoInterval);
            this.groupBox4.Controls.Add(this.rdoInterval);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.numInterval);
            this.groupBox4.Location = new System.Drawing.Point(478, 62);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(131, 64);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Interval(Millisecond)";
            // 
            // rdoNoInterval
            // 
            this.rdoNoInterval.AutoSize = true;
            this.rdoNoInterval.Checked = true;
            this.rdoNoInterval.Location = new System.Drawing.Point(6, 14);
            this.rdoNoInterval.Name = "rdoNoInterval";
            this.rdoNoInterval.Size = new System.Drawing.Size(37, 16);
            this.rdoNoInterval.TabIndex = 13;
            this.rdoNoInterval.TabStop = true;
            this.rdoNoInterval.Tag = "1";
            this.rdoNoInterval.Text = "No";
            this.rdoNoInterval.UseVisualStyleBackColor = true;
            this.rdoNoInterval.CheckedChanged += new System.EventHandler(this.rdoNoInterval_CheckedChanged);
            // 
            // rdoInterval
            // 
            this.rdoInterval.AutoSize = true;
            this.rdoInterval.Location = new System.Drawing.Point(5, 41);
            this.rdoInterval.Name = "rdoInterval";
            this.rdoInterval.Size = new System.Drawing.Size(14, 13);
            this.rdoInterval.TabIndex = 14;
            this.rdoInterval.Tag = "1";
            this.rdoInterval.UseVisualStyleBackColor = true;
            this.rdoInterval.CheckedChanged += new System.EventHandler(this.rdoInterval_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 407);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.pnlFile);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Happy Socket";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlFile.ResumeLayout(false);
            this.pnlFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoFile;
        private System.Windows.Forms.RadioButton rdoText;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton rdoUdp;
        private System.Windows.Forms.RadioButton rdoTcp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numTimes;
        private System.Windows.Forms.RadioButton rdoNotStop;
        private System.Windows.Forms.RadioButton rdoTimes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlFile;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.RadioButton rdoFolder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numInterval;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdoNoInterval;
        private System.Windows.Forms.RadioButton rdoInterval;
    }
}

