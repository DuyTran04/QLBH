namespace QLBH
{
    partial class fEditProduct
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            btBrowse = new Button();
            btClose = new Button();
            btSave = new Button();
            cbCategories = new ComboBox();
            ckStatus = new CheckBox();
            mMarketPrice = new MaskedTextBox();
            mPrice = new MaskedTextBox();
            toolTip1 = new ToolTip(components);
            mQuantity = new MaskedTextBox();
            rDescription = new RichTextBox();
            txtImageFile = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(500, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btBrowse
            // 
            btBrowse.Location = new Point(428, 83);
            btBrowse.Name = "btBrowse";
            btBrowse.Size = new Size(50, 23);
            btBrowse.TabIndex = 8;
            btBrowse.Text = " …";
            btBrowse.UseVisualStyleBackColor = true;
            btBrowse.Click += btBrowse_Click;
            // 
            // btClose
            // 
            btClose.Location = new Point(606, 141);
            btClose.Name = "btClose";
            btClose.Size = new Size(78, 23);
            btClose.TabIndex = 10;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // btSave
            // 
            btSave.Location = new Point(606, 112);
            btSave.Name = "btSave";
            btSave.Size = new Size(78, 23);
            btSave.TabIndex = 9;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // cbCategories
            // 
            cbCategories.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbCategories.FormattingEnabled = true;
            cbCategories.ItemHeight = 15;
            cbCategories.Location = new Point(479, 9);
            cbCategories.Name = "cbCategories";
            cbCategories.Size = new Size(121, 23);
            cbCategories.TabIndex = 1;
            // 
            // ckStatus
            // 
            ckStatus.AutoSize = true;
            ckStatus.CheckAlign = ContentAlignment.MiddleRight;
            ckStatus.Checked = true;
            ckStatus.CheckState = CheckState.Checked;
            ckStatus.Location = new Point(606, 11);
            ckStatus.Name = "ckStatus";
            ckStatus.Size = new Size(78, 19);
            ckStatus.TabIndex = 2;
            ckStatus.Text = "Trạng thái";
            ckStatus.UseVisualStyleBackColor = true;
            // 
            // mMarketPrice
            // 
            mMarketPrice.Location = new Point(500, 45);
            mMarketPrice.Name = "mMarketPrice";
            mMarketPrice.Size = new Size(100, 23);
            mMarketPrice.TabIndex = 5;
            // 
            // mPrice
            // 
            mPrice.Location = new Point(288, 45);
            mPrice.Name = "mPrice";
            mPrice.Size = new Size(100, 23);
            mPrice.TabIndex = 4;
            // 
            // mQuantity
            // 
            mQuantity.Location = new Point(92, 45);
            mQuantity.Name = "mQuantity";
            mQuantity.Size = new Size(90, 23);
            mQuantity.TabIndex = 3;
            // 
            // rDescription
            // 
            rDescription.Location = new Point(92, 84);
            rDescription.Name = "rDescription";
            rDescription.Size = new Size(176, 111);
            rDescription.TabIndex = 6;
            rDescription.Text = "";
            // 
            // txtImageFile
            // 
            txtImageFile.Location = new Point(348, 84);
            txtImageFile.Name = "txtImageFile";
            txtImageFile.Size = new Size(74, 23);
            txtImageFile.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(274, 88);
            label7.Name = "label7";
            label7.Size = new Size(70, 15);
            label7.TabIndex = 34;
            label7.Text = "Tập tin hình";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 87);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 33;
            label6.Text = "Mô tả ngắn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(414, 48);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 31;
            label5.Text = "Giá thị trường";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(221, 48);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 28;
            label4.Text = "Giá bán";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 48);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 27;
            label3.Text = "Số lượng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(444, 12);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 24;
            label2.Text = "Loại";
            // 
            // txtName
            // 
            txtName.Location = new Point(92, 9);
            txtName.Name = "txtName";
            txtName.Size = new Size(330, 23);
            txtName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 12);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 22;
            label1.Text = "Tên Sản phẩm";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.CornflowerBlue;
            label8.ForeColor = Color.FromArgb(192, 0, 0);
            label8.Location = new Point(274, 120);
            label8.Name = "label8";
            label8.Size = new Size(136, 15);
            label8.TabIndex = 39;
            label8.Text = "Để trống tên sẽ xóa hình";
            // 
            // fEditProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 200);
            ControlBox = false;
            Controls.Add(label8);
            Controls.Add(pictureBox1);
            Controls.Add(btBrowse);
            Controls.Add(btClose);
            Controls.Add(btSave);
            Controls.Add(cbCategories);
            Controls.Add(ckStatus);
            Controls.Add(mMarketPrice);
            Controls.Add(mPrice);
            Controls.Add(mQuantity);
            Controls.Add(rDescription);
            Controls.Add(txtImageFile);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            Name = "fEditProduct";
            Text = "Sửa đổi sản phẩm";
            WindowState = FormWindowState.Maximized;
            FormClosing += fEditProduct_FormClosing;
            Load += fEditProduct_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private Button btBrowse;
        private Button btClose;
        private Button btSave;
        private ComboBox cbCategories;
        private CheckBox ckStatus;
        private MaskedTextBox mMarketPrice;
        private MaskedTextBox mPrice;
        private ToolTip toolTip1;
        private MaskedTextBox mQuantity;
        private RichTextBox rDescription;
        private TextBox txtImageFile;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtName;
        private Label label1;
        private Label label8;
    }
}