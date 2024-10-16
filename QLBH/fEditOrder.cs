using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore; //sử dụng Include
using QLBH.Models;

namespace QLBH
{
    public partial class fEditOrder : Form
    {
        private Order order;
        private long OrderID;
        private EFDbContext db = new EFDbContext();
        public fEditOrder(long OrderID)
        {
            InitializeComponent();
            this.OrderID = OrderID;
        }
        private void fEditOrder_Load(object sender, EventArgs e)
        {
            order = db.Orders.Include(o => o.Customer).Single(o => o.OrderID == OrderID);
            Text = "SỬA ĐƠN HÀNG " + order.OrderID.ToString();
            txtReceiveAddress.Text = order.ReceiveAddress;
            dtOrderDate.Text = order.OrderDate.ToShortDateString();
            dtReceiveDate.Text = order.ReceiveDate.ToString();
            mOrderTime.Text = order.OrderTime.ToString();
            mReceiveTime.Text = order.ReceiveTime.ToString();
            cbProgresses.DisplayMember = "ProgressName";
            cbProgresses.ValueMember = "ProgressID";
            cbProgresses.DataSource = db.Progresses.ToList();
            cbProgresses.Text = order.ProgressID.ToString();
            cbCustomers.DisplayMember = "CustomerName";
            cbCustomers.ValueMember = "CustomerID";
            cbCustomers.DataSource = db.Customers.Select(c => new { c.CustomerID, c.CustomerName }).ToList();
            cbCustomers.Text = order.Customer.CustomerName;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fEditOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void btSave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtReceiveAddress.Text))
            {
                toolTip1.Show("Hãy nhập địa chỉ nhận hàng?", txtReceiveAddress, 0, 0, 1000);
                txtReceiveAddress.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(mOrderTime.Text))
            {
                toolTip1.Show("Hãy nhập giờ:phút:giây đặt hàng?", mOrderTime, 0, 0, 1000);
                mOrderTime.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(mReceiveTime.Text))
            {
                toolTip1.Show("Hãy nhập giờ:phút:giây nhận hàng?", mReceiveTime, 0, 0, 1000);
                mReceiveTime.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cbCustomers.Text))
            {
                toolTip1.Show("Hãy nhập khách hàng?", cbCustomers, 0, 0, 1000);
                cbCustomers.Focus();
                return;
            }
            if (Convert.ToDateTime(dtOrderDate.Value.ToShortDateString() + " " +
                Convert.ToDateTime(mOrderTime.Text).TimeOfDay) >
                Convert.ToDateTime(dtReceiveDate.Value.ToShortDateString() + " " +
                Convert.ToDateTime(mReceiveTime.Text).TimeOfDay))
            {
                toolTip1.Show("Thời điểm đặt hàng phải <= Thời điểm nhận hàng?",
               mReceiveTime, 0, 0, 1000);
                mOrderTime.Focus();
                return;
            }
            try
            {
                // Lấy đơn hàng hiện có
                order = db.Orders.Single(o => o.OrderID == OrderID);

                // Update the order's properties
                order.ReceiveAddress = txtReceiveAddress.Text;
                order.OrderDate = dtOrderDate.Value.Date;
                order.ReceiveDate = dtReceiveDate.Value.Date;
                order.OrderTime = Convert.ToDateTime(mOrderTime.Text).TimeOfDay;
                order.ReceiveTime = Convert.ToDateTime(mReceiveTime.Text).TimeOfDay;
                order.ProgressID = Convert.ToInt32(cbProgresses.SelectedValue);
                order.CustomerID = Convert.ToInt64(cbCustomers.SelectedValue);

                // Save changes to the database
                db.SaveChanges();

                // Display success message
                toolTip1.Show("Lưu thành công.", btSave, 0, 0, 1000);
                Close();
            }
            catch (Exception ex)
            {
                // Display error message
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btSave, 0, 0, 1000);
            }
        }
    }
}
