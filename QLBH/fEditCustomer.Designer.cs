namespace QLBH
{
    partial class fEditCustomer
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
            btClose = new Button();
            btSave = new Button();
            dateTimePicker1 = new DateTimePicker();
            ckStatus = new CheckBox();
            ckGender = new CheckBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            txtName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // btClose
            // 
            btClose.CausesValidation = false;
            btClose.Location = new Point(493, 132);
            btClose.Name = "btClose";
            btClose.Size = new Size(75, 23);
            btClose.TabIndex = 22;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // btSave
            // 
            btSave.Location = new Point(383, 132);
            btSave.Name = "btSave";
            btSave.Size = new Size(75, 23);
            btSave.TabIndex = 21;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(141, 126);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 19;
            dateTimePicker1.Validating += dateTimePicker1_Validating;
            // 
            // ckStatus
            // 
            ckStatus.AutoSize = true;
            ckStatus.CheckAlign = ContentAlignment.MiddleRight;
            ckStatus.Checked = true;
            ckStatus.CheckState = CheckState.Checked;
            ckStatus.Location = new Point(571, 28);
            ckStatus.Name = "ckStatus";
            ckStatus.Size = new Size(78, 19);
            ckStatus.TabIndex = 12;
            ckStatus.Text = "Trạng thái";
            ckStatus.UseVisualStyleBackColor = true;
            // 
            // ckGender
            // 
            ckGender.AutoSize = true;
            ckGender.CheckAlign = ContentAlignment.MiddleRight;
            ckGender.Checked = true;
            ckGender.CheckState = CheckState.Indeterminate;
            ckGender.Location = new Point(471, 26);
            ckGender.Name = "ckGender";
            ckGender.Size = new Size(74, 19);
            ckGender.TabIndex = 11;
            ckGender.Text = "Giới  tính";
            ckGender.ThreeState = true;
            ckGender.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(383, 91);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(271, 23);
            txtEmail.TabIndex = 17;
            txtEmail.Validating += txtEmail_Validating;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(117, 86);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(133, 23);
            txtPhone.TabIndex = 15;
            txtPhone.Validating += txtPhone_Validating;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(117, 56);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(537, 23);
            txtAddress.TabIndex = 13;
            txtAddress.Validating += txtAddress_Validating;
            // 
            // txtName
            // 
            txtName.Location = new Point(117, 26);
            txtName.Name = "txtName";
            txtName.Size = new Size(330, 23);
            txtName.TabIndex = 9;
            txtName.Validating += txtName_Validating;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 132);
            label7.Name = "label7";
            label7.Size = new Size(125, 15);
            label7.TabIndex = 20;
            label7.Text = "Ngày/tháng/năm sinh";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(341, 94);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 18;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 94);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 16;
            label5.Text = "Điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 64);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 14;
            label4.Text = "Địa chỉ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 29);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 10;
            label1.Text = "Tên khách hàng";
            // 
            // toolTip1
            // 
           
            // 
            // fEditCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 180);
            ControlBox = false;
            Controls.Add(btClose);
            Controls.Add(btSave);
            Controls.Add(dateTimePicker1);
            Controls.Add(ckStatus);
            Controls.Add(ckGender);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "fEditCustomer";
            Text = "Sửa đổi khách hàng ";
            WindowState = FormWindowState.Maximized;
            FormClosing += fEditCustomer_FormClosing;
            Load += fEditCustomer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btClose;
        private Button btSave;
        private DateTimePicker dateTimePicker1;
        private CheckBox ckStatus;
        private CheckBox ckGender;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private TextBox txtName;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label1;
        private ToolTip toolTip1;
    }
}