namespace QLBH
{
    partial class fNewProduct
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
            toolTip1 = new ToolTip(components);
            label8 = new Label();
            pictureBox1 = new PictureBox();
            btBrowse = new Button();
            btClose = new Button();
            btSave = new Button();
            cbCategories = new ComboBox();
            ckStatus = new CheckBox();
            mMarketPrice = new MaskedTextBox();
            mPrice = new MaskedTextBox();
            mQuantity = new MaskedTextBox();
            rDescription = new RichTextBox();
            openFileDialog1 = new OpenFileDialog();
            txtImageFile = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.CornflowerBlue;
            label8.ForeColor = Color.FromArgb(192, 0, 0);
            label8.Location = new Point(270, 119);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 59;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(496, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 58;
            pictureBox1.TabStop = false;
            // 
            // btBrowse
            // 
            btBrowse.Location = new Point(424, 82);
            btBrowse.Name = "btBrowse";
            btBrowse.Size = new Size(50, 23);
            btBrowse.TabIndex = 8;
            btBrowse.Text = " …";
            btBrowse.UseVisualStyleBackColor = true;
            btBrowse.Click += btBrowse_Click;
            // 
            // btClose
            // 
            btClose.CausesValidation = false;
            btClose.Location = new Point(602, 140);
            btClose.Name = "btClose";
            btClose.Size = new Size(78, 23);
            btClose.TabIndex = 10;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // btSave
            // 
            btSave.Location = new Point(602, 111);
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
            cbCategories.Location = new Point(475, 8);
            cbCategories.Name = "cbCategories";
            cbCategories.Size = new Size(121, 23);
            cbCategories.TabIndex = 1;
            cbCategories.Validating += cbCategories_Validating;
            // 
            // ckStatus
            // 
            ckStatus.AutoSize = true;
            ckStatus.CheckAlign = ContentAlignment.MiddleRight;
            ckStatus.Checked = true;
            ckStatus.CheckState = CheckState.Checked;
            ckStatus.Location = new Point(602, 10);
            ckStatus.Name = "ckStatus";
            ckStatus.Size = new Size(78, 19);
            ckStatus.TabIndex = 2;
            ckStatus.Text = "Trạng thái";
            ckStatus.UseVisualStyleBackColor = true;
            // 
            // mMarketPrice
            // 
            mMarketPrice.Location = new Point(496, 44);
            mMarketPrice.Name = "mMarketPrice";
            mMarketPrice.Size = new Size(100, 23);
            mMarketPrice.TabIndex = 5;
            mMarketPrice.TypeValidationCompleted += mMarketPrice_TypeValidationCompleted;
            // 
            // mPrice
            // 
            mPrice.Location = new Point(284, 44);
            mPrice.Name = "mPrice";
            mPrice.Size = new Size(100, 23);
            mPrice.TabIndex = 4;
            mPrice.TypeValidationCompleted += mPrice_TypeValidationCompleted;
            // 
            // mQuantity
            // 
            mQuantity.Location = new Point(88, 44);
            mQuantity.Name = "mQuantity";
            mQuantity.Size = new Size(90, 23);
            mQuantity.TabIndex = 3;
            mQuantity.TypeValidationCompleted += mQuantity_TypeValidationCompleted;
            // 
            // rDescription
            // 
            rDescription.Location = new Point(88, 83);
            rDescription.Name = "rDescription";
            rDescription.Size = new Size(176, 111);
            rDescription.TabIndex = 6;
            rDescription.Text = "";
            rDescription.Validating += rDescription_Validating;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtImageFile
            // 
            txtImageFile.Location = new Point(344, 83);
            txtImageFile.Name = "txtImageFile";
            txtImageFile.Size = new Size(74, 23);
            txtImageFile.TabIndex = 7;
            txtImageFile.Validating += txtImageFile_Validating;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(270, 87);
            label7.Name = "label7";
            label7.Size = new Size(70, 15);
            label7.TabIndex = 54;
            label7.Text = "Tập tin hình";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1, 86);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 53;
            label6.Text = "Mô tả ngắn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(410, 47);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 51;
            label5.Text = "Giá thị trường";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(217, 47);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 48;
            label4.Text = "Giá bán";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1, 47);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 47;
            label3.Text = "Số lượng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(440, 11);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 44;
            label2.Text = "Loại";
            // 
            // txtName
            // 
            txtName.Location = new Point(88, 8);
            txtName.Name = "txtName";
            txtName.Size = new Size(330, 23);
            txtName.TabIndex = 0;
            txtName.Validating += txtName_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1, 11);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 42;
            label1.Text = "Tên Sản phẩm";
            // 
            // fNewProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 205);
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
            Name = "fNewProduct";
            Text = "Nhập thêm sản phẩm mới";
            WindowState = FormWindowState.Maximized;
            FormClosing += fNewProduct_FormClosing;
            Load += fNewProduct_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolTip toolTip1;
        private Label label8;
        private PictureBox pictureBox1;
        private Button btBrowse;
        private Button btClose;
        private Button btSave;
        private ComboBox cbCategories;
        private CheckBox ckStatus;
        private MaskedTextBox mMarketPrice;
        private MaskedTextBox mPrice;
        private MaskedTextBox mQuantity;
        private RichTextBox rDescription;
        private OpenFileDialog openFileDialog1;
        private TextBox txtImageFile;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtName;
        private Label label1;
    }
}