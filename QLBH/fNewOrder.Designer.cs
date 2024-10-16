namespace QLBH
{
    partial class fNewOrder
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
            txtReceiveAddress = new TextBox();
            mOrderTime = new MaskedTextBox();
            mReceiveTime = new MaskedTextBox();
            dtOrderDate = new DateTimePicker();
            dtReceiveDate = new DateTimePicker();
            cbProgresses = new ComboBox();
            cbCustomers = new ComboBox();
            btSave = new Button();
            btClose = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // txtReceiveAddress
            // 
            txtReceiveAddress.Location = new Point(295, 26);
            txtReceiveAddress.Name = "txtReceiveAddress";
            txtReceiveAddress.Size = new Size(505, 23);
            txtReceiveAddress.TabIndex = 1;
            txtReceiveAddress.Validating += txtReceiveAddress_Validating;
            // 
            // mOrderTime
            // 
            mOrderTime.Location = new Point(362, 113);
            mOrderTime.Mask = "00:00:00";
            mOrderTime.Name = "mOrderTime";
            mOrderTime.Size = new Size(99, 23);
            mOrderTime.TabIndex = 5;
            mOrderTime.TypeValidationCompleted += mOrderTime_TypeValidationCompleted;
            // 
            // mReceiveTime
            // 
            mReceiveTime.Location = new Point(134, 113);
            mReceiveTime.Mask = "00:00:00";
            mReceiveTime.Name = "mReceiveTime";
            mReceiveTime.Size = new Size(100, 23);
            mReceiveTime.TabIndex = 3;
            mReceiveTime.TypeValidationCompleted += mReceiveTime_TypeValidationCompleted;
            // 
            // dtOrderDate
            // 
            dtOrderDate.CustomFormat = "dd/MM/yyyy";
            dtOrderDate.Format = DateTimePickerFormat.Custom;
            dtOrderDate.Location = new Point(249, 114);
            dtOrderDate.Name = "dtOrderDate";
            dtOrderDate.Size = new Size(104, 23);
            dtOrderDate.TabIndex = 4;
            // 
            // dtReceiveDate
            // 
            dtReceiveDate.CustomFormat = "dd/MM/yyyy";
            dtReceiveDate.Format = DateTimePickerFormat.Custom;
            dtReceiveDate.Location = new Point(21, 113);
            dtReceiveDate.Name = "dtReceiveDate";
            dtReceiveDate.Size = new Size(107, 23);
            dtReceiveDate.TabIndex = 2;
            // 
            // cbProgresses
            // 
            cbProgresses.Enabled = false;
            cbProgresses.FormattingEnabled = true;
            cbProgresses.Location = new Point(498, 111);
            cbProgresses.Name = "cbProgresses";
            cbProgresses.Size = new Size(121, 23);
            cbProgresses.TabIndex = 8;
            cbProgresses.Validating += cbProgresses_Validating;
            // 
            // cbCustomers
            // 
            cbCustomers.FormattingEnabled = true;
            cbCustomers.Location = new Point(12, 26);
            cbCustomers.Name = "cbCustomers";
            cbCustomers.Size = new Size(277, 23);
            cbCustomers.TabIndex = 0;
            cbCustomers.Validating += cbCustomers_Validating;
            // 
            // btSave
            // 
            btSave.Location = new Point(625, 111);
            btSave.Name = "btSave";
            btSave.Size = new Size(75, 23);
            btSave.TabIndex = 6;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // btClose
            // 
            btClose.CausesValidation = false;
            btClose.Location = new Point(706, 111);
            btClose.Name = "btClose";
            btClose.Size = new Size(75, 23);
            btClose.TabIndex = 7;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 10;
            label1.Text = "Khách hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(295, 8);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 11;
            label2.Text = "Địa chỉ giao hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(83, 74);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 12;
            label3.Text = "NHẬN HÀNG";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(21, 94);
            label4.Name = "label4";
            label4.Size = new Size(107, 17);
            label4.TabIndex = 13;
            label4.Text = "Ngày/tháng/năm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(134, 94);
            label5.Name = "label5";
            label5.Size = new Size(84, 17);
            label5.TabIndex = 14;
            label5.Text = "Giờ:phút:giây";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(314, 74);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 15;
            label6.Text = "ĐẶT HÀNG";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(246, 94);
            label7.Name = "label7";
            label7.Size = new Size(107, 17);
            label7.TabIndex = 16;
            label7.Text = "Ngày/tháng/năm";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(359, 94);
            label8.Name = "label8";
            label8.Size = new Size(84, 17);
            label8.TabIndex = 17;
            label8.Text = "Giờ:phút:giây";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(498, 91);
            label9.Name = "label9";
            label9.Size = new Size(62, 17);
            label9.TabIndex = 18;
            label9.Text = "Tiến trình";
            // 
            // fNewOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 215);
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
            Name = "fNewOrder";
            Text = "Nhập thêm đơn hàng mới";
            WindowState = FormWindowState.Maximized;
            FormClosing += fNewOrder_FormClosing;
            Load += fNewOrder_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtReceiveAddress;
        private MaskedTextBox mOrderTime;
        private MaskedTextBox mReceiveTime;
        private DateTimePicker dtOrderDate;
        private DateTimePicker dtReceiveDate;
        private ComboBox cbProgresses;
        private ComboBox cbCustomers;
        private Button btSave;
        private Button btClose;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ToolTip toolTip1;
    }
}