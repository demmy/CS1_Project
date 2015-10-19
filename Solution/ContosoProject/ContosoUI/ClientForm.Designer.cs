namespace ContosoUI
{
    partial class ClientForm
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
            this.layoutControl = new DevExpress.XtraLayout.LayoutControlGroup();
            this.personalGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.cityTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.firstNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.isActiveCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.lastNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.middleNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.middleNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.adressRichTextBox = new System.Windows.Forms.RichTextBox();
            this.adressLabel = new System.Windows.Forms.Label();
            this.telephonesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.telephonesLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.closeButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveCloseButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.ordersGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.orderNumberGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ordersLabel = new System.Windows.Forms.Label();
            this.PersonalDataGroupLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.closeButtonLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.saveAndCloseButtonLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.saveButtonLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.ordersDataGridLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.ordersLabelLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.CommentsGroupLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.commentsGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.commentsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.addCommentButton = new DevExpress.XtraEditors.SimpleButton();
            this.newCommentTextEdit = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalGroupControl)).BeginInit();
            this.personalGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isActiveCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonalDataGroupLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButtonLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveAndCloseButtonLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButtonLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersLabelLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommentsGroupLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsGroupControl)).BeginInit();
            this.commentsGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newCommentTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.commentsGroupControl);
            this.layoutControl1.Controls.Add(this.personalGroupControl);
            this.layoutControl1.Controls.Add(this.closeButton);
            this.layoutControl1.Controls.Add(this.saveCloseButton);
            this.layoutControl1.Controls.Add(this.saveButton);
            this.layoutControl1.Controls.Add(this.ordersGridControl);
            this.layoutControl1.Controls.Add(this.ordersLabel);
            this.layoutControl1.Location = new System.Drawing.Point(2, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(241, 154, 250, 350);
            this.layoutControl1.Root = this.layoutControl;
            this.layoutControl1.Size = new System.Drawing.Size(1002, 730);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControl
            // 
            this.layoutControl.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControl.GroupBordersVisible = false;
            this.layoutControl.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.CommentsGroupLayoutControlItem,
            this.PersonalDataGroupLayoutControlItem,
            this.closeButtonLayoutControlItem,
            this.saveAndCloseButtonLayoutControlItem,
            this.saveButtonLayoutControlItem,
            this.ordersDataGridLayoutControlItem,
            this.ordersLabelLayoutControlItem});
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "Root";
            this.layoutControl.Size = new System.Drawing.Size(1002, 730);
            this.layoutControl.TextVisible = false;
            // 
            // personalGroupControl
            // 
            this.personalGroupControl.Controls.Add(this.firstNameLabel);
            this.personalGroupControl.Controls.Add(this.cityTextEdit);
            this.personalGroupControl.Controls.Add(this.firstNameTextEdit);
            this.personalGroupControl.Controls.Add(this.isActiveCheckEdit);
            this.personalGroupControl.Controls.Add(this.lastNameTextEdit);
            this.personalGroupControl.Controls.Add(this.middleNameTextEdit);
            this.personalGroupControl.Controls.Add(this.middleNameLabel);
            this.personalGroupControl.Controls.Add(this.lastNameLabel);
            this.personalGroupControl.Controls.Add(this.adressRichTextBox);
            this.personalGroupControl.Controls.Add(this.adressLabel);
            this.personalGroupControl.Controls.Add(this.telephonesRichTextBox);
            this.personalGroupControl.Controls.Add(this.telephonesLabel);
            this.personalGroupControl.Controls.Add(this.cityLabel);
            this.personalGroupControl.Location = new System.Drawing.Point(12, 292);
            this.personalGroupControl.Name = "personalGroupControl";
            this.personalGroupControl.Size = new System.Drawing.Size(978, 300);
            this.personalGroupControl.TabIndex = 41;
            this.personalGroupControl.Text = "Personal data";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(13, 35);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First name";
            // 
            // cityTextEdit
            // 
            this.cityTextEdit.Location = new System.Drawing.Point(16, 197);
            this.cityTextEdit.Name = "cityTextEdit";
            this.cityTextEdit.Size = new System.Drawing.Size(123, 20);
            this.cityTextEdit.TabIndex = 33;
            // 
            // firstNameTextEdit
            // 
            this.firstNameTextEdit.Location = new System.Drawing.Point(17, 57);
            this.firstNameTextEdit.Name = "firstNameTextEdit";
            this.firstNameTextEdit.Size = new System.Drawing.Size(123, 20);
            this.firstNameTextEdit.TabIndex = 30;
            // 
            // isActiveCheckEdit
            // 
            this.isActiveCheckEdit.Location = new System.Drawing.Point(16, 249);
            this.isActiveCheckEdit.Name = "isActiveCheckEdit";
            this.isActiveCheckEdit.Properties.Caption = "Active";
            this.isActiveCheckEdit.Size = new System.Drawing.Size(75, 19);
            this.isActiveCheckEdit.TabIndex = 27;
            // 
            // lastNameTextEdit
            // 
            this.lastNameTextEdit.Location = new System.Drawing.Point(17, 150);
            this.lastNameTextEdit.Name = "lastNameTextEdit";
            this.lastNameTextEdit.Size = new System.Drawing.Size(123, 20);
            this.lastNameTextEdit.TabIndex = 32;
            // 
            // middleNameTextEdit
            // 
            this.middleNameTextEdit.Location = new System.Drawing.Point(17, 102);
            this.middleNameTextEdit.Name = "middleNameTextEdit";
            this.middleNameTextEdit.Size = new System.Drawing.Size(123, 20);
            this.middleNameTextEdit.TabIndex = 31;
            // 
            // middleNameLabel
            // 
            this.middleNameLabel.AutoSize = true;
            this.middleNameLabel.Location = new System.Drawing.Point(14, 80);
            this.middleNameLabel.Name = "middleNameLabel";
            this.middleNameLabel.Size = new System.Drawing.Size(66, 13);
            this.middleNameLabel.TabIndex = 1;
            this.middleNameLabel.Text = "Middle name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(14, 128);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(56, 13);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last name";
            // 
            // adressRichTextBox
            // 
            this.adressRichTextBox.Location = new System.Drawing.Point(163, 213);
            this.adressRichTextBox.Name = "adressRichTextBox";
            this.adressRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.adressRichTextBox.Size = new System.Drawing.Size(266, 116);
            this.adressRichTextBox.TabIndex = 13;
            this.adressRichTextBox.Text = "";
            // 
            // adressLabel
            // 
            this.adressLabel.AutoSize = true;
            this.adressLabel.Location = new System.Drawing.Point(160, 185);
            this.adressLabel.Name = "adressLabel";
            this.adressLabel.Size = new System.Drawing.Size(40, 13);
            this.adressLabel.TabIndex = 4;
            this.adressLabel.Text = "Adress";
            // 
            // telephonesRichTextBox
            // 
            this.telephonesRichTextBox.Location = new System.Drawing.Point(163, 60);
            this.telephonesRichTextBox.Name = "telephonesRichTextBox";
            this.telephonesRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.telephonesRichTextBox.Size = new System.Drawing.Size(266, 110);
            this.telephonesRichTextBox.TabIndex = 14;
            this.telephonesRichTextBox.Text = "";
            // 
            // telephonesLabel
            // 
            this.telephonesLabel.AutoSize = true;
            this.telephonesLabel.Location = new System.Drawing.Point(160, 35);
            this.telephonesLabel.Name = "telephonesLabel";
            this.telephonesLabel.Size = new System.Drawing.Size(62, 13);
            this.telephonesLabel.TabIndex = 5;
            this.telephonesLabel.Text = "Telephones";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(13, 181);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(26, 13);
            this.cityLabel.TabIndex = 3;
            this.cityLabel.Text = "City";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(12, 596);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(978, 22);
            this.closeButton.StyleController = this.layoutControl1;
            this.closeButton.TabIndex = 40;
            this.closeButton.Text = "Close";
            // 
            // saveCloseButton
            // 
            this.saveCloseButton.Location = new System.Drawing.Point(12, 622);
            this.saveCloseButton.Name = "saveCloseButton";
            this.saveCloseButton.Size = new System.Drawing.Size(978, 22);
            this.saveCloseButton.StyleController = this.layoutControl1;
            this.saveCloseButton.TabIndex = 39;
            this.saveCloseButton.Text = "Save and Close";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 648);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(978, 22);
            this.saveButton.StyleController = this.layoutControl1;
            this.saveButton.TabIndex = 38;
            this.saveButton.Text = "Save";
            // 
            // ordersGridControl
            // 
            this.ordersGridControl.Location = new System.Drawing.Point(12, 674);
            this.ordersGridControl.MainView = this.gridView1;
            this.ordersGridControl.Name = "ordersGridControl";
            this.ordersGridControl.Size = new System.Drawing.Size(978, 20);
            this.ordersGridControl.TabIndex = 37;
            this.ordersGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.orderNumberGridColumn,
            this.statusGridColumn,
            this.dateGridColumn});
            this.gridView1.GridControl = this.ordersGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // orderNumberGridColumn
            // 
            this.orderNumberGridColumn.Caption = "Order number";
            this.orderNumberGridColumn.Name = "orderNumberGridColumn";
            this.orderNumberGridColumn.Visible = true;
            this.orderNumberGridColumn.VisibleIndex = 0;
            // 
            // statusGridColumn
            // 
            this.statusGridColumn.Caption = "Status";
            this.statusGridColumn.Name = "statusGridColumn";
            this.statusGridColumn.Visible = true;
            this.statusGridColumn.VisibleIndex = 1;
            // 
            // dateGridColumn
            // 
            this.dateGridColumn.Caption = "Date";
            this.dateGridColumn.Name = "dateGridColumn";
            this.dateGridColumn.Visible = true;
            this.dateGridColumn.VisibleIndex = 2;
            // 
            // ordersLabel
            // 
            this.ordersLabel.Location = new System.Drawing.Point(12, 698);
            this.ordersLabel.Name = "ordersLabel";
            this.ordersLabel.Size = new System.Drawing.Size(978, 20);
            this.ordersLabel.TabIndex = 36;
            this.ordersLabel.Text = "Orders";
            // 
            // PersonalDataGroupLayoutControlItem
            // 
            this.PersonalDataGroupLayoutControlItem.Control = this.personalGroupControl;
            this.PersonalDataGroupLayoutControlItem.Location = new System.Drawing.Point(0, 280);
            this.PersonalDataGroupLayoutControlItem.Name = "PersonalDataGroupLayoutControlItem";
            this.PersonalDataGroupLayoutControlItem.Size = new System.Drawing.Size(982, 304);
            this.PersonalDataGroupLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.PersonalDataGroupLayoutControlItem.TextVisible = false;
            // 
            // closeButtonLayoutControlItem
            // 
            this.closeButtonLayoutControlItem.Control = this.closeButton;
            this.closeButtonLayoutControlItem.Location = new System.Drawing.Point(0, 584);
            this.closeButtonLayoutControlItem.Name = "closeButtonLayoutControlItem";
            this.closeButtonLayoutControlItem.Size = new System.Drawing.Size(982, 26);
            this.closeButtonLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.closeButtonLayoutControlItem.TextVisible = false;
            // 
            // saveAndCloseButtonLayoutControlItem
            // 
            this.saveAndCloseButtonLayoutControlItem.Control = this.saveCloseButton;
            this.saveAndCloseButtonLayoutControlItem.Location = new System.Drawing.Point(0, 610);
            this.saveAndCloseButtonLayoutControlItem.Name = "saveAndCloseButtonLayoutControlItem";
            this.saveAndCloseButtonLayoutControlItem.Size = new System.Drawing.Size(982, 26);
            this.saveAndCloseButtonLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.saveAndCloseButtonLayoutControlItem.TextVisible = false;
            // 
            // saveButtonLayoutControlItem
            // 
            this.saveButtonLayoutControlItem.Control = this.saveButton;
            this.saveButtonLayoutControlItem.Location = new System.Drawing.Point(0, 636);
            this.saveButtonLayoutControlItem.Name = "saveButtonLayoutControlItem";
            this.saveButtonLayoutControlItem.Size = new System.Drawing.Size(982, 26);
            this.saveButtonLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.saveButtonLayoutControlItem.TextVisible = false;
            // 
            // ordersDataGridLayoutControlItem
            // 
            this.ordersDataGridLayoutControlItem.Control = this.ordersGridControl;
            this.ordersDataGridLayoutControlItem.Location = new System.Drawing.Point(0, 662);
            this.ordersDataGridLayoutControlItem.Name = "ordersDataGridLayoutControlItem";
            this.ordersDataGridLayoutControlItem.Size = new System.Drawing.Size(982, 24);
            this.ordersDataGridLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.ordersDataGridLayoutControlItem.TextVisible = false;
            // 
            // ordersLabelLayoutControlItem
            // 
            this.ordersLabelLayoutControlItem.Control = this.ordersLabel;
            this.ordersLabelLayoutControlItem.Location = new System.Drawing.Point(0, 686);
            this.ordersLabelLayoutControlItem.Name = "ordersLabelLayoutControlItem";
            this.ordersLabelLayoutControlItem.Size = new System.Drawing.Size(982, 24);
            this.ordersLabelLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.ordersLabelLayoutControlItem.TextVisible = false;
            // 
            // CommentsGroupLayoutControlItem
            // 
            this.CommentsGroupLayoutControlItem.Control = this.commentsGroupControl;
            this.CommentsGroupLayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.CommentsGroupLayoutControlItem.Name = "CommentsGroupLayoutControlItem";
            this.CommentsGroupLayoutControlItem.Size = new System.Drawing.Size(982, 280);
            this.CommentsGroupLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.CommentsGroupLayoutControlItem.TextVisible = false;
            // 
            // commentsGroupControl
            // 
            this.commentsGroupControl.Controls.Add(this.commentsRichTextBox);
            this.commentsGroupControl.Controls.Add(this.addCommentButton);
            this.commentsGroupControl.Controls.Add(this.newCommentTextEdit);
            this.commentsGroupControl.Location = new System.Drawing.Point(12, 12);
            this.commentsGroupControl.Name = "commentsGroupControl";
            this.commentsGroupControl.Size = new System.Drawing.Size(978, 276);
            this.commentsGroupControl.TabIndex = 42;
            this.commentsGroupControl.Text = "Comments";
            // 
            // commentsRichTextBox
            // 
            this.commentsRichTextBox.Location = new System.Drawing.Point(16, 34);
            this.commentsRichTextBox.Name = "commentsRichTextBox";
            this.commentsRichTextBox.Size = new System.Drawing.Size(443, 208);
            this.commentsRichTextBox.TabIndex = 30;
            this.commentsRichTextBox.Text = "";
            // 
            // addCommentButton
            // 
            this.addCommentButton.Location = new System.Drawing.Point(431, 247);
            this.addCommentButton.Name = "addCommentButton";
            this.addCommentButton.Size = new System.Drawing.Size(28, 22);
            this.addCommentButton.TabIndex = 32;
            this.addCommentButton.Text = "+";
            // 
            // newCommentTextEdit
            // 
            this.newCommentTextEdit.Location = new System.Drawing.Point(15, 249);
            this.newCommentTextEdit.Name = "newCommentTextEdit";
            this.newCommentTextEdit.Size = new System.Drawing.Size(410, 20);
            this.newCommentTextEdit.TabIndex = 31;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.layoutControl1);
            this.Name = "ClientForm";
            this.Text = "Client form";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalGroupControl)).EndInit();
            this.personalGroupControl.ResumeLayout(false);
            this.personalGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isActiveCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonalDataGroupLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButtonLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveAndCloseButtonLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButtonLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersLabelLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommentsGroupLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsGroupControl)).EndInit();
            this.commentsGroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.newCommentTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.GroupControl commentsGroupControl;
        private System.Windows.Forms.RichTextBox commentsRichTextBox;
        private DevExpress.XtraEditors.SimpleButton addCommentButton;
        private DevExpress.XtraEditors.TextEdit newCommentTextEdit;
        private DevExpress.XtraEditors.GroupControl personalGroupControl;
        private System.Windows.Forms.Label firstNameLabel;
        private DevExpress.XtraEditors.TextEdit cityTextEdit;
        private DevExpress.XtraEditors.TextEdit firstNameTextEdit;
        private DevExpress.XtraEditors.CheckEdit isActiveCheckEdit;
        private DevExpress.XtraEditors.TextEdit lastNameTextEdit;
        private DevExpress.XtraEditors.TextEdit middleNameTextEdit;
        private System.Windows.Forms.Label middleNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.RichTextBox adressRichTextBox;
        private System.Windows.Forms.Label adressLabel;
        private System.Windows.Forms.RichTextBox telephonesRichTextBox;
        private System.Windows.Forms.Label telephonesLabel;
        private System.Windows.Forms.Label cityLabel;
        private DevExpress.XtraEditors.SimpleButton closeButton;
        private DevExpress.XtraEditors.SimpleButton saveCloseButton;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraGrid.GridControl ordersGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn orderNumberGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn statusGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn dateGridColumn;
        private System.Windows.Forms.Label ordersLabel;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControl;
        private DevExpress.XtraLayout.LayoutControlItem CommentsGroupLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem PersonalDataGroupLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem closeButtonLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem saveAndCloseButtonLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem saveButtonLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem ordersDataGridLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem ordersLabelLayoutControlItem;

    }
}