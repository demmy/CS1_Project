using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace ContosoUI.NicksForms
{
    public partial class productViewList : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public productViewList()
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
    }
}