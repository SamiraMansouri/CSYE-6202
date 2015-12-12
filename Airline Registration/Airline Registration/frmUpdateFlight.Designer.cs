namespace Airline_Registration
{
    partial class frmUpdateFlight
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtArrival = new System.Windows.Forms.TextBox();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.txtFlightNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFlights = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.chkBusiness = new System.Windows.Forms.CheckBox();
            this.chkEconomy = new System.Windows.Forms.CheckBox();
            this.chkEconomyPlus = new System.Windows.Forms.CheckBox();
            this.txtPriceBusiness = new System.Windows.Forms.TextBox();
            this.txtEndBusiness = new System.Windows.Forms.TextBox();
            this.txtStartBusiness = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPriceEconomyPlus = new System.Windows.Forms.TextBox();
            this.txtEndEconomyPlus = new System.Windows.Forms.TextBox();
            this.txtStartEconomyPlus = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPriceEconomy = new System.Windows.Forms.TextBox();
            this.txtEndEconomy = new System.Windows.Forms.TextBox();
            this.txtStartEconomy = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbMinute = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbHour = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCarrier = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlights)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(121, 123);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(160, 20);
            this.dateTimePicker1.TabIndex = 81;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtArrival
            // 
            this.txtArrival.Location = new System.Drawing.Point(457, 63);
            this.txtArrival.Name = "txtArrival";
            this.txtArrival.Size = new System.Drawing.Size(160, 20);
            this.txtArrival.TabIndex = 79;
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(121, 69);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(160, 20);
            this.txtDestination.TabIndex = 78;
            // 
            // txtFlightNumber
            // 
            this.txtFlightNumber.Location = new System.Drawing.Point(121, 21);
            this.txtFlightNumber.Name = "txtFlightNumber";
            this.txtFlightNumber.Size = new System.Drawing.Size(160, 20);
            this.txtFlightNumber.TabIndex = 76;
            this.txtFlightNumber.TextChanged += new System.EventHandler(this.txtFlightNumber_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 74;
            this.label6.Text = "Carrier";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(358, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 73;
            this.label5.Text = "Arrival";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 72;
            this.label4.Text = "Destination";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Flight Number";
            // 
            // dgvFlights
            // 
            this.dgvFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlights.Location = new System.Drawing.Point(25, 363);
            this.dgvFlights.Name = "dgvFlights";
            this.dgvFlights.Size = new System.Drawing.Size(662, 238);
            this.dgvFlights.TabIndex = 83;
            this.dgvFlights.SelectionChanged += new System.EventHandler(this.dgvFlights_SelectionChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(322, 307);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 85;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(239, 307);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 86;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // chkBusiness
            // 
            this.chkBusiness.AutoSize = true;
            this.chkBusiness.Location = new System.Drawing.Point(22, 261);
            this.chkBusiness.Name = "chkBusiness";
            this.chkBusiness.Size = new System.Drawing.Size(68, 17);
            this.chkBusiness.TabIndex = 116;
            this.chkBusiness.Text = "Business";
            this.chkBusiness.UseVisualStyleBackColor = true;
            // 
            // chkEconomy
            // 
            this.chkEconomy.AutoSize = true;
            this.chkEconomy.Location = new System.Drawing.Point(22, 182);
            this.chkEconomy.Name = "chkEconomy";
            this.chkEconomy.Size = new System.Drawing.Size(70, 17);
            this.chkEconomy.TabIndex = 115;
            this.chkEconomy.Text = "Economy";
            this.chkEconomy.UseVisualStyleBackColor = true;
            // 
            // chkEconomyPlus
            // 
            this.chkEconomyPlus.AutoSize = true;
            this.chkEconomyPlus.Location = new System.Drawing.Point(22, 224);
            this.chkEconomyPlus.Name = "chkEconomyPlus";
            this.chkEconomyPlus.Size = new System.Drawing.Size(93, 17);
            this.chkEconomyPlus.TabIndex = 114;
            this.chkEconomyPlus.Text = "Economy Plus";
            this.chkEconomyPlus.UseVisualStyleBackColor = true;
            // 
            // txtPriceBusiness
            // 
            this.txtPriceBusiness.Location = new System.Drawing.Point(569, 258);
            this.txtPriceBusiness.Name = "txtPriceBusiness";
            this.txtPriceBusiness.Size = new System.Drawing.Size(100, 20);
            this.txtPriceBusiness.TabIndex = 113;
            // 
            // txtEndBusiness
            // 
            this.txtEndBusiness.Location = new System.Drawing.Point(408, 258);
            this.txtEndBusiness.Name = "txtEndBusiness";
            this.txtEndBusiness.Size = new System.Drawing.Size(62, 20);
            this.txtEndBusiness.TabIndex = 112;
            // 
            // txtStartBusiness
            // 
            this.txtStartBusiness.Location = new System.Drawing.Point(214, 258);
            this.txtStartBusiness.Name = "txtStartBusiness";
            this.txtStartBusiness.Size = new System.Drawing.Size(67, 20);
            this.txtStartBusiness.TabIndex = 111;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(532, 261);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 110;
            this.label13.Text = "Price";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(352, 261);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 109;
            this.label14.Text = "End Seat";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(154, 261);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 108;
            this.label15.Text = "Start Seat";
            // 
            // txtPriceEconomyPlus
            // 
            this.txtPriceEconomyPlus.Location = new System.Drawing.Point(569, 222);
            this.txtPriceEconomyPlus.Name = "txtPriceEconomyPlus";
            this.txtPriceEconomyPlus.Size = new System.Drawing.Size(100, 20);
            this.txtPriceEconomyPlus.TabIndex = 107;
            // 
            // txtEndEconomyPlus
            // 
            this.txtEndEconomyPlus.Location = new System.Drawing.Point(408, 222);
            this.txtEndEconomyPlus.Name = "txtEndEconomyPlus";
            this.txtEndEconomyPlus.Size = new System.Drawing.Size(62, 20);
            this.txtEndEconomyPlus.TabIndex = 106;
            // 
            // txtStartEconomyPlus
            // 
            this.txtStartEconomyPlus.Location = new System.Drawing.Point(214, 222);
            this.txtStartEconomyPlus.Name = "txtStartEconomyPlus";
            this.txtStartEconomyPlus.Size = new System.Drawing.Size(67, 20);
            this.txtStartEconomyPlus.TabIndex = 105;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(532, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 104;
            this.label10.Text = "Price";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(352, 225);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 103;
            this.label11.Text = "End Seat";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(154, 225);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 102;
            this.label12.Text = "Start Seat";
            // 
            // txtPriceEconomy
            // 
            this.txtPriceEconomy.Location = new System.Drawing.Point(569, 179);
            this.txtPriceEconomy.Name = "txtPriceEconomy";
            this.txtPriceEconomy.Size = new System.Drawing.Size(100, 20);
            this.txtPriceEconomy.TabIndex = 101;
            // 
            // txtEndEconomy
            // 
            this.txtEndEconomy.Location = new System.Drawing.Point(408, 179);
            this.txtEndEconomy.Name = "txtEndEconomy";
            this.txtEndEconomy.Size = new System.Drawing.Size(62, 20);
            this.txtEndEconomy.TabIndex = 100;
            // 
            // txtStartEconomy
            // 
            this.txtStartEconomy.Location = new System.Drawing.Point(214, 179);
            this.txtStartEconomy.Name = "txtStartEconomy";
            this.txtStartEconomy.Size = new System.Drawing.Size(67, 20);
            this.txtStartEconomy.TabIndex = 99;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(532, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 98;
            this.label7.Text = "Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(352, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 97;
            this.label9.Text = "End Seat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(154, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 96;
            this.label8.Text = "Start Seat";
            // 
            // cmbMinute
            // 
            this.cmbMinute.FormattingEnabled = true;
            this.cmbMinute.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cmbMinute.Location = new System.Drawing.Point(521, 122);
            this.cmbMinute.Name = "cmbMinute";
            this.cmbMinute.Size = new System.Drawing.Size(42, 21);
            this.cmbMinute.TabIndex = 121;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(505, 125);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(10, 13);
            this.label17.TabIndex = 120;
            this.label17.Text = ":";
            // 
            // cmbHour
            // 
            this.cmbHour.FormattingEnabled = true;
            this.cmbHour.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cmbHour.Location = new System.Drawing.Point(456, 122);
            this.cmbHour.Name = "cmbHour";
            this.cmbHour.Size = new System.Drawing.Size(43, 21);
            this.cmbHour.TabIndex = 119;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(573, 122);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 13);
            this.label16.TabIndex = 118;
            this.label16.Text = "HH:MM";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 117;
            this.label3.Text = "Time";
            // 
            // txtCarrier
            // 
            this.txtCarrier.Location = new System.Drawing.Point(456, 24);
            this.txtCarrier.Name = "txtCarrier";
            this.txtCarrier.Size = new System.Drawing.Size(161, 20);
            this.txtCarrier.TabIndex = 122;
            // 
            // frmUpdateFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 613);
            this.Controls.Add(this.txtCarrier);
            this.Controls.Add(this.cmbMinute);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cmbHour);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkBusiness);
            this.Controls.Add(this.chkEconomy);
            this.Controls.Add(this.chkEconomyPlus);
            this.Controls.Add(this.txtPriceBusiness);
            this.Controls.Add(this.txtEndBusiness);
            this.Controls.Add(this.txtStartBusiness);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtPriceEconomyPlus);
            this.Controls.Add(this.txtEndEconomyPlus);
            this.Controls.Add(this.txtStartEconomyPlus);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtPriceEconomy);
            this.Controls.Add(this.txtEndEconomy);
            this.Controls.Add(this.txtStartEconomy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvFlights);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtArrival);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.txtFlightNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUpdateFlight";
            this.Text = "Update Flights Information";
            this.Load += new System.EventHandler(this.frmUpdateFlight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlights)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtArrival;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.TextBox txtFlightNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvFlights;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckBox chkBusiness;
        private System.Windows.Forms.CheckBox chkEconomy;
        private System.Windows.Forms.CheckBox chkEconomyPlus;
        private System.Windows.Forms.TextBox txtPriceBusiness;
        private System.Windows.Forms.TextBox txtEndBusiness;
        private System.Windows.Forms.TextBox txtStartBusiness;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPriceEconomyPlus;
        private System.Windows.Forms.TextBox txtEndEconomyPlus;
        private System.Windows.Forms.TextBox txtStartEconomyPlus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPriceEconomy;
        private System.Windows.Forms.TextBox txtEndEconomy;
        private System.Windows.Forms.TextBox txtStartEconomy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbMinute;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbHour;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCarrier;
    }
}