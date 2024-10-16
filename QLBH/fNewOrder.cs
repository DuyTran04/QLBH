using QLBH.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLBH
{
    public partial class fNewOrder : Form
    {
        private Order order;

        public fNewOrder()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close(); //nhớ đặt thuộc tính CausesValidation

        }

        private void fNewOrder_Load(object sender, EventArgs e)
        {
            cbCustomers.DisplayMember = "CustomerName";
            cbCustomers.ValueMember = "CustomerID";
            using (var db = new EFDbContext())
            {
                cbCustomers.DataSource = db.Customers.Select(c => new { c.CustomerID, c.CustomerName }).ToList();
            }
            cbCustomers.Text = null;
            mOrderTime.Text = DateTime.Now.TimeOfDay.ToString();
            mReceiveTime.Text = DateTime.Now.TimeOfDay.ToString();
            mOrderTime.ValidatingType = typeof(DateTime);
            mReceiveTime.ValidatingType = typeof(DateTime);
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
                order = new Order();
                order.ReceiveAddress = txtReceiveAddress.Text;
                order.OrderDate = dtOrderDate.Value.Date;
                order.ReceiveDate = dtReceiveDate.Value.Date;
                order.OrderTime = Convert.ToDateTime(mOrderTime.Text).TimeOfDay;
                order.ReceiveTime = Convert.ToDateTime(mReceiveTime.Text).TimeOfDay;
                order.ProgressID = 1;
                //order.ProgressID = Convert.ToInt32(cbProgresses.SelectedValue);
                order.CustomerID = Convert.ToInt64(cbCustomers.SelectedValue);
                order.EmployeeID = 1; //tạm
                using (var db = new EFDbContext())
                {
                    db.Orders.Add(order);
                    db.SaveChanges();
                }
                txtReceiveAddress.Text = null;
                mReceiveTime.Text = DateTime.Now.TimeOfDay.ToString();
                mOrderTime.Text = DateTime.Now.TimeOfDay.ToString();
                //cbProgresses.Text = "1";
                cbCustomers.Text = null;
                toolTip1.Show("Lưu thành công.", btSave, 0, 0, 1000);
                Close();
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btSave, 0, 0, 1000);
            }
        }

        private void fNewOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void txtReceiveAddress_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtReceiveAddress.Text))
            {
                toolTip1.Show("Hãy nhập địa chỉ nhận hàng?", txtReceiveAddress, 0, 0, 1000);
                e.Cancel = true;
            }
            else
            if (txtReceiveAddress.Text.Length > 250)
            {
                toolTip1.Show("Địa chỉ nhận hàng - tối đa 250 ký tự?", txtReceiveAddress, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void cbCustomers_Validating(object sender, CancelEventArgs e)
        {
            if (cbCustomers.FindStringExact(cbCustomers.Text) < 0)
            {
                toolTip1.Show("Nhập sai khách hàng?", cbCustomers, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void cbProgresses_Validating(object sender, CancelEventArgs e)
        {
            //???????????????????????????????????????????????????????????
        }

        private void mReceiveTime_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                toolTip1.Show("Dữ liệu sai kiểu Time?", mReceiveTime, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void mOrderTime_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                toolTip1.Show("Dữ liệu sai kiểu Time?", mOrderTime, 0, 0, 1000);
                e.Cancel = true;
            }
        }
    }
}
