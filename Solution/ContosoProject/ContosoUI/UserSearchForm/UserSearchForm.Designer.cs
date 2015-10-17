namespace ContosoUI.UserSearchForm
{
    partial class UserSearchForm
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.LoginTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.UsersGridControl = new DevExpress.XtraGrid.GridControl();
            this.UserGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LoginColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LastNameLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.LastNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.LoginLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.SearchUserButton = new DevExpress.XtraEditors.SimpleButton();
            this.AddUserButton = new DevExpress.XtraEditors.SimpleButton();
            this.EditUserButton = new DevExpress.XtraEditors.SimpleButton();
            this.CancelUserButton = new DevExpress.XtraEditors.SimpleButton();
            this.FirstNameLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.FirstNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlLoginTextEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlUsersGrid = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlLastNameLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlLastNameTextEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlLoginLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlFirstNameLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlFirstNameTextEdit = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoginTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FirstNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlLoginTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlUsersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlLastNameLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlLastNameTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlLoginLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlFirstNameLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlFirstNameTextEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutControl1.Controls.Add(this.LoginTextEdit);
            this.layoutControl1.Controls.Add(this.UsersGridControl);
            this.layoutControl1.Controls.Add(this.LastNameLabelControl);
            this.layoutControl1.Controls.Add(this.LastNameTextEdit);
            this.layoutControl1.Controls.Add(this.LoginLabelControl);
            this.layoutControl1.Controls.Add(this.panelControl1);
            this.layoutControl1.Controls.Add(this.FirstNameLabelControl);
            this.layoutControl1.Controls.Add(this.FirstNameTextEdit);
            this.layoutControl1.Location = new System.Drawing.Point(2, -1);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1010, 730);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // LoginTextEdit
            // 
            this.LoginTextEdit.Location = new System.Drawing.Point(5, 105);
            this.LoginTextEdit.Name = "LoginTextEdit";
            this.LoginTextEdit.Size = new System.Drawing.Size(328, 20);
            this.LoginTextEdit.StyleController = this.layoutControl1;
            this.LoginTextEdit.TabIndex = 52;
            // 
            // UsersGridControl
            // 
            this.UsersGridControl.Location = new System.Drawing.Point(5, 136);
            this.UsersGridControl.MainView = this.UserGridView;
            this.UsersGridControl.Name = "UsersGridControl";
            this.UsersGridControl.Size = new System.Drawing.Size(996, 589);
            this.UsersGridControl.TabIndex = 57;
            this.UsersGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.UserGridView,
            this.gridView2});
            // 
            // UserGridView
            // 
            this.UserGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.LoginColumn,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn6,
            this.gridColumn8});
            this.UserGridView.GridControl = this.UsersGridControl;
            this.UserGridView.Name = "UserGridView";
            this.UserGridView.OptionsView.ShowGroupPanel = false;
            // 
            // LoginColumn
            // 
            this.LoginColumn.Caption = "Login";
            this.LoginColumn.FieldName = "Login";
            this.LoginColumn.Name = "LoginColumn";
            this.LoginColumn.Visible = true;
            this.LoginColumn.VisibleIndex = 0;
            this.LoginColumn.Width = 112;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Last Name";
            this.gridColumn2.FieldName = "Person.LastName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 155;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "First Name";
            this.gridColumn3.FieldName = "Person.FirstName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 162;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Middle Name";
            this.gridColumn4.FieldName = "Person.MiddleName";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 159;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Role";
            this.gridColumn6.FieldName = "Role";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            this.gridColumn6.Width = 133;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Active";
            this.gridColumn8.FieldName = "IsActive";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 5;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.UsersGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // LastNameLabelControl
            // 
            this.LastNameLabelControl.Location = new System.Drawing.Point(690, 71);
            this.LastNameLabelControl.Name = "LastNameLabelControl";
            this.LastNameLabelControl.Size = new System.Drawing.Size(296, 30);
            this.LastNameLabelControl.StyleController = this.layoutControl1;
            this.LastNameLabelControl.TabIndex = 53;
            this.LastNameLabelControl.Text = "Last Name";
            // 
            // LastNameTextEdit
            // 
            this.LastNameTextEdit.Location = new System.Drawing.Point(680, 105);
            this.LastNameTextEdit.Name = "LastNameTextEdit";
            this.LastNameTextEdit.Size = new System.Drawing.Size(321, 20);
            this.LastNameTextEdit.StyleController = this.layoutControl1;
            this.LastNameTextEdit.TabIndex = 61;
            // 
            // LoginLabelControl
            // 
            this.LoginLabelControl.Location = new System.Drawing.Point(15, 71);
            this.LoginLabelControl.Name = "LoginLabelControl";
            this.LoginLabelControl.Size = new System.Drawing.Size(293, 30);
            this.LoginLabelControl.StyleController = this.layoutControl1;
            this.LoginLabelControl.TabIndex = 62;
            this.LoginLabelControl.Text = "Login";
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.SearchUserButton);
            this.panelControl1.Controls.Add(this.AddUserButton);
            this.panelControl1.Controls.Add(this.EditUserButton);
            this.panelControl1.Controls.Add(this.CancelUserButton);
            this.panelControl1.Location = new System.Drawing.Point(2, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1002, 63);
            this.panelControl1.TabIndex = 64;
            // 
            // SearchUserButton
            // 
            this.SearchUserButton.Appearance.BackColor = System.Drawing.Color.CornflowerBlue;
            this.SearchUserButton.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.SearchUserButton.Appearance.ForeColor = System.Drawing.Color.White;
            this.SearchUserButton.Appearance.Options.UseBackColor = true;
            this.SearchUserButton.Appearance.Options.UseFont = true;
            this.SearchUserButton.Appearance.Options.UseForeColor = true;
            this.SearchUserButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.SearchUserButton.Location = new System.Drawing.Point(262, 5);
            this.SearchUserButton.Name = "SearchUserButton";
            this.SearchUserButton.Size = new System.Drawing.Size(120, 53);
            this.SearchUserButton.TabIndex = 55;
            this.SearchUserButton.Text = "Search";
            this.SearchUserButton.Click += new System.EventHandler(this.SearchUserButton_Click);
            // 
            // AddUserButton
            // 
            this.AddUserButton.Appearance.BackColor = System.Drawing.Color.CornflowerBlue;
            this.AddUserButton.Appearance.BackColor2 = System.Drawing.Color.LightSteelBlue;
            this.AddUserButton.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.AddUserButton.Appearance.ForeColor = System.Drawing.Color.White;
            this.AddUserButton.Appearance.Options.UseBackColor = true;
            this.AddUserButton.Appearance.Options.UseFont = true;
            this.AddUserButton.Appearance.Options.UseForeColor = true;
            this.AddUserButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.AddUserButton.Location = new System.Drawing.Point(10, 5);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(120, 53);
            this.AddUserButton.TabIndex = 58;
            this.AddUserButton.Text = "Add user";
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // EditUserButton
            // 
            this.EditUserButton.Appearance.BackColor = System.Drawing.Color.CornflowerBlue;
            this.EditUserButton.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.EditUserButton.Appearance.ForeColor = System.Drawing.Color.White;
            this.EditUserButton.Appearance.Options.UseBackColor = true;
            this.EditUserButton.Appearance.Options.UseFont = true;
            this.EditUserButton.Appearance.Options.UseForeColor = true;
            this.EditUserButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.EditUserButton.Location = new System.Drawing.Point(136, 5);
            this.EditUserButton.Name = "EditUserButton";
            this.EditUserButton.Size = new System.Drawing.Size(120, 53);
            this.EditUserButton.TabIndex = 59;
            this.EditUserButton.Text = "Edit user";
            // 
            // CancelUserButton
            // 
            this.CancelUserButton.Appearance.BackColor = System.Drawing.Color.CornflowerBlue;
            this.CancelUserButton.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.CancelUserButton.Appearance.ForeColor = System.Drawing.Color.White;
            this.CancelUserButton.Appearance.Options.UseBackColor = true;
            this.CancelUserButton.Appearance.Options.UseFont = true;
            this.CancelUserButton.Appearance.Options.UseForeColor = true;
            this.CancelUserButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.CancelUserButton.Location = new System.Drawing.Point(388, 5);
            this.CancelUserButton.Name = "CancelUserButton";
            this.CancelUserButton.Size = new System.Drawing.Size(120, 53);
            this.CancelUserButton.TabIndex = 60;
            this.CancelUserButton.Text = "Cancel";
            this.CancelUserButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // FirstNameLabelControl
            // 
            this.FirstNameLabelControl.Location = new System.Drawing.Point(350, 71);
            this.FirstNameLabelControl.Name = "FirstNameLabelControl";
            this.FirstNameLabelControl.Size = new System.Drawing.Size(293, 30);
            this.FirstNameLabelControl.StyleController = this.layoutControl1;
            this.FirstNameLabelControl.TabIndex = 62;
            this.FirstNameLabelControl.Text = "First Name";
            // 
            // FirstNameTextEdit
            // 
            this.FirstNameTextEdit.Location = new System.Drawing.Point(345, 105);
            this.FirstNameTextEdit.Name = "FirstNameTextEdit";
            this.FirstNameTextEdit.Size = new System.Drawing.Size(323, 20);
            this.FirstNameTextEdit.StyleController = this.layoutControl1;
            this.FirstNameTextEdit.TabIndex = 63;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlLoginTextEdit,
            this.layoutControlUsersGrid,
            this.layoutControlLastNameLabel,
            this.layoutControlLastNameTextEdit,
            this.layoutControlLoginLabel,
            this.layoutControlItem1,
            this.layoutControlFirstNameLabel,
            this.layoutControlFirstNameTextEdit});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 4, 2, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(1010, 730);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlLoginTextEdit
            // 
            this.layoutControlLoginTextEdit.Control = this.LoginTextEdit;
            this.layoutControlLoginTextEdit.CustomizationFormText = "layoutControlFirstNameTextEdit";
            this.layoutControlLoginTextEdit.Location = new System.Drawing.Point(0, 101);
            this.layoutControlLoginTextEdit.MinSize = new System.Drawing.Size(57, 24);
            this.layoutControlLoginTextEdit.Name = "layoutControlLoginTextEdit";
            this.layoutControlLoginTextEdit.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 2, 2, 2);
            this.layoutControlLoginTextEdit.Size = new System.Drawing.Size(335, 28);
            this.layoutControlLoginTextEdit.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlLoginTextEdit.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlLoginTextEdit.TextVisible = false;
            // 
            // layoutControlUsersGrid
            // 
            this.layoutControlUsersGrid.Control = this.UsersGridControl;
            this.layoutControlUsersGrid.CustomizationFormText = "layoutControlClientsGrid";
            this.layoutControlUsersGrid.Location = new System.Drawing.Point(0, 129);
            this.layoutControlUsersGrid.MinSize = new System.Drawing.Size(190, 70);
            this.layoutControlUsersGrid.Name = "layoutControlUsersGrid";
            this.layoutControlUsersGrid.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlUsersGrid.Size = new System.Drawing.Size(1006, 599);
            this.layoutControlUsersGrid.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlUsersGrid.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlUsersGrid.TextVisible = false;
            // 
            // layoutControlLastNameLabel
            // 
            this.layoutControlLastNameLabel.Control = this.LastNameLabelControl;
            this.layoutControlLastNameLabel.CustomizationFormText = "layoutControlCityLabel";
            this.layoutControlLastNameLabel.Location = new System.Drawing.Point(670, 67);
            this.layoutControlLastNameLabel.MinSize = new System.Drawing.Size(54, 17);
            this.layoutControlLastNameLabel.Name = "layoutControlLastNameLabel";
            this.layoutControlLastNameLabel.Padding = new DevExpress.XtraLayout.Utils.Padding(20, 20, 2, 2);
            this.layoutControlLastNameLabel.Size = new System.Drawing.Size(336, 34);
            this.layoutControlLastNameLabel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlLastNameLabel.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlLastNameLabel.TextVisible = false;
            // 
            // layoutControlLastNameTextEdit
            // 
            this.layoutControlLastNameTextEdit.Control = this.LastNameTextEdit;
            this.layoutControlLastNameTextEdit.CustomizationFormText = "layoutControlCityTextEdit";
            this.layoutControlLastNameTextEdit.Location = new System.Drawing.Point(670, 101);
            this.layoutControlLastNameTextEdit.MinSize = new System.Drawing.Size(62, 24);
            this.layoutControlLastNameTextEdit.Name = "layoutControlLastNameTextEdit";
            this.layoutControlLastNameTextEdit.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 5, 2, 2);
            this.layoutControlLastNameTextEdit.Size = new System.Drawing.Size(336, 28);
            this.layoutControlLastNameTextEdit.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlLastNameTextEdit.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlLastNameTextEdit.TextVisible = false;
            // 
            // layoutControlLoginLabel
            // 
            this.layoutControlLoginLabel.Control = this.LoginLabelControl;
            this.layoutControlLoginLabel.CustomizationFormText = "layoutControlFirstNameLabel";
            this.layoutControlLoginLabel.Location = new System.Drawing.Point(0, 67);
            this.layoutControlLoginLabel.MinSize = new System.Drawing.Size(81, 17);
            this.layoutControlLoginLabel.Name = "layoutControlLoginLabel";
            this.layoutControlLoginLabel.Padding = new DevExpress.XtraLayout.Utils.Padding(15, 27, 2, 2);
            this.layoutControlLoginLabel.Size = new System.Drawing.Size(335, 34);
            this.layoutControlLoginLabel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlLoginLabel.Text = "layoutControlLastNameLabel";
            this.layoutControlLoginLabel.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlLoginLabel.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.panelControl1;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1006, 67);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlFirstNameLabel
            // 
            this.layoutControlFirstNameLabel.Control = this.FirstNameLabelControl;
            this.layoutControlFirstNameLabel.CustomizationFormText = "layoutControlLastNameLabel";
            this.layoutControlFirstNameLabel.Location = new System.Drawing.Point(335, 67);
            this.layoutControlFirstNameLabel.MinSize = new System.Drawing.Size(148, 17);
            this.layoutControlFirstNameLabel.Name = "layoutControlFirstNameLabel";
            this.layoutControlFirstNameLabel.Padding = new DevExpress.XtraLayout.Utils.Padding(15, 27, 2, 2);
            this.layoutControlFirstNameLabel.Size = new System.Drawing.Size(335, 34);
            this.layoutControlFirstNameLabel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlFirstNameLabel.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlFirstNameLabel.TextVisible = false;
            // 
            // layoutControlFirstNameTextEdit
            // 
            this.layoutControlFirstNameTextEdit.Control = this.FirstNameTextEdit;
            this.layoutControlFirstNameTextEdit.CustomizationFormText = "layoutControlLastNameTextEdit";
            this.layoutControlFirstNameTextEdit.Location = new System.Drawing.Point(335, 101);
            this.layoutControlFirstNameTextEdit.MinSize = new System.Drawing.Size(57, 24);
            this.layoutControlFirstNameTextEdit.Name = "layoutControlFirstNameTextEdit";
            this.layoutControlFirstNameTextEdit.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 2, 2, 2);
            this.layoutControlFirstNameTextEdit.Size = new System.Drawing.Size(335, 28);
            this.layoutControlFirstNameTextEdit.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlFirstNameTextEdit.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlFirstNameTextEdit.TextVisible = false;
            // 
            // UserSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.layoutControl1);
            this.Name = "UserSearchForm";
            this.Text = "User Search Form";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LoginTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FirstNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlLoginTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlUsersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlLastNameLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlLastNameTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlLoginLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlFirstNameLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlFirstNameTextEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit LoginTextEdit;
        private DevExpress.XtraGrid.GridControl UsersGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView UserGridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn LoginColumn;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.LabelControl LastNameLabelControl;
        private DevExpress.XtraEditors.TextEdit LastNameTextEdit;
        private DevExpress.XtraEditors.LabelControl LoginLabelControl;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton SearchUserButton;
        private DevExpress.XtraEditors.SimpleButton AddUserButton;
        private DevExpress.XtraEditors.SimpleButton EditUserButton;
        private DevExpress.XtraEditors.SimpleButton CancelUserButton;
        private DevExpress.XtraEditors.LabelControl FirstNameLabelControl;
        private DevExpress.XtraEditors.TextEdit FirstNameTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlLoginTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlUsersGrid;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlLastNameLabel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlLastNameTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlLoginLabel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlFirstNameLabel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlFirstNameTextEdit;


    }
}