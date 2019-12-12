namespace KazanPaper_Session4
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
            this.POMBtn = new System.Windows.Forms.Button();
            this.IRBtn = new System.Windows.Forms.Button();
            this.WMBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EditItemBtn = new System.Windows.Forms.Button();
            this.RmItemBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // POMBtn
            // 
            this.POMBtn.Location = new System.Drawing.Point(12, 9);
            this.POMBtn.Name = "POMBtn";
            this.POMBtn.Size = new System.Drawing.Size(223, 34);
            this.POMBtn.TabIndex = 0;
            this.POMBtn.Text = "Puchase Order Management";
            this.POMBtn.UseVisualStyleBackColor = true;
            this.POMBtn.Click += new System.EventHandler(this.POMBtn_Click);
            // 
            // IRBtn
            // 
            this.IRBtn.Location = new System.Drawing.Point(520, 10);
            this.IRBtn.Name = "IRBtn";
            this.IRBtn.Size = new System.Drawing.Size(161, 33);
            this.IRBtn.TabIndex = 1;
            this.IRBtn.Text = "Inventory Report";
            this.IRBtn.UseVisualStyleBackColor = true;
            // 
            // WMBtn
            // 
            this.WMBtn.Location = new System.Drawing.Point(269, 10);
            this.WMBtn.Name = "WMBtn";
            this.WMBtn.Size = new System.Drawing.Size(219, 33);
            this.WMBtn.TabIndex = 2;
            this.WMBtn.Text = "Warehouse Management";
            this.WMBtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 54);
            this.panel1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(776, 325);
            this.dataGridView1.TabIndex = 4;
            // 
            // EditItemBtn
            // 
            this.EditItemBtn.Location = new System.Drawing.Point(96, 403);
            this.EditItemBtn.Name = "EditItemBtn";
            this.EditItemBtn.Size = new System.Drawing.Size(126, 35);
            this.EditItemBtn.TabIndex = 5;
            this.EditItemBtn.Text = "Edit Item!";
            this.EditItemBtn.UseVisualStyleBackColor = true;
            // 
            // RmItemBtn
            // 
            this.RmItemBtn.Location = new System.Drawing.Point(414, 403);
            this.RmItemBtn.Name = "RmItemBtn";
            this.RmItemBtn.Size = new System.Drawing.Size(126, 35);
            this.RmItemBtn.TabIndex = 6;
            this.RmItemBtn.Text = "Remove Item!";
            this.RmItemBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RmItemBtn);
            this.Controls.Add(this.EditItemBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.WMBtn);
            this.Controls.Add(this.IRBtn);
            this.Controls.Add(this.POMBtn);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button POMBtn;
        private System.Windows.Forms.Button IRBtn;
        private System.Windows.Forms.Button WMBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button EditItemBtn;
        private System.Windows.Forms.Button RmItemBtn;
    }
}

