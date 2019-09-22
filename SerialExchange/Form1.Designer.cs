namespace SerialExchange
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.mbtnOpen = new System.Windows.Forms.Button();
            this.mbtnClose = new System.Windows.Forms.Button();
            this.mSent = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mcBoxBAUDRATE = new System.Windows.Forms.ComboBox();
            this.mcBoxDATABITS = new System.Windows.Forms.ComboBox();
            this.mcBoxSTOPBITS = new System.Windows.Forms.ComboBox();
            this.mcBoxPARITYBITS = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mcBoxCOMPORT = new System.Windows.Forms.ComboBox();
            this.tBoxDataOut = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.sbtnOpen = new System.Windows.Forms.Button();
            this.sbtnClose = new System.Windows.Forms.Button();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.sbtnSent = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.scBoxBAUDRATE = new System.Windows.Forms.ComboBox();
            this.scBoxDATABITS = new System.Windows.Forms.ComboBox();
            this.scBoxSTOPBITS = new System.Windows.Forms.ComboBox();
            this.scBoxPARITYBITS = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.scBoxCOMPORT = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox2);
            this.groupBox5.Controls.Add(this.mSent);
            this.groupBox5.Controls.Add(this.groupBox1);
            this.groupBox5.Controls.Add(this.tBoxDataOut);
            this.groupBox5.Location = new System.Drawing.Point(13, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(581, 299);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Master ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.mbtnOpen);
            this.groupBox2.Controls.Add(this.mbtnClose);
            this.groupBox2.Location = new System.Drawing.Point(6, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 85);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(17, 48);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(156, 23);
            this.progressBar1.TabIndex = 13;
            // 
            // mbtnOpen
            // 
            this.mbtnOpen.Location = new System.Drawing.Point(17, 19);
            this.mbtnOpen.Name = "mbtnOpen";
            this.mbtnOpen.Size = new System.Drawing.Size(75, 23);
            this.mbtnOpen.TabIndex = 10;
            this.mbtnOpen.Text = "Open";
            this.mbtnOpen.UseVisualStyleBackColor = true;
            this.mbtnOpen.Click += new System.EventHandler(this.mbtnOpen_Click);
            // 
            // mbtnClose
            // 
            this.mbtnClose.Location = new System.Drawing.Point(98, 19);
            this.mbtnClose.Name = "mbtnClose";
            this.mbtnClose.Size = new System.Drawing.Size(75, 23);
            this.mbtnClose.TabIndex = 11;
            this.mbtnClose.Text = "Close";
            this.mbtnClose.UseVisualStyleBackColor = true;
            this.mbtnClose.Click += new System.EventHandler(this.mbtnClose_Click);
            // 
            // mSent
            // 
            this.mSent.Location = new System.Drawing.Point(197, 210);
            this.mSent.Name = "mSent";
            this.mSent.Size = new System.Drawing.Size(80, 81);
            this.mSent.TabIndex = 20;
            this.mSent.Text = "Sent";
            this.mSent.UseVisualStyleBackColor = true;
            this.mSent.Click += new System.EventHandler(this.mSent_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mcBoxBAUDRATE);
            this.groupBox1.Controls.Add(this.mcBoxDATABITS);
            this.groupBox1.Controls.Add(this.mcBoxSTOPBITS);
            this.groupBox1.Controls.Add(this.mcBoxPARITYBITS);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mcBoxCOMPORT);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 181);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Com Port Control";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "BAUD  RATE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "STOP BITS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "DATA BITS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "PARITY BITS";
            // 
            // mcBoxBAUDRATE
            // 
            this.mcBoxBAUDRATE.FormattingEnabled = true;
            this.mcBoxBAUDRATE.Items.AddRange(new object[] {
            "110",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.mcBoxBAUDRATE.Location = new System.Drawing.Point(104, 58);
            this.mcBoxBAUDRATE.Name = "mcBoxBAUDRATE";
            this.mcBoxBAUDRATE.Size = new System.Drawing.Size(121, 21);
            this.mcBoxBAUDRATE.TabIndex = 22;
            this.mcBoxBAUDRATE.Text = "9600";
            // 
            // mcBoxDATABITS
            // 
            this.mcBoxDATABITS.FormattingEnabled = true;
            this.mcBoxDATABITS.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.mcBoxDATABITS.Location = new System.Drawing.Point(104, 85);
            this.mcBoxDATABITS.Name = "mcBoxDATABITS";
            this.mcBoxDATABITS.Size = new System.Drawing.Size(121, 21);
            this.mcBoxDATABITS.TabIndex = 21;
            this.mcBoxDATABITS.Text = "8";
            // 
            // mcBoxSTOPBITS
            // 
            this.mcBoxSTOPBITS.FormattingEnabled = true;
            this.mcBoxSTOPBITS.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.mcBoxSTOPBITS.Location = new System.Drawing.Point(104, 110);
            this.mcBoxSTOPBITS.Name = "mcBoxSTOPBITS";
            this.mcBoxSTOPBITS.Size = new System.Drawing.Size(121, 21);
            this.mcBoxSTOPBITS.TabIndex = 20;
            this.mcBoxSTOPBITS.Text = "One";
            // 
            // mcBoxPARITYBITS
            // 
            this.mcBoxPARITYBITS.FormattingEnabled = true;
            this.mcBoxPARITYBITS.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.mcBoxPARITYBITS.Location = new System.Drawing.Point(104, 139);
            this.mcBoxPARITYBITS.Name = "mcBoxPARITYBITS";
            this.mcBoxPARITYBITS.Size = new System.Drawing.Size(121, 21);
            this.mcBoxPARITYBITS.TabIndex = 19;
            this.mcBoxPARITYBITS.Text = "None";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "COM PORT";
            // 
            // mcBoxCOMPORT
            // 
            this.mcBoxCOMPORT.FormattingEnabled = true;
            this.mcBoxCOMPORT.Location = new System.Drawing.Point(104, 29);
            this.mcBoxCOMPORT.Name = "mcBoxCOMPORT";
            this.mcBoxCOMPORT.Size = new System.Drawing.Size(121, 21);
            this.mcBoxCOMPORT.TabIndex = 17;
            // 
            // tBoxDataOut
            // 
            this.tBoxDataOut.Location = new System.Drawing.Point(281, 22);
            this.tBoxDataOut.Multiline = true;
            this.tBoxDataOut.Name = "tBoxDataOut";
            this.tBoxDataOut.Size = new System.Drawing.Size(284, 269);
            this.tBoxDataOut.TabIndex = 19;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.sbtnOpen);
            this.groupBox6.Controls.Add(this.sbtnClose);
            this.groupBox6.Controls.Add(this.progressBar2);
            this.groupBox6.Controls.Add(this.sbtnSent);
            this.groupBox6.Controls.Add(this.groupBox3);
            this.groupBox6.Location = new System.Drawing.Point(600, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(307, 299);
            this.groupBox6.TabIndex = 23;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Slave ";
            // 
            // sbtnOpen
            // 
            this.sbtnOpen.Location = new System.Drawing.Point(25, 210);
            this.sbtnOpen.Name = "sbtnOpen";
            this.sbtnOpen.Size = new System.Drawing.Size(72, 23);
            this.sbtnOpen.TabIndex = 26;
            this.sbtnOpen.Text = "Open";
            this.sbtnOpen.UseVisualStyleBackColor = true;
            // 
            // sbtnClose
            // 
            this.sbtnClose.Location = new System.Drawing.Point(106, 210);
            this.sbtnClose.Name = "sbtnClose";
            this.sbtnClose.Size = new System.Drawing.Size(72, 23);
            this.sbtnClose.TabIndex = 27;
            this.sbtnClose.Text = "Close";
            this.sbtnClose.UseVisualStyleBackColor = true;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(25, 253);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(153, 23);
            this.progressBar2.TabIndex = 25;
            // 
            // sbtnSent
            // 
            this.sbtnSent.Location = new System.Drawing.Point(191, 210);
            this.sbtnSent.Name = "sbtnSent";
            this.sbtnSent.Size = new System.Drawing.Size(91, 66);
            this.sbtnSent.TabIndex = 24;
            this.sbtnSent.Text = "Master DeviceSent Message to slave";
            this.sbtnSent.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.scBoxBAUDRATE);
            this.groupBox3.Controls.Add(this.scBoxDATABITS);
            this.groupBox3.Controls.Add(this.scBoxSTOPBITS);
            this.groupBox3.Controls.Add(this.scBoxPARITYBITS);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.scBoxCOMPORT);
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(276, 174);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Com Port Control";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "BAUD  RATE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "STOP BITS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "DATA BITS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "PARITY BITS";
            // 
            // scBoxBAUDRATE
            // 
            this.scBoxBAUDRATE.FormattingEnabled = true;
            this.scBoxBAUDRATE.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.scBoxBAUDRATE.Location = new System.Drawing.Point(100, 57);
            this.scBoxBAUDRATE.Name = "scBoxBAUDRATE";
            this.scBoxBAUDRATE.Size = new System.Drawing.Size(121, 21);
            this.scBoxBAUDRATE.TabIndex = 32;
            this.scBoxBAUDRATE.Text = "9600";
            // 
            // scBoxDATABITS
            // 
            this.scBoxDATABITS.FormattingEnabled = true;
            this.scBoxDATABITS.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.scBoxDATABITS.Location = new System.Drawing.Point(100, 84);
            this.scBoxDATABITS.Name = "scBoxDATABITS";
            this.scBoxDATABITS.Size = new System.Drawing.Size(121, 21);
            this.scBoxDATABITS.TabIndex = 31;
            this.scBoxDATABITS.Text = "8";
            // 
            // scBoxSTOPBITS
            // 
            this.scBoxSTOPBITS.FormattingEnabled = true;
            this.scBoxSTOPBITS.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.scBoxSTOPBITS.Location = new System.Drawing.Point(100, 109);
            this.scBoxSTOPBITS.Name = "scBoxSTOPBITS";
            this.scBoxSTOPBITS.Size = new System.Drawing.Size(121, 21);
            this.scBoxSTOPBITS.TabIndex = 30;
            this.scBoxSTOPBITS.Text = "One";
            // 
            // scBoxPARITYBITS
            // 
            this.scBoxPARITYBITS.FormattingEnabled = true;
            this.scBoxPARITYBITS.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.scBoxPARITYBITS.Location = new System.Drawing.Point(100, 138);
            this.scBoxPARITYBITS.Name = "scBoxPARITYBITS";
            this.scBoxPARITYBITS.Size = new System.Drawing.Size(121, 21);
            this.scBoxPARITYBITS.TabIndex = 29;
            this.scBoxPARITYBITS.Text = "None";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "COM PORT";
            // 
            // scBoxCOMPORT
            // 
            this.scBoxCOMPORT.FormattingEnabled = true;
            this.scBoxCOMPORT.Location = new System.Drawing.Point(100, 28);
            this.scBoxCOMPORT.Name = "scBoxCOMPORT";
            this.scBoxCOMPORT.Size = new System.Drawing.Size(121, 21);
            this.scBoxCOMPORT.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 510);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Name = "Form1";
            this.Text = "ComPort Exchange Data";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button mbtnOpen;
        private System.Windows.Forms.Button mbtnClose;
        private System.Windows.Forms.Button mSent;
        private System.Windows.Forms.TextBox tBoxDataOut;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button sbtnSent;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox scBoxBAUDRATE;
        private System.Windows.Forms.ComboBox scBoxDATABITS;
        private System.Windows.Forms.ComboBox scBoxSTOPBITS;
        private System.Windows.Forms.ComboBox scBoxPARITYBITS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox scBoxCOMPORT;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Button sbtnOpen;
        private System.Windows.Forms.Button sbtnClose;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox mcBoxBAUDRATE;
        private System.Windows.Forms.ComboBox mcBoxDATABITS;
        private System.Windows.Forms.ComboBox mcBoxSTOPBITS;
        private System.Windows.Forms.ComboBox mcBoxPARITYBITS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox mcBoxCOMPORT;
    }
}

