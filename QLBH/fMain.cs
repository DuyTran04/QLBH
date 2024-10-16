namespace QLBH
{
    public partial class fMain : Form
    {


        public fMain()
        {
            InitializeComponent();
        }

        private void manageCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Utility.IsOpeningForm("fManageCustomer"))
                return;
            fManageCustomer f = new fManageCustomer();
            f.MdiParent = this;
            f.Show();
        }

        private void manageProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fManageProduct"))
                return;
            fManageProduct f = new fManageProduct();
            f.MdiParent = this;
            f.Show();
        }

        private void manageOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fManageOrder"))
                return;
            fManageOrder f = new fManageOrder();
            f.MdiParent = this;
            f.Show();

        }

        private void processOrderDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fProcessOrderDetails"))
                return;
            fProcessOrderDetails f = new fProcessOrderDetails();
            f.MdiParent = this;
            f.Show();
        }

        private void manageCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("test"))
                return;
            test f = new test();
            f.MdiParent = this;
            f.Show();
        }
    }
}
