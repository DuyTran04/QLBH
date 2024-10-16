using Microsoft.EntityFrameworkCore; //sử dụng Include
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
    public partial class fEditProduct : Form
    {
        private Product product;
        private long ProductID;
        private EFDbContext db = new EFDbContext();

        public fEditProduct(long ProductID)
        {
            InitializeComponent();
            this.ProductID = ProductID;
        }
        
        private void fEditProduct_Load(object sender, EventArgs e)
        {
            try
            {
                using (var db = new EFDbContext())
                {
                    // Lấy thông tin sản phẩm cần chỉnh sửa từ cơ sở dữ liệu
                    var product = db.Products.Include(p => p.Category).Single(p => p.ProductID == ProductID);

                    // Hiển thị thông tin sản phẩm trong các điều khiển trên form
                    txtName.Text = product.ProductName;
                    mQuantity.Text = product.Quantity.ToString();
                    mPrice.Text = product.Price.ToString();
                    mMarketPrice.Text = product.MarketPrice.ToString();
                    ckStatus.Checked = product.Status;
                    rDescription.Text = product.Description;
                    txtImageFile.Text = string.IsNullOrWhiteSpace(product.ImageFile) ? null : Utility.ImagePath + product.ImageFile;
                    pictureBox1.ImageLocation = txtImageFile.Text; // Hiển thị hình

                    // Nạp dữ liệu cho ComboBox danh mục
                    cbCategories.DisplayMember = "CategoryName";
                    cbCategories.ValueMember = "CategoryID";
                    cbCategories.DataSource = db.Categories.ToList();
                    cbCategories.SelectedValue = product.CategoryID; // Chọn danh mục tương ứng với sản phẩm

                    // Đặt tiêu đề cho form
                    Text = "SỬA ĐỔI SẢN PHẨM " + product.ProductID.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu sản phẩm: " + ex.Message);
            }
        }

        private void btBrowse_Click(object sender, EventArgs e)
        {
            //Nhớ xóa trống thuộc tính Filename lúc thiết kế
            //Filter có thể thiết lập lúc thiết kế
            openFileDialog1.Filter = "All file|*.*|Bitmap File | *.bmp; *.dib | JPEG | *.jpg; *.jpe; *.jpeg; *.jfif | GIF | *.gif | TIFF | *.tif; *.tiff | PNG | *.png | ICO | *.ico";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtImageFile.Text = openFileDialog1.FileName;
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new EFDbContext())
                {
                    // Load the existing product
                    var product = db.Products.SingleOrDefault(p => p.ProductID == ProductID);
                    if (product == null)
                    {
                        MessageBox.Show("Product not found.");
                        return;
                    }

                    // Update the product properties
                    product.ProductName = txtName.Text;
                    product.Quantity = Convert.ToInt32(mQuantity.Text);
                    product.Price = Convert.ToDecimal(mPrice.Text);
                    product.MarketPrice = string.IsNullOrWhiteSpace(mMarketPrice.Text) ? (decimal?)null : Convert.ToDecimal(mMarketPrice.Text);
                    product.Status = ckStatus.Checked;
                    product.Description = rDescription.Text;
                    product.CategoryID = Convert.ToInt64(cbCategories.SelectedValue);

                    // Save the image file if it has been changed
                    if (!string.IsNullOrWhiteSpace(txtImageFile.Text) && txtImageFile.Text != Utility.ImagePath + product.ImageFile)
                    {
                        string ext = System.IO.Path.GetExtension(txtImageFile.Text);
                        product.ImageFile = product.ProductID + ext;
                        pictureBox1.Image.Save(Utility.ImagePath + product.ImageFile);
                    }

                    db.SaveChanges(); // Save changes to the database

                    // Notify the user of the success
                    toolTip1.Show("Lưu thành công.", btSave, 0, 0, 1000);
                    Close();
                }

                // Optionally, clear or reset the form fields
                txtName.Text = null;
                mQuantity.Text = null;
                mPrice.Text = null;
                mMarketPrice.Text = null;
                rDescription.Text = null;
                ckStatus.Checked = true;
                txtImageFile.Text = null;
                pictureBox1.ImageLocation = null;

            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btSave, 0, 0, 1000);
            }

            txtName.Focus();
        }


        private void fEditProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
