namespace QLBH
{
    partial class fManageOrder
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
            cbMonth = new ComboBox();
            cbYear = new ComboBox();
            btNew = new Button();
            btFind = new Button();
            dateTimePicker1 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            OrderID = new DataGridViewTextBoxColumn();
            OrderDate = new DataGridViewTextBoxColumn();
            OrderTime = new DataGridViewTextBoxColumn();
            ReceiveDate = new DataGridViewTextBoxColumn();
            ReceiveTime = new DataGridViewTextBoxColumn();
            ReceiveAddress = new DataGridViewTextBoxColumn();
            ProgressID = new DataGridViewTextBoxColumn();
            ProgressName = new DataGridViewTextBoxColumn();
            CustomerID = new DataGridViewTextBoxColumn();
            EmployeeID = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cbMonth
            // 
            cbMonth.FormattingEnabled = true;
            cbMonth.Items.AddRange(new object[] { "Tất cả", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cbMonth.Location = new Point(384, 45);
            cbMonth.Name = "cbMonth";
            cbMonth.Size = new Size(60, 23);
            cbMonth.TabIndex = 1;
            cbMonth.SelectedIndexChanged += cbMonth_SelectedIndexChanged;
            // 
            // cbYear
            // 
            cbYear.FormattingEnabled = true;
            cbYear.Location = new Point(263, 45);
            cbYear.Name = "cbYear";
            cbYear.Size = new Size(60, 23);
            cbYear.TabIndex = 0;
            cbYear.SelectedIndexChanged += cbYear_SelectedIndexChanged;
            // 
            // btNew
            // 
            btNew.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btNew.Location = new Point(12, 45);
            btNew.Name = "btNew";
            btNew.Size = new Size(79, 28);
            btNew.TabIndex = 4;
            btNew.Text = "Nhập mới";
            btNew.UseVisualStyleBackColor = true;
            btNew.Click += btNew_Click;
            // 
            // btFind
            // 
            btFind.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btFind.Location = new Point(672, 43);
            btFind.Name = "btFind";
            btFind.Size = new Size(55, 29);
            btFind.TabIndex = 3;
            btFind.Text = "Tìm";
            btFind.UseVisualStyleBackColor = true;
            btFind.Click += btFind_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(562, 45);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(104, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { OrderID, OrderDate, OrderTime, ReceiveDate, ReceiveTime, ReceiveAddress, ProgressID, ProgressName, CustomerID, EmployeeID, Edit, Delete });
            dataGridView1.Location = new Point(12, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1106, 460);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // OrderID
            // 
            OrderID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            OrderID.DataPropertyName = "OrderID";
            OrderID.HeaderText = "OrderID";
            OrderID.Name = "OrderID";
            OrderID.Width = 73;
            // 
            // OrderDate
            // 
            OrderDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            OrderDate.DataPropertyName = "OrderDate";
            OrderDate.HeaderText = "OrderDate";
            OrderDate.Name = "OrderDate";
            OrderDate.Width = 86;
            // 
            // OrderTime
            // 
            OrderTime.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            OrderTime.DataPropertyName = "OrderTime";
            OrderTime.HeaderText = "OrderTime";
            OrderTime.Name = "OrderTime";
            OrderTime.Width = 88;
            // 
            // ReceiveDate
            // 
            ReceiveDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ReceiveDate.DataPropertyName = "ReceiveDate";
            ReceiveDate.HeaderText = "ReceiveDate";
            ReceiveDate.Name = "ReceiveDate";
            ReceiveDate.Width = 96;
            // 
            // ReceiveTime
            // 
            ReceiveTime.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ReceiveTime.DataPropertyName = "ReceiveTime";
            ReceiveTime.HeaderText = "ReceiveTime";
            ReceiveTime.Name = "ReceiveTime";
            ReceiveTime.Width = 98;
            // 
            // ReceiveAddress
            // 
            ReceiveAddress.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ReceiveAddress.DataPropertyName = "ReceiveAddress";
            ReceiveAddress.HeaderText = "ReceiveAddress";
            ReceiveAddress.Name = "ReceiveAddress";
            ReceiveAddress.Width = 114;
            // 
            // ProgressID
            // 
            ProgressID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ProgressID.DataPropertyName = "ProgressID";
            ProgressID.HeaderText = "ProgressID";
            ProgressID.Name = "ProgressID";
            ProgressID.Width = 88;
            // 
            // ProgressName
            // 
            ProgressName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ProgressName.DataPropertyName = "ProgressName";
            ProgressName.HeaderText = "ProgressName";
            ProgressName.Name = "ProgressName";
            ProgressName.Width = 109;
            // 
            // CustomerID
            // 
            CustomerID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CustomerID.DataPropertyName = "CustomerID";
            CustomerID.HeaderText = "CustomerID";
            CustomerID.Name = "CustomerID";
            CustomerID.Width = 95;
            // 
            // EmployeeID
            // 
            EmployeeID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            EmployeeID.DataPropertyName = "EmployeeID";
            EmployeeID.HeaderText = "EmployeeID";
            EmployeeID.Name = "EmployeeID";
            EmployeeID.Width = 95;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.HeaderText = "Edit";
            Edit.Name = "Edit";
            Edit.Resizable = DataGridViewTriState.True;
            Edit.SortMode = DataGridViewColumnSortMode.Automatic;
            Edit.Text = "Edit";
            Edit.UseColumnTextForButtonValue = true;
            Edit.Width = 52;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "Delete";
            Delete.Name = "Delete";
            Delete.Resizable = DataGridViewTriState.True;
            Delete.SortMode = DataGridViewColumnSortMode.Automatic;
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            Delete.Width = 65;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(263, 9);
            label2.Name = "label2";
            label2.Size = new Size(179, 19);
            label2.TabIndex = 6;
            label2.Text = "QUẢN LÝ ĐƠN HÀNG";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(97, 53);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 7;
            label1.Text = "Số lượng hóa đơn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(471, 48);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 8;
            label3.Text = "Ngày đặt hàng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(224, 48);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 9;
            label4.Text = "Năm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(338, 48);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 10;
            label5.Text = "Tháng";
            // 
            // fManageOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 538);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker1);
            Controls.Add(btFind);
            Controls.Add(btNew);
            Controls.Add(cbYear);
            Controls.Add(cbMonth);
            Name = "fManageOrder";
            Text = "Quản lý Đơn hàng";
            WindowState = FormWindowState.Maximized;
            Activated += fManageOrder_Activated;
            Load += fManageOrder_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbMonth;
        private ComboBox cbYear;
        private Button btNew;
        private Button btFind;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridViewTextBoxColumn OrderID;
        private DataGridViewTextBoxColumn OrderDate;
        private DataGridViewTextBoxColumn OrderTime;
        private DataGridViewTextBoxColumn ReceiveDate;
        private DataGridViewTextBoxColumn ReceiveTime;
        private DataGridViewTextBoxColumn ReceiveAddress;
        private DataGridViewTextBoxColumn ProgressID;
        private DataGridViewTextBoxColumn ProgressName;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn EmployeeID;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}