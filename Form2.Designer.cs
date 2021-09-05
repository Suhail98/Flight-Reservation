namespace FlightReservationSystem
{
    partial class Form2
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
            this.adminRdioButton = new System.Windows.Forms.RadioButton();
            this.customerRadioButton = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.FnameBox = new System.Windows.Forms.TextBox();
            this.LnameBox = new System.Windows.Forms.TextBox();
            this.mailBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First name";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // adminRdioButton
            // 
            this.adminRdioButton.AutoSize = true;
            this.adminRdioButton.Location = new System.Drawing.Point(79, 240);
            this.adminRdioButton.Name = "adminRdioButton";
            this.adminRdioButton.Size = new System.Drawing.Size(54, 17);
            this.adminRdioButton.TabIndex = 4;
            this.adminRdioButton.TabStop = true;
            this.adminRdioButton.Text = "Admin";
            this.adminRdioButton.UseVisualStyleBackColor = true;
            this.adminRdioButton.CheckedChanged += new System.EventHandler(this.AdminRdioButton_CheckedChanged);
            // 
            // customerRadioButton
            // 
            this.customerRadioButton.AutoSize = true;
            this.customerRadioButton.Location = new System.Drawing.Point(237, 240);
            this.customerRadioButton.Name = "customerRadioButton";
            this.customerRadioButton.Size = new System.Drawing.Size(69, 17);
            this.customerRadioButton.TabIndex = 5;
            this.customerRadioButton.TabStop = true;
            this.customerRadioButton.Text = "Customer";
            this.customerRadioButton.UseVisualStyleBackColor = true;
            this.customerRadioButton.CheckedChanged += new System.EventHandler(this.CustomerRadioButton_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // FnameBox
            // 
            this.FnameBox.Location = new System.Drawing.Point(175, 39);
            this.FnameBox.Name = "FnameBox";
            this.FnameBox.Size = new System.Drawing.Size(147, 20);
            this.FnameBox.TabIndex = 7;
            this.FnameBox.TextChanged += new System.EventHandler(this.FnameBox_TextChanged);
            // 
            // LnameBox
            // 
            this.LnameBox.Location = new System.Drawing.Point(175, 82);
            this.LnameBox.Name = "LnameBox";
            this.LnameBox.Size = new System.Drawing.Size(147, 20);
            this.LnameBox.TabIndex = 8;
            this.LnameBox.TextChanged += new System.EventHandler(this.LnameBox_TextChanged);
            // 
            // mailBox
            // 
            this.mailBox.Location = new System.Drawing.Point(175, 126);
            this.mailBox.Name = "mailBox";
            this.mailBox.Size = new System.Drawing.Size(147, 20);
            this.mailBox.TabIndex = 9;
            this.mailBox.TextChanged += new System.EventHandler(this.MailBox_TextChanged);
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(175, 174);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(147, 20);
            this.passwordBox.TabIndex = 10;
            this.passwordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 340);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.mailBox);
            this.Controls.Add(this.LnameBox);
            this.Controls.Add(this.FnameBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.customerRadioButton);
            this.Controls.Add(this.adminRdioButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton adminRdioButton;
        private System.Windows.Forms.RadioButton customerRadioButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox FnameBox;
        private System.Windows.Forms.TextBox LnameBox;
        private System.Windows.Forms.TextBox mailBox;
        private System.Windows.Forms.TextBox passwordBox;
    }
}