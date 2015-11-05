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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using Domain.Entities.Users;

namespace ContosoUI.RoleForm
{
    public partial class RoleView : DevExpress.XtraBars.Ribbon.RibbonForm, IRoleView
    {
        private readonly RolePresenter _presenter;
        private BindingSource binding = new BindingSource();

        public RoleView()
        {
            InitializeComponent();
            _presenter = new RolePresenter(this, new RoleModel());
        }

       private void RoleView_Load(object sender, EventArgs e)
        {
            binding.DataSource = _presenter;

            roleGridControl.DataBindings.Add("DataSource", binding, "AvalaibleRoles");

        }

        private void roleGridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

            permissionsCheckedListBox.DataBindings.Clear();
            GridView view = (GridView) sender;
            GridHitInfo info = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));

            if (e.HitInfo.InRow || e.HitInfo.InColumn)
            {
                int id = (int) view.GetRowCellValue(info.RowHandle, "Id");
                _presenter.UsePermissionWithRoleID(id);
                FillThePermissionsList();

            }
        }

        private void FillThePermissionsList()
        {
            permissionsCheckedListBox.Items.Clear();
            foreach (var permission in _presenter.CheckedPermissions)
            {
                permissionsCheckedListBox.Items.Add(permission.Key, permission.Value);
            }
        }

     
        private void barSaveButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            _presenter.Save();
        }

        private void barSaveNewButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            _presenter.SaveAndNew();
        }

        private void barAddButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            _presenter.AddNewRole();
        }

        private void permissionsCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (_presenter.Role == null) return;
            var checkedPermission = permissionsCheckedListBox.SelectedItem as Permission;
            if (checkedPermission != null)
            {
                _presenter.ChangedRolePermission(checkedPermission, e.NewValue == CheckState.Checked);
            }
        }
    }
}