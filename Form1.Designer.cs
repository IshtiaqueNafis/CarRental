namespace CarRental
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtDateRented = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtDateReturned = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.drComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(141, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(552, 93);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car Rental System\r\n\r\n";
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Location = new System.Drawing.Point(12, 140);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(297, 22);
            this.tbCustomerName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Name\r\n";
            // 
            // dtDateRented
            // 
            this.dtDateRented.Location = new System.Drawing.Point(12, 202);
            this.dtDateRented.Name = "dtDateRented";
            this.dtDateRented.Size = new System.Drawing.Size(200, 22);
            this.dtDateRented.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date Rented\r\n";
            // 
            // dtDateReturned
            // 
            this.dtDateReturned.Location = new System.Drawing.Point(477, 202);
            this.dtDateReturned.Name = "dtDateReturned";
            this.dtDateReturned.Size = new System.Drawing.Size(200, 22);
            this.dtDateReturned.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(477, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date Returned\r\n\r\n";
            // 
            // drComboBox
            // 
            this.drComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drComboBox.FormattingEnabled = true;
            this.drComboBox.Items.AddRange(new object[] {"Honda", "Toyota ", "Lada", "Buggy "});
            this.drComboBox.Location = new System.Drawing.Point(12, 308);
            this.drComboBox.Name = "drComboBox";
            this.drComboBox.Size = new System.Drawing.Size(261, 24);
            this.drComboBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(490, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 75);
            this.button1.TabIndex = 8;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Type of Car\r\n";
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(465, 131);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(175, 22);
            this.tbCost.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(465, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cost\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.drComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtDateReturned);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtDateRented);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCustomerName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox tbCost;

       
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.ComboBox drComboBox;

        private System.Windows.Forms.DateTimePicker dtDateReturned;

        private System.Windows.Forms.DateTimePicker dtDateRented;

        private System.Windows.Forms.TextBox tbCustomerName;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Button button1;

        

        private System.Windows.Forms.Label label4;

        
        
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

     

        private System.Windows.Forms.Label label1;

        #endregion
    }
}