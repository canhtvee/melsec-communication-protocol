namespace FCCTest
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtCoeff2 = new System.Windows.Forms.TextBox();
            this.txtCoeff1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.btnFR = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtG7DCVolt = new System.Windows.Forms.TextBox();
            this.txtA1000DCVolt = new System.Windows.Forms.TextBox();
            this.txtG7OutVolt = new System.Windows.Forms.TextBox();
            this.txtA1000OutVolt = new System.Windows.Forms.TextBox();
            this.txtG7OutCurrent = new System.Windows.Forms.TextBox();
            this.txtA1000OutCurrent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSTART = new System.Windows.Forms.Button();
            this.btnSTOP = new System.Windows.Forms.Button();
            this.btnUP = new System.Windows.Forms.Button();
            this.btnDOWN = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.txtA1000OutFreq = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txtG7OutFreq = new System.Windows.Forms.TextBox();
            this.txtG7FreqCmd = new System.Windows.Forms.TextBox();
            this.txtA1000FreqCmd = new System.Windows.Forms.TextBox();
            this.txtConnectStatus = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(191, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 22);
            this.label6.TabIndex = 79;
            this.label6.Text = "Freq Command";
            // 
            // txtCoeff2
            // 
            this.txtCoeff2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoeff2.Location = new System.Drawing.Point(380, 178);
            this.txtCoeff2.Name = "txtCoeff2";
            this.txtCoeff2.Size = new System.Drawing.Size(40, 27);
            this.txtCoeff2.TabIndex = 78;
            this.txtCoeff2.TextChanged += new System.EventHandler(this.txtCoeff2_TextChanged);
            this.txtCoeff2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCoeff2_KeyUp);
            // 
            // txtCoeff1
            // 
            this.txtCoeff1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoeff1.Location = new System.Drawing.Point(380, 144);
            this.txtCoeff1.Name = "txtCoeff1";
            this.txtCoeff1.Size = new System.Drawing.Size(40, 27);
            this.txtCoeff1.TabIndex = 77;
            this.txtCoeff1.TextChanged += new System.EventHandler(this.txtCoeff1_TextChanged);
            this.txtCoeff1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCoeff1_KeyUp);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(191, 115);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(317, 22);
            this.label16.TabIndex = 76;
            this.label16.Text = "G7 = A1000 - ( a*A1000^2 + b*A1000)";
            // 
            // txtTarget
            // 
            this.txtTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarget.Location = new System.Drawing.Point(380, 80);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(85, 27);
            this.txtTarget.TabIndex = 71;
            this.txtTarget.TextChanged += new System.EventHandler(this.txtTarget_TextChanged);
            this.txtTarget.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTarget_KeyUp);
            // 
            // btnFR
            // 
            this.btnFR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFR.Location = new System.Drawing.Point(336, 427);
            this.btnFR.Name = "btnFR";
            this.btnFR.Size = new System.Drawing.Size(85, 48);
            this.btnFR.TabIndex = 69;
            this.btnFR.Text = "F/R";
            this.btnFR.UseVisualStyleBackColor = true;
            this.btnFR.Click += new System.EventHandler(this.btnFR_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(191, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(194, 22);
            this.label11.TabIndex = 68;
            this.label11.Text = "A1000 = TargetFreq = ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(553, 385);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 22);
            this.label13.TabIndex = 67;
            this.label13.Text = "V";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(191, 385);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(138, 22);
            this.label.TabIndex = 66;
            this.label.Text = "DC Bus Voltage";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(553, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 22);
            this.label9.TabIndex = 65;
            this.label9.Text = "V";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 22);
            this.label1.TabIndex = 64;
            this.label1.Text = "Output Voltage";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(553, 353);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 22);
            this.label8.TabIndex = 63;
            this.label8.Text = "A";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(191, 353);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 22);
            this.label10.TabIndex = 62;
            this.label10.Text = "Output Current";
            // 
            // txtG7DCVolt
            // 
            this.txtG7DCVolt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtG7DCVolt.Location = new System.Drawing.Point(456, 382);
            this.txtG7DCVolt.Name = "txtG7DCVolt";
            this.txtG7DCVolt.Size = new System.Drawing.Size(85, 27);
            this.txtG7DCVolt.TabIndex = 60;
            // 
            // txtA1000DCVolt
            // 
            this.txtA1000DCVolt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA1000DCVolt.Location = new System.Drawing.Point(336, 382);
            this.txtA1000DCVolt.Name = "txtA1000DCVolt";
            this.txtA1000DCVolt.Size = new System.Drawing.Size(85, 27);
            this.txtA1000DCVolt.TabIndex = 58;
            // 
            // txtG7OutVolt
            // 
            this.txtG7OutVolt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtG7OutVolt.Location = new System.Drawing.Point(456, 318);
            this.txtG7OutVolt.Name = "txtG7OutVolt";
            this.txtG7OutVolt.Size = new System.Drawing.Size(85, 27);
            this.txtG7OutVolt.TabIndex = 61;
            // 
            // txtA1000OutVolt
            // 
            this.txtA1000OutVolt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA1000OutVolt.Location = new System.Drawing.Point(336, 318);
            this.txtA1000OutVolt.Name = "txtA1000OutVolt";
            this.txtA1000OutVolt.Size = new System.Drawing.Size(85, 27);
            this.txtA1000OutVolt.TabIndex = 57;
            // 
            // txtG7OutCurrent
            // 
            this.txtG7OutCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtG7OutCurrent.Location = new System.Drawing.Point(456, 350);
            this.txtG7OutCurrent.Name = "txtG7OutCurrent";
            this.txtG7OutCurrent.Size = new System.Drawing.Size(85, 27);
            this.txtG7OutCurrent.TabIndex = 59;
            // 
            // txtA1000OutCurrent
            // 
            this.txtA1000OutCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA1000OutCurrent.Location = new System.Drawing.Point(336, 350);
            this.txtA1000OutCurrent.Name = "txtA1000OutCurrent";
            this.txtA1000OutCurrent.Size = new System.Drawing.Size(85, 27);
            this.txtA1000OutCurrent.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(553, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 22);
            this.label4.TabIndex = 55;
            this.label4.Text = "Hz";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(471, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 22);
            this.label12.TabIndex = 54;
            this.label12.Text = "Hz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(553, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 22);
            this.label3.TabIndex = 53;
            this.label3.Text = "Hz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(191, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 22);
            this.label2.TabIndex = 52;
            this.label2.Text = "Output Freq";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(191, 147);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(331, 22);
            this.label17.TabIndex = 51;
            this.label17.Text = "a = D550*coefficient =          *coefficient ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(191, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(331, 22);
            this.label7.TabIndex = 50;
            this.label7.Text = "b = D552*coefficient =          *coefficient ";
            // 
            // btnSTART
            // 
            this.btnSTART.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSTART.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSTART.Location = new System.Drawing.Point(518, 427);
            this.btnSTART.Name = "btnSTART";
            this.btnSTART.Size = new System.Drawing.Size(85, 48);
            this.btnSTART.TabIndex = 49;
            this.btnSTART.Text = "START";
            this.btnSTART.UseVisualStyleBackColor = true;
            this.btnSTART.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSTART_MouseDown);
            this.btnSTART.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnSTART_MouseUp);
            // 
            // btnSTOP
            // 
            this.btnSTOP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSTOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSTOP.Location = new System.Drawing.Point(427, 427);
            this.btnSTOP.Name = "btnSTOP";
            this.btnSTOP.Size = new System.Drawing.Size(85, 48);
            this.btnSTOP.TabIndex = 48;
            this.btnSTOP.Text = "STOP";
            this.btnSTOP.UseVisualStyleBackColor = true;
            this.btnSTOP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSTOP_MouseDown);
            this.btnSTOP.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnSTOP_MouseUp);
            // 
            // btnUP
            // 
            this.btnUP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUP.Location = new System.Drawing.Point(244, 427);
            this.btnUP.Name = "btnUP";
            this.btnUP.Size = new System.Drawing.Size(85, 48);
            this.btnUP.TabIndex = 47;
            this.btnUP.Text = "UP";
            this.btnUP.UseVisualStyleBackColor = true;
            this.btnUP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnUP_MouseDown);
            this.btnUP.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnUP_MouseUp);
            // 
            // btnDOWN
            // 
            this.btnDOWN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDOWN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDOWN.Location = new System.Drawing.Point(153, 427);
            this.btnDOWN.Name = "btnDOWN";
            this.btnDOWN.Size = new System.Drawing.Size(85, 48);
            this.btnDOWN.TabIndex = 46;
            this.btnDOWN.Text = "DOWN";
            this.btnDOWN.UseVisualStyleBackColor = true;
            this.btnDOWN.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDOWN_MouseDown);
            this.btnDOWN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnDOWN_MouseUp);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(482, 226);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 22);
            this.label18.TabIndex = 45;
            this.label18.Text = "G7";
            // 
            // txtA1000OutFreq
            // 
            this.txtA1000OutFreq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA1000OutFreq.Location = new System.Drawing.Point(336, 287);
            this.txtA1000OutFreq.Name = "txtA1000OutFreq";
            this.txtA1000OutFreq.Size = new System.Drawing.Size(85, 27);
            this.txtA1000OutFreq.TabIndex = 41;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(348, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 22);
            this.label5.TabIndex = 44;
            this.label5.Text = "A1000";
            // 
            // txtG7OutFreq
            // 
            this.txtG7OutFreq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtG7OutFreq.Location = new System.Drawing.Point(456, 287);
            this.txtG7OutFreq.Name = "txtG7OutFreq";
            this.txtG7OutFreq.Size = new System.Drawing.Size(85, 27);
            this.txtG7OutFreq.TabIndex = 42;
            // 
            // txtG7FreqCmd
            // 
            this.txtG7FreqCmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtG7FreqCmd.Location = new System.Drawing.Point(456, 256);
            this.txtG7FreqCmd.Name = "txtG7FreqCmd";
            this.txtG7FreqCmd.Size = new System.Drawing.Size(85, 27);
            this.txtG7FreqCmd.TabIndex = 43;
            // 
            // txtA1000FreqCmd
            // 
            this.txtA1000FreqCmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA1000FreqCmd.Location = new System.Drawing.Point(336, 256);
            this.txtA1000FreqCmd.Name = "txtA1000FreqCmd";
            this.txtA1000FreqCmd.Size = new System.Drawing.Size(85, 27);
            this.txtA1000FreqCmd.TabIndex = 40;
            // 
            // txtConnectStatus
            // 
            this.txtConnectStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConnectStatus.Location = new System.Drawing.Point(151, 35);
            this.txtConnectStatus.Multiline = true;
            this.txtConnectStatus.Name = "txtConnectStatus";
            this.txtConnectStatus.Size = new System.Drawing.Size(83, 27);
            this.txtConnectStatus.TabIndex = 39;
            this.txtConnectStatus.Text = "Offline";
            this.txtConnectStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConnect
            // 
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(2, 68);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(112, 30);
            this.btnConnect.TabIndex = 38;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP.Location = new System.Drawing.Point(80, 2);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(154, 27);
            this.txtIP.TabIndex = 40;
            this.txtIP.Text = "192.168.3.1";
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.Location = new System.Drawing.Point(80, 35);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(65, 27);
            this.txtPort.TabIndex = 40;
            this.txtPort.Text = "10002";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(-2, 7);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 22);
            this.label19.TabIndex = 53;
            this.label19.Text = "Address";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(-2, 38);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(71, 22);
            this.label20.TabIndex = 53;
            this.label20.Text = "PortNo.";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(331, 24);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(123, 25);
            this.label21.TabIndex = 44;
            this.label21.Text = "FCC TEST";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(614, 489);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCoeff2);
            this.Controls.Add(this.txtCoeff1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtTarget);
            this.Controls.Add(this.btnFR);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtG7DCVolt);
            this.Controls.Add(this.txtA1000DCVolt);
            this.Controls.Add(this.txtG7OutVolt);
            this.Controls.Add(this.txtA1000OutVolt);
            this.Controls.Add(this.txtG7OutCurrent);
            this.Controls.Add(this.txtA1000OutCurrent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSTART);
            this.Controls.Add(this.btnSTOP);
            this.Controls.Add(this.btnUP);
            this.Controls.Add(this.btnDOWN);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtA1000OutFreq);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtG7OutFreq);
            this.Controls.Add(this.txtG7FreqCmd);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.txtA1000FreqCmd);
            this.Controls.Add(this.txtConnectStatus);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "FCCTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCoeff2;
        private System.Windows.Forms.TextBox txtCoeff1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.Button btnFR;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtG7DCVolt;
        private System.Windows.Forms.TextBox txtA1000DCVolt;
        private System.Windows.Forms.TextBox txtG7OutVolt;
        private System.Windows.Forms.TextBox txtA1000OutVolt;
        private System.Windows.Forms.TextBox txtG7OutCurrent;
        private System.Windows.Forms.TextBox txtA1000OutCurrent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSTART;
        private System.Windows.Forms.Button btnSTOP;
        private System.Windows.Forms.Button btnUP;
        private System.Windows.Forms.Button btnDOWN;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtA1000OutFreq;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtG7OutFreq;
        private System.Windows.Forms.TextBox txtG7FreqCmd;
        private System.Windows.Forms.TextBox txtA1000FreqCmd;
        private System.Windows.Forms.TextBox txtConnectStatus;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
    }
}

