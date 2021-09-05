namespace FlightReservationSystem
{
    partial class Form12
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
            this.DateBox = new System.Windows.Forms.TextBox();
            this.destonationBox = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.SeatsBox = new System.Windows.Forms.Label();
            this.MakeBox = new System.Windows.Forms.Label();
            this.SourceBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 56;
            this.label1.Text = "From";
            // 
            // DateBox
            // 
            this.DateBox.Location = new System.Drawing.Point(184, 182);
            this.DateBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(118, 24);
            this.DateBox.TabIndex = 55;
            this.DateBox.TextChanged += new System.EventHandler(this.SeatsBox2_TextChanged);
            // 
            // destonationBox
            // 
            this.destonationBox.Location = new System.Drawing.Point(308, 102);
            this.destonationBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.destonationBox.Name = "destonationBox";
            this.destonationBox.Size = new System.Drawing.Size(159, 24);
            this.destonationBox.TabIndex = 54;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(191, 305);
            this.Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(87, 28);
            this.Add.TabIndex = 52;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // SeatsBox
            // 
            this.SeatsBox.AutoSize = true;
            this.SeatsBox.Location = new System.Drawing.Point(134, 189);
            this.SeatsBox.Name = "SeatsBox";
            this.SeatsBox.Size = new System.Drawing.Size(37, 17);
            this.SeatsBox.TabIndex = 51;
            this.SeatsBox.Text = "Date";
            // 
            // MakeBox
            // 
            this.MakeBox.AutoSize = true;
            this.MakeBox.Location = new System.Drawing.Point(278, 109);
            this.MakeBox.Name = "MakeBox";
            this.MakeBox.Size = new System.Drawing.Size(24, 17);
            this.MakeBox.TabIndex = 50;
            this.MakeBox.Text = "To";
            this.MakeBox.Click += new System.EventHandler(this.MakeBox_Click);
            // 
            // SourceBox
            // 
            this.SourceBox.Location = new System.Drawing.Point(72, 102);
            this.SourceBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SourceBox.Name = "SourceBox";
            this.SourceBox.Size = new System.Drawing.Size(140, 24);
            this.SourceBox.TabIndex = 53;
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.destonationBox);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.SeatsBox);
            this.Controls.Add(this.MakeBox);
            this.Controls.Add(this.SourceBox);
            this.Name = "Form12";
            this.Text = "Form12";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DateBox;
        private System.Windows.Forms.TextBox destonationBox;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label SeatsBox;
        private System.Windows.Forms.Label MakeBox;
        private System.Windows.Forms.TextBox SourceBox;
    }
}