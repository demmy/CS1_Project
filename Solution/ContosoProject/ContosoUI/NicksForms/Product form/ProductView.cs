using System;
using System.Drawing;
using DevExpress.XtraBars;

namespace ContosoUI.NicksForms.Product_form
{
    public partial class ProductView : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public ProductView()
        {
            InitializeComponent();
        }

        private void ribbon_Click(object sender, EventArgs e)
        {
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            flyoutPanel1.OwnerControl = newCategorySimpleButton;
            flyoutPanel1.Options.Location = new Point(Location.X + 290, Location.Y + 144);
            flyoutPanel1.ShowPopup();
        }

        private void ProductAddView_Load(object sender, EventArgs e)
        {

        }
    }
}