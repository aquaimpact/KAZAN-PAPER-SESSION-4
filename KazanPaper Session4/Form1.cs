﻿using System;
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
            dataGridView1.Columns["ID"].Visible = false;
            links();
        }

        private void links()
        {
            DataGridViewLinkColumn links = new DataGridViewLinkColumn();

            links.UseColumnTextForLinkValue = true;
            links.HeaderText = "Actions";
            links.Text = "Add";

            dataGridView1.Columns.Add(links);
        }

        DataTable CDBT(List<OrderItem> orderItem)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("Part Name");
            table.Columns.Add("Transaction Type");
            table.Columns.Add("Date");
            table.Columns.Add("Amount");
            table.Columns.Add("Source");
            table.Columns.Add("Destination");

            foreach (var item in orderItem)
            {
                DataRow dataRow = table.NewRow();
                var query = db.Orders.Where(x => x.ID == item.OrderID).FirstOrDefault();
                dataRow["ID"] = item.OrderID;
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
            PurchaseOrder purchaseOrder = new PurchaseOrder("a");
            purchaseOrder.ShowDialog();
        }

        private void EditItemBtn_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 1)
            {
                foreach(DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    var order = long.Parse(row.Cells["ID"].Value.ToString());
                    var query = db.Orders.Where(x => x.ID == order).FirstOrDefault();
                    PurchaseOrder purchaseOrder = new PurchaseOrder("e", query);
                    purchaseOrder.ShowDialog();
                }
                
            }
            else
            {
                MessageBox.Show("Invalid Selection!");
            }
            
        }

        private void RmItemBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    var order = long.Parse(row.Cells["ID"].Value.ToString());
                    var query = db.Orders.Where(x => x.ID == order).FirstOrDefault();
                    var query2 = db.OrderItems.Where(x => x.OrderID == order);
                    foreach (var item in query2)
                    {
                        db.OrderItems.Remove(item);
                    }
                    db.Orders.Remove(query);
                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Successfully Deleted!");
                        var query4 = db.OrderItems.ToList();
                        dataGridView1.DataSource = CDBT(query4);
                        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dataGridView1.Columns["ID"].Visible = false;
                    }
                    catch (Exception es)
                    {
                        MessageBox.Show(es.ToString());
                    }
                    
                }

            }
            else
            {
                MessageBox.Show("Invalid Selection!");
            }
        }

        private void WMBtn_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.TransactionTypeID = 2;
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
            //var query = db.Orders.OrderByDescending(x => x.ID).FirstOrDefault();
            var query = db.Orders.Last();
            WarehouseManagement warehouse = new WarehouseManagement("a", query);
            warehouse.ShowDialog();
        }
    }
}
