namespace QLBH
{
    partial class fProcessOrderDetails
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
            label2 = new Label();
            label10 = new Label();
            btClose = new Button();
            btSave = new Button();
            cbCustomers = new ComboBox();
            label9 = new Label();
            cbProgresses = new ComboBox();
            label1 = new Label();
            cbOrders = new ComboBox();
            panel1 = new Panel();
            toolTip1 = new ToolTip(components);
            panel3 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dtReceiveDate = new DateTimePicker();
            mReceiveTime = new MaskedTextBox();
            dataGridView1 = new DataGridView();
            Delete = new DataGridViewButtonColumn();
            txtReceiveAddress = new TextBox();
            mOrderTime = new MaskedTextBox();
            label13 = new Label();
            panel4 = new Panel();
            label12 = new Label();
            label11 = new Label();
            btCancel = new Button();
            btAddOrderDetail = new Button();
            mPrice = new MaskedTextBox();
            mQuantity = new MaskedTextBox();
            cbProducts = new ComboBox();
            dtOrderDate = new DateTimePicker();
            panel2 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(286, 12);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 68;
            label2.Text = "Địa chỉ giao hàng";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 12);
            label10.Name = "label10";
            label10.Size = new Size(70, 15);
            label10.TabIndex = 67;
            label10.Text = "Khách hàng";
            // 
            // btClose
            // 
            btClose.CausesValidation = false;
            btClose.Location = new Point(755, 341);
            btClose.Name = "btClose";
            btClose.Size = new Size(75, 23);
            btClose.TabIndex = 7;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            // 
            // btSave
            // 
            btSave.Location = new Point(755, 299);
            btSave.Name = "btSave";
            btSave.Size = new Size(75, 23);
            btSave.TabIndex = 7;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // cbCustomers
            // 
            cbCustomers.Enabled = false;
            cbCustomers.FormattingEnabled = true;
            cbCustomers.Location = new Point(3, 30);
            cbCustomers.Name = "cbCustomers";
            cbCustomers.Size = new Size(277, 23);
            cbCustomers.TabIndex = 65;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(5, 11);
            label9.Name = "label9";
            label9.Size = new Size(62, 17);
            label9.TabIndex = 36;
            label9.Text = "Tiến trình";
            // 
            // cbProgresses
            // 
            cbProgresses.Enabled = false;
            cbProgresses.FormattingEnabled = true;
            cbProgresses.Location = new Point(5, 33);
            cbProgresses.Name = "cbProgresses";
            cbProgresses.Size = new Size(121, 23);
            cbProgresses.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(149, 15);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "Chọn đơn hàng";
            // 
            // cbOrders
            // 
            cbOrders.FormattingEnabled = true;
            cbOrders.Location = new Point(149, 33);
            cbOrders.Name = "cbOrders";
            cbOrders.Size = new Size(121, 23);
            cbOrders.TabIndex = 0;
            cbOrders.SelectionChangeCommitted += cbOrders_SelectionChangeCommitted;
            // 
            // panel1
            // 
            panel1.Controls.Add(label9);
            panel1.Controls.Add(cbProgresses);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cbOrders);
            panel1.Location = new Point(2, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(278, 86);
            panel1.TabIndex = 69;
            // 
            // panel3
            // 
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(dtReceiveDate);
            panel3.Controls.Add(mReceiveTime);
            panel3.Location = new Point(601, 77);
            panel3.Name = "panel3";
            panel3.Size = new Size(229, 86);
            panel3.TabIndex = 72;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(121, 27);
            label5.Name = "label5";
            label5.Size = new Size(84, 17);
            label5.TabIndex = 32;
            label5.Text = "Giờ:phút:giây";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(8, 27);
            label4.Name = "label4";
            label4.Size = new Size(107, 17);
            label4.TabIndex = 31;
            label4.Text = "Ngày/tháng/năm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(70, 7);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 30;
            label3.Text = "GIAO HÀNG";
            // 
            // dtReceiveDate
            // 
            dtReceiveDate.CustomFormat = "dd/MM/yyyy";
            dtReceiveDate.Enabled = false;
            dtReceiveDate.Format = DateTimePickerFormat.Custom;
            dtReceiveDate.Location = new Point(8, 46);
            dtReceiveDate.Name = "dtReceiveDate";
            dtReceiveDate.Size = new Size(107, 23);
            dtReceiveDate.TabIndex = 21;
            // 
            // mReceiveTime
            // 
            mReceiveTime.Enabled = false;
            mReceiveTime.Location = new Point(121, 46);
            mReceiveTime.Mask = "00:00:00";
            mReceiveTime.Name = "mReceiveTime";
            mReceiveTime.Size = new Size(100, 23);
            mReceiveTime.TabIndex = 22;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Delete });
            dataGridView1.Location = new Point(2, 280);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(747, 183);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            dataGridView1.CellValidating += dataGridView1_CellValidating;
            // 
            // Delete
            // 
            Delete.DataPropertyName = "Delete";
            Delete.HeaderText = "Delete";
            Delete.Name = "Delete";
            Delete.Resizable = DataGridViewTriState.True;
            Delete.SortMode = DataGridViewColumnSortMode.Automatic;
            Delete.UseColumnTextForButtonValue = true;
            // 
            // txtReceiveAddress
            // 
            txtReceiveAddress.Enabled = false;
            txtReceiveAddress.Location = new Point(286, 30);
            txtReceiveAddress.Name = "txtReceiveAddress";
            txtReceiveAddress.Size = new Size(544, 23);
            txtReceiveAddress.TabIndex = 66;
            // 
            // mOrderTime
            // 
            mOrderTime.Enabled = false;
            mOrderTime.Location = new Point(127, 46);
            mOrderTime.Mask = "00:00:00";
            mOrderTime.Name = "mOrderTime";
            mOrderTime.Size = new Size(99, 23);
            mOrderTime.TabIndex = 24;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(286, 7);
            label13.Name = "label13";
            label13.Size = new Size(48, 15);
            label13.TabIndex = 46;
            label13.Text = "Đơn giá";
            // 
            // panel4
            // 
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(btCancel);
            panel4.Controls.Add(btAddOrderDetail);
            panel4.Controls.Add(mPrice);
            panel4.Controls.Add(mQuantity);
            panel4.Controls.Add(cbProducts);
            panel4.Location = new Point(0, 183);
            panel4.Name = "panel4";
            panel4.Size = new Size(598, 76);
            panel4.TabIndex = 71;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(172, 6);
            label12.Name = "label12";
            label12.Size = new Size(54, 15);
            label12.TabIndex = 45;
            label12.Text = "Số lượng";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(7, 6);
            label11.Name = "label11";
            label11.Size = new Size(91, 15);
            label11.TabIndex = 44;
            label11.Text = "Chọn sản phẩm";
            // 
            // btCancel
            // 
            btCancel.Location = new Point(418, 25);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(75, 23);
            btCancel.TabIndex = 4;
            btCancel.Text = "Hủy";
            btCancel.UseVisualStyleBackColor = true;
            // 
            // btAddOrderDetail
            // 
            btAddOrderDetail.Location = new Point(509, 25);
            btAddOrderDetail.Name = "btAddOrderDetail";
            btAddOrderDetail.Size = new Size(75, 23);
            btAddOrderDetail.TabIndex = 5;
            btAddOrderDetail.Text = "Thêm";
            btAddOrderDetail.UseVisualStyleBackColor = true;
            btAddOrderDetail.Click += btAddOrderDetail_Click;
            // 
            // mPrice
            // 
            mPrice.Enabled = false;
            mPrice.Location = new Point(286, 25);
            mPrice.Name = "mPrice";
            mPrice.Size = new Size(117, 23);
            mPrice.TabIndex = 3;
            // 
            // mQuantity
            // 
            mQuantity.Location = new Point(172, 25);
            mQuantity.Name = "mQuantity";
            mQuantity.Size = new Size(108, 23);
            mQuantity.TabIndex = 2;
            mQuantity.TypeValidationCompleted += mQuantity_TypeValidationCompleted;
            // 
            // cbProducts
            // 
            cbProducts.FormattingEnabled = true;
            cbProducts.Location = new Point(7, 24);
            cbProducts.Name = "cbProducts";
            cbProducts.Size = new Size(153, 23);
            cbProducts.TabIndex = 1;
            cbProducts.SelectedIndexChanged += cbProducts_SelectedIndexChanged;
            cbProducts.Validating += cbProducts_Validating;
            // 
            // dtOrderDate
            // 
            dtOrderDate.CustomFormat = "dd/MM/yyyy";
            dtOrderDate.Enabled = false;
            dtOrderDate.Format = DateTimePickerFormat.Custom;
            dtOrderDate.Location = new Point(17, 47);
            dtOrderDate.Name = "dtOrderDate";
            dtOrderDate.Size = new Size(104, 23);
            dtOrderDate.TabIndex = 23;
            // 
            // panel2
            // 
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(dtOrderDate);
            panel2.Controls.Add(mOrderTime);
            panel2.Location = new Point(344, 77);
            panel2.Name = "panel2";
            panel2.Size = new Size(247, 86);
            panel2.TabIndex = 70;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(127, 27);
            label8.Name = "label8";
            label8.Size = new Size(84, 17);
            label8.TabIndex = 35;
            label8.Text = "Giờ:phút:giây";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(14, 27);
            label7.Name = "label7";
            label7.Size = new Size(107, 17);
            label7.TabIndex = 34;
            label7.Text = "Ngày/tháng/năm";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(82, 7);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 33;
            label6.Text = "ĐẶT HÀNG";
            // 
            // fProcessOrderDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 531);
            Controls.Add(label2);
            Controls.Add(label10);
            Controls.Add(btClose);
            Controls.Add(btSave);
            Controls.Add(cbCustomers);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(dataGridView1);
            Controls.Add(txtReceiveAddress);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Name = "fProcessOrderDetails";
            Text = "Xử lý chi tiết đơn hàng";
            WindowState = FormWindowState.Maximized;
            FormClosing += fProcessOrderDetails_FormClosing;
            Load += fProcessOrderDetails_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label10;
        private Button btClose;
        private Button btSave;
        private ComboBox cbCustomers;
        private Label label9;
        private ComboBox cbProgresses;
        private Label label1;
        private ComboBox cbOrders;
        private Panel panel1;
        private ToolTip toolTip1;
        private Panel panel3;
        private Label label5;
        private Label label4;
        private Label label3;
        private DateTimePicker dtReceiveDate;
        private MaskedTextBox mReceiveTime;
        private DataGridView dataGridView1;
        private DataGridViewButtonColumn Delete;
        private TextBox txtReceiveAddress;
        private MaskedTextBox mOrderTime;
        private Label label13;
        private Panel panel4;
        private Label label12;
        private Label label11;
        private Button btCancel;
        private Button btAddOrderDetail;
        private MaskedTextBox mPrice;
        private MaskedTextBox mQuantity;
        private ComboBox cbProducts;
        private DateTimePicker dtOrderDate;
        private Panel panel2;
        private Label label8;
        private Label label7;
        private Label label6;
    }
}