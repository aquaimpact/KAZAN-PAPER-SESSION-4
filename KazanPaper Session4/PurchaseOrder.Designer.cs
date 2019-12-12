namespace KazanPaper_Session4
{
    partial class PurchaseOrder
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuppliersBox = new System.Windows.Forms.ComboBox();
            this.WarehouseBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddtolistBtn = new System.Windows.Forms.Button();
            this.AmtNOTxt = new System.Windows.Forms.TextBox();
            this.BatchNOTxt = new System.Windows.Forms.TextBox();
            this.PartnameBox = new System.Windows.Forms.ComboBox();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Suppliers:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Warehouse:";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Parts List";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Date:";
            // 
            // SuppliersBox
            // 
            this.SuppliersBox.FormattingEnabled = true;
            this.SuppliersBox.Location = new System.Drawing.Point(39, 44);
            this.SuppliersBox.Name = "SuppliersBox";
            this.SuppliersBox.Size = new System.Drawing.Size(262, 28);
            this.SuppliersBox.TabIndex = 7;
            // 
            // WarehouseBox
            // 
            this.WarehouseBox.FormattingEnabled = true;
            this.WarehouseBox.Location = new System.Drawing.Point(373, 44);
            this.WarehouseBox.Name = "WarehouseBox";
            this.WarehouseBox.Size = new System.Drawing.Size(278, 28);
            this.WarehouseBox.TabIndex = 8;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(89, 99);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker.TabIndex = 9;
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
            this.panel1.Location = new System.Drawing.Point(12, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 225);
            this.panel1.TabIndex = 10;
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
            this.AddtolistBtn.Click += new System.EventHandler(this.AddtolistBtn_Click);
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
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(265, 400);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(75, 33);
            this.SubmitBtn.TabIndex = 15;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(433, 400);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 33);
            this.CancelBtn.TabIndex = 16;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // PurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.WarehouseBox);
            this.Controls.Add(this.SuppliersBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "PurchaseOrder";
            this.Text = "PurchaseOrder";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox SuppliersBox;
        private System.Windows.Forms.ComboBox WarehouseBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddtolistBtn;
        private System.Windows.Forms.TextBox AmtNOTxt;
        private System.Windows.Forms.TextBox BatchNOTxt;
        private System.Windows.Forms.ComboBox PartnameBox;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}