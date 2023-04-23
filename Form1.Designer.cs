namespace Travel_Booking_System
{
    partial class frmTravelbookingSystem
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
            this.label1 = new System.Windows.Forms.Label();
            this.tboxNumGuests = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radApril30 = new System.Windows.Forms.RadioButton();
            this.radMay07 = new System.Windows.Forms.RadioButton();
            this.radMay14 = new System.Windows.Forms.RadioButton();
            this.radMay21 = new System.Windows.Forms.RadioButton();
            this.radMay28 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxNumNights = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radBasic = new System.Windows.Forms.RadioButton();
            this.radLuxury = new System.Windows.Forms.RadioButton();
            this.radNone = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxNumDays = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOutTotalCost = new System.Windows.Forms.Label();
            this.btnCalcTotalCost = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. of Guests";
            // 
            // tboxNumGuests
            // 
            this.tboxNumGuests.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxNumGuests.Location = new System.Drawing.Point(168, 29);
            this.tboxNumGuests.Name = "tboxNumGuests";
            this.tboxNumGuests.Size = new System.Drawing.Size(114, 26);
            this.tboxNumGuests.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 128);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Destination";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Items.AddRange(new object[] {
            "New York",
            "Los Angeles",
            "Miami",
            "Chicago",
            "San Fancisco"});
            this.listBox1.Location = new System.Drawing.Point(6, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(232, 99);
            this.listBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radMay28);
            this.groupBox2.Controls.Add(this.radMay21);
            this.groupBox2.Controls.Add(this.radMay14);
            this.groupBox2.Controls.Add(this.radMay07);
            this.groupBox2.Controls.Add(this.radApril30);
            this.groupBox2.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(288, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 191);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Departure Date";
            // 
            // radApril30
            // 
            this.radApril30.AutoSize = true;
            this.radApril30.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radApril30.Location = new System.Drawing.Point(37, 34);
            this.radApril30.Name = "radApril30";
            this.radApril30.Size = new System.Drawing.Size(99, 23);
            this.radApril30.TabIndex = 0;
            this.radApril30.TabStop = true;
            this.radApril30.Text = "April 30";
            this.radApril30.UseVisualStyleBackColor = true;
            // 
            // radMay07
            // 
            this.radMay07.AutoSize = true;
            this.radMay07.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMay07.Location = new System.Drawing.Point(37, 63);
            this.radMay07.Name = "radMay07";
            this.radMay07.Size = new System.Drawing.Size(81, 23);
            this.radMay07.TabIndex = 1;
            this.radMay07.TabStop = true;
            this.radMay07.Text = "May 07";
            this.radMay07.UseVisualStyleBackColor = true;
            // 
            // radMay14
            // 
            this.radMay14.AutoSize = true;
            this.radMay14.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMay14.Location = new System.Drawing.Point(37, 92);
            this.radMay14.Name = "radMay14";
            this.radMay14.Size = new System.Drawing.Size(81, 23);
            this.radMay14.TabIndex = 2;
            this.radMay14.TabStop = true;
            this.radMay14.Text = "May 14";
            this.radMay14.UseVisualStyleBackColor = true;
            // 
            // radMay21
            // 
            this.radMay21.AutoSize = true;
            this.radMay21.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMay21.Location = new System.Drawing.Point(37, 121);
            this.radMay21.Name = "radMay21";
            this.radMay21.Size = new System.Drawing.Size(81, 23);
            this.radMay21.TabIndex = 3;
            this.radMay21.TabStop = true;
            this.radMay21.Text = "May 21";
            this.radMay21.UseVisualStyleBackColor = true;
            // 
            // radMay28
            // 
            this.radMay28.AutoSize = true;
            this.radMay28.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMay28.Location = new System.Drawing.Point(37, 150);
            this.radMay28.Name = "radMay28";
            this.radMay28.Size = new System.Drawing.Size(81, 23);
            this.radMay28.TabIndex = 4;
            this.radMay28.TabStop = true;
            this.radMay28.Text = "May 28";
            this.radMay28.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tboxNumNights);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(38, 220);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(244, 57);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hotel Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "No. of Nights";
            // 
            // tboxNumNights
            // 
            this.tboxNumNights.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxNumNights.Location = new System.Drawing.Point(138, 25);
            this.tboxNumNights.Name = "tboxNumNights";
            this.tboxNumNights.Size = new System.Drawing.Size(100, 26);
            this.tboxNumNights.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tboxNumDays);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.radNone);
            this.groupBox4.Controls.Add(this.radLuxury);
            this.groupBox4.Controls.Add(this.radBasic);
            this.groupBox4.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(494, 86);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(245, 191);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Rental Car Information";
            // 
            // radBasic
            // 
            this.radBasic.AutoSize = true;
            this.radBasic.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBasic.Location = new System.Drawing.Point(18, 49);
            this.radBasic.Name = "radBasic";
            this.radBasic.Size = new System.Drawing.Size(72, 23);
            this.radBasic.TabIndex = 0;
            this.radBasic.TabStop = true;
            this.radBasic.Text = "Basic";
            this.radBasic.UseVisualStyleBackColor = true;
            // 
            // radLuxury
            // 
            this.radLuxury.AutoSize = true;
            this.radLuxury.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLuxury.Location = new System.Drawing.Point(18, 78);
            this.radLuxury.Name = "radLuxury";
            this.radLuxury.Size = new System.Drawing.Size(81, 23);
            this.radLuxury.TabIndex = 1;
            this.radLuxury.TabStop = true;
            this.radLuxury.Text = "Luxury";
            this.radLuxury.UseVisualStyleBackColor = true;
            // 
            // radNone
            // 
            this.radNone.AutoSize = true;
            this.radNone.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNone.Location = new System.Drawing.Point(18, 107);
            this.radNone.Name = "radNone";
            this.radNone.Size = new System.Drawing.Size(63, 23);
            this.radNone.TabIndex = 2;
            this.radNone.TabStop = true;
            this.radNone.Text = "None";
            this.radNone.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "No. of Days";
            // 
            // tboxNumDays
            // 
            this.tboxNumDays.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxNumDays.Location = new System.Drawing.Point(128, 159);
            this.tboxNumDays.Name = "tboxNumDays";
            this.tboxNumDays.Size = new System.Drawing.Size(111, 26);
            this.tboxNumDays.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total Cost of Travel";
            // 
            // lblOutTotalCost
            // 
            this.lblOutTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutTotalCost.Font = new System.Drawing.Font("NanumGothicCoding", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutTotalCost.Location = new System.Drawing.Point(238, 300);
            this.lblOutTotalCost.Name = "lblOutTotalCost";
            this.lblOutTotalCost.Size = new System.Drawing.Size(501, 43);
            this.lblOutTotalCost.TabIndex = 6;
            this.lblOutTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalcTotalCost
            // 
            this.btnCalcTotalCost.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcTotalCost.Location = new System.Drawing.Point(38, 361);
            this.btnCalcTotalCost.Name = "btnCalcTotalCost";
            this.btnCalcTotalCost.Size = new System.Drawing.Size(219, 59);
            this.btnCalcTotalCost.TabIndex = 7;
            this.btnCalcTotalCost.Text = "Calculate Total Cost";
            this.btnCalcTotalCost.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(263, 361);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 59);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // frmTravelbookingSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalcTotalCost);
            this.Controls.Add(this.lblOutTotalCost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tboxNumGuests);
            this.Controls.Add(this.label1);
            this.Name = "frmTravelbookingSystem";
            this.Text = "Travel Booking System";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxNumGuests;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radMay28;
        private System.Windows.Forms.RadioButton radMay21;
        private System.Windows.Forms.RadioButton radMay14;
        private System.Windows.Forms.RadioButton radMay07;
        private System.Windows.Forms.RadioButton radApril30;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tboxNumNights;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radNone;
        private System.Windows.Forms.RadioButton radLuxury;
        private System.Windows.Forms.RadioButton radBasic;
        private System.Windows.Forms.TextBox tboxNumDays;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOutTotalCost;
        private System.Windows.Forms.Button btnCalcTotalCost;
        private System.Windows.Forms.Button btnExit;
    }
}

