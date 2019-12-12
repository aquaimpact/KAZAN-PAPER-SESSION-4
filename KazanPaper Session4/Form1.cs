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
    public partial class Form1 : Form
    {
        Session4Entities db = new Session4Entities();
        public Form1()
        {
            InitializeComponent();
            var query4 = db.OrderItems.ToList();
            dataGridView1.DataSource = CDBT(query4);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        DataTable CDBT(List<OrderItem> orderItem)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Part Name");
            table.Columns.Add("Transaction Type");
            table.Columns.Add("Date");
            table.Columns.Add("Amount");
            table.Columns.Add("Source");
            table.Columns.Add("Destination");
            table.Columns.Add("Actions");

            foreach(var item in orderItem)
            {
                DataRow dataRow = table.NewRow();
                var query = db.Orders.Where(x => x.ID == item.OrderID).FirstOrDefault();
                dataRow["Part Name"] = item.Part.Name;
                dataRow["Transaction Type"] = query.TransactionType.Name;
                dataRow["Date"] = query.Date;
                dataRow["Amount"] = item.Amount;
                var query2 = db.Warehouses.Where(x => x.ID == query.SourceWarehouseID).FirstOrDefault();
                dataRow["Source"] = query2.Name;

                var query3 = db.Warehouses.Where(x => x.ID == query.DestinationWarehouseID).FirstOrDefault();
                dataRow["Destination"] = query3.Name;

                //TODO: ADD ACTION BTNS
                //dataRow["Actions"] =
                table.Rows.Add(dataRow);
            }
            return table;
        }

        private void POMBtn_Click(object sender, EventArgs e)
        {
            //just create a new add template for the object.
            

            Order order = new Order();
            order.TransactionTypeID = 1;
            order.SupplierID = 1;
            order.SourceWarehouseID = 1;
            order.DestinationWarehouseID = 1;
            order.Date = DateTime.Now;

            db.Orders.Add(order);
            try
            {
                db.SaveChanges();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.ToString());
            }
            var query = db.Orders.OrderByDescending(x => x.ID).FirstOrDefault();
            PurchaseOrder purchaseOrder = new PurchaseOrder("a", query);
            purchaseOrder.ShowDialog();
        }
    }
}
