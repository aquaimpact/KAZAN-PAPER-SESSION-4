namespace KazanPaper_Session4
{
    partial class WarehouseManagement
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddtolistBtn = new System.Windows.Forms.Button();
            this.AmtNOTxt = new System.Windows.Forms.TextBox();
            this.BatchNOTxt = new System.Windows.Forms.TextBox();
            this.PartnameBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DestWarehouseBox = new System.Windows.Forms.ComboBox();
            this.SourceWarehouseBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(741, 150);
            this.dataGridView1.TabIndex = 14;
            // 
            // AddtolistBtn
            // 
            this.AddtolistBtn.Location = new System.Drawing.Point(637, 25);
            this.AddtolistBtn.Name = "AddtolistBtn";
            this.AddtolistBtn.Size = new System.Drawing.Size(118, 29);
            this.AddtolistBtn.TabIndex = 13;
            this.AddtolistBtn.Text = "+ Add to List";
            this.AddtolistBtn.UseVisualStyleBackColor = true;
            // 
            // AmtNOTxt
            // 
            this.AmtNOTxt.Location = new System.Drawing.Point(510, 27);
            this.AmtNOTxt.Name = "AmtNOTxt";
            this.AmtNOTxt.Size = new System.Drawing.Size(100, 26);
            this.AmtNOTxt.TabIndex = 12;
            this.AmtNOTxt.TextChanged += new System.EventHandler(this.AmtNOTxt_TextChanged);
            // 
            // BatchNOTxt
            // 
            this.BatchNOTxt.Location = new System.Drawing.Point(339, 26);
            this.BatchNOTxt.Name = "BatchNOTxt";
            this.BatchNOTxt.Size = new System.Drawing.Size(100, 26);
            this.BatchNOTxt.TabIndex = 11;
            // 
            // PartnameBox
            // 
            this.PartnameBox.FormattingEnabled = true;
            this.PartnameBox.Location = new System.Drawing.Point(99, 26);
            this.PartnameBox.Name = "PartnameBox";
            this.PartnameBox.Size = new System.Drawing.Size(121, 28);
            this.PartnameBox.TabIndex = 11;
            this.PartnameBox.SelectedIndexChanged += new System.EventHandler(this.PartnameBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Part Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Batch Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(445, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Amount:";
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(433, 395);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 33);
            this.CancelBtn.TabIndex = 26;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(265, 395);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(75, 33);
            this.SubmitBtn.TabIndex = 25;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(103, 101);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker.TabIndex = 23;
            // 
            // DestWarehouseBox
            // 
            this.DestWarehouseBox.FormattingEnabled = true;
            this.DestWarehouseBox.Location = new System.Drawing.Point(387, 46);
            this.DestWarehouseBox.Name = "DestWarehouseBox";
            this.DestWarehouseBox.Size = new System.Drawing.Size(278, 28);
            this.DestWarehouseBox.TabIndex = 22;
            // 
            // SourceWarehouseBox
            // 
            this.SourceWarehouseBox.FormattingEnabled = true;
            this.SourceWarehouseBox.Location = new System.Drawing.Point(53, 46);
            this.SourceWarehouseBox.Name = "SourceWarehouseBox";
            this.SourceWarehouseBox.Size = new System.Drawing.Size(262, 28);
            this.SourceWarehouseBox.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Parts List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Destination Warehouse:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Source Warehouse:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.AddtolistBtn);
            this.panel1.Controls.Add(this.AmtNOTxt);
            this.panel1.Controls.Add(this.BatchNOTxt);
            this.panel1.Controls.Add(this.PartnameBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 225);
            this.panel1.TabIndex = 24;
            // 
            // WarehouseManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.DestWarehouseBox);
            this.Controls.Add(this.SourceWarehouseBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "WarehouseManagement";
            this.Text = "WarehouseManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddtolistBtn;
        private System.Windows.Forms.TextBox AmtNOTxt;
        private System.Windows.Forms.TextBox BatchNOTxt;
        private System.Windows.Forms.ComboBox PartnameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox DestWarehouseBox;
        private System.Windows.Forms.ComboBox SourceWarehouseBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}