namespace ContosoUI.UserSearchForm
{
    partial class UsersListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersListView));
            this.userSearchRibbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.addUserBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.searchUserBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.clearUserBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.userSearchRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.userSearchFileRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.layoutControlUsers = new DevExpress.XtraLayout.LayoutControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.usersGridControl = new DevExpress.XtraGrid.GridControl();
            this.usersGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lastNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.firstNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.loginTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroupUsers = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlLogin = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlFirstName = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlLastName = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlUsersGrid = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.userSearchRibbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlUsers)).BeginInit();
            this.layoutControlUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlUsersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // userSearchRibbon
            // 
            this.userSearchRibbon.ExpandCollapseItem.Id = 0;
            this.userSearchRibbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.userSearchRibbon.ExpandCollapseItem,
            this.addUserBarButton,
            this.searchUserBarButton,
            this.clearUserBarButton});
            this.userSearchRibbon.Location = new System.Drawing.Point(0, 0);
            this.userSearchRibbon.MaxItemId = 5;
            this.userSearchRibbon.Name = "userSearchRibbon";
            this.userSearchRibbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.userSearchRibbonPage});
            this.userSearchRibbon.Size = new System.Drawing.Size(1014, 143);
            this.userSearchRibbon.StatusBar = this.ribbonStatusBar;
            // 
            // addUserBarButton
            // 
            this.addUserBarButton.Caption = "Add";
            this.addUserBarButton.Glyph = ((System.Drawing.Image)(resources.GetObject("addUserBarButton.Glyph")));
            this.addUserBarButton.Id = 1;
            this.addUserBarButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("addUserBarButton.LargeGlyph")));
            this.addUserBarButton.Name = "addUserBarButton";
            this.addUserBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addUserBarButton_ItemClick);
            // 
            // searchUserBarButton
            // 
            this.searchUserBarButton.Caption = "Search";
            this.searchUserBarButton.Glyph = ((System.Drawing.Image)(resources.GetObject("searchUserBarButton.Glyph")));
            this.searchUserBarButton.Id = 2;
            this.searchUserBarButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("searchUserBarButton.LargeGlyph")));
            this.searchUserBarButton.Name = "searchUserBarButton";
            this.searchUserBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.searchUserBarButton_ItemClick);
            // 
            // clearUserBarButton
            // 
            this.clearUserBarButton.Caption = "Clear";
            this.clearUserBarButton.Glyph = ((System.Drawing.Image)(resources.GetObject("clearUserBarButton.Glyph")));
            this.clearUserBarButton.Id = 3;
            this.clearUserBarButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("clearUserBarButton.LargeGlyph")));
            this.clearUserBarButton.Name = "clearUserBarButton";
            this.clearUserBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.clearUserBarButton_ItemClick);
            // 
            // userSearchRibbonPage
            // 
            this.userSearchRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.userSearchFileRibbonPageGroup});
            this.userSearchRibbonPage.Name = "userSearchRibbonPage";
            this.userSearchRibbonPage.Text = "User search";
            // 
            // userSearchFileRibbonPageGroup
            // 
            this.userSearchFileRibbonPageGroup.ItemLinks.Add(this.addUserBarButton);
            this.userSearchFileRibbonPageGroup.ItemLinks.Add(this.searchUserBarButton);
            this.userSearchFileRibbonPageGroup.ItemLinks.Add(this.clearUserBarButton);
            this.userSearchFileRibbonPageGroup.Name = "userSearchFileRibbonPageGroup";
            this.userSearchFileRibbonPageGroup.Text = "File";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 736);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.userSearchRibbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1014, 31);
            // 
            // layoutControlUsers
            // 
            this.layoutControlUsers.Controls.Add(this.simpleButton1);
            this.layoutControlUsers.Controls.Add(this.usersGridControl);
            this.layoutControlUsers.Controls.Add(this.lastNameTextEdit);
            this.layoutControlUsers.Controls.Add(this.firstNameTextEdit);
            this.layoutControlUsers.Controls.Add(this.loginTextEdit);
            this.layoutControlUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControlUsers.Location = new System.Drawing.Point(0, 143);
            this.layoutControlUsers.Name = "layoutControlUsers";
            this.layoutControlUsers.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(573, 123, 250, 350);
            this.layoutControlUsers.Root = this.layoutControlGroupUsers;
            this.layoutControlUsers.Size = new System.Drawing.Size(1014, 593);
            this.layoutControlUsers.TabIndex = 2;
            this.layoutControlUsers.Text = "layoutControl1";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(12, 559);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(990, 22);
            this.simpleButton1.StyleController = this.layoutControlUsers;
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // usersGridControl
            // 
            this.usersGridControl.Location = new System.Drawing.Point(17, 67);
            this.usersGridControl.MainView = this.usersGridView;
            this.usersGridControl.MenuManager = this.userSearchRibbon;
            this.usersGridControl.Name = "usersGridControl";
            this.usersGridControl.Size = new System.Drawing.Size(980, 483);
            this.usersGridControl.TabIndex = 7;
            this.usersGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.usersGridView});
            this.usersGridView.DoubleClick += new System.EventHandler(this.usersGridView_DoubleClick);
            // 
            // usersGridView
            // 
            this.usersGridView.GridControl = this.usersGridControl;
            this.usersGridView.Name = "usersGridView";
            this.usersGridView.OptionsBehavior.Editable = false;
            // 
            // lastNameTextEdit
            // 
            this.lastNameTextEdit.Location = new System.Drawing.Point(680, 33);
            this.lastNameTextEdit.MenuManager = this.userSearchRibbon;
            this.lastNameTextEdit.Name = "lastNameTextEdit";
            this.lastNameTextEdit.Size = new System.Drawing.Size(317, 20);
            this.lastNameTextEdit.StyleController = this.layoutControlUsers;
            this.lastNameTextEdit.TabIndex = 6;
            // 
            // firstNameTextEdit
            // 
            this.firstNameTextEdit.Location = new System.Drawing.Point(349, 33);
            this.firstNameTextEdit.MenuManager = this.userSearchRibbon;
            this.firstNameTextEdit.Name = "firstNameTextEdit";
            this.firstNameTextEdit.Size = new System.Drawing.Size(317, 20);
            this.firstNameTextEdit.StyleController = this.layoutControlUsers;
            this.firstNameTextEdit.TabIndex = 5;
            // 
            // loginTextEdit
            // 
            this.loginTextEdit.Location = new System.Drawing.Point(17, 33);
            this.loginTextEdit.Name = "loginTextEdit";
            this.loginTextEdit.Size = new System.Drawing.Size(318, 20);
            this.loginTextEdit.StyleController = this.layoutControlUsers;
            this.loginTextEdit.TabIndex = 4;
            // 
            // layoutControlGroupUsers
            // 
            this.layoutControlGroupUsers.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupUsers.GroupBordersVisible = false;
            this.layoutControlGroupUsers.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlLogin,
            this.layoutControlFirstName,
            this.layoutControlLastName,
            this.layoutControlUsersGrid,
            this.layoutControlItem1});
            this.layoutControlGroupUsers.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupUsers.Name = "layoutControlGroupUsers";
            this.layoutControlGroupUsers.Size = new System.Drawing.Size(1014, 593);
            this.layoutControlGroupUsers.TextVisible = false;
            // 
            // layoutControlLogin
            // 
            this.layoutControlLogin.Control = this.loginTextEdit;
            this.layoutControlLogin.Location = new System.Drawing.Point(0, 0);
            this.layoutControlLogin.Name = "layoutControlLogin";
            this.layoutControlLogin.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlLogin.Size = new System.Drawing.Size(332, 50);
            this.layoutControlLogin.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlLogin.Text = "City";
            this.layoutControlLogin.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlLogin.TextSize = new System.Drawing.Size(50, 13);
            // 
            // layoutControlFirstName
            // 
            this.layoutControlFirstName.Control = this.firstNameTextEdit;
            this.layoutControlFirstName.Location = new System.Drawing.Point(332, 0);
            this.layoutControlFirstName.Name = "layoutControlFirstName";
            this.layoutControlFirstName.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlFirstName.Size = new System.Drawing.Size(331, 50);
            this.layoutControlFirstName.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlFirstName.Text = "First name";
            this.layoutControlFirstName.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlFirstName.TextSize = new System.Drawing.Size(50, 13);
            // 
            // layoutControlLastName
            // 
            this.layoutControlLastName.Control = this.lastNameTextEdit;
            this.layoutControlLastName.Location = new System.Drawing.Point(663, 0);
            this.layoutControlLastName.Name = "layoutControlLastName";
            this.layoutControlLastName.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlLastName.Size = new System.Drawing.Size(331, 50);
            this.layoutControlLastName.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlLastName.Text = "Last name";
            this.layoutControlLastName.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlLastName.TextSize = new System.Drawing.Size(50, 13);
            // 
            // layoutControlUsersGrid
            // 
            this.layoutControlUsersGrid.Control = this.usersGridControl;
            this.layoutControlUsersGrid.Location = new System.Drawing.Point(0, 50);
            this.layoutControlUsersGrid.Name = "layoutControlUsersGrid";
            this.layoutControlUsersGrid.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlUsersGrid.Size = new System.Drawing.Size(994, 497);
            this.layoutControlUsersGrid.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlUsersGrid.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlUsersGrid.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.simpleButton1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 547);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(994, 26);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // UsersListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 767);
            this.Controls.Add(this.layoutControlUsers);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.userSearchRibbon);
            this.Name = "UsersListView";
            this.Ribbon = this.userSearchRibbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "User Search";
            ((System.ComponentModel.ISupportInitialize)(this.userSearchRibbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlUsers)).EndInit();
            this.layoutControlUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlUsersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl userSearchRibbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage userSearchRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup userSearchFileRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraLayout.LayoutControl layoutControlUsers;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupUsers;
        private DevExpress.XtraGrid.GridControl usersGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView usersGridView;
        private DevExpress.XtraEditors.TextEdit lastNameTextEdit;
        private DevExpress.XtraEditors.TextEdit firstNameTextEdit;
        private DevExpress.XtraEditors.TextEdit loginTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlLogin;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlFirstName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlLastName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlUsersGrid;
        private DevExpress.XtraBars.BarButtonItem addUserBarButton;
        private DevExpress.XtraBars.BarButtonItem searchUserBarButton;
        private DevExpress.XtraBars.BarButtonItem clearUserBarButton;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}