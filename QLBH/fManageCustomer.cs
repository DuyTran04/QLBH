using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using QLBH.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH
{
    public partial class fManageCustomer : Form
    {
        public fManageCustomer()
        {
            InitializeComponent();
            fManageCustomer_Activated(null, null);
        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {
                    long CustomerID = Convert.ToInt64(dataGridView2.Rows[e.RowIndex].Cells["CustomerID"].Value);
                    using (var db = new EFDbContext())
                    {
                        Customer customer = db.Customers.Single(c => c.CustomerID == CustomerID);
                        if (MessageBox.Show("Bạn muốn xóa khách hàng " + customer.CustomerName, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            db.Customers.Remove(customer);
                            db.SaveChanges();
                            fManageCustomer_Activated(sender, e);

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi, chưa xóa được? Error: " + ex.Message);
                }
            }
            if (dataGridView2.Columns[e.ColumnIndex].Name == "Edit")
            {
                if (Utility.IsOpeningForm("fEditCustomer"))
                    return;
                fEditCustomer f = new fEditCustomer(Convert.ToInt64(dataGridView2.Rows[e.RowIndex].Cells["CustomerID"].Value));
                f.MdiParent = this.MdiParent;
                f.Show();
            }
        }


        private void btNew_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fNewCustomer"))
                return;
            fNewCustomer f = new fNewCustomer();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                dataGridView2.DataSource = db.Customers
                     .Select(c => new
                     {
                         c.CustomerID,
                         c.CustomerName,
                         c.Gender,
                         c.BirthDay,
                         c.Address,
                         c.Phone,
                         c.Email,
                         c.Status
                     })
                     .Where(c => c.CustomerName.Contains(txtName.Text))
                     .ToList();
            }
        }

        private void fManageCustomer_Activated(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                dataGridView2.DataSource = db.Customers
                    .Select(c => new
                    {
                        c.CustomerID,
                        c.CustomerName,
                        c.Gender,
                        c.BirthDay,
                        c.Address,
                        c.Phone,
                        c.Email,
                        c.Status
                    })
                    .ToList();
            }
        }

        private void fManageCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}