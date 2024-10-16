namespace QLBH
{
    partial class fEditOrder
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
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btClose = new Button();
            btSave = new Button();
            cbCustomers = new ComboBox();
            cbProgresses = new ComboBox();
            dtReceiveDate = new DateTimePicker();
            dtOrderDate = new DateTimePicker();
            mReceiveTime = new MaskedTextBox();
            mOrderTime = new MaskedTextBox();
            txtReceiveAddress = new TextBox();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(486, 102);
            label9.Name = "label9";
            label9.Size = new Size(62, 17);
            label9.TabIndex = 36;
            label9.Text = "Tiến trình";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(347, 105);
            label8.Name = "label8";
            label8.Size = new Size(84, 17);
            label8.TabIndex = 35;
            label8.Text = "Giờ:phút:giây";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(234, 105);
            label7.Name = "label7";
            label7.Size = new Size(107, 17);
            label7.TabIndex = 34;
            label7.Text = "Ngày/tháng/năm";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(302, 85);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 33;
            label6.Text = "ĐẶT HÀNG";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(122, 105);
            label5.Name = "label5";
            label5.Size = new Size(84, 17);
            label5.TabIndex = 32;
            label5.Text = "Giờ:phút:giây";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(9, 105);
            label4.Name = "label4";
            label4.Size = new Size(107, 17);
            label4.TabIndex = 31;
            label4.Text = "Ngày/tháng/năm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(71, 85);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 30;
            label3.Text = "NHẬN HÀNG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(283, 19);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 29;
            label2.Text = "Địa chỉ giao hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 19);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 28;
            label1.Text = "Khách hàng";
            // 
            // btClose
            // 
            btClose.Location = new Point(694, 122);
            btClose.Name = "btClose";
            btClose.Size = new Size(75, 23);
            btClose.TabIndex = 26;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // btSave
            // 
            btSave.Location = new Point(613, 122);
            btSave.Name = "btSave";
            btSave.Size = new Size(75, 23);
            btSave.TabIndex = 25;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // cbCustomers
            // 
            cbCustomers.FormattingEnabled = true;
            cbCustomers.Location = new Point(0, 37);
            cbCustomers.Name = "cbCustomers";
            cbCustomers.Size = new Size(277, 23);
            cbCustomers.TabIndex = 19;
            // 
            // cbProgresses
            // 
            cbProgresses.FormattingEnabled = true;
            cbProgresses.Location = new Point(486, 122);
            cbProgresses.Name = "cbProgresses";
            cbProgresses.Size = new Size(121, 23);
            cbProgresses.TabIndex = 27;
            // 
            // dtReceiveDate
            // 
            dtReceiveDate.CustomFormat = "dd/MM/yyyy";
            dtReceiveDate.Format = DateTimePickerFormat.Custom;
            dtReceiveDate.Location = new Point(9, 124);
            dtReceiveDate.Name = "dtReceiveDate";
            dtReceiveDate.Size = new Size(107, 23);
            dtReceiveDate.TabIndex = 21;
            // 
            // dtOrderDate
            // 
            dtOrderDate.CustomFormat = "dd/MM/yyyy";
            dtOrderDate.Format = DateTimePickerFormat.Custom;
            dtOrderDate.Location = new Point(237, 125);
            dtOrderDate.Name = "dtOrderDate";
            dtOrderDate.Size = new Size(104, 23);
            dtOrderDate.TabIndex = 23;
            // 
            // mReceiveTime
            // 
            mReceiveTime.Location = new Point(122, 124);
            mReceiveTime.Mask = "00:00:00";
            mReceiveTime.Name = "mReceiveTime";
            mReceiveTime.Size = new Size(100, 23);
            mReceiveTime.TabIndex = 22;
            // 
            // mOrderTime
            // 
            mOrderTime.Location = new Point(350, 124);
            mOrderTime.Mask = "00:00:00";
            mOrderTime.Name = "mOrderTime";
            mOrderTime.Size = new Size(99, 23);
            mOrderTime.TabIndex = 24;
            // 
            // txtReceiveAddress
            // 
            txtReceiveAddress.Location = new Point(283, 37);
            txtReceiveAddress.Name = "txtReceiveAddress";
            txtReceiveAddress.Size = new Size(505, 23);
            txtReceiveAddress.TabIndex = 20;
            // 
            // fEditOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 209);
            ControlBox = false;
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btClose);
            Controls.Add(btSave);
            Controls.Add(cbCustomers);
            Controls.Add(cbProgresses);
            Controls.Add(dtReceiveDate);
            Controls.Add(dtOrderDate);
            Controls.Add(mReceiveTime);
            Controls.Add(mOrderTime);
            Controls.Add(txtReceiveAddress);
            Name = "fEditOrder";
            Text = "Sửa đổi Đơn hàng";
            WindowState = FormWindowState.Maximized;
            FormClosing += fEditOrder_FormClosing;
            Load += fEditOrder_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btClose;
        private Button btSave;
        private ComboBox cbCustomers;
        private ComboBox cbProgresses;
        private DateTimePicker dtReceiveDate;
        private DateTimePicker dtOrderDate;
        private MaskedTextBox mReceiveTime;
        private MaskedTextBox mOrderTime;
        private TextBox txtReceiveAddress;
        private ToolTip toolTip1;
    }
}