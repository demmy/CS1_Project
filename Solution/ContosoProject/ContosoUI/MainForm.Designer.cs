using System.ComponentModel;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraTabbedMdi;

namespace ContosoUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainRibbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.clientsMenuBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ordersMenuBtn = new DevExpress.XtraBars.BarButtonItem();
            this.exitMenuBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barUserButton = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.UsersListBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ProductsBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ProductBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.Р = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.workRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.systemRibbonGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.ClientBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainRibbon
            // 
            this.mainRibbon.ExpandCollapseItem.Id = 0;
            this.mainRibbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainRibbon.ExpandCollapseItem,
            this.clientsMenuBtn,
            this.ordersMenuBtn,
            this.exitMenuBtn,
            this.barUserButton,
            this.barButtonItem1,
            this.UsersListBarButtonItem,
            this.ProductsBarButtonItem,
            this.ProductBarButtonItem,
            this.ClientBarButtonItem});
            this.mainRibbon.Location = new System.Drawing.Point(0, 0);
            this.mainRibbon.MaxItemId = 7;
            this.mainRibbon.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.mainRibbon.Name = "mainRibbon";
            this.mainRibbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.Р});
            this.mainRibbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbon.ShowCategoryInCaption = false;
            this.mainRibbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbon.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.mainRibbon.ShowQatLocationSelector = false;
            this.mainRibbon.ShowToolbarCustomizeItem = false;
            this.mainRibbon.Size = new System.Drawing.Size(902, 143);
            this.mainRibbon.Toolbar.ShowCustomizeItem = false;
            // 
            // clientsMenuBtn
            // 
            this.clientsMenuBtn.Caption = "Clients";
            this.clientsMenuBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("clientsMenuBtn.Glyph")));
            this.clientsMenuBtn.Id = 1;
            this.clientsMenuBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("clientsMenuBtn.LargeGlyph")));
            this.clientsMenuBtn.Name = "clientsMenuBtn";
            this.clientsMenuBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.clientsMenuBtn_ItemClick);
            // 
            // ordersMenuBtn
            // 
            this.ordersMenuBtn.Caption = "Orders";
            this.ordersMenuBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("ordersMenuBtn.Glyph")));
            this.ordersMenuBtn.Id = 2;
            this.ordersMenuBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("ordersMenuBtn.LargeGlyph")));
            this.ordersMenuBtn.Name = "ordersMenuBtn";
            this.ordersMenuBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ordersMenuBtn_ItemClick);
            // 
            // exitMenuBtn
            // 
            this.exitMenuBtn.Caption = "Выход";
            this.exitMenuBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("exitMenuBtn.Glyph")));
            this.exitMenuBtn.Id = 3;
            this.exitMenuBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("exitMenuBtn.LargeGlyph")));
            this.exitMenuBtn.Name = "exitMenuBtn";
            this.exitMenuBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.exitMenuBtn_ItemClick);
            // 
            // barUserButton
            // 
            this.barUserButton.Caption = "User";
            this.barUserButton.Glyph = ((System.Drawing.Image)(resources.GetObject("barUserButton.Glyph")));
            this.barUserButton.Id = 1;
            this.barUserButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barUserButton.LargeGlyph")));
            this.barUserButton.Name = "barUserButton";
            this.barUserButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barUserButton_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Order";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // UsersListBarButtonItem
            // 
            this.UsersListBarButtonItem.Caption = "Users";
            this.UsersListBarButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("UsersListBarButtonItem.Glyph")));
            this.UsersListBarButtonItem.Id = 3;
            this.UsersListBarButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("UsersListBarButtonItem.LargeGlyph")));
            this.UsersListBarButtonItem.Name = "UsersListBarButtonItem";
            this.UsersListBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.UsersListBarButtonItem_ItemClick);
            // 
            // ProductsBarButtonItem
            // 
            this.ProductsBarButtonItem.Caption = "Products";
            this.ProductsBarButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("ProductsBarButtonItem.Glyph")));
            this.ProductsBarButtonItem.Id = 4;
            this.ProductsBarButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("ProductsBarButtonItem.LargeGlyph")));
            this.ProductsBarButtonItem.Name = "ProductsBarButtonItem";
            this.ProductsBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ProductsBarButtonItem_ItemClick);
            // 
            // ProductBarButtonItem
            // 
            this.ProductBarButtonItem.Caption = "Product";
            this.ProductBarButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("ProductBarButtonItem.Glyph")));
            this.ProductBarButtonItem.Id = 5;
            this.ProductBarButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("ProductBarButtonItem.LargeGlyph")));
            this.ProductBarButtonItem.Name = "ProductBarButtonItem";
            this.ProductBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ProductBarButtonItem_ItemClick);
            // 
            // Р
            // 
            this.Р.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.workRibbonPageGroup,
            this.systemRibbonGroup});
            this.Р.Name = "Р";
            this.Р.Text = "RibbonMerge";
            // 
            // workRibbonPageGroup
            // 
            this.workRibbonPageGroup.ItemLinks.Add(this.UsersListBarButtonItem);
            this.workRibbonPageGroup.ItemLinks.Add(this.barUserButton);
            this.workRibbonPageGroup.ItemLinks.Add(this.clientsMenuBtn, "К");
            this.workRibbonPageGroup.ItemLinks.Add(this.ClientBarButtonItem);
            this.workRibbonPageGroup.ItemLinks.Add(this.ordersMenuBtn, "З");
            this.workRibbonPageGroup.ItemLinks.Add(this.barButtonItem1);
            this.workRibbonPageGroup.ItemLinks.Add(this.ProductsBarButtonItem);
            this.workRibbonPageGroup.ItemLinks.Add(this.ProductBarButtonItem);
            this.workRibbonPageGroup.KeyTip = "Р";
            this.workRibbonPageGroup.MergeOrder = 999;
            this.workRibbonPageGroup.Name = "workRibbonPageGroup";
            this.workRibbonPageGroup.Text = "Работа";
            // 
            // systemRibbonGroup
            // 
            this.systemRibbonGroup.ItemLinks.Add(this.exitMenuBtn, "В");
            this.systemRibbonGroup.KeyTip = "0";
            this.systemRibbonGroup.MergeOrder = 999;
            this.systemRibbonGroup.Name = "systemRibbonGroup";
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.ItemLinks.Add(this.ordersMenuBtn);
            this.applicationMenu1.ItemLinks.Add(this.clientsMenuBtn);
            this.applicationMenu1.Name = "applicationMenu1";
            this.applicationMenu1.Ribbon = this.mainRibbon;
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InTabControlHeader;
            this.xtraTabbedMdiManager1.HeaderButtonsShowMode = DevExpress.XtraTab.TabButtonShowMode.WhenNeeded;
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // ClientBarButtonItem
            // 
            this.ClientBarButtonItem.Caption = "Client";
            this.ClientBarButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("ClientBarButtonItem.Glyph")));
            this.ClientBarButtonItem.Id = 6;
            this.ClientBarButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("ClientBarButtonItem.LargeGlyph")));
            this.ClientBarButtonItem.Name = "ClientBarButtonItem";
            this.ClientBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ClientBarButtonItem_ItemClick);
            // 
            // MainForm
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AllowMdiBar = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 566);
            this.Controls.Add(this.mainRibbon);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.mainRibbon.SetPopupContextMenu(this, this.applicationMenu1);
            this.Ribbon = this.mainRibbon;
            this.Text = "CHAIRS";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RibbonControl mainRibbon;
        private RibbonPage Р;
        private RibbonPageGroup workRibbonPageGroup;
        private BarButtonItem clientsMenuBtn;
        private BarButtonItem ordersMenuBtn;
        private BarButtonItem exitMenuBtn;
        private RibbonPageGroup systemRibbonGroup;
        private XtraTabbedMdiManager xtraTabbedMdiManager1;
        private ApplicationMenu applicationMenu1;
        private BarButtonItem barUserButton;
        private BarButtonItem barButtonItem1;
        private BarButtonItem UsersListBarButtonItem;
        private BarButtonItem ProductsBarButtonItem;
        private BarButtonItem ProductBarButtonItem;
        private BarButtonItem ClientBarButtonItem;
    }
}

