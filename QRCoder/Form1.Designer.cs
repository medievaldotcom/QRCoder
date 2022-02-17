namespace QRCoder
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
            this.txtQRCodeName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.txtQRCodeBirthdate = new System.Windows.Forms.TextBox();
            this.txtQRCodeAddress = new System.Windows.Forms.TextBox();
            this.txtQRCodePhoneNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQRCodeEmailAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.choosedevice = new System.Windows.Forms.ComboBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.QRtext = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Start = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQRCodeName
            // 
            this.txtQRCodeName.Location = new System.Drawing.Point(767, 280);
            this.txtQRCodeName.Multiline = true;
            this.txtQRCodeName.Name = "txtQRCodeName";
            this.txtQRCodeName.Size = new System.Drawing.Size(227, 29);
            this.txtQRCodeName.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1000, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generate QR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GenerateQR);
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(12, 25);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(383, 481);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            // 
            // txtQRCodeBirthdate
            // 
            this.txtQRCodeBirthdate.Location = new System.Drawing.Point(767, 328);
            this.txtQRCodeBirthdate.Multiline = true;
            this.txtQRCodeBirthdate.Name = "txtQRCodeBirthdate";
            this.txtQRCodeBirthdate.Size = new System.Drawing.Size(227, 29);
            this.txtQRCodeBirthdate.TabIndex = 3;
            // 
            // txtQRCodeAddress
            // 
            this.txtQRCodeAddress.Location = new System.Drawing.Point(767, 376);
            this.txtQRCodeAddress.Multiline = true;
            this.txtQRCodeAddress.Name = "txtQRCodeAddress";
            this.txtQRCodeAddress.Size = new System.Drawing.Size(227, 29);
            this.txtQRCodeAddress.TabIndex = 4;
            // 
            // txtQRCodePhoneNumber
            // 
            this.txtQRCodePhoneNumber.Location = new System.Drawing.Point(767, 425);
            this.txtQRCodePhoneNumber.Multiline = true;
            this.txtQRCodePhoneNumber.Name = "txtQRCodePhoneNumber";
            this.txtQRCodePhoneNumber.Size = new System.Drawing.Size(227, 29);
            this.txtQRCodePhoneNumber.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(764, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(764, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Date of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(764, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(764, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Phone No.";
            // 
            // label5
            // 
            this.label5.AccessibleName = "txtQRCodeEmail";
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(764, 457);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Email Address";
            // 
            // txtQRCodeEmailAddress
            // 
            this.txtQRCodeEmailAddress.AccessibleName = "txtQRCodeEmail";
            this.txtQRCodeEmailAddress.Location = new System.Drawing.Point(767, 473);
            this.txtQRCodeEmailAddress.Multiline = true;
            this.txtQRCodeEmailAddress.Name = "txtQRCodeEmailAddress";
            this.txtQRCodeEmailAddress.Size = new System.Drawing.Size(227, 29);
            this.txtQRCodeEmailAddress.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "QR Generator";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(401, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Camera:";
            // 
            // choosedevice
            // 
            this.choosedevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.choosedevice.FormattingEnabled = true;
            this.choosedevice.Location = new System.Drawing.Point(453, 38);
            this.choosedevice.Name = "choosedevice";
            this.choosedevice.Size = new System.Drawing.Size(121, 21);
            this.choosedevice.TabIndex = 15;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(453, 65);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(302, 438);
            this.pictureBox.TabIndex = 16;
            this.pictureBox.TabStop = false;
            // 
            // QRtext
            // 
            this.QRtext.Location = new System.Drawing.Point(767, 54);
            this.QRtext.Multiline = true;
            this.QRtext.Name = "QRtext";
            this.QRtext.Size = new System.Drawing.Size(327, 204);
            this.QRtext.TabIndex = 17;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(578, 38);
            this.Start.Margin = new System.Windows.Forms.Padding(2);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(88, 19);
            this.Start.TabIndex = 18;
            this.Start.Text = "Capture QR";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(670, 38);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 21);
            this.button2.TabIndex = 19;
            this.button2.Text = "Upload QR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.uploadQR);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(889, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "QR Text";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 518);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.QRtext);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.choosedevice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtQRCodeEmailAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQRCodePhoneNumber);
            this.Controls.Add(this.txtQRCodeAddress);
            this.Controls.Add(this.txtQRCodeBirthdate);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtQRCodeName);
            this.Name = "Form1";
            this.Text = "QR Master";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQRCodeName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.TextBox txtQRCodeBirthdate;
        private System.Windows.Forms.TextBox txtQRCodeAddress;
        private System.Windows.Forms.TextBox txtQRCodePhoneNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQRCodeEmailAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox choosedevice;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox QRtext;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label8;
    }
}

