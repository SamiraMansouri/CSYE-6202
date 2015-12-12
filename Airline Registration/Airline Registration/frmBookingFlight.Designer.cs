namespace Airline_Registration
{
    partial class frmBookingFlight
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtFlightID = new System.Windows.Forms.TextBox();
            this.cmbSeatTypes = new System.Windows.Forms.ComboBox();
            this.txtPassengerID = new System.Windows.Forms.TextBox();
            this.cmbSeatNumber = new System.Windows.Forms.ComboBox();
            this.dgvPassengers = new System.Windows.Forms.DataGridView();
            this.dgvFlights = new System.Windows.Forms.DataGridView();
            this.btnPay = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassengers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlights)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flight Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type of Seat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Seat Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Passenger ID";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(119, 95);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(183, 20);
            this.txtPrice.TabIndex = 5;
            // 
            // txtFlightID
            // 
            this.txtFlightID.Location = new System.Drawing.Point(119, 26);
            this.txtFlightID.Name = "txtFlightID";
            this.txtFlightID.Size = new System.Drawing.Size(183, 20);
            this.txtFlightID.TabIndex = 6;
            // 
            // cmbSeatTypes
            // 
            this.cmbSeatTypes.FormattingEnabled = true;
            this.cmbSeatTypes.Location = new System.Drawing.Point(119, 64);
            this.cmbSeatTypes.Name = "cmbSeatTypes";
            this.cmbSeatTypes.Size = new System.Drawing.Size(183, 21);
            this.cmbSeatTypes.TabIndex = 7;
            this.cmbSeatTypes.SelectedIndexChanged += new System.EventHandler(this.cmbSeatTypes_SelectedIndexChanged);
            // 
            // txtPassengerID
            // 
            this.txtPassengerID.Location = new System.Drawing.Point(461, 26);
            this.txtPassengerID.Name = "txtPassengerID";
            this.txtPassengerID.Size = new System.Drawing.Size(183, 20);
            this.txtPassengerID.TabIndex = 8;
            // 
            // cmbSeatNumber
            // 
            this.cmbSeatNumber.FormattingEnabled = true;
            this.cmbSeatNumber.Location = new System.Drawing.Point(461, 61);
            this.cmbSeatNumber.Name = "cmbSeatNumber";
            this.cmbSeatNumber.Size = new System.Drawing.Size(183, 21);
            this.cmbSeatNumber.TabIndex = 9;
            // 
            // dgvPassengers
            // 
            this.dgvPassengers.AllowUserToAddRows = false;
            this.dgvPassengers.AllowUserToDeleteRows = false;
            this.dgvPassengers.AllowUserToOrderColumns = true;
            this.dgvPassengers.AllowUserToResizeColumns = false;
            this.dgvPassengers.AllowUserToResizeRows = false;
            this.dgvPassengers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvPassengers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPassengers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPassengers.Location = new System.Drawing.Point(24, 182);
            this.dgvPassengers.Name = "dgvPassengers";
            this.dgvPassengers.Size = new System.Drawing.Size(673, 150);
            this.dgvPassengers.TabIndex = 10;
            this.dgvPassengers.SelectionChanged += new System.EventHandler(this.dgvPassengers_SelectionChanged);
            // 
            // dgvFlights
            // 
            this.dgvFlights.AllowUserToAddRows = false;
            this.dgvFlights.AllowUserToDeleteRows = false;
            this.dgvFlights.AllowUserToResizeColumns = false;
            this.dgvFlights.AllowUserToResizeRows = false;
            this.dgvFlights.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvFlights.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlights.Location = new System.Drawing.Point(24, 380);
            this.dgvFlights.Name = "dgvFlights";
            this.dgvFlights.Size = new System.Drawing.Size(673, 195);
            this.dgvFlights.TabIndex = 11;
            this.dgvFlights.SelectionChanged += new System.EventHandler(this.dgvFlights_SelectionChanged);
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(333, 135);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(73, 26);
            this.btnPay.TabIndex = 12;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Customers";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Flights";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(245, 135);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 590);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(725, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // frmBookingFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 612);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.dgvFlights);
            this.Controls.Add(this.dgvPassengers);
            this.Controls.Add(this.cmbSeatNumber);
            this.Controls.Add(this.txtPassengerID);
            this.Controls.Add(this.cmbSeatTypes);
            this.Controls.Add(this.txtFlightID);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBookingFlight";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmBookingFlight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassengers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlights)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtFlightID;
        private System.Windows.Forms.ComboBox cmbSeatTypes;
        private System.Windows.Forms.TextBox txtPassengerID;
        private System.Windows.Forms.ComboBox cmbSeatNumber;
        private System.Windows.Forms.DataGridView dgvPassengers;
        private System.Windows.Forms.DataGridView dgvFlights;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}