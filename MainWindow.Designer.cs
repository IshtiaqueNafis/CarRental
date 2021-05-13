
namespace CarRental
{
    partial class MainWindow
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.manageVechineListingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addVechileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editVechileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewListingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRentalRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRentalRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewArchiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRentalRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1130, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageVechineListingToolStripMenuItem,
            this.manageRentalRecordsToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1130, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // manageVechineListingToolStripMenuItem
            // 
            this.manageVechineListingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addVechileToolStripMenuItem,
            this.editVechileToolStripMenuItem,
            this.viewListingToolStripMenuItem});
            this.manageVechineListingToolStripMenuItem.Name = "manageVechineListingToolStripMenuItem";
            this.manageVechineListingToolStripMenuItem.Size = new System.Drawing.Size(144, 20);
            this.manageVechineListingToolStripMenuItem.Text = "Manage Vechine Listing";
            // 
            // addVechileToolStripMenuItem
            // 
            this.addVechileToolStripMenuItem.Name = "addVechileToolStripMenuItem";
            this.addVechileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addVechileToolStripMenuItem.Text = "Add Vechile";
            // 
            // editVechileToolStripMenuItem
            // 
            this.editVechileToolStripMenuItem.Name = "editVechileToolStripMenuItem";
            this.editVechileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editVechileToolStripMenuItem.Text = "Edit Vechile";
            // 
            // viewListingToolStripMenuItem
            // 
            this.viewListingToolStripMenuItem.Name = "viewListingToolStripMenuItem";
            this.viewListingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewListingToolStripMenuItem.Text = "View Listing";
            // 
            // manageRentalRecordsToolStripMenuItem
            // 
            this.manageRentalRecordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRentalRecordsToolStripMenuItem,
            this.viewArchiveToolStripMenuItem,
            this.editRentalRecordToolStripMenuItem});
            this.manageRentalRecordsToolStripMenuItem.Name = "manageRentalRecordsToolStripMenuItem";
            this.manageRentalRecordsToolStripMenuItem.Size = new System.Drawing.Size(143, 20);
            this.manageRentalRecordsToolStripMenuItem.Text = "Manage Rental Records";
            // 
            // addRentalRecordsToolStripMenuItem
            // 
            this.addRentalRecordsToolStripMenuItem.Name = "addRentalRecordsToolStripMenuItem";
            this.addRentalRecordsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addRentalRecordsToolStripMenuItem.Text = "Add Rental Records";
            this.addRentalRecordsToolStripMenuItem.Click += new System.EventHandler(this.addRentalRecordsToolStripMenuItem_Click);
            // 
            // viewArchiveToolStripMenuItem
            // 
            this.viewArchiveToolStripMenuItem.Name = "viewArchiveToolStripMenuItem";
            this.viewArchiveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewArchiveToolStripMenuItem.Text = "View Archive";
            // 
            // editRentalRecordToolStripMenuItem
            // 
            this.editRentalRecordToolStripMenuItem.Name = "editRentalRecordToolStripMenuItem";
            this.editRentalRecordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editRentalRecordToolStripMenuItem.Text = "Edit Rental Record";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 571);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Main Window";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem manageVechineListingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addVechileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editVechileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewListingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageRentalRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRentalRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewArchiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRentalRecordToolStripMenuItem;
    }
}