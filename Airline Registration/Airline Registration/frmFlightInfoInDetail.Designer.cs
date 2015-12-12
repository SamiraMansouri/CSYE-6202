namespace Airline_Registration
{
    partial class frmFlightInfoInDetail
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
            this.txtFlightNumber = new System.Windows.Forms.TextBox();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.txtArrival = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvCarrierInfo = new System.Windows.Forms.DataGridView();
            this.lblCrews = new System.Windows.Forms.Label();
            this.dgvCrews = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvPassengers = new System.Windows.Forms.DataGridView();
            this.Seats = new System.Windows.Forms.Label();
            this.dgvSeats = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrierInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassengers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeats)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flight Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destination";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(532, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Arrival";
            // 
            // txtFlightNumber
            // 
            this.txtFlightNumber.Location = new System.Drawing.Point(102, 21);
            this.txtFlightNumber.Name = "txtFlightNumber";
            this.txtFlightNumber.Size = new System.Drawing.Size(173, 20);
            this.txtFlightNumber.TabIndex = 5;
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(102, 52);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(173, 20);
            this.txtDestination.TabIndex = 6;
            // 
            // txtArrival
            // 
            this.txtArrival.Location = new System.Drawing.Point(343, 51);
            this.txtArrival.Name = "txtArrival";
            this.txtArrival.Size = new System.Drawing.Size(173, 20);
            this.txtArrival.TabIndex = 8;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(343, 20);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(173, 20);
            this.txtDate.TabIndex = 7;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(568, 17);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(144, 20);
            this.txtTime.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Flight carrier information";
            // 
            // dgvCarrierInfo
            // 
            this.dgvCarrierInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrierInfo.Location = new System.Drawing.Point(24, 127);
            this.dgvCarrierInfo.Name = "dgvCarrierInfo";
            this.dgvCarrierInfo.Size = new System.Drawing.Size(660, 67);
            this.dgvCarrierInfo.TabIndex = 11;
            // 
            // lblCrews
            // 
            this.lblCrews.AutoSize = true;
            this.lblCrews.Location = new System.Drawing.Point(24, 342);
            this.lblCrews.Name = "lblCrews";
            this.lblCrews.Size = new System.Drawing.Size(36, 13);
            this.lblCrews.TabIndex = 12;
            this.lblCrews.Text = "Crews";
            // 
            // dgvCrews
            // 
            this.dgvCrews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCrews.Location = new System.Drawing.Point(24, 358);
            this.dgvCrews.Name = "dgvCrews";
            this.dgvCrews.Size = new System.Drawing.Size(654, 122);
            this.dgvCrews.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 496);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Passengers";
            // 
            // dgvPassengers
            // 
            this.dgvPassengers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPassengers.Location = new System.Drawing.Point(24, 512);
            this.dgvPassengers.Name = "dgvPassengers";
            this.dgvPassengers.Size = new System.Drawing.Size(654, 149);
            this.dgvPassengers.TabIndex = 15;
            // 
            // Seats
            // 
            this.Seats.AutoSize = true;
            this.Seats.Location = new System.Drawing.Point(27, 216);
            this.Seats.Name = "Seats";
            this.Seats.Size = new System.Drawing.Size(61, 13);
            this.Seats.TabIndex = 16;
            this.Seats.Text = "Seat Types";
            // 
            // dgvSeats
            // 
            this.dgvSeats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeats.Location = new System.Drawing.Point(24, 232);
            this.dgvSeats.Name = "dgvSeats";
            this.dgvSeats.Size = new System.Drawing.Size(657, 76);
            this.dgvSeats.TabIndex = 17;
            // 
            // frmFlightInfoInDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 673);
            this.Controls.Add(this.dgvSeats);
            this.Controls.Add(this.Seats);
            this.Controls.Add(this.dgvPassengers);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvCrews);
            this.Controls.Add(this.lblCrews);
            this.Controls.Add(this.dgvCarrierInfo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtArrival);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.txtFlightNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFlightInfoInDetail";
            this.Text = "Detailed information about flight";
            this.Load += new System.EventHandler(this.frmFlightInfoInDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrierInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassengers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFlightNumber;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.TextBox txtArrival;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvCarrierInfo;
        private System.Windows.Forms.Label lblCrews;
        private System.Windows.Forms.DataGridView dgvCrews;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvPassengers;
        private System.Windows.Forms.Label Seats;
        private System.Windows.Forms.DataGridView dgvSeats;
    }
}