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
using ContosoUI.NicksForms.Client_form;

namespace ContosoUI.NicksForms
{
    public partial class ClientViewList : DevExpress.XtraBars.Ribbon.RibbonForm, IClientView
    {
        public ClientViewList()
        {
            InitializeComponent();
        }

        private void clientViewList_Load(object sender, EventArgs e)
        {

        }
    }
}