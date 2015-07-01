namespace ContosoUI.OrderSearchForm
{
    partial class OrderListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderListView));
            this.ribbonOrderView = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.addOrderBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.searchOrderBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.clearButton = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageOrderSearch = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.OrderViewFileRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBarOrderView = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.layoutControlOrderView = new DevExpress.XtraLayout.LayoutControl();
            this.orderItemsGridControl = new DevExpress.XtraGrid.GridControl();
            this.orderItemsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.statusComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.orderNumberTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroupOrderView = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlOrderNumberTextEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlStatusComboBoxEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlOrderItemsGridControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.clientLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlClientLookUpEdit = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonOrderView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlOrderView)).BeginInit();
            this.layoutControlOrderView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderNumberTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupOrderView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlOrderNumberTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlStatusComboBoxEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlOrderItemsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlClientLookUpEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonOrderView
            // 
            this.ribbonOrderView.ExpandCollapseItem.Id = 0;
            this.ribbonOrderView.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonOrderView.ExpandCollapseItem,
            this.addOrderBarButton,
            this.searchOrderBarButton,
            this.clearButton});
            this.ribbonOrderView.Location = new System.Drawing.Point(0, 0);
            this.ribbonOrderView.MaxItemId = 4;
            this.ribbonOrderView.Name = "ribbonOrderView";
            this.ribbonOrderView.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageOrderSearch});
            this.ribbonOrderView.Size = new System.Drawing.Size(1014, 143);
            this.ribbonOrderView.StatusBar = this.ribbonStatusBarOrderView;
            // 
            // addOrderBarButton
            // 
            this.addOrderBarButton.Caption = "Add";
            this.addOrderBarButton.Glyph = ((System.Drawing.Image)(resources.GetObject("addOrderBarButton.Glyph")));
            this.addOrderBarButton.Id = 1;
            this.addOrderBarButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("addOrderBarButton.LargeGlyph")));
            this.addOrderBarButton.Name = "addOrderBarButton";
            // 
            // searchOrderBarButton
            // 
            this.searchOrderBarButton.Caption = "Search";
            this.searchOrderBarButton.Glyph = ((System.Drawing.Image)(resources.GetObject("searchOrderBarButton.Glyph")));
            this.searchOrderBarButton.Id = 2;
            this.searchOrderBarButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("searchOrderBarButton.LargeGlyph")));
            this.searchOrderBarButton.Name = "searchOrderBarButton";
            // 
            // clearButton
            // 
            this.clearButton.Caption = "Clear";
            this.clearButton.Glyph = ((System.Drawing.Image)(resources.GetObject("clearButton.Glyph")));
            this.clearButton.Id = 3;
            this.clearButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("clearButton.LargeGlyph")));
            this.clearButton.Name = "clearButton";
            // 
            // ribbonPageOrderSearch
            // 
            this.ribbonPageOrderSearch.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.OrderViewFileRibbonPageGroup});
            this.ribbonPageOrderSearch.Name = "ribbonPageOrderSearch";
            this.ribbonPageOrderSearch.Text = "Order search";
            // 
            // OrderViewFileRibbonPageGroup
            // 
            this.OrderViewFileRibbonPageGroup.ItemLinks.Add(this.addOrderBarButton);
            this.OrderViewFileRibbonPageGroup.ItemLinks.Add(this.searchOrderBarButton);
            this.OrderViewFileRibbonPageGroup.ItemLinks.Add(this.clearButton);
            this.OrderViewFileRibbonPageGroup.Name = "OrderViewFileRibbonPageGroup";
            this.OrderViewFileRibbonPageGroup.Text = "File";
            // 
            // ribbonStatusBarOrderView
            // 
            this.ribbonStatusBarOrderView.Location = new System.Drawing.Point(0, 736);
            this.ribbonStatusBarOrderView.Name = "ribbonStatusBarOrderView";
            this.ribbonStatusBarOrderView.Ribbon = this.ribbonOrderView;
            this.ribbonStatusBarOrderView.Size = new System.Drawing.Size(1014, 31);
            // 
            // layoutControlOrderView
            // 
            this.layoutControlOrderView.Controls.Add(this.clientLookUpEdit);
            this.layoutControlOrderView.Controls.Add(this.orderItemsGridControl);
            this.layoutControlOrderView.Controls.Add(this.statusComboBoxEdit);
            this.layoutControlOrderView.Controls.Add(this.orderNumberTextEdit);
            this.layoutControlOrderView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControlOrderView.Location = new System.Drawing.Point(0, 143);
            this.layoutControlOrderView.Name = "layoutControlOrderView";
            this.layoutControlOrderView.Root = this.layoutControlGroupOrderView;
            this.layoutControlOrderView.Size = new System.Drawing.Size(1014, 593);
            this.layoutControlOrderView.TabIndex = 2;
            this.layoutControlOrderView.Text = "layoutControl1";
            // 
            // orderItemsGridControl
            // 
            this.orderItemsGridControl.Location = new System.Drawing.Point(17, 83);
            this.orderItemsGridControl.MainView = this.orderItemsGridView;
            this.orderItemsGridControl.MenuManager = this.ribbonOrderView;
            this.orderItemsGridControl.Name = "orderItemsGridControl";
            this.orderItemsGridControl.Size = new System.Drawing.Size(980, 493);
            this.orderItemsGridControl.TabIndex = 6;
            this.orderItemsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.orderItemsGridView});
            // 
            // orderItemsGridView
            // 
            this.orderItemsGridView.GridControl = this.orderItemsGridControl;
            this.orderItemsGridView.Name = "orderItemsGridView";
            // 
            // statusComboBoxEdit
            // 
            this.statusComboBoxEdit.Location = new System.Drawing.Point(354, 33);
            this.statusComboBoxEdit.MenuManager = this.ribbonOrderView;
            this.statusComboBoxEdit.Name = "statusComboBoxEdit";
            this.statusComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.statusComboBoxEdit.Size = new System.Drawing.Size(327, 20);
            this.statusComboBoxEdit.StyleController = this.layoutControlOrderView;
            this.statusComboBoxEdit.TabIndex = 5;
            // 
            // orderNumberTextEdit
            // 
            this.orderNumberTextEdit.Location = new System.Drawing.Point(17, 33);
            this.orderNumberTextEdit.MenuManager = this.ribbonOrderView;
            this.orderNumberTextEdit.Name = "orderNumberTextEdit";
            this.orderNumberTextEdit.Size = new System.Drawing.Size(323, 20);
            this.orderNumberTextEdit.StyleController = this.layoutControlOrderView;
            this.orderNumberTextEdit.TabIndex = 4;
            // 
            // layoutControlGroupOrderView
            // 
            this.layoutControlGroupOrderView.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupOrderView.GroupBordersVisible = false;
            this.layoutControlGroupOrderView.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlOrderNumberTextEdit,
            this.layoutControlOrderItemsGridControl,
            this.layoutControlStatusComboBoxEdit,
            this.layoutControlClientLookUpEdit});
            this.layoutControlGroupOrderView.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupOrderView.Name = "layoutControlGroupOrderView";
            this.layoutControlGroupOrderView.Size = new System.Drawing.Size(1014, 593);
            this.layoutControlGroupOrderView.TextVisible = false;
            // 
            // layoutControlOrderNumberTextEdit
            // 
            this.layoutControlOrderNumberTextEdit.Control = this.orderNumberTextEdit;
            this.layoutControlOrderNumberTextEdit.Location = new System.Drawing.Point(0, 0);
            this.layoutControlOrderNumberTextEdit.Name = "layoutControlOrderNumberTextEdit";
            this.layoutControlOrderNumberTextEdit.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlOrderNumberTextEdit.Size = new System.Drawing.Size(337, 50);
            this.layoutControlOrderNumberTextEdit.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlOrderNumberTextEdit.Text = "Order number";
            this.layoutControlOrderNumberTextEdit.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlOrderNumberTextEdit.TextSize = new System.Drawing.Size(67, 13);
            // 
            // layoutControlStatusComboBoxEdit
            // 
            this.layoutControlStatusComboBoxEdit.Control = this.statusComboBoxEdit;
            this.layoutControlStatusComboBoxEdit.Location = new System.Drawing.Point(337, 0);
            this.layoutControlStatusComboBoxEdit.Name = "layoutControlStatusComboBoxEdit";
            this.layoutControlStatusComboBoxEdit.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlStatusComboBoxEdit.Size = new System.Drawing.Size(341, 50);
            this.layoutControlStatusComboBoxEdit.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlStatusComboBoxEdit.Text = "Status";
            this.layoutControlStatusComboBoxEdit.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlStatusComboBoxEdit.TextSize = new System.Drawing.Size(67, 13);
            // 
            // layoutControlOrderItemsGridControl
            // 
            this.layoutControlOrderItemsGridControl.Control = this.orderItemsGridControl;
            this.layoutControlOrderItemsGridControl.Location = new System.Drawing.Point(0, 50);
            this.layoutControlOrderItemsGridControl.Name = "layoutControlOrderItemsGridControl";
            this.layoutControlOrderItemsGridControl.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlOrderItemsGridControl.Size = new System.Drawing.Size(994, 523);
            this.layoutControlOrderItemsGridControl.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlOrderItemsGridControl.Text = "Order items";
            this.layoutControlOrderItemsGridControl.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlOrderItemsGridControl.TextSize = new System.Drawing.Size(67, 13);
            // 
            // clientLookUpEdit
            // 
            this.clientLookUpEdit.Location = new System.Drawing.Point(695, 33);
            this.clientLookUpEdit.MenuManager = this.ribbonOrderView;
            this.clientLookUpEdit.Name = "clientLookUpEdit";
            this.clientLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.clientLookUpEdit.Size = new System.Drawing.Size(302, 20);
            this.clientLookUpEdit.StyleController = this.layoutControlOrderView;
            this.clientLookUpEdit.TabIndex = 5;
            // 
            // layoutControlClientLookUpEdit
            // 
            this.layoutControlClientLookUpEdit.Control = this.clientLookUpEdit;
            this.layoutControlClientLookUpEdit.Location = new System.Drawing.Point(678, 0);
            this.layoutControlClientLookUpEdit.Name = "layoutControlClientLookUpEdit";
            this.layoutControlClientLookUpEdit.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlClientLookUpEdit.Size = new System.Drawing.Size(316, 50);
            this.layoutControlClientLookUpEdit.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlClientLookUpEdit.Text = "Client";
            this.layoutControlClientLookUpEdit.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlClientLookUpEdit.TextSize = new System.Drawing.Size(67, 13);
            // 
            // OrderListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 767);
            this.Controls.Add(this.layoutControlOrderView);
            this.Controls.Add(this.ribbonStatusBarOrderView);
            this.Controls.Add(this.ribbonOrderView);
            this.Name = "OrderListView";
            this.Ribbon = this.ribbonOrderView;
            this.StatusBar = this.ribbonStatusBarOrderView;
            this.Text = "OrderListView";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonOrderView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlOrderView)).EndInit();
            this.layoutControlOrderView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderNumberTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupOrderView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlOrderNumberTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlStatusComboBoxEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlOrderItemsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlClientLookUpEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonOrderView;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageOrderSearch;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup OrderViewFileRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBarOrderView;
        private DevExpress.XtraLayout.LayoutControl layoutControlOrderView;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupOrderView;
        private DevExpress.XtraGrid.GridControl orderItemsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView orderItemsGridView;
        private DevExpress.XtraEditors.ComboBoxEdit statusComboBoxEdit;
        private DevExpress.XtraEditors.TextEdit orderNumberTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlOrderNumberTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlStatusComboBoxEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlOrderItemsGridControl;
        private DevExpress.XtraBars.BarButtonItem addOrderBarButton;
        private DevExpress.XtraBars.BarButtonItem searchOrderBarButton;
        private DevExpress.XtraBars.BarButtonItem clearButton;
        private DevExpress.XtraEditors.LookUpEdit clientLookUpEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlClientLookUpEdit;
    }
}