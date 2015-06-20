using System.Windows.Forms;
using DevExpress.XtraBars;

namespace ContosoUI.NicksForms
{
    partial class productViewList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productViewList));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barSaveProductButton = new DevExpress.XtraBars.BarButtonItem();
            this.barSaveAndNewProductButton = new DevExpress.XtraBars.BarButtonItem();
            this.barClearProductButton = new DevExpress.XtraBars.BarButtonItem();
            this.barProductRemoveRevertButton = new DevExpress.XtraBars.BarButtonItem();
            this.barCategorySaveButton = new DevExpress.XtraBars.BarButtonItem();
            this.barSaveAndNewCategoryButton = new DevExpress.XtraBars.BarButtonItem();
            this.barClearCategoryButton = new DevExpress.XtraBars.BarButtonItem();
            this.barRemoveRevertCategoryButton = new DevExpress.XtraBars.BarButtonItem();
            this.barNewCategoryButton = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonProductPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageProductFileGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageProductRemoveRevertGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonCategoryPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonFileCategoryPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonCategoryPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.newCategorySimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.categorySearchControl = new DevExpress.XtraEditors.SearchControl();
            this.categoryCommentsListBoxControl = new DevExpress.XtraEditors.ListBoxControl();
            this.categoryGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.newCommentTextBox = new System.Windows.Forms.TextBox();
            this.addCommentButton = new DevExpress.XtraEditors.SimpleButton();
            this.productCommentsListBoxControl = new DevExpress.XtraEditors.ListBoxControl();
            this.productQuantitySpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.categoryComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.productPriceTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.productTitleTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.productSKUTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.categoryNewCommentTextBox = new System.Windows.Forms.TextBox();
            this.addCategoryCommetSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlNewCategoryButton = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlProductCategoryGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.tabbedControlProductGroup = new DevExpress.XtraLayout.TabbedControlGroup();
            this.layoutControlProductGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlProductCategoryComboBoxEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlProductPriceTextEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlProductQuantitySpinEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlProductTitleTextEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlProductSKUTextEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.tabbedControlGroup4 = new DevExpress.XtraLayout.TabbedControlGroup();
            this.layoutControlCommentsGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlProductComments = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlProductNewCommentTextEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlProductAddNewCommentButton = new DevExpress.XtraLayout.LayoutControlItem();
            this.tabbedControlCategoryGroup = new DevExpress.XtraLayout.TabbedControlGroup();
            this.layoutControlCategoryGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlCategoryGrid = new DevExpress.XtraLayout.LayoutControlItem();
            this.tabbedControlCategoryCommentsGroup = new DevExpress.XtraLayout.TabbedControlGroup();
            this.layoutControlCategoryCommentsGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlCategoryCommentsListBox = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlCategoryAddCommentButton = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlCategoryNewCommetTextEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutCategorySearchControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.flyoutPanel1 = new DevExpress.Utils.FlyoutPanel();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.simpleCancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.simpleAddTitleButton = new DevExpress.XtraEditors.SimpleButton();
            this.newCategoryTitletextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup6 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlTitleTextEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlAddNewCategoryButton = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlNewCategoryCancelButton = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categorySearchControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryCommentsListBoxControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCommentsListBoxControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productQuantitySpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPriceTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTitleTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSKUTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlNewCategoryButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlProductCategoryGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlProductGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlProductGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlProductCategoryComboBoxEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlProductPriceTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlProductQuantitySpinEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlProductTitleTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlProductSKUTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlCommentsGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlProductComments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlProductNewCommentTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlProductAddNewCommentButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlCategoryGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlCategoryGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlCategoryGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlCategoryCommentsGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlCategoryCommentsGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlCategoryCommentsListBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlCategoryAddCommentButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlCategoryNewCommetTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutCategorySearchControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel1)).BeginInit();
            this.flyoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newCategoryTitletextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlTitleTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlAddNewCategoryButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlNewCategoryCancelButton)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barSaveProductButton,
            this.barSaveAndNewProductButton,
            this.barClearProductButton,
            this.barProductRemoveRevertButton,
            this.barCategorySaveButton,
            this.barSaveAndNewCategoryButton,
            this.barClearCategoryButton,
            this.barRemoveRevertCategoryButton,
            this.barNewCategoryButton});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 13;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonProductPage,
            this.ribbonCategoryPage});
            this.ribbon.Size = new System.Drawing.Size(946, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // barSaveProductButton
            // 
            this.barSaveProductButton.Caption = "Save";
            this.barSaveProductButton.Glyph = ((System.Drawing.Image)(resources.GetObject("barSaveProductButton.Glyph")));
            this.barSaveProductButton.Id = 3;
            this.barSaveProductButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barSaveProductButton.LargeGlyph")));
            this.barSaveProductButton.Name = "barSaveProductButton";
            // 
            // barSaveAndNewProductButton
            // 
            this.barSaveAndNewProductButton.Caption = "Save and New";
            this.barSaveAndNewProductButton.Glyph = ((System.Drawing.Image)(resources.GetObject("barSaveAndNewProductButton.Glyph")));
            this.barSaveAndNewProductButton.Id = 4;
            this.barSaveAndNewProductButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barSaveAndNewProductButton.LargeGlyph")));
            this.barSaveAndNewProductButton.Name = "barSaveAndNewProductButton";
            // 
            // barClearProductButton
            // 
            this.barClearProductButton.Caption = "Clear";
            this.barClearProductButton.Glyph = ((System.Drawing.Image)(resources.GetObject("barClearProductButton.Glyph")));
            this.barClearProductButton.Id = 5;
            this.barClearProductButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barClearProductButton.LargeGlyph")));
            this.barClearProductButton.Name = "barClearProductButton";
            // 
            // barProductRemoveRevertButton
            // 
            this.barProductRemoveRevertButton.Caption = "Remove(Revert)";
            this.barProductRemoveRevertButton.Glyph = ((System.Drawing.Image)(resources.GetObject("barProductRemoveRevertButton.Glyph")));
            this.barProductRemoveRevertButton.Id = 6;
            this.barProductRemoveRevertButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barProductRemoveRevertButton.LargeGlyph")));
            this.barProductRemoveRevertButton.Name = "barProductRemoveRevertButton";
            // 
            // barCategorySaveButton
            // 
            this.barCategorySaveButton.Caption = "Save";
            this.barCategorySaveButton.Glyph = ((System.Drawing.Image)(resources.GetObject("barCategorySaveButton.Glyph")));
            this.barCategorySaveButton.Id = 7;
            this.barCategorySaveButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barCategorySaveButton.LargeGlyph")));
            this.barCategorySaveButton.Name = "barCategorySaveButton";
            // 
            // barSaveAndNewCategoryButton
            // 
            this.barSaveAndNewCategoryButton.Caption = "Save and New";
            this.barSaveAndNewCategoryButton.Glyph = ((System.Drawing.Image)(resources.GetObject("barSaveAndNewCategoryButton.Glyph")));
            this.barSaveAndNewCategoryButton.Id = 8;
            this.barSaveAndNewCategoryButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barSaveAndNewCategoryButton.LargeGlyph")));
            this.barSaveAndNewCategoryButton.Name = "barSaveAndNewCategoryButton";
            // 
            // barClearCategoryButton
            // 
            this.barClearCategoryButton.Caption = "Clear";
            this.barClearCategoryButton.Glyph = ((System.Drawing.Image)(resources.GetObject("barClearCategoryButton.Glyph")));
            this.barClearCategoryButton.Id = 9;
            this.barClearCategoryButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barClearCategoryButton.LargeGlyph")));
            this.barClearCategoryButton.Name = "barClearCategoryButton";
            // 
            // barRemoveRevertCategoryButton
            // 
            this.barRemoveRevertCategoryButton.Caption = "Remove(Revert)";
            this.barRemoveRevertCategoryButton.Glyph = ((System.Drawing.Image)(resources.GetObject("barRemoveRevertCategoryButton.Glyph")));
            this.barRemoveRevertCategoryButton.Id = 11;
            this.barRemoveRevertCategoryButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barRemoveRevertCategoryButton.LargeGlyph")));
            this.barRemoveRevertCategoryButton.Name = "barRemoveRevertCategoryButton";
            // 
            // barNewCategoryButton
            // 
            this.barNewCategoryButton.Caption = "New";
            this.barNewCategoryButton.Glyph = ((System.Drawing.Image)(resources.GetObject("barNewCategoryButton.Glyph")));
            this.barNewCategoryButton.Id = 12;
            this.barNewCategoryButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barNewCategoryButton.LargeGlyph")));
            this.barNewCategoryButton.Name = "barNewCategoryButton";
            this.barNewCategoryButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // ribbonProductPage
            // 
            this.ribbonProductPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageProductFileGroup,
            this.ribbonPageProductRemoveRevertGroup});
            this.ribbonProductPage.Name = "ribbonProductPage";
            this.ribbonProductPage.Text = "Product";
            // 
            // ribbonPageProductFileGroup
            // 
            this.ribbonPageProductFileGroup.ItemLinks.Add(this.barSaveProductButton);
            this.ribbonPageProductFileGroup.ItemLinks.Add(this.barSaveAndNewProductButton);
            this.ribbonPageProductFileGroup.ItemLinks.Add(this.barClearProductButton);
            this.ribbonPageProductFileGroup.Name = "ribbonPageProductFileGroup";
            this.ribbonPageProductFileGroup.Text = "File";
            // 
            // ribbonPageProductRemoveRevertGroup
            // 
            this.ribbonPageProductRemoveRevertGroup.ItemLinks.Add(this.barProductRemoveRevertButton);
            this.ribbonPageProductRemoveRevertGroup.Name = "ribbonPageProductRemoveRevertGroup";
            this.ribbonPageProductRemoveRevertGroup.Text = "Product";
            // 
            // ribbonCategoryPage
            // 
            this.ribbonCategoryPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonFileCategoryPageGroup,
            this.ribbonCategoryPageGroup});
            this.ribbonCategoryPage.Name = "ribbonCategoryPage";
            this.ribbonCategoryPage.Text = "Category";
            // 
            // ribbonFileCategoryPageGroup
            // 
            this.ribbonFileCategoryPageGroup.ItemLinks.Add(this.barCategorySaveButton);
            this.ribbonFileCategoryPageGroup.ItemLinks.Add(this.barSaveAndNewCategoryButton);
            this.ribbonFileCategoryPageGroup.ItemLinks.Add(this.barClearCategoryButton);
            this.ribbonFileCategoryPageGroup.Name = "ribbonFileCategoryPageGroup";
            this.ribbonFileCategoryPageGroup.Text = "File";
            // 
            // ribbonCategoryPageGroup
            // 
            this.ribbonCategoryPageGroup.ItemLinks.Add(this.barRemoveRevertCategoryButton);
            this.ribbonCategoryPageGroup.ItemLinks.Add(this.barNewCategoryButton);
            this.ribbonCategoryPageGroup.Name = "ribbonCategoryPageGroup";
            this.ribbonCategoryPageGroup.Text = "Category";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 736);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(946, 31);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.newCategorySimpleButton);
            this.layoutControl1.Controls.Add(this.categorySearchControl);
            this.layoutControl1.Controls.Add(this.categoryCommentsListBoxControl);
            this.layoutControl1.Controls.Add(this.categoryGridControl);
            this.layoutControl1.Controls.Add(this.newCommentTextBox);
            this.layoutControl1.Controls.Add(this.addCommentButton);
            this.layoutControl1.Controls.Add(this.productCommentsListBoxControl);
            this.layoutControl1.Controls.Add(this.productQuantitySpinEdit);
            this.layoutControl1.Controls.Add(this.categoryComboBoxEdit);
            this.layoutControl1.Controls.Add(this.productPriceTextEdit);
            this.layoutControl1.Controls.Add(this.productTitleTextEdit);
            this.layoutControl1.Controls.Add(this.productSKUTextEdit);
            this.layoutControl1.Controls.Add(this.categoryNewCommentTextBox);
            this.layoutControl1.Controls.Add(this.addCategoryCommetSimpleButton);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlNewCategoryButton});
            this.layoutControl1.Location = new System.Drawing.Point(0, 143);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(594, 294, 468, 495);
            this.layoutControl1.Root = this.layoutControlProductCategoryGroup;
            this.layoutControl1.Size = new System.Drawing.Size(946, 593);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // newCategorySimpleButton
            // 
            this.newCategorySimpleButton.Location = new System.Drawing.Point(114, 12);
            this.newCategorySimpleButton.Name = "newCategorySimpleButton";
            this.newCategorySimpleButton.Size = new System.Drawing.Size(820, 22);
            this.newCategorySimpleButton.StyleController = this.layoutControl1;
            this.newCategorySimpleButton.TabIndex = 24;
            this.newCategorySimpleButton.Text = "New category";
            this.newCategorySimpleButton.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // categorySearchControl
            // 
            this.categorySearchControl.Location = new System.Drawing.Point(476, 46);
            this.categorySearchControl.MenuManager = this.ribbon;
            this.categorySearchControl.Name = "categorySearchControl";
            this.categorySearchControl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.categorySearchControl.Size = new System.Drawing.Size(446, 20);
            this.categorySearchControl.StyleController = this.layoutControl1;
            this.categorySearchControl.TabIndex = 23;
            // 
            // categoryCommentsListBoxControl
            // 
            this.categoryCommentsListBoxControl.Location = new System.Drawing.Point(488, 328);
            this.categoryCommentsListBoxControl.Name = "categoryCommentsListBoxControl";
            this.categoryCommentsListBoxControl.Size = new System.Drawing.Size(422, 193);
            this.categoryCommentsListBoxControl.StyleController = this.layoutControl1;
            this.categoryCommentsListBoxControl.TabIndex = 22;
            // 
            // categoryGridControl
            // 
            this.categoryGridControl.Location = new System.Drawing.Point(476, 70);
            this.categoryGridControl.MainView = this.gridView1;
            this.categoryGridControl.MenuManager = this.ribbon;
            this.categoryGridControl.Name = "categoryGridControl";
            this.categoryGridControl.Size = new System.Drawing.Size(446, 220);
            this.categoryGridControl.TabIndex = 21;
            this.categoryGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.categoryGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // newCommentTextBox
            // 
            this.newCommentTextBox.Location = new System.Drawing.Point(41, 530);
            this.newCommentTextBox.Multiline = true;
            this.newCommentTextBox.Name = "newCommentTextBox";
            this.newCommentTextBox.Size = new System.Drawing.Size(284, 22);
            this.newCommentTextBox.TabIndex = 16;
            // 
            // addCommentButton
            // 
            this.addCommentButton.Location = new System.Drawing.Point(339, 530);
            this.addCommentButton.Name = "addCommentButton";
            this.addCommentButton.Size = new System.Drawing.Size(87, 22);
            this.addCommentButton.StyleController = this.layoutControl1;
            this.addCommentButton.TabIndex = 17;
            this.addCommentButton.Text = "Add comment";
            // 
            // productCommentsListBoxControl
            // 
            this.productCommentsListBoxControl.Location = new System.Drawing.Point(41, 335);
            this.productCommentsListBoxControl.Name = "productCommentsListBoxControl";
            this.productCommentsListBoxControl.Size = new System.Drawing.Size(385, 181);
            this.productCommentsListBoxControl.StyleController = this.layoutControl1;
            this.productCommentsListBoxControl.TabIndex = 9;
            // 
            // productQuantitySpinEdit
            // 
            this.productQuantitySpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.productQuantitySpinEdit.Location = new System.Drawing.Point(29, 167);
            this.productQuantitySpinEdit.MenuManager = this.ribbon;
            this.productQuantitySpinEdit.Name = "productQuantitySpinEdit";
            this.productQuantitySpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.productQuantitySpinEdit.Size = new System.Drawing.Size(409, 20);
            this.productQuantitySpinEdit.StyleController = this.layoutControl1;
            this.productQuantitySpinEdit.TabIndex = 8;
            // 
            // categoryComboBoxEdit
            // 
            this.categoryComboBoxEdit.Location = new System.Drawing.Point(29, 267);
            this.categoryComboBoxEdit.MenuManager = this.ribbon;
            this.categoryComboBoxEdit.Name = "categoryComboBoxEdit";
            this.categoryComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.categoryComboBoxEdit.Size = new System.Drawing.Size(409, 20);
            this.categoryComboBoxEdit.StyleController = this.layoutControl1;
            this.categoryComboBoxEdit.TabIndex = 7;
            // 
            // productPriceTextEdit
            // 
            this.productPriceTextEdit.Location = new System.Drawing.Point(29, 217);
            this.productPriceTextEdit.MenuManager = this.ribbon;
            this.productPriceTextEdit.Name = "productPriceTextEdit";
            this.productPriceTextEdit.Size = new System.Drawing.Size(409, 20);
            this.productPriceTextEdit.StyleController = this.layoutControl1;
            this.productPriceTextEdit.TabIndex = 6;
            // 
            // productTitleTextEdit
            // 
            this.productTitleTextEdit.Location = new System.Drawing.Point(29, 117);
            this.productTitleTextEdit.MenuManager = this.ribbon;
            this.productTitleTextEdit.Name = "productTitleTextEdit";
            this.productTitleTextEdit.Size = new System.Drawing.Size(409, 20);
            this.productTitleTextEdit.StyleController = this.layoutControl1;
            this.productTitleTextEdit.TabIndex = 5;
            // 
            // productSKUTextEdit
            // 
            this.productSKUTextEdit.Location = new System.Drawing.Point(29, 67);
            this.productSKUTextEdit.MenuManager = this.ribbon;
            this.productSKUTextEdit.Name = "productSKUTextEdit";
            this.productSKUTextEdit.Size = new System.Drawing.Size(409, 20);
            this.productSKUTextEdit.StyleController = this.layoutControl1;
            this.productSKUTextEdit.TabIndex = 4;
            // 
            // categoryNewCommentTextBox
            // 
            this.categoryNewCommentTextBox.Location = new System.Drawing.Point(493, 530);
            this.categoryNewCommentTextBox.Multiline = true;
            this.categoryNewCommentTextBox.Name = "categoryNewCommentTextBox";
            this.categoryNewCommentTextBox.Size = new System.Drawing.Size(315, 22);
            this.categoryNewCommentTextBox.TabIndex = 16;
            // 
            // addCategoryCommetSimpleButton
            // 
            this.addCategoryCommetSimpleButton.Location = new System.Drawing.Point(822, 530);
            this.addCategoryCommetSimpleButton.Name = "addCategoryCommetSimpleButton";
            this.addCategoryCommetSimpleButton.Size = new System.Drawing.Size(83, 22);
            this.addCategoryCommetSimpleButton.StyleController = this.layoutControl1;
            this.addCategoryCommetSimpleButton.TabIndex = 17;
            this.addCategoryCommetSimpleButton.Text = "Add comment";
            // 
            // layoutControlNewCategoryButton
            // 
            this.layoutControlNewCategoryButton.Control = this.newCategorySimpleButton;
            this.layoutControlNewCategoryButton.Location = new System.Drawing.Point(0, 0);
            this.layoutControlNewCategoryButton.Name = "layoutControlNewCategoryButton";
            this.layoutControlNewCategoryButton.Size = new System.Drawing.Size(926, 26);
            this.layoutControlNewCategoryButton.Text = "New category";
            this.layoutControlNewCategoryButton.TextSize = new System.Drawing.Size(99, 13);
            // 
            // layoutControlProductCategoryGroup
            // 
            this.layoutControlProductCategoryGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlProductCategoryGroup.GroupBordersVisible = false;
            this.layoutControlProductCategoryGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.tabbedControlProductGroup,
            this.tabbedControlCategoryGroup,
            this.splitterItem1});
            this.layoutControlProductCategoryGroup.Location = new System.Drawing.Point(0, 0);
            this.layoutControlProductCategoryGroup.Name = "Root";
            this.layoutControlProductCategoryGroup.Size = new System.Drawing.Size(946, 593);
            this.layoutControlProductCategoryGroup.TextVisible = false;
            // 
            // tabbedControlProductGroup
            // 
            this.tabbedControlProductGroup.Location = new System.Drawing.Point(0, 0);
            this.tabbedControlProductGroup.Name = "tabbedControlProductGroup";
            this.tabbedControlProductGroup.SelectedTabPage = this.layoutControlProductGroup;
            this.tabbedControlProductGroup.SelectedTabPageIndex = 0;
            this.tabbedControlProductGroup.Size = new System.Drawing.Size(447, 573);
            this.tabbedControlProductGroup.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlProductGroup});
            // 
            // layoutControlProductGroup
            // 
            this.layoutControlProductGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlProductCategoryComboBoxEdit,
            this.layoutControlProductPriceTextEdit,
            this.layoutControlProductQuantitySpinEdit,
            this.layoutControlProductTitleTextEdit,
            this.layoutControlProductSKUTextEdit,
            this.tabbedControlGroup4});
            this.layoutControlProductGroup.Location = new System.Drawing.Point(0, 0);
            this.layoutControlProductGroup.Name = "layoutControlProductGroup";
            this.layoutControlProductGroup.Size = new System.Drawing.Size(423, 527);
            this.layoutControlProductGroup.Text = "Product";
            // 
            // layoutControlProductCategoryComboBoxEdit
            // 
            this.layoutControlProductCategoryComboBoxEdit.Control = this.categoryComboBoxEdit;
            this.layoutControlProductCategoryComboBoxEdit.Location = new System.Drawing.Point(0, 200);
            this.layoutControlProductCategoryComboBoxEdit.Name = "layoutControlProductCategoryComboBoxEdit";
            this.layoutControlProductCategoryComboBoxEdit.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlProductCategoryComboBoxEdit.Size = new System.Drawing.Size(423, 50);
            this.layoutControlProductCategoryComboBoxEdit.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlProductCategoryComboBoxEdit.Text = "Category";
            this.layoutControlProductCategoryComboBoxEdit.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlProductCategoryComboBoxEdit.TextSize = new System.Drawing.Size(51, 13);
            // 
            // layoutControlProductPriceTextEdit
            // 
            this.layoutControlProductPriceTextEdit.Control = this.productPriceTextEdit;
            this.layoutControlProductPriceTextEdit.Location = new System.Drawing.Point(0, 150);
            this.layoutControlProductPriceTextEdit.Name = "layoutControlProductPriceTextEdit";
            this.layoutControlProductPriceTextEdit.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlProductPriceTextEdit.Size = new System.Drawing.Size(423, 50);
            this.layoutControlProductPriceTextEdit.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlProductPriceTextEdit.Text = "Price, UAH";
            this.layoutControlProductPriceTextEdit.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlProductPriceTextEdit.TextSize = new System.Drawing.Size(51, 13);
            // 
            // layoutControlProductQuantitySpinEdit
            // 
            this.layoutControlProductQuantitySpinEdit.Control = this.productQuantitySpinEdit;
            this.layoutControlProductQuantitySpinEdit.Location = new System.Drawing.Point(0, 100);
            this.layoutControlProductQuantitySpinEdit.Name = "layoutControlProductQuantitySpinEdit";
            this.layoutControlProductQuantitySpinEdit.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlProductQuantitySpinEdit.Size = new System.Drawing.Size(423, 50);
            this.layoutControlProductQuantitySpinEdit.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlProductQuantitySpinEdit.Text = "Quantity";
            this.layoutControlProductQuantitySpinEdit.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlProductQuantitySpinEdit.TextSize = new System.Drawing.Size(51, 13);
            // 
            // layoutControlProductTitleTextEdit
            // 
            this.layoutControlProductTitleTextEdit.Control = this.productTitleTextEdit;
            this.layoutControlProductTitleTextEdit.Location = new System.Drawing.Point(0, 50);
            this.layoutControlProductTitleTextEdit.Name = "layoutControlProductTitleTextEdit";
            this.layoutControlProductTitleTextEdit.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlProductTitleTextEdit.Size = new System.Drawing.Size(423, 50);
            this.layoutControlProductTitleTextEdit.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlProductTitleTextEdit.Text = "Title";
            this.layoutControlProductTitleTextEdit.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlProductTitleTextEdit.TextSize = new System.Drawing.Size(51, 13);
            // 
            // layoutControlProductSKUTextEdit
            // 
            this.layoutControlProductSKUTextEdit.Control = this.productSKUTextEdit;
            this.layoutControlProductSKUTextEdit.Location = new System.Drawing.Point(0, 0);
            this.layoutControlProductSKUTextEdit.Name = "layoutControlProductSKUTextEdit";
            this.layoutControlProductSKUTextEdit.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlProductSKUTextEdit.Size = new System.Drawing.Size(423, 50);
            this.layoutControlProductSKUTextEdit.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlProductSKUTextEdit.Text = "SKU";
            this.layoutControlProductSKUTextEdit.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlProductSKUTextEdit.TextSize = new System.Drawing.Size(51, 13);
            // 
            // tabbedControlGroup4
            // 
            this.tabbedControlGroup4.Location = new System.Drawing.Point(0, 250);
            this.tabbedControlGroup4.Name = "tabbedControlGroup4";
            this.tabbedControlGroup4.SelectedTabPage = this.layoutControlCommentsGroup;
            this.tabbedControlGroup4.SelectedTabPageIndex = 0;
            this.tabbedControlGroup4.Size = new System.Drawing.Size(423, 277);
            this.tabbedControlGroup4.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlCommentsGroup});
            // 
            // layoutControlCommentsGroup
            // 
            this.layoutControlCommentsGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlProductComments,
            this.layoutControlProductNewCommentTextEdit,
            this.layoutControlProductAddNewCommentButton});
            this.layoutControlCommentsGroup.Location = new System.Drawing.Point(0, 0);
            this.layoutControlCommentsGroup.Name = "layoutControlCommentsGroup";
            this.layoutControlCommentsGroup.Size = new System.Drawing.Size(399, 231);
            this.layoutControlCommentsGroup.Text = "Comments";
            // 
            // layoutControlProductComments
            // 
            this.layoutControlProductComments.Control = this.productCommentsListBoxControl;
            this.layoutControlProductComments.Location = new System.Drawing.Point(0, 0);
            this.layoutControlProductComments.Name = "layoutControlProductComments";
            this.layoutControlProductComments.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlProductComments.Size = new System.Drawing.Size(399, 195);
            this.layoutControlProductComments.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlProductComments.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlProductComments.TextVisible = false;
            // 
            // layoutControlProductNewCommentTextEdit
            // 
            this.layoutControlProductNewCommentTextEdit.Control = this.newCommentTextBox;
            this.layoutControlProductNewCommentTextEdit.Location = new System.Drawing.Point(0, 195);
            this.layoutControlProductNewCommentTextEdit.Name = "layoutControlProductNewCommentTextEdit";
            this.layoutControlProductNewCommentTextEdit.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlProductNewCommentTextEdit.Size = new System.Drawing.Size(298, 36);
            this.layoutControlProductNewCommentTextEdit.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlProductNewCommentTextEdit.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlProductNewCommentTextEdit.TextVisible = false;
            // 
            // layoutControlProductAddNewCommentButton
            // 
            this.layoutControlProductAddNewCommentButton.Control = this.addCommentButton;
            this.layoutControlProductAddNewCommentButton.Location = new System.Drawing.Point(298, 195);
            this.layoutControlProductAddNewCommentButton.Name = "layoutControlProductAddNewCommentButton";
            this.layoutControlProductAddNewCommentButton.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlProductAddNewCommentButton.Size = new System.Drawing.Size(101, 36);
            this.layoutControlProductAddNewCommentButton.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlProductAddNewCommentButton.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlProductAddNewCommentButton.TextVisible = false;
            // 
            // tabbedControlCategoryGroup
            // 
            this.tabbedControlCategoryGroup.Location = new System.Drawing.Point(452, 0);
            this.tabbedControlCategoryGroup.Name = "tabbedControlCategoryGroup";
            this.tabbedControlCategoryGroup.SelectedTabPage = this.layoutControlCategoryGroup;
            this.tabbedControlCategoryGroup.SelectedTabPageIndex = 0;
            this.tabbedControlCategoryGroup.Size = new System.Drawing.Size(474, 573);
            this.tabbedControlCategoryGroup.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlCategoryGroup});
            // 
            // layoutControlCategoryGroup
            // 
            this.layoutControlCategoryGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlCategoryGrid,
            this.tabbedControlCategoryCommentsGroup,
            this.layoutCategorySearchControl});
            this.layoutControlCategoryGroup.Location = new System.Drawing.Point(0, 0);
            this.layoutControlCategoryGroup.Name = "layoutControlCategoryGroup";
            this.layoutControlCategoryGroup.Size = new System.Drawing.Size(450, 527);
            this.layoutControlCategoryGroup.Text = "Category";
            // 
            // layoutControlCategoryGrid
            // 
            this.layoutControlCategoryGrid.Control = this.categoryGridControl;
            this.layoutControlCategoryGrid.Location = new System.Drawing.Point(0, 24);
            this.layoutControlCategoryGrid.Name = "layoutControlCategoryGrid";
            this.layoutControlCategoryGrid.Size = new System.Drawing.Size(450, 224);
            this.layoutControlCategoryGrid.Text = "Category grid";
            this.layoutControlCategoryGrid.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlCategoryGrid.TextVisible = false;
            // 
            // tabbedControlCategoryCommentsGroup
            // 
            this.tabbedControlCategoryCommentsGroup.Location = new System.Drawing.Point(0, 248);
            this.tabbedControlCategoryCommentsGroup.Name = "tabbedControlCategoryCommentsGroup";
            this.tabbedControlCategoryCommentsGroup.SelectedTabPage = this.layoutControlCategoryCommentsGroup;
            this.tabbedControlCategoryCommentsGroup.SelectedTabPageIndex = 0;
            this.tabbedControlCategoryCommentsGroup.Size = new System.Drawing.Size(450, 279);
            this.tabbedControlCategoryCommentsGroup.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlCategoryCommentsGroup});
            // 
            // layoutControlCategoryCommentsGroup
            // 
            this.layoutControlCategoryCommentsGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlCategoryCommentsListBox,
            this.layoutControlCategoryAddCommentButton,
            this.layoutControlCategoryNewCommetTextEdit});
            this.layoutControlCategoryCommentsGroup.Location = new System.Drawing.Point(0, 0);
            this.layoutControlCategoryCommentsGroup.Name = "layoutControlCategoryCommentsGroup";
            this.layoutControlCategoryCommentsGroup.Size = new System.Drawing.Size(426, 233);
            this.layoutControlCategoryCommentsGroup.Text = "Comments";
            // 
            // layoutControlCategoryCommentsListBox
            // 
            this.layoutControlCategoryCommentsListBox.Control = this.categoryCommentsListBoxControl;
            this.layoutControlCategoryCommentsListBox.Location = new System.Drawing.Point(0, 0);
            this.layoutControlCategoryCommentsListBox.Name = "layoutControlCategoryCommentsListBox";
            this.layoutControlCategoryCommentsListBox.Size = new System.Drawing.Size(426, 197);
            this.layoutControlCategoryCommentsListBox.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlCategoryCommentsListBox.TextVisible = false;
            // 
            // layoutControlCategoryAddCommentButton
            // 
            this.layoutControlCategoryAddCommentButton.Control = this.addCategoryCommetSimpleButton;
            this.layoutControlCategoryAddCommentButton.CustomizationFormText = "layoutControlItem3";
            this.layoutControlCategoryAddCommentButton.Location = new System.Drawing.Point(329, 197);
            this.layoutControlCategoryAddCommentButton.Name = "layoutControlCategoryAddCommentButton";
            this.layoutControlCategoryAddCommentButton.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlCategoryAddCommentButton.Size = new System.Drawing.Size(97, 36);
            this.layoutControlCategoryAddCommentButton.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlCategoryAddCommentButton.Text = "layoutControlItem3";
            this.layoutControlCategoryAddCommentButton.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlCategoryAddCommentButton.TextVisible = false;
            // 
            // layoutControlCategoryNewCommetTextEdit
            // 
            this.layoutControlCategoryNewCommetTextEdit.Control = this.categoryNewCommentTextBox;
            this.layoutControlCategoryNewCommetTextEdit.CustomizationFormText = "layoutControlItem2";
            this.layoutControlCategoryNewCommetTextEdit.Location = new System.Drawing.Point(0, 197);
            this.layoutControlCategoryNewCommetTextEdit.Name = "layoutControlCategoryNewCommetTextEdit";
            this.layoutControlCategoryNewCommetTextEdit.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlCategoryNewCommetTextEdit.Size = new System.Drawing.Size(329, 36);
            this.layoutControlCategoryNewCommetTextEdit.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlCategoryNewCommetTextEdit.Text = "layoutControlItem2";
            this.layoutControlCategoryNewCommetTextEdit.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlCategoryNewCommetTextEdit.TextVisible = false;
            // 
            // layoutCategorySearchControl
            // 
            this.layoutCategorySearchControl.Control = this.categorySearchControl;
            this.layoutCategorySearchControl.Location = new System.Drawing.Point(0, 0);
            this.layoutCategorySearchControl.Name = "layoutCategorySearchControl";
            this.layoutCategorySearchControl.Size = new System.Drawing.Size(450, 24);
            this.layoutCategorySearchControl.TextSize = new System.Drawing.Size(0, 0);
            this.layoutCategorySearchControl.TextVisible = false;
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.Location = new System.Drawing.Point(447, 0);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(5, 573);
            // 
            // flyoutPanel1
            // 
            this.flyoutPanel1.Controls.Add(this.layoutControl2);
            this.flyoutPanel1.Location = new System.Drawing.Point(460, 50);
            this.flyoutPanel1.Name = "flyoutPanel1";
            this.flyoutPanel1.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Manual;
            this.flyoutPanel1.Options.AnimationType = DevExpress.Utils.Win.PopupToolWindowAnimation.Fade;
            this.flyoutPanel1.Options.CloseOnOuterClick = true;
            this.flyoutPanel1.Options.Location = new System.Drawing.Point(180, 122);
            this.flyoutPanel1.OwnerControl = this.newCategorySimpleButton;
            this.flyoutPanel1.Size = new System.Drawing.Size(235, 87);
            this.flyoutPanel1.TabIndex = 8;
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.simpleCancelButton);
            this.layoutControl2.Controls.Add(this.simpleAddTitleButton);
            this.layoutControl2.Controls.Add(this.newCategoryTitletextEdit);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(0, 0);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup6;
            this.layoutControl2.Size = new System.Drawing.Size(235, 87);
            this.layoutControl2.TabIndex = 0;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // simpleCancelButton
            // 
            this.simpleCancelButton.Location = new System.Drawing.Point(120, 52);
            this.simpleCancelButton.Name = "simpleCancelButton";
            this.simpleCancelButton.Size = new System.Drawing.Size(103, 22);
            this.simpleCancelButton.StyleController = this.layoutControl2;
            this.simpleCancelButton.TabIndex = 6;
            this.simpleCancelButton.Text = "Cancel";
            // 
            // simpleAddTitleButton
            // 
            this.simpleAddTitleButton.Location = new System.Drawing.Point(12, 52);
            this.simpleAddTitleButton.Name = "simpleAddTitleButton";
            this.simpleAddTitleButton.Size = new System.Drawing.Size(104, 22);
            this.simpleAddTitleButton.StyleController = this.layoutControl2;
            this.simpleAddTitleButton.TabIndex = 5;
            this.simpleAddTitleButton.Text = "Add";
            // 
            // newCategoryTitletextEdit
            // 
            this.newCategoryTitletextEdit.Location = new System.Drawing.Point(12, 28);
            this.newCategoryTitletextEdit.MenuManager = this.ribbon;
            this.newCategoryTitletextEdit.Name = "newCategoryTitletextEdit";
            this.newCategoryTitletextEdit.Size = new System.Drawing.Size(211, 20);
            this.newCategoryTitletextEdit.StyleController = this.layoutControl2;
            this.newCategoryTitletextEdit.TabIndex = 4;
            // 
            // layoutControlGroup6
            // 
            this.layoutControlGroup6.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup6.GroupBordersVisible = false;
            this.layoutControlGroup6.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlTitleTextEdit,
            this.layoutControlAddNewCategoryButton,
            this.layoutControlNewCategoryCancelButton});
            this.layoutControlGroup6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup6.Name = "layoutControlGroup6";
            this.layoutControlGroup6.Size = new System.Drawing.Size(235, 87);
            this.layoutControlGroup6.TextVisible = false;
            // 
            // layoutControlTitleTextEdit
            // 
            this.layoutControlTitleTextEdit.Control = this.newCategoryTitletextEdit;
            this.layoutControlTitleTextEdit.Location = new System.Drawing.Point(0, 0);
            this.layoutControlTitleTextEdit.Name = "layoutControlTitleTextEdit";
            this.layoutControlTitleTextEdit.Size = new System.Drawing.Size(215, 40);
            this.layoutControlTitleTextEdit.Text = "Title";
            this.layoutControlTitleTextEdit.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlTitleTextEdit.TextSize = new System.Drawing.Size(20, 13);
            // 
            // layoutControlAddNewCategoryButton
            // 
            this.layoutControlAddNewCategoryButton.Control = this.simpleAddTitleButton;
            this.layoutControlAddNewCategoryButton.Location = new System.Drawing.Point(0, 40);
            this.layoutControlAddNewCategoryButton.Name = "layoutControlAddNewCategoryButton";
            this.layoutControlAddNewCategoryButton.Size = new System.Drawing.Size(108, 27);
            this.layoutControlAddNewCategoryButton.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlAddNewCategoryButton.TextVisible = false;
            // 
            // layoutControlNewCategoryCancelButton
            // 
            this.layoutControlNewCategoryCancelButton.Control = this.simpleCancelButton;
            this.layoutControlNewCategoryCancelButton.Location = new System.Drawing.Point(108, 40);
            this.layoutControlNewCategoryCancelButton.Name = "layoutControlNewCategoryCancelButton";
            this.layoutControlNewCategoryCancelButton.Size = new System.Drawing.Size(107, 27);
            this.layoutControlNewCategoryCancelButton.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlNewCategoryCancelButton.TextVisible = false;
            // 
            // productViewList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 767);
            this.Controls.Add(this.flyoutPanel1);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "productViewList";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "ProductViewList";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categorySearchControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryCommentsListBoxControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCommentsListBoxControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productQuantitySpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPriceTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTitleTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSKUTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlNewCategoryButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlProductCategoryGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlProductGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlProductGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlProductCategoryComboBoxEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlProductPriceTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlProductQuantitySpinEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlProductTitleTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlProductSKUTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlCommentsGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlProductComments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlProductNewCommentTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlProductAddNewCommentButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlCategoryGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlCategoryGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlCategoryGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlCategoryCommentsGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlCategoryCommentsGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlCategoryCommentsListBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlCategoryAddCommentButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlCategoryNewCommetTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutCategorySearchControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel1)).EndInit();
            this.flyoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.newCategoryTitletextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlTitleTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlAddNewCategoryButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlNewCategoryCancelButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonProductPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageProductFileGroup;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit productTitleTextEdit;
        private DevExpress.XtraEditors.TextEdit productSKUTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlProductCategoryGroup;
        private DevExpress.XtraEditors.ListBoxControl productCommentsListBoxControl;
        private DevExpress.XtraEditors.SpinEdit productQuantitySpinEdit;
        private DevExpress.XtraEditors.ComboBoxEdit categoryComboBoxEdit;
        private DevExpress.XtraEditors.TextEdit productPriceTextEdit;
        private DevExpress.XtraEditors.ListBoxControl categoryCommentsListBoxControl;
        private DevExpress.XtraGrid.GridControl categoryGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TextBox newCommentTextBox;
        private DevExpress.XtraEditors.SimpleButton addCommentButton;
        private DevExpress.XtraLayout.TabbedControlGroup tabbedControlProductGroup;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlProductGroup;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlProductCategoryComboBoxEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlProductPriceTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlProductQuantitySpinEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlProductTitleTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlProductSKUTextEdit;
        private DevExpress.XtraLayout.TabbedControlGroup tabbedControlCategoryGroup;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlCategoryGroup;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlCategoryGrid;
        private System.Windows.Forms.TextBox categoryNewCommentTextBox;
        private DevExpress.XtraEditors.SimpleButton addCategoryCommetSimpleButton;
        private DevExpress.XtraEditors.SearchControl categorySearchControl;
        private DevExpress.XtraLayout.TabbedControlGroup tabbedControlGroup4;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlCommentsGroup;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlProductComments;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlProductNewCommentTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlProductAddNewCommentButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutCategorySearchControl;
        private DevExpress.XtraLayout.TabbedControlGroup tabbedControlCategoryCommentsGroup;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlCategoryCommentsGroup;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlCategoryCommentsListBox;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlCategoryAddCommentButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlCategoryNewCommetTextEdit;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private DevExpress.XtraEditors.SimpleButton newCategorySimpleButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlNewCategoryButton;
        private DevExpress.Utils.FlyoutPanel flyoutPanel1;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraEditors.SimpleButton simpleCancelButton;
        private DevExpress.XtraEditors.SimpleButton simpleAddTitleButton;
        private DevExpress.XtraEditors.TextEdit newCategoryTitletextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlTitleTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlAddNewCategoryButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlNewCategoryCancelButton;
        private BarButtonItem barSaveProductButton;
        private BarButtonItem barSaveAndNewProductButton;
        private BarButtonItem barClearProductButton;
        private BarButtonItem barProductRemoveRevertButton;
        private BarButtonItem barCategorySaveButton;
        private BarButtonItem barSaveAndNewCategoryButton;
        private BarButtonItem barClearCategoryButton;
        private BarButtonItem barRemoveRevertCategoryButton;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageProductRemoveRevertGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonCategoryPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonFileCategoryPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonCategoryPageGroup;
        private BarButtonItem barNewCategoryButton;
    }
}