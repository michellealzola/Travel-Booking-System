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
            this.gboxDestination = new System.Windows.Forms.GroupBox();
            this.lboxDestination = new System.Windows.Forms.ListBox();
            this.gboxDepartureDate = new System.Windows.Forms.GroupBox();
            this.radApril30 = new System.Windows.Forms.RadioButton();
            this.radMay07 = new System.Windows.Forms.RadioButton();
            this.radMay14 = new System.Windows.Forms.RadioButton();
            this.radMay21 = new System.Windows.Forms.RadioButton();
            this.radMay28 = new System.Windows.Forms.RadioButton();
            this.gboxHotel = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxNumNights = new System.Windows.Forms.TextBox();
            this.gboxRentalCar = new System.Windows.Forms.GroupBox();
            this.radBasic = new System.Windows.Forms.RadioButton();
            this.radLuxury = new System.Windows.Forms.RadioButton();
            this.radNone = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxNumDays = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOutTotalCost = new System.Windows.Forms.Label();
            this.btnCalcTotalCost = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gboxDestination.SuspendLayout();
            this.gboxDepartureDate.SuspendLayout();
            this.gboxHotel.SuspendLayout();
            this.gboxRentalCar.SuspendLayout();
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
            // gboxDestination
            // 
            this.gboxDestination.Controls.Add(this.lboxDestination);
            this.gboxDestination.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxDestination.Location = new System.Drawing.Point(38, 86);
            this.gboxDestination.Name = "gboxDestination";
            this.gboxDestination.Size = new System.Drawing.Size(244, 128);
            this.gboxDestination.TabIndex = 2;
            this.gboxDestination.TabStop = false;
            this.gboxDestination.Text = "Destination";
            // 
            // lboxDestination
            // 
            this.lboxDestination.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboxDestination.FormattingEnabled = true;
            this.lboxDestination.ItemHeight = 19;
            this.lboxDestination.Items.AddRange(new object[] {
            "New York ($400)",
            "Los Angeles ($500)",
            "Miami ($450)",
            "Chicago ($350)",
            "San Francisco ($550)"});
            this.lboxDestination.Location = new System.Drawing.Point(6, 23);
            this.lboxDestination.Name = "lboxDestination";
            this.lboxDestination.Size = new System.Drawing.Size(232, 99);
            this.lboxDestination.TabIndex = 0;
            // 
            // gboxDepartureDate
            // 
            this.gboxDepartureDate.Controls.Add(this.radMay28);
            this.gboxDepartureDate.Controls.Add(this.radMay21);
            this.gboxDepartureDate.Controls.Add(this.radMay14);
            this.gboxDepartureDate.Controls.Add(this.radMay07);
            this.gboxDepartureDate.Controls.Add(this.radApril30);
            this.gboxDepartureDate.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxDepartureDate.Location = new System.Drawing.Point(288, 86);
            this.gboxDepartureDate.Name = "gboxDepartureDate";
            this.gboxDepartureDate.Size = new System.Drawing.Size(200, 199);
            this.gboxDepartureDate.TabIndex = 5;
            this.gboxDepartureDate.TabStop = false;
            this.gboxDepartureDate.Text = "Departure Date";
            // 
            // radApril30
            // 
            this.radApril30.AutoSize = true;
            this.radApril30.Checked = true;
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
            // gboxHotel
            // 
            this.gboxHotel.Controls.Add(this.tboxNumNights);
            this.gboxHotel.Controls.Add(this.label2);
            this.gboxHotel.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxHotel.Location = new System.Drawing.Point(38, 220);
            this.gboxHotel.Name = "gboxHotel";
            this.gboxHotel.Size = new System.Drawing.Size(244, 65);
            this.gboxHotel.TabIndex = 3;
            this.gboxHotel.TabStop = false;
            this.gboxHotel.Text = "Hotel ($150 per night)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "No. of Nights";
            // 
            // tboxNumNights
            // 
            this.tboxNumNights.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxNumNights.Location = new System.Drawing.Point(138, 33);
            this.tboxNumNights.Name = "tboxNumNights";
            this.tboxNumNights.Size = new System.Drawing.Size(100, 26);
            this.tboxNumNights.TabIndex = 4;
            // 
            // gboxRentalCar
            // 
            this.gboxRentalCar.Controls.Add(this.tboxNumDays);
            this.gboxRentalCar.Controls.Add(this.label3);
            this.gboxRentalCar.Controls.Add(this.radNone);
            this.gboxRentalCar.Controls.Add(this.radLuxury);
            this.gboxRentalCar.Controls.Add(this.radBasic);
            this.gboxRentalCar.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxRentalCar.Location = new System.Drawing.Point(494, 86);
            this.gboxRentalCar.Name = "gboxRentalCar";
            this.gboxRentalCar.Size = new System.Drawing.Size(245, 199);
            this.gboxRentalCar.TabIndex = 6;
            this.gboxRentalCar.TabStop = false;
            this.gboxRentalCar.Text = "Rental Car Information";
            // 
            // radBasic
            // 
            this.radBasic.AutoSize = true;
            this.radBasic.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBasic.Location = new System.Drawing.Point(18, 49);
            this.radBasic.Name = "radBasic";
            this.radBasic.Size = new System.Drawing.Size(198, 23);
            this.radBasic.TabIndex = 0;
            this.radBasic.TabStop = true;
            this.radBasic.Text = "Basic ($50 per day)";
            this.radBasic.UseVisualStyleBackColor = true;
            // 
            // radLuxury
            // 
            this.radLuxury.AutoSize = true;
            this.radLuxury.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLuxury.Location = new System.Drawing.Point(18, 78);
            this.radLuxury.Name = "radLuxury";
            this.radLuxury.Size = new System.Drawing.Size(216, 23);
            this.radLuxury.TabIndex = 1;
            this.radLuxury.TabStop = true;
            this.radLuxury.Text = "Luxury ($100 per day)";
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
            this.label3.Location = new System.Drawing.Point(14, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "No. of Days";
            // 
            // tboxNumDays
            // 
            this.tboxNumDays.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxNumDays.Location = new System.Drawing.Point(128, 167);
            this.tboxNumDays.Name = "tboxNumDays";
            this.tboxNumDays.Size = new System.Drawing.Size(111, 26);
            this.tboxNumDays.TabIndex = 7;
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
            this.btnCalcTotalCost.TabIndex = 8;
            this.btnCalcTotalCost.Text = "Calculate Total Cost";
            this.btnCalcTotalCost.UseVisualStyleBackColor = true;
            this.btnCalcTotalCost.Click += new System.EventHandler(this.btnCalcTotalCost_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(263, 361);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 59);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            this.Controls.Add(this.gboxRentalCar);
            this.Controls.Add(this.gboxHotel);
            this.Controls.Add(this.gboxDepartureDate);
            this.Controls.Add(this.gboxDestination);
            this.Controls.Add(this.tboxNumGuests);
            this.Controls.Add(this.label1);
            this.Name = "frmTravelbookingSystem";
            this.Text = "Travel Booking System";
            this.gboxDestination.ResumeLayout(false);
            this.gboxDepartureDate.ResumeLayout(false);
            this.gboxDepartureDate.PerformLayout();
            this.gboxHotel.ResumeLayout(false);
            this.gboxHotel.PerformLayout();
            this.gboxRentalCar.ResumeLayout(false);
            this.gboxRentalCar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxNumGuests;
        private System.Windows.Forms.GroupBox gboxDestination;
        private System.Windows.Forms.ListBox lboxDestination;
        private System.Windows.Forms.GroupBox gboxDepartureDate;
        private System.Windows.Forms.RadioButton radMay28;
        private System.Windows.Forms.RadioButton radMay21;
        private System.Windows.Forms.RadioButton radMay14;
        private System.Windows.Forms.RadioButton radMay07;
        private System.Windows.Forms.RadioButton radApril30;
        private System.Windows.Forms.GroupBox gboxHotel;
        private System.Windows.Forms.TextBox tboxNumNights;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gboxRentalCar;
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

