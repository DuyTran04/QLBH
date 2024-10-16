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

namespace QLBH
{
    public partial class fNewProduct : Form
    {
        internal Product Product { get; private set; }

        public fNewProduct()
        {
            InitializeComponent();
        }

        private void fNewProduct_Load(object sender, EventArgs e)
        {
            mQuantity.ValidatingType = typeof(UInt64);
            mPrice.ValidatingType = typeof(decimal);
            mMarketPrice.ValidatingType = typeof(decimal);

            using (var db = new EFDbContext())
            {
                cbCategories.DisplayMember = "CategoryName";
                cbCategories.ValueMember = "CategoryID";
                cbCategories.DataSource = db.Categories.OrderBy(c =>
               c.Order).Select(c => new { c.CategoryID, c.CategoryName }).ToList();
            }

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                toolTip1.Show("Hãy nhập tên sản phẩm?", txtName, 0, 0, 1000);
                txtName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cbCategories.Text))
            {
                toolTip1.Show("Hãy nhập loại sản phẩm?", cbCategories, 0, 0, 1000);
                cbCategories.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(mQuantity.Text))
            {
                toolTip1.Show("Hãy nhập số lượng?", mQuantity, 0, 0, 1000);
                mQuantity.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(mPrice.Text))
            {
                toolTip1.Show("Hãy nhập giá bán?", mPrice, 0, 0, 1000);
                mPrice.Focus();
                return;
            }

            try
            {
                Product = new Product(); //Tạo một thể hiện cho sản phẩm mới
                Product.ProductName = txtName.Text;
                Product.Quantity = Convert.ToInt32(mQuantity.Text);
                Product.Price = Convert.ToDecimal(mPrice.Text);
                Product.MarketPrice = string.IsNullOrWhiteSpace(mMarketPrice.Text) ? (decimal?)null : Convert.ToDecimal(mMarketPrice.Text);
                Product.Status = ckStatus.Checked;
                Product.Description = rDescription.Text;
                Product.CategoryID = Convert.ToInt64(cbCategories.SelectedValue);
                using (var db = new EFDbContext())
                {
                    db.Products.Add(Product); //Thêm sản phẩm vào bối cảnh
                    db.SaveChanges(); //Lưu các thay đổi vào csdl
                                      //Lưu hình vào thư mục hình và tên tập tin hình vào csdl
                    if (!string.IsNullOrWhiteSpace(txtImageFile.Text))
                    {
                        string ext =
                       txtImageFile.Text.Substring(txtImageFile.Text.LastIndexOf("."),
                       txtImageFile.Text.Length - txtImageFile.Text.LastIndexOf("."));
                        Product.ImageFile = Product.ProductID + ext;
                        pictureBox1.Image.Save(Utility.ImagePath + Product.ProductID
                       + ext);
                        db.SaveChanges(); //Lưu các thay đổi vào csdl
                    }
                }
                //Xóa trống và thiết lập lại các điều khiển
                txtName.Text = null;
                //cbCategories.Text = null;
                mQuantity.Text = null;
                mPrice.Text = null;
                mMarketPrice.Text = null;
                rDescription.Text = null;
                ckStatus.Checked = true;
                txtImageFile.Text = null;
                pictureBox1.ImageLocation = null;
                toolTip1.Show("Lưu thành công.", btSave, 0, 0, 1000);
                Close();
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btSave, 0, 0, 1000);
                MessageBox.Show("Hiển thị thông điệpngoại lệ: " + ex.InnerException?.Message);

            }
            txtName.Focus();
        }

        private void btBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All file|*.*|Bitmap File | *.bmp; *.dib | JPEG | *.jpg; *.jpe; *.jpeg; *.jfif | GIF | *.gif | TIFF | *.tif; *.tiff | PNG | *.png | ICO | *.ico";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtImageFile.Text = openFileDialog1.FileName;
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void fNewProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void txtName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                toolTip1.Show("Hãy nhập tên sản phẩm?", txtName, 0, 0, 1000);
                e.Cancel = true; //Phải nhập dữ liệu cho cột not null
            }
            else if (txtName.Text.Length > 200)
            {
                toolTip1.Show("Tên sản phẩm  <= 100 ký tự?", txtName, 0, 0, 1000);
                e.Cancel = true;
            }

        }



        private void txtImageFile_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            pictureBox1.Image = null;
            if (string.IsNullOrWhiteSpace(txtImageFile.Text))
                return; //Không cần nhập dữ liệu cho cột có thể null
            if (txtImageFile.Text.Length > 200)
            {
                toolTip1.Show("Tên tập tin - tối đa 200 ký tự?", txtImageFile, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (!File.Exists(txtImageFile.Text))
            {
                toolTip1.Show("Tên tập tin sai hoặc Tập tin không tồn tại?", txtImageFile, 0, 0, 1000);
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false; // Cho phép sự kiện tiếp tục nếu dữ liệu hợp lệ
            }
        }

        private void cbCategories_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (cbCategories.FindStringExact(cbCategories.Text) < 0) //Nếu sai tên loại
            {
                toolTip1.Show("Nhập sai loại sản phẩm?", cbCategories, 0, 0, 1000);
                e.Cancel = true; // Hủy bỏ sự kiện nếu giá trị không hợp lệ
            }
            else
            {
                e.Cancel = false; // Cho phép sự kiện tiếp tục nếu giá trị hợp lệ
            }


        }

        private void mQuantity_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput) //Nếu nhập sai kiểu
            {
                toolTip1.Show("Hãy nhập số lượng?", mQuantity, 0, 0, 1000);
                e.Cancel = true;
            }
            else if ((UInt64)e.ReturnValue < 0) //Nếu giá trị âm
            {
                toolTip1.Show("Số lượng phải >= 0?", mQuantity, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void mPrice_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                toolTip1.Show("Hãy nhập giá bán?", mPrice, 0, 0, 1000);
                e.Cancel = true;
            }
            else if ((decimal)e.ReturnValue < 0)
            {
                toolTip1.Show("Giá phải >= 0?", mPrice, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void mMarketPrice_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mMarketPrice.Text))
                return; //Không cần nhập dữ liệu cho cột có thể null
            if (!e.IsValidInput)
            {
                toolTip1.Show("Hãy nhập giá thị trường?", mMarketPrice, 0, 0, 1000);
                e.Cancel = true;
            }
            else if ((decimal)e.ReturnValue < 0)
            {
                toolTip1.Show("Giá phải >= 0?", mMarketPrice, 0, 0, 1000);
                e.Cancel = true;
            }

        }

        private void rDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rDescription.Text))
            {
                toolTip1.Show("Hãy nhập mô tả sản phẩm?", rDescription, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (rDescription.Text.Length > 1000)
            {
                toolTip1.Show("Mô tả sản phẩm không được quá 1000 ký tự?", rDescription, 0, 0, 1000);
                e.Cancel = true;
            }

        }
    }
}












       