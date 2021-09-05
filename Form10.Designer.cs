namespace FlightReservationSystem
{
    partial class Form10
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
            this.SeatsBox2 = new System.Windows.Forms.TextBox();
            this.MakeBox2 = new System.Windows.Forms.TextBox();
            this.ModelBox = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.SeatsBox = new System.Windows.Forms.Label();
            this.MakeBox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SeatsBox2
            // 
            this.SeatsBox2.Location = new System.Drawing.Point(222, 233);
            this.SeatsBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SeatsBox2.Name = "SeatsBox2";
            this.SeatsBox2.Size = new System.Drawing.Size(171, 24);
            this.SeatsBox2.TabIndex = 41;
            // 
            // MakeBox2
            // 
            this.MakeBox2.Location = new System.Drawing.Point(222, 160);
            this.MakeBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MakeBox2.Name = "MakeBox2";
            this.MakeBox2.Size = new System.Drawing.Size(171, 24);
            this.MakeBox2.TabIndex = 40;
            // 
            // ModelBox
            // 
            this.ModelBox.Location = new System.Drawing.Point(222, 86);
            this.ModelBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ModelBox.Name = "ModelBox";
            this.ModelBox.Size = new System.Drawing.Size(171, 24);
            this.ModelBox.TabIndex = 39;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(202, 304);
            this.Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(87, 28);
            this.Add.TabIndex = 38;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // SeatsBox
            // 
            this.SeatsBox.AutoSize = true;
            this.SeatsBox.Location = new System.Drawing.Point(107, 240);
            this.SeatsBox.Name = "SeatsBox";
            this.SeatsBox.Size = new System.Drawing.Size(93, 17);
            this.SeatsBox.TabIndex = 37;
            this.SeatsBox.Text = "Seats number";
            // 
            // MakeBox
            // 
            this.MakeBox.AutoSize = true;
            this.MakeBox.Location = new System.Drawing.Point(107, 167);
            this.MakeBox.Name = "MakeBox";
            this.MakeBox.Size = new System.Drawing.Size(39, 17);
            this.MakeBox.TabIndex = 36;
            this.MakeBox.Text = "Make";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "Model";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 419);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SeatsBox2);
            this.Controls.Add(this.MakeBox2);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.SeatsBox);
            this.Controls.Add(this.MakeBox);
            this.Controls.Add(this.ModelBox);
            this.Name = "Form10";
            this.Text = "Form10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SeatsBox2;
        private System.Windows.Forms.TextBox MakeBox2;
        private System.Windows.Forms.TextBox ModelBox;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label SeatsBox;
        private System.Windows.Forms.Label MakeBox;
        private System.Windows.Forms.Label label1;
    }
}