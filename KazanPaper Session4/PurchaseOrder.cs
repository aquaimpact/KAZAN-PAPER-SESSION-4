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
    public partial class PurchaseOrder : Form
    {
        Session4Entities db = new Session4Entities();
        private string AddOrEdit;
        private List<OrderItem> ordersItem = new List<OrderItem>();
        private Order orderq, editOrder;

        public PurchaseOrder(string AddOrEdt, Order orders = null)
        {
            InitializeComponent();
            AddOrEdit = AddOrEdt;
            editOrder = orders;
            var suppliers = db.Suppliers.ToList();
            foreach (var item in suppliers)
            {
                SuppliersBox.Items.Add(item.Name);
            }
            SuppliersBox.SelectedIndex = 0;

            var warehouses = db.Warehouses.ToList();
            foreach (var item in warehouses)
            {
                WarehouseBox.Items.Add(item.Name);
            }
            WarehouseBox.SelectedIndex = 0;

            dateTimePicker.Value = DateTime.Now;

            var partnames = db.Parts.ToList();
            foreach (var item in partnames)
            {
                PartnameBox.Items.Add(item.Name);
            }

            //Creating a new Order
            Order order = new Order();
            order.TransactionTypeID = 1;
            order.SupplierID = 1;
            order.SourceWarehouseID = 1;
            order.DestinationWarehouseID = 1;
            order.Date = DateTime.Now;
            orderq = order;

            if (AddOrEdit == "e")
            {
                WarehouseBox.SelectedIndex = (int)editOrder.SourceWarehouseID - 1;
                SuppliersBox.SelectedIndex = (int)editOrder.SupplierID - 1;
                dateTimePicker.Value = editOrder.Date;
                var query2 = db.OrderItems.Where(x => x.OrderID == editOrder.ID).ToList();
                dataGridView1.DataSource = CDBT(query2);
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
                var query = db.Parts.Where(x => x.ID == item.PartID).FirstOrDefault();
                dataRow["Part Name"] = query.Name;
                dataRow["Batch Number"] = item.BatchNumber;
                dataRow["Amount"] = item.Amount;
                //dataRow["Action"]
                table.Rows.Add(dataRow);
            }
            return table;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddtolistBtn_Click(object sender, EventArgs e)
        {
            OrderItem orderItem = new OrderItem();
            if (BatchNOTxt.Text == "")
            {
                orderItem.BatchNumber = null;
            }
            else
            {
                orderItem.BatchNumber = BatchNOTxt.Text.Trim();
            }
            try
            {
                orderItem.Amount = decimal.Parse(AmtNOTxt.Text.Trim());
            }
            catch
            {
                MessageBox.Show("Invalid Amount!");
            }
            string partname = PartnameBox.Text.Trim();
            var query5 = db.Parts.Where(x => x.Name == partname).FirstOrDefault();
            orderItem.PartID = query5.ID;
            if(AddOrEdit == "a")
            {
                ordersItem.Add(orderItem);
                dataGridView1.DataSource = CDBT(ordersItem);
            }
            else if(AddOrEdit == "e")
            {
                orderItem.OrderID = editOrder.ID;
                OrderItem order1 = db.OrderItems.Add(orderItem);
                try
                {
                    db.SaveChanges();
                }
                catch(Exception es)
                {
                    MessageBox.Show(es.ToString());
                }
                var query2 = db.OrderItems.Where(x => x.OrderID == editOrder.ID).ToList();
                dataGridView1.DataSource = CDBT(query2);
            }
            
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            Order order = null;
            if (AddOrEdit == "a")
            {
                order = orderq;

            }
            else if (AddOrEdit == "e")
            {
                order = db.Orders.Where(x => x.ID == editOrder.ID).FirstOrDefault();
            }

            var val = SuppliersBox.Text;
            var query = db.Suppliers.Where(x => x.Name == val).FirstOrDefault();
            order.SupplierID = query.ID;

            var val2 = WarehouseBox.Text;
            var query2 = db.Warehouses.Where(x => x.Name == val2).FirstOrDefault();
            order.SourceWarehouseID = query2.ID;

            var val3 = dateTimePicker.Value;
            order.Date = val3;

            Order ordersss = db.Orders.Add(order);
            try
            {
                db.SaveChanges();

                if(AddOrEdit == "a")
                {
                    var id = ordersss.ID;
                    var query3 = db.Orders.Where(x => x.ID == id).FirstOrDefault();
                    foreach (var item in ordersItem)
                    {
                        item.OrderID = query3.ID;
                        OrderItem ordersssss = db.OrderItems.Add(item);
                    }

                    db.SaveChanges();
                }

                this.Hide();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.ToString());
            }
        }
    }
}
