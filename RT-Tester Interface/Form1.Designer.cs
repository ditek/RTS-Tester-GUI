namespace RT_Tester_Interface
{
    partial class Form1
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnOpenPort = new System.Windows.Forms.Button();
            this.cboPorts = new System.Windows.Forms.ComboBox();
            this.btnStartTest = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.bar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIntD = new System.Windows.Forms.TextBox();
            this.txtIntC = new System.Windows.Forms.TextBox();
            this.txtIntB = new System.Windows.Forms.TextBox();
            this.txtScaler = new System.Windows.Forms.TextBox();
            this.txtHold = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtIntA = new System.Windows.Forms.TextBox();
            this.chkIntD = new System.Windows.Forms.CheckBox();
            this.chkIntC = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkIntB = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkIntA = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkBurst = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMem = new System.Windows.Forms.Button();
            this.btnConf = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTimeout = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMemPC = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.btnAnalyzeBasic = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtHex = new System.Windows.Forms.RichTextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenPort
            // 
            this.btnOpenPort.Location = new System.Drawing.Point(182, 13);
            this.btnOpenPort.Name = "btnOpenPort";
            this.btnOpenPort.Size = new System.Drawing.Size(113, 23);
            this.btnOpenPort.TabIndex = 0;
            this.btnOpenPort.Text = "Open Port";
            this.btnOpenPort.UseVisualStyleBackColor = true;
            this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPort_Click);
            // 
            // cboPorts
            // 
            this.cboPorts.FormattingEnabled = true;
            this.cboPorts.Location = new System.Drawing.Point(9, 15);
            this.cboPorts.Name = "cboPorts";
            this.cboPorts.Size = new System.Drawing.Size(147, 21);
            this.cboPorts.TabIndex = 1;
            this.cboPorts.Text = "Select Port";
            this.cboPorts.SelectedIndexChanged += new System.EventHandler(this.cboPorts_SelectedIndexChanged);
            this.cboPorts.Click += new System.EventHandler(this.cboPorts_Click);
            // 
            // btnStartTest
            // 
            this.btnStartTest.Enabled = false;
            this.btnStartTest.Location = new System.Drawing.Point(182, 42);
            this.btnStartTest.Name = "btnStartTest";
            this.btnStartTest.Size = new System.Drawing.Size(113, 23);
            this.btnStartTest.TabIndex = 2;
            this.btnStartTest.Text = "Start Test";
            this.btnStartTest.UseVisualStyleBackColor = true;
            this.btnStartTest.Click += new System.EventHandler(this.btnStartTest_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtStatus.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(0, 0);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStatus.Size = new System.Drawing.Size(479, 463);
            this.txtStatus.TabIndex = 3;
            // 
            // bar1
            // 
            this.bar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bar1.Location = new System.Drawing.Point(0, 463);
            this.bar1.Maximum = 511;
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(781, 23);
            this.bar1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHex);
            this.groupBox1.Controls.Add(this.txtIntD);
            this.groupBox1.Controls.Add(this.txtIntC);
            this.groupBox1.Controls.Add(this.txtIntB);
            this.groupBox1.Controls.Add(this.txtScaler);
            this.groupBox1.Controls.Add(this.txtHold);
            this.groupBox1.Controls.Add(this.txtDuration);
            this.groupBox1.Controls.Add(this.txtIntA);
            this.groupBox1.Controls.Add(this.chkIntD);
            this.groupBox1.Controls.Add(this.chkIntC);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.chkIntB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.chkIntA);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.chkBurst);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(479, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 272);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tester Configuration";
            // 
            // txtIntD
            // 
            this.txtIntD.Location = new System.Drawing.Point(115, 181);
            this.txtIntD.Name = "txtIntD";
            this.txtIntD.Size = new System.Drawing.Size(35, 20);
            this.txtIntD.TabIndex = 6;
            this.txtIntD.Text = "10";
            // 
            // txtIntC
            // 
            this.txtIntC.Location = new System.Drawing.Point(115, 158);
            this.txtIntC.Name = "txtIntC";
            this.txtIntC.Size = new System.Drawing.Size(35, 20);
            this.txtIntC.TabIndex = 6;
            this.txtIntC.Text = "10";
            // 
            // txtIntB
            // 
            this.txtIntB.Location = new System.Drawing.Point(115, 135);
            this.txtIntB.Name = "txtIntB";
            this.txtIntB.Size = new System.Drawing.Size(35, 20);
            this.txtIntB.TabIndex = 6;
            this.txtIntB.Text = "10";
            // 
            // txtScaler
            // 
            this.txtScaler.Location = new System.Drawing.Point(115, 66);
            this.txtScaler.Name = "txtScaler";
            this.txtScaler.Size = new System.Drawing.Size(35, 20);
            this.txtScaler.TabIndex = 6;
            this.txtScaler.Text = "3";
            // 
            // txtHold
            // 
            this.txtHold.Location = new System.Drawing.Point(115, 44);
            this.txtHold.Name = "txtHold";
            this.txtHold.Size = new System.Drawing.Size(35, 20);
            this.txtHold.TabIndex = 6;
            this.txtHold.Text = "1";
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(115, 22);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(35, 20);
            this.txtDuration.TabIndex = 6;
            this.txtDuration.Text = "10";
            // 
            // txtIntA
            // 
            this.txtIntA.Location = new System.Drawing.Point(115, 112);
            this.txtIntA.Name = "txtIntA";
            this.txtIntA.Size = new System.Drawing.Size(35, 20);
            this.txtIntA.TabIndex = 6;
            this.txtIntA.Text = "10";
            // 
            // chkIntD
            // 
            this.chkIntD.AutoSize = true;
            this.chkIntD.Checked = true;
            this.chkIntD.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIntD.Location = new System.Drawing.Point(9, 183);
            this.chkIntD.Name = "chkIntD";
            this.chkIntD.Size = new System.Drawing.Size(94, 17);
            this.chkIntD.TabIndex = 8;
            this.chkIntD.Text = "INT_D_Period";
            this.chkIntD.UseVisualStyleBackColor = true;
            this.chkIntD.CheckedChanged += new System.EventHandler(this.chkIntD_CheckedChanged);
            // 
            // chkIntC
            // 
            this.chkIntC.AutoSize = true;
            this.chkIntC.Checked = true;
            this.chkIntC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIntC.Location = new System.Drawing.Point(9, 160);
            this.chkIntC.Name = "chkIntC";
            this.chkIntC.Size = new System.Drawing.Size(90, 17);
            this.chkIntC.TabIndex = 8;
            this.chkIntC.Text = "INT_C Period";
            this.chkIntC.UseVisualStyleBackColor = true;
            this.chkIntC.CheckedChanged += new System.EventHandler(this.chkIntC_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "us";
            // 
            // chkIntB
            // 
            this.chkIntB.AutoSize = true;
            this.chkIntB.Checked = true;
            this.chkIntB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIntB.Location = new System.Drawing.Point(9, 137);
            this.chkIntB.Name = "chkIntB";
            this.chkIntB.Size = new System.Drawing.Size(90, 17);
            this.chkIntB.TabIndex = 8;
            this.chkIntB.Text = "INT_B Period";
            this.chkIntB.UseVisualStyleBackColor = true;
            this.chkIntB.CheckedChanged += new System.EventHandler(this.chkIntB_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "us";
            // 
            // chkIntA
            // 
            this.chkIntA.AutoSize = true;
            this.chkIntA.Checked = true;
            this.chkIntA.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIntA.Location = new System.Drawing.Point(9, 114);
            this.chkIntA.Name = "chkIntA";
            this.chkIntA.Size = new System.Drawing.Size(90, 17);
            this.chkIntA.TabIndex = 8;
            this.chkIntA.Text = "INT_A Period";
            this.chkIntA.UseVisualStyleBackColor = true;
            this.chkIntA.CheckedChanged += new System.EventHandler(this.chkIntA_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "us";
            // 
            // chkBurst
            // 
            this.chkBurst.AutoSize = true;
            this.chkBurst.Checked = true;
            this.chkBurst.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBurst.Location = new System.Drawing.Point(9, 91);
            this.chkBurst.Name = "chkBurst";
            this.chkBurst.Size = new System.Drawing.Size(80, 17);
            this.chkBurst.TabIndex = 7;
            this.chkBurst.Text = "Burst Mode";
            this.chkBurst.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(156, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "ns";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(156, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "ms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "us";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Time Scaler";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Hold Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Test Duration";
            // 
            // btnMem
            // 
            this.btnMem.Enabled = false;
            this.btnMem.Location = new System.Drawing.Point(182, 71);
            this.btnMem.Name = "btnMem";
            this.btnMem.Size = new System.Drawing.Size(113, 23);
            this.btnMem.TabIndex = 6;
            this.btnMem.Text = "Read Memory to SD card";
            this.btnMem.UseVisualStyleBackColor = true;
            this.btnMem.Click += new System.EventHandler(this.btnMem_Click);
            // 
            // btnConf
            // 
            this.btnConf.Enabled = false;
            this.btnConf.Location = new System.Drawing.Point(182, 128);
            this.btnConf.Name = "btnConf";
            this.btnConf.Size = new System.Drawing.Size(113, 23);
            this.btnConf.TabIndex = 9;
            this.btnConf.Text = "Configure";
            this.btnConf.UseVisualStyleBackColor = true;
            this.btnConf.Click += new System.EventHandler(this.btnConf_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Port read timeout (ms)";
            // 
            // txtTimeout
            // 
            this.txtTimeout.Location = new System.Drawing.Point(115, 39);
            this.txtTimeout.Name = "txtTimeout";
            this.txtTimeout.Size = new System.Drawing.Size(41, 20);
            this.txtTimeout.TabIndex = 6;
            this.txtTimeout.Text = "4000";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSelect);
            this.groupBox2.Controls.Add(this.btnOpen);
            this.groupBox2.Controls.Add(this.btnAnalyzeBasic);
            this.groupBox2.Controls.Add(this.btnAnalyze);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnConf);
            this.groupBox2.Controls.Add(this.btnMemPC);
            this.groupBox2.Controls.Add(this.btnMem);
            this.groupBox2.Controls.Add(this.txtTimeout);
            this.groupBox2.Controls.Add(this.btnStartTest);
            this.groupBox2.Controls.Add(this.cboPorts);
            this.groupBox2.Controls.Add(this.btnOpenPort);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(479, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 157);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // btnMemPC
            // 
            this.btnMemPC.Enabled = false;
            this.btnMemPC.Location = new System.Drawing.Point(182, 99);
            this.btnMemPC.Name = "btnMemPC";
            this.btnMemPC.Size = new System.Drawing.Size(113, 23);
            this.btnMemPC.TabIndex = 6;
            this.btnMemPC.Text = "Read Memory to PC";
            this.btnMemPC.UseVisualStyleBackColor = true;
            this.btnMemPC.Click += new System.EventHandler(this.btnMemPC_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Clear Screen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(604, 163);
            this.txtTest.Multiline = true;
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(107, 23);
            this.txtTest.TabIndex = 12;
            this.txtTest.Text = "56c1500000057936";
            this.txtTest.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(107, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dlgOpen
            // 
            this.dlgOpen.FileName = "Log File";
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(93, 71);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(83, 23);
            this.btnAnalyze.TabIndex = 13;
            this.btnAnalyze.Text = "Time Analysis";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // btnAnalyzeBasic
            // 
            this.btnAnalyzeBasic.Location = new System.Drawing.Point(93, 99);
            this.btnAnalyzeBasic.Name = "btnAnalyzeBasic";
            this.btnAnalyzeBasic.Size = new System.Drawing.Size(83, 23);
            this.btnAnalyzeBasic.TabIndex = 13;
            this.btnAnalyzeBasic.Text = "Basic Analysis";
            this.btnAnalyzeBasic.UseVisualStyleBackColor = true;
            this.btnAnalyzeBasic.Click += new System.EventHandler(this.btnAnalyzeBasic_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(6, 128);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(81, 23);
            this.btnOpen.TabIndex = 14;
            this.btnOpen.Text = "Open Log File";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtHex
            // 
            this.txtHex.Location = new System.Drawing.Point(182, 19);
            this.txtHex.Name = "txtHex";
            this.txtHex.Size = new System.Drawing.Size(113, 219);
            this.txtHex.TabIndex = 13;
            this.txtHex.Text = "";
            this.txtHex.Visible = false;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(6, 100);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(81, 23);
            this.btnSelect.TabIndex = 15;
            this.btnSelect.Text = "Select All";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 486);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.bar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Real-Time Tester";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnOpenPort;
        private System.Windows.Forms.ComboBox cboPorts;
        private System.Windows.Forms.Button btnStartTest;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.ProgressBar bar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIntD;
        private System.Windows.Forms.TextBox txtIntC;
        private System.Windows.Forms.TextBox txtIntB;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtIntA;
        private System.Windows.Forms.CheckBox chkIntD;
        private System.Windows.Forms.CheckBox chkIntC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkIntB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkIntA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkBurst;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtScaler;
        private System.Windows.Forms.TextBox txtHold;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnMem;
        private System.Windows.Forms.Button btnConf;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTimeout;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMemPC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnAnalyzeBasic;
        private System.Windows.Forms.RichTextBox txtHex;
        private System.Windows.Forms.Button btnSelect;
    }
}

