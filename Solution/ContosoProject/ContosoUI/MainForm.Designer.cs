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
            this.ribbonClientsGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ClientsListBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.ClientBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.OrdersListBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.ExitBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.UserBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.OrderBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.UsersListBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ProductsBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.ProductBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.RibbonMerge = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonUserGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonProductsGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonOrdersGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.systemRibbonGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonClientsGroup
            // 
            this.ribbonClientsGroup.ItemLinks.Add(this.ClientsListBarButton);
            this.ribbonClientsGroup.ItemLinks.Add(this.ClientBarButton);
            this.ribbonClientsGroup.MergeOrder = 200;
            this.ribbonClientsGroup.Name = "ribbonClientsGroup";
            this.ribbonClientsGroup.Text = "Clients";
            // 
            // ClientsListBarButton
            // 
            this.ClientsListBarButton.Caption = "Clients";
            this.ClientsListBarButton.Glyph = ((System.Drawing.Image)(resources.GetObject("ClientsListBarButton.Glyph")));
            this.ClientsListBarButton.Id = 1;
            this.ClientsListBarButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("ClientsListBarButton.LargeGlyph")));
            this.ClientsListBarButton.Name = "ClientsListBarButton";
            this.ClientsListBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.clientsMenuBtn_ItemClick);
            // 
            // ClientBarButton
            // 
            this.ClientBarButton.Caption = "Client";
            this.ClientBarButton.Id = 6;
            this.ClientBarButton.Name = "ClientBarButton";
            this.ClientBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ClientBarButtonItem_ItemClick);
            // 
            // mainRibbon
            // 
            this.mainRibbon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mainRibbon.ExpandCollapseItem.Id = 0;
            this.mainRibbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainRibbon.ExpandCollapseItem,
            this.ClientsListBarButton,
            this.OrdersListBarButton,
            this.ExitBarButton,
            this.UserBarButton,
            this.OrderBarButton,
            this.UsersListBarButtonItem,
            this.ProductsBarButton,
            this.ProductBarButton,
            this.ClientBarButton});
            this.mainRibbon.Location = new System.Drawing.Point(0, 0);
            this.mainRibbon.MaxItemId = 1;
            this.mainRibbon.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.mainRibbon.Name = "mainRibbon";
            this.mainRibbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.RibbonMerge});
            this.mainRibbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbon.ShowCategoryInCaption = false;
            this.mainRibbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.True;
            this.mainRibbon.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.mainRibbon.ShowQatLocationSelector = false;
            this.mainRibbon.ShowToolbarCustomizeItem = false;
            this.mainRibbon.Size = new System.Drawing.Size(764, 143);
            this.mainRibbon.Toolbar.ShowCustomizeItem = false;
            // 
            // OrdersListBarButton
            // 
            this.OrdersListBarButton.Caption = "Orders";
            this.OrdersListBarButton.Id = 2;
            this.OrdersListBarButton.Name = "OrdersListBarButton";
            this.OrdersListBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ordersMenuBtn_ItemClick);
            // 
            // ExitBarButton
            // 
            this.ExitBarButton.Caption = "Exit";
            this.ExitBarButton.Id = 3;
            this.ExitBarButton.Name = "ExitBarButton";
            this.ExitBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ExitBarButton_ItemClick);
            // 
            // UserBarButton
            // 
            this.UserBarButton.Caption = "User";
            this.UserBarButton.Glyph = ((System.Drawing.Image)(resources.GetObject("UserBarButton.Glyph")));
            this.UserBarButton.Id = 1;
            this.UserBarButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("UserBarButton.LargeGlyph")));
            this.UserBarButton.Name = "UserBarButton";
            this.UserBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barUserButton_ItemClick);
            // 
            // OrderBarButton
            // 
            this.OrderBarButton.Caption = "Order";
            this.OrderBarButton.Id = 2;
            this.OrderBarButton.Name = "OrderBarButton";
            this.OrderBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
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
            // ProductsBarButton
            // 
            this.ProductsBarButton.Caption = "Products";
            this.ProductsBarButton.Id = 4;
            this.ProductsBarButton.Name = "ProductsBarButton";
            this.ProductsBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ProductsBarButtonItem_ItemClick);
            // 
            // ProductBarButton
            // 
            this.ProductBarButton.Caption = "Product";
            this.ProductBarButton.Id = 5;
            this.ProductBarButton.Name = "ProductBarButton";
            this.ProductBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ProductBarButtonItem_ItemClick);
            // 
            // RibbonMerge
            // 
            this.RibbonMerge.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonUserGroup,
            this.ribbonClientsGroup,
            this.ribbonProductsGroup,
            this.ribbonOrdersGroup,
            this.systemRibbonGroup});
            this.RibbonMerge.Name = "RibbonMerge";
            this.RibbonMerge.Text = "RibbonMerge";
            // 
            // ribbonUserGroup
            // 
            this.ribbonUserGroup.ItemLinks.Add(this.UsersListBarButtonItem);
            this.ribbonUserGroup.ItemLinks.Add(this.UserBarButton);
            this.ribbonUserGroup.MergeOrder = 100;
            this.ribbonUserGroup.Name = "ribbonUserGroup";
            this.ribbonUserGroup.Text = "Users";
            // 
            // ribbonProductsGroup
            // 
            this.ribbonProductsGroup.ItemLinks.Add(this.ProductsBarButton);
            this.ribbonProductsGroup.ItemLinks.Add(this.ProductBarButton);
            this.ribbonProductsGroup.MergeOrder = 300;
            this.ribbonProductsGroup.Name = "ribbonProductsGroup";
            this.ribbonProductsGroup.Text = "Products";
            // 
            // ribbonOrdersGroup
            // 
            this.ribbonOrdersGroup.ItemLinks.Add(this.OrdersListBarButton, "З");
            this.ribbonOrdersGroup.ItemLinks.Add(this.OrderBarButton);
            this.ribbonOrdersGroup.KeyTip = "Р";
            this.ribbonOrdersGroup.MergeOrder = 400;
            this.ribbonOrdersGroup.Name = "ribbonOrdersGroup";
            this.ribbonOrdersGroup.Text = "Orders";
            // 
            // systemRibbonGroup
            // 
            this.systemRibbonGroup.ItemLinks.Add(this.ExitBarButton, "В");
            this.systemRibbonGroup.KeyTip = "0";
            this.systemRibbonGroup.Name = "systemRibbonGroup";
            // 
            // xtraTabbedMdiManager
            // 
            this.xtraTabbedMdiManager.HeaderButtonsShowMode = DevExpress.XtraTab.TabButtonShowMode.WhenNeeded;
            this.xtraTabbedMdiManager.MdiParent = this;
            this.xtraTabbedMdiManager.PageRemoved += new DevExpress.XtraTabbedMdi.MdiTabPageEventHandler(this.xtraTabbedMdiManager_PageRemoved);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(0, 149);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.AllowFocused = false;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit1.Properties.UseDisabledStatePainter = false;
            this.pictureEdit1.Size = new System.Drawing.Size(764, 482);
            this.pictureEdit1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AllowMdiBar = true;
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 632);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.mainRibbon);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Ribbon = this.mainRibbon;
            this.Text = "CHAIRS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MdiChildActivate += new System.EventHandler(this.MainForm_MdiChildActivate);
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RibbonControl mainRibbon;
        private RibbonPage RibbonMerge;
        private RibbonPageGroup ribbonOrdersGroup;
        private BarButtonItem ClientsListBarButton;
        private BarButtonItem OrdersListBarButton;
        private BarButtonItem ExitBarButton;
        private RibbonPageGroup systemRibbonGroup;
        private XtraTabbedMdiManager xtraTabbedMdiManager;
        private BarButtonItem UserBarButton;
        private BarButtonItem OrderBarButton;
        private BarButtonItem UsersListBarButtonItem;
        private BarButtonItem ProductsBarButton;
        private BarButtonItem ProductBarButton;
        private BarButtonItem ClientBarButton;
        private RibbonPageGroup ribbonUserGroup;
        private RibbonPageGroup ribbonProductsGroup;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private RibbonPageGroup ribbonClientsGroup;
    }
}

