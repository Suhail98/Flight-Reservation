namespace FlightReservationSystem
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.addAircraftButton = new System.Windows.Forms.Button();
            this.updateAircraftButton = new System.Windows.Forms.Button();
            this.addFlightButton = new System.Windows.Forms.Button();
            this.updateFlightButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 47);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Update User Details";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(187, 143);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(218, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "Search For Flights";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(187, 238);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(218, 43);
            this.button3.TabIndex = 2;
            this.button3.Text = "Manage Your Tickts";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // addAircraftButton
            // 
            this.addAircraftButton.Location = new System.Drawing.Point(28, 369);
            this.addAircraftButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addAircraftButton.Name = "addAircraftButton";
            this.addAircraftButton.Size = new System.Drawing.Size(87, 28);
            this.addAircraftButton.TabIndex = 3;
            this.addAircraftButton.Text = "Add Aircraft";
            this.addAircraftButton.UseVisualStyleBackColor = true;
            this.addAircraftButton.Visible = false;
            this.addAircraftButton.Click += new System.EventHandler(this.AddAircraftButton_Click);
            // 
            // updateAircraftButton
            // 
            this.updateAircraftButton.Location = new System.Drawing.Point(175, 369);
            this.updateAircraftButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.updateAircraftButton.Name = "updateAircraftButton";
            this.updateAircraftButton.Size = new System.Drawing.Size(117, 28);
            this.updateAircraftButton.TabIndex = 4;
            this.updateAircraftButton.Text = "Update Air Craft";
            this.updateAircraftButton.UseVisualStyleBackColor = true;
            this.updateAircraftButton.Visible = false;
            this.updateAircraftButton.Click += new System.EventHandler(this.UpdateAircraftButton_Click);
            // 
            // addFlightButton
            // 
            this.addFlightButton.Location = new System.Drawing.Point(353, 369);
            this.addFlightButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addFlightButton.Name = "addFlightButton";
            this.addFlightButton.Size = new System.Drawing.Size(87, 28);
            this.addFlightButton.TabIndex = 5;
            this.addFlightButton.Text = "Add Flight";
            this.addFlightButton.UseVisualStyleBackColor = true;
            this.addFlightButton.Visible = false;
            this.addFlightButton.Click += new System.EventHandler(this.Button6_Click);
            // 
            // updateFlightButton
            // 
            this.updateFlightButton.Location = new System.Drawing.Point(513, 369);
            this.updateFlightButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.updateFlightButton.Name = "updateFlightButton";
            this.updateFlightButton.Size = new System.Drawing.Size(87, 28);
            this.updateFlightButton.TabIndex = 6;
            this.updateFlightButton.Text = "Update flight";
            this.updateFlightButton.UseVisualStyleBackColor = true;
            this.updateFlightButton.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 457);
            this.Controls.Add(this.updateFlightButton);
            this.Controls.Add(this.addFlightButton);
            this.Controls.Add(this.updateAircraftButton);
            this.Controls.Add(this.addAircraftButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button addAircraftButton;
        private System.Windows.Forms.Button updateAircraftButton;
        private System.Windows.Forms.Button addFlightButton;
        private System.Windows.Forms.Button updateFlightButton;
    }
}