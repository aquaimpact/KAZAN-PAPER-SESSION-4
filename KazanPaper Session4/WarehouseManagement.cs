using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KazanPaper_Session4
{
    public partial class WarehouseManagement : Form
    {
        Session4Entities db = new Session4Entities();
        private string AddOrEdit;
        private Order orderq;

        public WarehouseManagement(string AddOrEdt, Order order)
        {
            InitializeComponent();
            orderq = order;
            AddOrEdit = AddOrEdt;

            var query = db.Warehouses.ToList();
            foreach(var item in query)
            {
                SourceWarehouseBox.Items.Add(item.Name);
                DestWarehouseBox.Items.Add(item.Name);
            }
            SourceWarehouseBox.SelectedIndex = 0;
            DestWarehouseBox.SelectedIndex = 0;

            dateTimePicker.Value = DateTime.Now;

            var query2 = db.Parts.ToList();
            foreach(var item in query2)
            {
                PartnameBox.Items.Add(item.Name);
            }


        }

        DataTable CDBT(List<OrderItem> parts)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Part Name");
            table.Columns.Add("Batch Number");
            table.Columns.Add("Amount");
            table.Columns.Add("Action");

            foreach (var item in parts)
            {
                DataRow dataRow = table.NewRow();
                dataRow["Part Name"] = item.Part.Name;
                dataRow["Batch Number"] = item.BatchNumber;
                dataRow["Amount"] = item.Amount;
                //dataRow["Action"]
                table.Rows.Add(dataRow);
            }
            return table;
        }

        private void AmtNOTxt_TextChanged(object sender, EventArgs e)
        {
            if (AmtNOTxt.TextLength > 1)
            {
                try
                {
                    double value = double.Parse(AmtNOTxt.Text);
                    if (value < 0)
                    {
                        MessageBox.Show("Amount cannot be a negative number!");
                    }
                }
                catch
                {
                    MessageBox.Show("Amount cannot contain words!");
                }
            }
        }

        private void PartnameBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var value = PartnameBox.Text;
            var query = db.Parts.Where(x => x.Name == value).FirstOrDefault();
            bool BNR = bool.Parse(query.BatchNumberHasRequired.ToString());
            if (BNR == false)
            {
                BatchNOTxt.Visible = false;
                BatchNOTxt.Text = "";
            }
            else
            {
                BatchNOTxt.Visible = true;
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (AddOrEdit == "a")
            {
                var query = db.Orders.Where(x => x.ID == orderq.ID).FirstOrDefault();
                db.Orders.Remove(query);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception es)
                {
                    MessageBox.Show(es.ToString());
                }
            }
        }
    }
}
