namespace Airline_Registration
{
    partial class frmMainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.flightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllFlightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddFlight = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateFlight = new System.Windows.Forms.ToolStripMenuItem();
            this.flightCarrierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFlightCarrierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editFlightCarrierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flightCrewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFlightCrewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateFlightCrewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateBookingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flightToolStripMenuItem,
            this.flightCarrierToolStripMenuItem,
            this.flightCrewToolStripMenuItem,
            this.bookingToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(649, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // flightToolStripMenuItem
            // 
            this.flightToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAllFlightToolStripMenuItem,
            this.AddFlight,
            this.UpdateFlight});
            this.flightToolStripMenuItem.Name = "flightToolStripMenuItem";
            this.flightToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.flightToolStripMenuItem.Text = "Flight";
            // 
            // showAllFlightToolStripMenuItem
            // 
            this.showAllFlightToolStripMenuItem.Name = "showAllFlightToolStripMenuItem";
            this.showAllFlightToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.showAllFlightToolStripMenuItem.Text = "Show All Flight";
            this.showAllFlightToolStripMenuItem.Click += new System.EventHandler(this.showAllFlightToolStripMenuItem_Click);
            // 
            // AddFlight
            // 
            this.AddFlight.Name = "AddFlight";
            this.AddFlight.Size = new System.Drawing.Size(156, 22);
            this.AddFlight.Text = "Add New Flight";
            this.AddFlight.Click += new System.EventHandler(this.AddFlight_Click);
            // 
            // UpdateFlight
            // 
            this.UpdateFlight.Name = "UpdateFlight";
            this.UpdateFlight.Size = new System.Drawing.Size(156, 22);
            this.UpdateFlight.Text = "Update a Flight";
            this.UpdateFlight.Click += new System.EventHandler(this.UpdateFlight_Click);
            // 
            // flightCarrierToolStripMenuItem
            // 
            this.flightCarrierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFlightCarrierToolStripMenuItem,
            this.editFlightCarrierToolStripMenuItem});
            this.flightCarrierToolStripMenuItem.Name = "flightCarrierToolStripMenuItem";
            this.flightCarrierToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.flightCarrierToolStripMenuItem.Text = "Flight Carrier";
            this.flightCarrierToolStripMenuItem.Click += new System.EventHandler(this.flightCarrierToolStripMenuItem_Click);
            // 
            // addFlightCarrierToolStripMenuItem
            // 
            this.addFlightCarrierToolStripMenuItem.Name = "addFlightCarrierToolStripMenuItem";
            this.addFlightCarrierToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.addFlightCarrierToolStripMenuItem.Text = "Add Flight Carrier";
            this.addFlightCarrierToolStripMenuItem.Click += new System.EventHandler(this.addFlightCarrierToolStripMenuItem_Click);
            // 
            // editFlightCarrierToolStripMenuItem
            // 
            this.editFlightCarrierToolStripMenuItem.Name = "editFlightCarrierToolStripMenuItem";
            this.editFlightCarrierToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.editFlightCarrierToolStripMenuItem.Text = "Update Flight Carrier";
            this.editFlightCarrierToolStripMenuItem.Click += new System.EventHandler(this.editFlightCarrierToolStripMenuItem_Click);
            // 
            // flightCrewToolStripMenuItem
            // 
            this.flightCrewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFlightCrewToolStripMenuItem,
            this.updateFlightCrewToolStripMenuItem});
            this.flightCrewToolStripMenuItem.Name = "flightCrewToolStripMenuItem";
            this.flightCrewToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.flightCrewToolStripMenuItem.Text = "Flight Crew";
            // 
            // addFlightCrewToolStripMenuItem
            // 
            this.addFlightCrewToolStripMenuItem.Name = "addFlightCrewToolStripMenuItem";
            this.addFlightCrewToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.addFlightCrewToolStripMenuItem.Text = "Add Flight Crew";
            this.addFlightCrewToolStripMenuItem.Click += new System.EventHandler(this.addFlightCrewToolStripMenuItem_Click);
            // 
            // updateFlightCrewToolStripMenuItem
            // 
            this.updateFlightCrewToolStripMenuItem.Name = "updateFlightCrewToolStripMenuItem";
            this.updateFlightCrewToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.updateFlightCrewToolStripMenuItem.Text = "Update Flight Crew";
            this.updateFlightCrewToolStripMenuItem.Click += new System.EventHandler(this.updateFlightCrewToolStripMenuItem_Click);
            // 
            // bookingToolStripMenuItem
            // 
            this.bookingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookingToolStripMenuItem1,
            this.updateBookingsToolStripMenuItem});
            this.bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            this.bookingToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.bookingToolStripMenuItem.Text = "Booking";
            // 
            // bookingToolStripMenuItem1
            // 
            this.bookingToolStripMenuItem1.Name = "bookingToolStripMenuItem1";
            this.bookingToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.bookingToolStripMenuItem1.Text = "Booking ";
            this.bookingToolStripMenuItem1.Click += new System.EventHandler(this.bookingToolStripMenuItem1_Click);
            // 
            // updateBookingsToolStripMenuItem
            // 
            this.updateBookingsToolStripMenuItem.Name = "updateBookingsToolStripMenuItem";
            this.updateBookingsToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.updateBookingsToolStripMenuItem.Text = "Unbooking Flight";
            this.updateBookingsToolStripMenuItem.Click += new System.EventHandler(this.updateBookingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 458);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMainWindow";
            this.Text = "Main Window";
            this.Load += new System.EventHandler(this.frmMainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem flightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllFlightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddFlight;
        private System.Windows.Forms.ToolStripMenuItem UpdateFlight;
        private System.Windows.Forms.ToolStripMenuItem flightCarrierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFlightCarrierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editFlightCarrierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flightCrewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFlightCrewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateFlightCrewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateBookingsToolStripMenuItem;
    }
}