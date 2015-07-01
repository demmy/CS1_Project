namespace ContosoUI.ProductSearchForm
{
    partial class ProductListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductListView));
            this.ribbonProductView = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.addProductBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.searchProductBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.clearProductBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageProductView = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.productFileRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBarProductView = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.layoutControlProductView = new DevExpress.XtraLayout.LayoutControl();
            this.productsGridControl = new DevExpress.XtraGrid.GridControl();
            this.productsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.productTitleTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.skuTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroupProductView = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlSKUTextEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlProductTitleTextEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlProductsGridView = new DevExpress.XtraLayout.LayoutControlItem();
            this.categoryComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControlCategoryComboBoxEdit = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonProductView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlProductView)).BeginInit();
            this.layoutControlProductView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTitleTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skuTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupProductView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlSKUTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlProductTitleTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlProductsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlCategoryComboBoxEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonProductView
            // 
            this.ribbonProductView.ExpandCollapseItem.Id = 0;
            this.ribbonProductView.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonProductView.ExpandCollapseItem,
            this.addProductBarButton,
            this.searchProductBarButton,
            this.clearProductBarButton});
            this.ribbonProductView.Location = new System.Drawing.Point(0, 0);
            this.ribbonProductView.MaxItemId = 4;
            this.ribbonProductView.Name = "ribbonProductView";
            this.ribbonProductView.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageProductView});
            this.ribbonProductView.Size = new System.Drawing.Size(1014, 143);
            this.ribbonProductView.StatusBar = this.ribbonStatusBarProductView;
            // 
            // addProductBarButton
            // 
            this.addProductBarButton.Caption = "Add";
            this.addProductBarButton.Glyph = ((System.Drawing.Image)(resources.GetObject("addProductBarButton.Glyph")));
            this.addProductBarButton.Id = 1;
            this.addProductBarButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("addProductBarButton.LargeGlyph")));
            this.addProductBarButton.Name = "addProductBarButton";
            // 
            // searchProductBarButton
            // 
            this.searchProductBarButton.Caption = "Search";
            this.searchProductBarButton.Glyph = ((System.Drawing.Image)(resources.GetObject("searchProductBarButton.Glyph")));
            this.searchProductBarButton.Id = 2;
            this.searchProductBarButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("searchProductBarButton.LargeGlyph")));
            this.searchProductBarButton.Name = "searchProductBarButton";
            // 
            // clearProductBarButton
            // 
            this.clearProductBarButton.Caption = "Clear";
            this.clearProductBarButton.Glyph = ((System.Drawing.Image)(resources.GetObject("clearProductBarButton.Glyph")));
            this.clearProductBarButton.Id = 3;
            this.clearProductBarButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("clearProductBarButton.LargeGlyph")));
            this.clearProductBarButton.Name = "clearProductBarButton";
            // 
            // ribbonPageProductView
            // 
            this.ribbonPageProductView.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.productFileRibbonPageGroup});
            this.ribbonPageProductView.Name = "ribbonPageProductView";
            this.ribbonPageProductView.Text = "Product search";
            // 
            // productFileRibbonPageGroup
            // 
            this.productFileRibbonPageGroup.ItemLinks.Add(this.addProductBarButton);
            this.productFileRibbonPageGroup.ItemLinks.Add(this.searchProductBarButton);
            this.productFileRibbonPageGroup.ItemLinks.Add(this.clearProductBarButton);
            this.productFileRibbonPageGroup.Name = "productFileRibbonPageGroup";
            this.productFileRibbonPageGroup.Text = "File";
            // 
            // ribbonStatusBarProductView
            // 
            this.ribbonStatusBarProductView.Location = new System.Drawing.Point(0, 736);
            this.ribbonStatusBarProductView.Name = "ribbonStatusBarProductView";
            this.ribbonStatusBarProductView.Ribbon = this.ribbonProductView;
            this.ribbonStatusBarProductView.Size = new System.Drawing.Size(1014, 31);
            // 
            // layoutControlProductView
            // 
            this.layoutControlProductView.Controls.Add(this.categoryComboBoxEdit);
            this.layoutControlProductView.Controls.Add(this.productsGridControl);
            this.layoutControlProductView.Controls.Add(this.productTitleTextEdit);
            this.layoutControlProductView.Controls.Add(this.skuTextEdit);
            this.layoutControlProductView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControlProductView.Location = new System.Drawing.Point(0, 143);
            this.layoutControlProductView.Name = "layoutControlProductView";
            this.layoutControlProductView.Root = this.layoutControlGroupProductView;
            this.layoutControlProductView.Size = new System.Drawing.Size(1014, 593);
            this.layoutControlProductView.TabIndex = 2;
            this.layoutControlProductView.Text = "layoutControl1";
            // 
            // productsGridControl
            // 
            this.productsGridControl.Location = new System.Drawing.Point(17, 67);
            this.productsGridControl.MainView = this.productsGridView;
            this.productsGridControl.MenuManager = this.ribbonProductView;
            this.productsGridControl.Name = "productsGridControl";
            this.productsGridControl.Size = new System.Drawing.Size(980, 509);
            this.productsGridControl.TabIndex = 7;
            this.productsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.productsGridView});
            // 
            // productsGridView
            // 
            this.productsGridView.GridControl = this.productsGridControl;
            this.productsGridView.Name = "productsGridView";
            // 
            // productTitleTextEdit
            // 
            this.productTitleTextEdit.Location = new System.Drawing.Point(349, 33);
            this.productTitleTextEdit.MenuManager = this.ribbonProductView;
            this.productTitleTextEdit.Name = "productTitleTextEdit";
            this.productTitleTextEdit.Size = new System.Drawing.Size(317, 20);
            this.productTitleTextEdit.StyleController = this.layoutControlProductView;
            this.productTitleTextEdit.TabIndex = 5;
            // 
            // skuTextEdit
            // 
            this.skuTextEdit.Location = new System.Drawing.Point(17, 33);
            this.skuTextEdit.MenuManager = this.ribbonProductView;
            this.skuTextEdit.Name = "skuTextEdit";
            this.skuTextEdit.Size = new System.Drawing.Size(318, 20);
            this.skuTextEdit.StyleController = this.layoutControlProductView;
            this.skuTextEdit.TabIndex = 4;
            // 
            // layoutControlGroupProductView
            // 
            this.layoutControlGroupProductView.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupProductView.GroupBordersVisible = false;
            this.layoutControlGroupProductView.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlSKUTextEdit,
            this.layoutControlProductTitleTextEdit,
            this.layoutControlProductsGridView,
            this.layoutControlCategoryComboBoxEdit});
            this.layoutControlGroupProductView.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupProductView.Name = "layoutControlGroupProductView";
            this.layoutControlGroupProductView.Size = new System.Drawing.Size(1014, 593);
            this.layoutControlGroupProductView.TextVisible = false;
            // 
            // layoutControlSKUTextEdit
            // 
            this.layoutControlSKUTextEdit.Control = this.skuTextEdit;
            this.layoutControlSKUTextEdit.Location = new System.Drawing.Point(0, 0);
            this.layoutControlSKUTextEdit.Name = "layoutControlSKUTextEdit";
            this.layoutControlSKUTextEdit.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlSKUTextEdit.Size = new System.Drawing.Size(332, 50);
            this.layoutControlSKUTextEdit.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlSKUTextEdit.Text = "SKU";
            this.layoutControlSKUTextEdit.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlSKUTextEdit.TextSize = new System.Drawing.Size(45, 13);
            // 
            // layoutControlProductTitleTextEdit
            // 
            this.layoutControlProductTitleTextEdit.Control = this.productTitleTextEdit;
            this.layoutControlProductTitleTextEdit.Location = new System.Drawing.Point(332, 0);
            this.layoutControlProductTitleTextEdit.Name = "layoutControlProductTitleTextEdit";
            this.layoutControlProductTitleTextEdit.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlProductTitleTextEdit.Size = new System.Drawing.Size(331, 50);
            this.layoutControlProductTitleTextEdit.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlProductTitleTextEdit.Text = "Title";
            this.layoutControlProductTitleTextEdit.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlProductTitleTextEdit.TextSize = new System.Drawing.Size(45, 13);
            // 
            // layoutControlProductsGridView
            // 
            this.layoutControlProductsGridView.Control = this.productsGridControl;
            this.layoutControlProductsGridView.Location = new System.Drawing.Point(0, 50);
            this.layoutControlProductsGridView.Name = "layoutControlProductsGridView";
            this.layoutControlProductsGridView.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlProductsGridView.Size = new System.Drawing.Size(994, 523);
            this.layoutControlProductsGridView.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlProductsGridView.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlProductsGridView.TextVisible = false;
            // 
            // categoryComboBoxEdit
            // 
            this.categoryComboBoxEdit.Location = new System.Drawing.Point(680, 33);
            this.categoryComboBoxEdit.MenuManager = this.ribbonProductView;
            this.categoryComboBoxEdit.Name = "categoryComboBoxEdit";
            this.categoryComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.categoryComboBoxEdit.Size = new System.Drawing.Size(317, 20);
            this.categoryComboBoxEdit.StyleController = this.layoutControlProductView;
            this.categoryComboBoxEdit.TabIndex = 8;
            // 
            // layoutControlCategoryComboBoxEdit
            // 
            this.layoutControlCategoryComboBoxEdit.Control = this.categoryComboBoxEdit;
            this.layoutControlCategoryComboBoxEdit.Location = new System.Drawing.Point(663, 0);
            this.layoutControlCategoryComboBoxEdit.Name = "layoutControlCategoryComboBoxEdit";
            this.layoutControlCategoryComboBoxEdit.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlCategoryComboBoxEdit.Size = new System.Drawing.Size(331, 50);
            this.layoutControlCategoryComboBoxEdit.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlCategoryComboBoxEdit.Text = "Category";
            this.layoutControlCategoryComboBoxEdit.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlCategoryComboBoxEdit.TextSize = new System.Drawing.Size(45, 13);
            // 
            // ProductListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 767);
            this.Controls.Add(this.layoutControlProductView);
            this.Controls.Add(this.ribbonStatusBarProductView);
            this.Controls.Add(this.ribbonProductView);
            this.Name = "ProductListView";
            this.Ribbon = this.ribbonProductView;
            this.StatusBar = this.ribbonStatusBarProductView;
            this.Text = "ProductListView";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonProductView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlProductView)).EndInit();
            this.layoutControlProductView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTitleTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skuTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupProductView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlSKUTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlProductTitleTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlProductsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlCategoryComboBoxEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonProductView;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageProductView;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup productFileRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBarProductView;
        private DevExpress.XtraBars.BarButtonItem addProductBarButton;
        private DevExpress.XtraBars.BarButtonItem searchProductBarButton;
        private DevExpress.XtraBars.BarButtonItem clearProductBarButton;
        private DevExpress.XtraLayout.LayoutControl layoutControlProductView;
        private DevExpress.XtraGrid.GridControl productsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView productsGridView;
        private DevExpress.XtraEditors.TextEdit productTitleTextEdit;
        private DevExpress.XtraEditors.TextEdit skuTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupProductView;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlSKUTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlProductTitleTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlProductsGridView;
        private DevExpress.XtraEditors.ComboBoxEdit categoryComboBoxEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlCategoryComboBoxEdit;
    }
}