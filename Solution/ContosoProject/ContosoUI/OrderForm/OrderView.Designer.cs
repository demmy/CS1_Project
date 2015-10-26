namespace ContosoUI.OrderForm
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.orderRibbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.orderSaveAndNewBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.orderSaveBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.ClearBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.orderRibbonPageOrderView = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.orderRibbonPageFileGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.orderRibbonPageOrderGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.orderRibbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.orderViewLayoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.clientLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.addCommentButton = new DevExpress.XtraEditors.SimpleButton();
            this.newCommentTextBox = new System.Windows.Forms.TextBox();
            this.commentsListBox = new DevExpress.XtraEditors.ListBoxControl();
            this.orderGridControl = new DevExpress.XtraGrid.GridControl();
            this.orderGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.orderDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.orderNumberTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.orderStatusLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlOrderNumberTextEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlStatusComboBox = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlDateEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.orderTabbedControlOrderAndCommentGroup = new DevExpress.XtraLayout.TabbedControlGroup();
            this.layoutControlCommentsList = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlCommentListBox = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlNewCommentTextBox = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlAddNewCommentButton = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlDataGrid = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlOrderGrid = new DevExpress.XtraLayout.LayoutControlItem();
            this.orderSplitter = new DevExpress.XtraLayout.SplitterItem();
            this.layoutControlClientLookUp = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.orderRibbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderViewLayoutControl)).BeginInit();
            this.orderViewLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsListBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderNumberTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderStatusLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlOrderNumberTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlStatusComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlDateEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTabbedControlOrderAndCommentGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlCommentsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlCommentListBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlNewCommentTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlAddNewCommentButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlOrderGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderSplitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlClientLookUp)).BeginInit();
            this.SuspendLayout();
            // 
            // orderRibbon
            // 
            this.orderRibbon.ExpandCollapseItem.Id = 0;
            this.orderRibbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.orderRibbon.ExpandCollapseItem,
            this.orderSaveAndNewBarButton,
            this.orderSaveBarButton,
            this.ClearBarButton,
            this.barButtonItem1});
            this.orderRibbon.Location = new System.Drawing.Point(0, 0);
            this.orderRibbon.MaxItemId = 5;
            this.orderRibbon.Name = "orderRibbon";
            this.orderRibbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.orderRibbonPageOrderView});
            this.orderRibbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.orderRibbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.orderRibbon.ShowCategoryInCaption = false;
            this.orderRibbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.orderRibbon.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.False;
            this.orderRibbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.orderRibbon.ShowQatLocationSelector = false;
            this.orderRibbon.ShowToolbarCustomizeItem = false;
            this.orderRibbon.Size = new System.Drawing.Size(1014, 122);
            this.orderRibbon.StatusBar = this.orderRibbonStatusBar;
            this.orderRibbon.Toolbar.ShowCustomizeItem = false;
            // 
            // orderSaveAndNewBarButton
            // 
            this.orderSaveAndNewBarButton.Caption = "Save and New";
            this.orderSaveAndNewBarButton.Glyph = ((System.Drawing.Image)(resources.GetObject("orderSaveAndNewBarButton.Glyph")));
            this.orderSaveAndNewBarButton.Id = 1;
            this.orderSaveAndNewBarButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("orderSaveAndNewBarButton.LargeGlyph")));
            this.orderSaveAndNewBarButton.Name = "orderSaveAndNewBarButton";
            this.orderSaveAndNewBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.orderSaveAndNewBarButton_ItemClick);
            // 
            // orderSaveBarButton
            // 
            this.orderSaveBarButton.Caption = "Save";
            this.orderSaveBarButton.Glyph = ((System.Drawing.Image)(resources.GetObject("orderSaveBarButton.Glyph")));
            this.orderSaveBarButton.Id = 2;
            this.orderSaveBarButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("orderSaveBarButton.LargeGlyph")));
            this.orderSaveBarButton.Name = "orderSaveBarButton";
            this.orderSaveBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.orderSaveBarButton_ItemClick);
            // 
            // ClearBarButton
            // 
            this.ClearBarButton.Caption = "Clear";
            this.ClearBarButton.Glyph = ((System.Drawing.Image)(resources.GetObject("ClearBarButton.Glyph")));
            this.ClearBarButton.Id = 3;
            this.ClearBarButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("ClearBarButton.LargeGlyph")));
            this.ClearBarButton.Name = "ClearBarButton";
            this.ClearBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ClearBarButton_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Remove(Revert)";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // orderRibbonPageOrderView
            // 
            this.orderRibbonPageOrderView.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.orderRibbonPageFileGroup,
            this.orderRibbonPageOrderGroup});
            this.orderRibbonPageOrderView.MergeOrder = 50;
            this.orderRibbonPageOrderView.Name = "orderRibbonPageOrderView";
            this.orderRibbonPageOrderView.Text = "RibbonMerge";
            // 
            // orderRibbonPageFileGroup
            // 
            this.orderRibbonPageFileGroup.ItemLinks.Add(this.orderSaveBarButton);
            this.orderRibbonPageFileGroup.ItemLinks.Add(this.orderSaveAndNewBarButton);
            this.orderRibbonPageFileGroup.ItemLinks.Add(this.ClearBarButton);
            this.orderRibbonPageFileGroup.MergeOrder = 50;
            this.orderRibbonPageFileGroup.Name = "orderRibbonPageFileGroup";
            this.orderRibbonPageFileGroup.Text = "File";
            // 
            // orderRibbonPageOrderGroup
            // 
            this.orderRibbonPageOrderGroup.ItemLinks.Add(this.barButtonItem1);
            this.orderRibbonPageOrderGroup.MergeOrder = 60;
            this.orderRibbonPageOrderGroup.Name = "orderRibbonPageOrderGroup";
            this.orderRibbonPageOrderGroup.Text = "Edit";
            // 
            // orderRibbonStatusBar
            // 
            this.orderRibbonStatusBar.Location = new System.Drawing.Point(0, 736);
            this.orderRibbonStatusBar.Name = "orderRibbonStatusBar";
            this.orderRibbonStatusBar.Ribbon = this.orderRibbon;
            this.orderRibbonStatusBar.Size = new System.Drawing.Size(1014, 31);
            // 
            // orderViewLayoutControl
            // 
            this.orderViewLayoutControl.Controls.Add(this.clientLookUpEdit);
            this.orderViewLayoutControl.Controls.Add(this.addCommentButton);
            this.orderViewLayoutControl.Controls.Add(this.newCommentTextBox);
            this.orderViewLayoutControl.Controls.Add(this.commentsListBox);
            this.orderViewLayoutControl.Controls.Add(this.orderGridControl);
            this.orderViewLayoutControl.Controls.Add(this.orderDateEdit);
            this.orderViewLayoutControl.Controls.Add(this.orderNumberTextEdit);
            this.orderViewLayoutControl.Controls.Add(this.orderStatusLookUpEdit);
            this.orderViewLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderViewLayoutControl.Location = new System.Drawing.Point(0, 122);
            this.orderViewLayoutControl.Name = "orderViewLayoutControl";
            this.orderViewLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(606, 162, 405, 343);
            this.orderViewLayoutControl.Root = this.layoutControlGroup;
            this.orderViewLayoutControl.Size = new System.Drawing.Size(1014, 614);
            this.orderViewLayoutControl.TabIndex = 2;
            this.orderViewLayoutControl.Text = "layoutControl1";
            // 
            // clientLookUpEdit
            // 
            this.clientLookUpEdit.Location = new System.Drawing.Point(15, 169);
            this.clientLookUpEdit.MenuManager = this.orderRibbon;
            this.clientLookUpEdit.Name = "clientLookUpEdit";
            this.clientLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.clientLookUpEdit.Size = new System.Drawing.Size(326, 20);
            this.clientLookUpEdit.StyleController = this.orderViewLayoutControl;
            this.clientLookUpEdit.TabIndex = 12;
            // 
            // addCommentButton
            // 
            this.addCommentButton.Location = new System.Drawing.Point(842, 485);
            this.addCommentButton.Name = "addCommentButton";
            this.addCommentButton.Size = new System.Drawing.Size(148, 105);
            this.addCommentButton.StyleController = this.orderViewLayoutControl;
            this.addCommentButton.TabIndex = 11;
            this.addCommentButton.Text = "Add comment";
            // 
            // newCommentTextBox
            // 
            this.newCommentTextBox.Location = new System.Drawing.Point(365, 485);
            this.newCommentTextBox.Multiline = true;
            this.newCommentTextBox.Name = "newCommentTextBox";
            this.newCommentTextBox.Size = new System.Drawing.Size(473, 105);
            this.newCommentTextBox.TabIndex = 10;
            // 
            // commentsListBox
            // 
            this.commentsListBox.Location = new System.Drawing.Point(365, 46);
            this.commentsListBox.Name = "commentsListBox";
            this.commentsListBox.Size = new System.Drawing.Size(625, 435);
            this.commentsListBox.StyleController = this.orderViewLayoutControl;
            this.commentsListBox.TabIndex = 9;
            // 
            // orderGridControl
            // 
            this.orderGridControl.Location = new System.Drawing.Point(365, 46);
            this.orderGridControl.MainView = this.orderGridView;
            this.orderGridControl.MenuManager = this.orderRibbon;
            this.orderGridControl.Name = "orderGridControl";
            this.orderGridControl.Size = new System.Drawing.Size(625, 544);
            this.orderGridControl.TabIndex = 8;
            this.orderGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.orderGridView});
            // 
            // orderGridView
            // 
            this.orderGridView.GridControl = this.orderGridControl;
            this.orderGridView.Name = "orderGridView";
            // 
            // orderDateEdit
            // 
            this.orderDateEdit.EditValue = null;
            this.orderDateEdit.Location = new System.Drawing.Point(15, 123);
            this.orderDateEdit.MenuManager = this.orderRibbon;
            this.orderDateEdit.Name = "orderDateEdit";
            this.orderDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.orderDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.orderDateEdit.Size = new System.Drawing.Size(326, 20);
            this.orderDateEdit.StyleController = this.orderViewLayoutControl;
            this.orderDateEdit.TabIndex = 6;
            // 
            // orderNumberTextEdit
            // 
            this.orderNumberTextEdit.Location = new System.Drawing.Point(15, 31);
            this.orderNumberTextEdit.MenuManager = this.orderRibbon;
            this.orderNumberTextEdit.Name = "orderNumberTextEdit";
            this.orderNumberTextEdit.Size = new System.Drawing.Size(326, 20);
            this.orderNumberTextEdit.StyleController = this.orderViewLayoutControl;
            this.orderNumberTextEdit.TabIndex = 4;
            // 
            // orderStatusLookUpEdit
            // 
            this.orderStatusLookUpEdit.EditValue = System.Drawing.Color.Empty;
            this.orderStatusLookUpEdit.Location = new System.Drawing.Point(15, 77);
            this.orderStatusLookUpEdit.MenuManager = this.orderRibbon;
            this.orderStatusLookUpEdit.Name = "orderStatusLookUpEdit";
            this.orderStatusLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.orderStatusLookUpEdit.Properties.NullText = "";
            this.orderStatusLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.orderStatusLookUpEdit.Size = new System.Drawing.Size(326, 20);
            this.orderStatusLookUpEdit.StyleController = this.orderViewLayoutControl;
            this.orderStatusLookUpEdit.TabIndex = 5;
            // 
            // layoutControlGroup
            // 
            this.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup.GroupBordersVisible = false;
            this.layoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlOrderNumberTextEdit,
            this.layoutControlStatusComboBox,
            this.layoutControlDateEdit,
            this.orderTabbedControlOrderAndCommentGroup,
            this.orderSplitter,
            this.layoutControlClientLookUp});
            this.layoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup.Name = "layoutControlGroup";
            this.layoutControlGroup.Size = new System.Drawing.Size(1014, 614);
            this.layoutControlGroup.TextVisible = false;
            // 
            // layoutControlOrderNumberTextEdit
            // 
            this.layoutControlOrderNumberTextEdit.Control = this.orderNumberTextEdit;
            this.layoutControlOrderNumberTextEdit.Location = new System.Drawing.Point(0, 0);
            this.layoutControlOrderNumberTextEdit.Name = "layoutControlOrderNumberTextEdit";
            this.layoutControlOrderNumberTextEdit.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlOrderNumberTextEdit.Size = new System.Drawing.Size(336, 46);
            this.layoutControlOrderNumberTextEdit.Text = "Order number";
            this.layoutControlOrderNumberTextEdit.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlOrderNumberTextEdit.TextSize = new System.Drawing.Size(67, 13);
            // 
            // layoutControlStatusComboBox
            // 
            this.layoutControlStatusComboBox.Control = this.orderStatusLookUpEdit;
            this.layoutControlStatusComboBox.Location = new System.Drawing.Point(0, 46);
            this.layoutControlStatusComboBox.Name = "layoutControlStatusComboBox";
            this.layoutControlStatusComboBox.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlStatusComboBox.Size = new System.Drawing.Size(336, 46);
            this.layoutControlStatusComboBox.Text = "Status";
            this.layoutControlStatusComboBox.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlStatusComboBox.TextSize = new System.Drawing.Size(67, 13);
            // 
            // layoutControlDateEdit
            // 
            this.layoutControlDateEdit.Control = this.orderDateEdit;
            this.layoutControlDateEdit.Location = new System.Drawing.Point(0, 92);
            this.layoutControlDateEdit.Name = "layoutControlDateEdit";
            this.layoutControlDateEdit.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlDateEdit.Size = new System.Drawing.Size(336, 46);
            this.layoutControlDateEdit.Text = "Date";
            this.layoutControlDateEdit.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlDateEdit.TextSize = new System.Drawing.Size(67, 13);
            // 
            // orderTabbedControlOrderAndCommentGroup
            // 
            this.orderTabbedControlOrderAndCommentGroup.Location = new System.Drawing.Point(341, 0);
            this.orderTabbedControlOrderAndCommentGroup.Name = "orderTabbedControlOrderAndCommentGroup";
            this.orderTabbedControlOrderAndCommentGroup.SelectedTabPage = this.layoutControlCommentsList;
            this.orderTabbedControlOrderAndCommentGroup.SelectedTabPageIndex = 1;
            this.orderTabbedControlOrderAndCommentGroup.Size = new System.Drawing.Size(653, 594);
            this.orderTabbedControlOrderAndCommentGroup.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlDataGrid,
            this.layoutControlCommentsList});
            // 
            // layoutControlCommentsList
            // 
            this.layoutControlCommentsList.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlCommentListBox,
            this.layoutControlNewCommentTextBox,
            this.layoutControlAddNewCommentButton});
            this.layoutControlCommentsList.Location = new System.Drawing.Point(0, 0);
            this.layoutControlCommentsList.Name = "layoutControlCommentsList";
            this.layoutControlCommentsList.Size = new System.Drawing.Size(629, 548);
            this.layoutControlCommentsList.Text = "Comments";
            // 
            // layoutControlCommentListBox
            // 
            this.layoutControlCommentListBox.Control = this.commentsListBox;
            this.layoutControlCommentListBox.Location = new System.Drawing.Point(0, 0);
            this.layoutControlCommentListBox.Name = "layoutControlCommentListBox";
            this.layoutControlCommentListBox.Size = new System.Drawing.Size(629, 439);
            this.layoutControlCommentListBox.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlCommentListBox.TextVisible = false;
            // 
            // layoutControlNewCommentTextBox
            // 
            this.layoutControlNewCommentTextBox.Control = this.newCommentTextBox;
            this.layoutControlNewCommentTextBox.Location = new System.Drawing.Point(0, 439);
            this.layoutControlNewCommentTextBox.MaxSize = new System.Drawing.Size(477, 109);
            this.layoutControlNewCommentTextBox.MinSize = new System.Drawing.Size(477, 109);
            this.layoutControlNewCommentTextBox.Name = "layoutControlNewCommentTextBox";
            this.layoutControlNewCommentTextBox.Size = new System.Drawing.Size(477, 109);
            this.layoutControlNewCommentTextBox.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlNewCommentTextBox.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlNewCommentTextBox.TextVisible = false;
            // 
            // layoutControlAddNewCommentButton
            // 
            this.layoutControlAddNewCommentButton.Control = this.addCommentButton;
            this.layoutControlAddNewCommentButton.Location = new System.Drawing.Point(477, 439);
            this.layoutControlAddNewCommentButton.MaxSize = new System.Drawing.Size(152, 109);
            this.layoutControlAddNewCommentButton.MinSize = new System.Drawing.Size(152, 109);
            this.layoutControlAddNewCommentButton.Name = "layoutControlAddNewCommentButton";
            this.layoutControlAddNewCommentButton.Size = new System.Drawing.Size(152, 109);
            this.layoutControlAddNewCommentButton.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlAddNewCommentButton.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlAddNewCommentButton.TextVisible = false;
            // 
            // layoutControlDataGrid
            // 
            this.layoutControlDataGrid.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlOrderGrid});
            this.layoutControlDataGrid.Location = new System.Drawing.Point(0, 0);
            this.layoutControlDataGrid.Name = "layoutControlDataGrid";
            this.layoutControlDataGrid.Size = new System.Drawing.Size(629, 548);
            this.layoutControlDataGrid.Text = "Order";
            // 
            // layoutControlOrderGrid
            // 
            this.layoutControlOrderGrid.Control = this.orderGridControl;
            this.layoutControlOrderGrid.Location = new System.Drawing.Point(0, 0);
            this.layoutControlOrderGrid.Name = "layoutControlOrderGrid";
            this.layoutControlOrderGrid.Size = new System.Drawing.Size(629, 548);
            this.layoutControlOrderGrid.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlOrderGrid.TextVisible = false;
            // 
            // orderSplitter
            // 
            this.orderSplitter.AllowHotTrack = true;
            this.orderSplitter.Location = new System.Drawing.Point(336, 0);
            this.orderSplitter.Name = "orderSplitter";
            this.orderSplitter.Size = new System.Drawing.Size(5, 594);
            // 
            // layoutControlClientLookUp
            // 
            this.layoutControlClientLookUp.Control = this.clientLookUpEdit;
            this.layoutControlClientLookUp.Location = new System.Drawing.Point(0, 138);
            this.layoutControlClientLookUp.Name = "layoutControlClientLookUp";
            this.layoutControlClientLookUp.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlClientLookUp.Size = new System.Drawing.Size(336, 456);
            this.layoutControlClientLookUp.Text = "Client";
            this.layoutControlClientLookUp.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlClientLookUp.TextSize = new System.Drawing.Size(67, 13);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 767);
            this.Controls.Add(this.orderViewLayoutControl);
            this.Controls.Add(this.orderRibbonStatusBar);
            this.Controls.Add(this.orderRibbon);
            this.Name = "OrderForm";
            this.Ribbon = this.orderRibbon;
            this.StatusBar = this.orderRibbonStatusBar;
            this.Text = "OrderViewList";
            this.Load += new System.EventHandler(this.OrderViewList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderRibbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderViewLayoutControl)).EndInit();
            this.orderViewLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsListBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderNumberTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderStatusLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlOrderNumberTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlStatusComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlDateEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTabbedControlOrderAndCommentGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlCommentsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlCommentListBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlNewCommentTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlAddNewCommentButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlOrderGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderSplitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlClientLookUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl orderRibbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage orderRibbonPageOrderView;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup orderRibbonPageFileGroup;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar orderRibbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem orderSaveAndNewBarButton;
        private DevExpress.XtraBars.BarButtonItem orderSaveBarButton;
        private DevExpress.XtraBars.BarButtonItem ClearBarButton;
        private DevExpress.XtraLayout.LayoutControl orderViewLayoutControl;
        private DevExpress.XtraGrid.GridControl orderGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView orderGridView;
        private DevExpress.XtraEditors.DateEdit orderDateEdit;
        private DevExpress.XtraEditors.TextEdit orderNumberTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlOrderNumberTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlStatusComboBox;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlDateEdit;
        private DevExpress.XtraEditors.SimpleButton addCommentButton;
        private System.Windows.Forms.TextBox newCommentTextBox;
        private DevExpress.XtraEditors.ListBoxControl commentsListBox;
        private DevExpress.XtraLayout.TabbedControlGroup orderTabbedControlOrderAndCommentGroup;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlCommentsList;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlCommentListBox;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlNewCommentTextBox;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlAddNewCommentButton;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlDataGrid;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlOrderGrid;
        private DevExpress.XtraLayout.SplitterItem orderSplitter;
        private DevExpress.XtraEditors.LookUpEdit clientLookUpEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlClientLookUp;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup orderRibbonPageOrderGroup;
        private DevExpress.XtraEditors.LookUpEdit orderStatusLookUpEdit;
    }
}