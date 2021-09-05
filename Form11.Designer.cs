namespace FlightReservationSystem
{
    partial class Form11
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
            this.components = new System.ComponentModel.Container();
            this.NewSeatsBox = new System.Windows.Forms.TextBox();
            this.NewMakeBox = new System.Windows.Forms.TextBox();
            this.NewModelBox = new System.Windows.Forms.TextBox();
            this.Ubdate = new System.Windows.Forms.Button();
            this.SeatsBox = new System.Windows.Forms.Label();
            this.MakeBox = new System.Windows.Forms.Label();
            this.ModelBox = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flightSystemDataSet = new FlightReservationSystem.FlightSystemDataSet();
            this.aIRCRAFTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aIRCRAFTTableAdapter = new FlightReservationSystem.FlightSystemDataSetTableAdapters.AIRCRAFTTableAdapter();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAKEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOSEATSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.previousModelBox = new System.Windows.Forms.TextBox();
            this.previousMakeBox = new System.Windows.Forms.TextBox();
            this.previousSeatsBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRCRAFTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // NewSeatsBox
            // 
            this.NewSeatsBox.Location = new System.Drawing.Point(469, 368);
            this.NewSeatsBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewSeatsBox.Name = "NewSeatsBox";
            this.NewSeatsBox.Size = new System.Drawing.Size(147, 24);
            this.NewSeatsBox.TabIndex = 34;
            this.NewSeatsBox.TextChanged += new System.EventHandler(this.NewSeatsBox_TextChanged);
            // 
            // NewMakeBox
            // 
            this.NewMakeBox.Location = new System.Drawing.Point(469, 330);
            this.NewMakeBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewMakeBox.Name = "NewMakeBox";
            this.NewMakeBox.Size = new System.Drawing.Size(147, 24);
            this.NewMakeBox.TabIndex = 33;
            this.NewMakeBox.TextChanged += new System.EventHandler(this.NewMakeBox_TextChanged);
            // 
            // NewModelBox
            // 
            this.NewModelBox.Location = new System.Drawing.Point(469, 284);
            this.NewModelBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewModelBox.Name = "NewModelBox";
            this.NewModelBox.Size = new System.Drawing.Size(147, 24);
            this.NewModelBox.TabIndex = 32;
            this.NewModelBox.TextChanged += new System.EventHandler(this.NewModelBox_TextChanged);
            // 
            // Ubdate
            // 
            this.Ubdate.Location = new System.Drawing.Point(263, 412);
            this.Ubdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Ubdate.Name = "Ubdate";
            this.Ubdate.Size = new System.Drawing.Size(87, 28);
            this.Ubdate.TabIndex = 31;
            this.Ubdate.Text = "Ubdate";
            this.Ubdate.UseVisualStyleBackColor = true;
            this.Ubdate.Click += new System.EventHandler(this.Ubdate_Click);
            // 
            // SeatsBox
            // 
            this.SeatsBox.AutoSize = true;
            this.SeatsBox.Location = new System.Drawing.Point(321, 371);
            this.SeatsBox.Name = "SeatsBox";
            this.SeatsBox.Size = new System.Drawing.Size(124, 17);
            this.SeatsBox.TabIndex = 30;
            this.SeatsBox.Text = "New Seats Number";
            this.SeatsBox.Click += new System.EventHandler(this.SeatsBox_Click);
            // 
            // MakeBox
            // 
            this.MakeBox.AutoSize = true;
            this.MakeBox.Location = new System.Drawing.Point(321, 333);
            this.MakeBox.Name = "MakeBox";
            this.MakeBox.Size = new System.Drawing.Size(69, 17);
            this.MakeBox.TabIndex = 29;
            this.MakeBox.Text = "New Make";
            this.MakeBox.Click += new System.EventHandler(this.MakeBox_Click);
            // 
            // ModelBox
            // 
            this.ModelBox.AutoSize = true;
            this.ModelBox.Location = new System.Drawing.Point(321, 291);
            this.ModelBox.Name = "ModelBox";
            this.ModelBox.Size = new System.Drawing.Size(73, 17);
            this.ModelBox.TabIndex = 28;
            this.ModelBox.Text = "New Model";
            this.ModelBox.Click += new System.EventHandler(this.ModelBox_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Model,
            this.mAKEDataGridViewTextBoxColumn,
            this.nOSEATSDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aIRCRAFTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(103, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(433, 242);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // flightSystemDataSet
            // 
            this.flightSystemDataSet.DataSetName = "FlightSystemDataSet";
            this.flightSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aIRCRAFTBindingSource
            // 
            this.aIRCRAFTBindingSource.DataMember = "AIRCRAFT";
            this.aIRCRAFTBindingSource.DataSource = this.flightSystemDataSet;
            // 
            // aIRCRAFTTableAdapter
            // 
            this.aIRCRAFTTableAdapter.ClearBeforeFill = true;
            // 
            // Model
            // 
            this.Model.DataPropertyName = "MODEL";
            this.Model.HeaderText = "MODEL";
            this.Model.MinimumWidth = 6;
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            this.Model.Width = 125;
            // 
            // mAKEDataGridViewTextBoxColumn
            // 
            this.mAKEDataGridViewTextBoxColumn.DataPropertyName = "MAKE";
            this.mAKEDataGridViewTextBoxColumn.HeaderText = "MAKE";
            this.mAKEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mAKEDataGridViewTextBoxColumn.Name = "mAKEDataGridViewTextBoxColumn";
            this.mAKEDataGridViewTextBoxColumn.ReadOnly = true;
            this.mAKEDataGridViewTextBoxColumn.Width = 125;
            // 
            // nOSEATSDataGridViewTextBoxColumn
            // 
            this.nOSEATSDataGridViewTextBoxColumn.DataPropertyName = "NO_SEATS";
            this.nOSEATSDataGridViewTextBoxColumn.HeaderText = "NO_SEATS";
            this.nOSEATSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nOSEATSDataGridViewTextBoxColumn.Name = "nOSEATSDataGridViewTextBoxColumn";
            this.nOSEATSDataGridViewTextBoxColumn.ReadOnly = true;
            this.nOSEATSDataGridViewTextBoxColumn.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Model";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Make";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Seats Number";
            // 
            // previousModelBox
            // 
            this.previousModelBox.Location = new System.Drawing.Point(103, 284);
            this.previousModelBox.Name = "previousModelBox";
            this.previousModelBox.Size = new System.Drawing.Size(140, 24);
            this.previousModelBox.TabIndex = 39;
            // 
            // previousMakeBox
            // 
            this.previousMakeBox.Location = new System.Drawing.Point(103, 326);
            this.previousMakeBox.Name = "previousMakeBox";
            this.previousMakeBox.Size = new System.Drawing.Size(140, 24);
            this.previousMakeBox.TabIndex = 40;
            // 
            // previousSeatsBox
            // 
            this.previousSeatsBox.Location = new System.Drawing.Point(103, 371);
            this.previousSeatsBox.Name = "previousSeatsBox";
            this.previousSeatsBox.Size = new System.Drawing.Size(140, 24);
            this.previousSeatsBox.TabIndex = 41;
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 462);
            this.Controls.Add(this.previousSeatsBox);
            this.Controls.Add(this.previousMakeBox);
            this.Controls.Add(this.previousModelBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.NewSeatsBox);
            this.Controls.Add(this.NewMakeBox);
            this.Controls.Add(this.NewModelBox);
            this.Controls.Add(this.Ubdate);
            this.Controls.Add(this.SeatsBox);
            this.Controls.Add(this.MakeBox);
            this.Controls.Add(this.ModelBox);
            this.Name = "Form11";
            this.Text = "Form11";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRCRAFTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NewSeatsBox;
        private System.Windows.Forms.TextBox NewMakeBox;
        private System.Windows.Forms.TextBox NewModelBox;
        private System.Windows.Forms.Button Ubdate;
        private System.Windows.Forms.Label SeatsBox;
        private System.Windows.Forms.Label MakeBox;
        private System.Windows.Forms.Label ModelBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FlightSystemDataSet flightSystemDataSet;
        private System.Windows.Forms.BindingSource aIRCRAFTBindingSource;
        private FlightSystemDataSetTableAdapters.AIRCRAFTTableAdapter aIRCRAFTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAKEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOSEATSDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox previousModelBox;
        private System.Windows.Forms.TextBox previousMakeBox;
        private System.Windows.Forms.TextBox previousSeatsBox;
    }
}