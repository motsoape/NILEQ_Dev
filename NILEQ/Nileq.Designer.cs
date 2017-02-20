namespace NILEQ
{
    partial class Nileq
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nileq));
            this.helpGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.helpButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.optionPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.settingsGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.settingsButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.reportPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.viewApplicationsPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.studyButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.feesButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.applicationPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.registerPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.registerButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.loginPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.loginButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.homePage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.application = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.studyApplication = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.jobApplication = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.apply = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // helpGroup
            // 
            this.helpGroup.ItemLinks.Add(this.helpButtonItem);
            this.helpGroup.Name = "helpGroup";
            this.helpGroup.Text = "Help";
            // 
            // helpButtonItem
            // 
            this.helpButtonItem.Caption = "Help";
            this.helpButtonItem.Id = 4;
            this.helpButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("helpButtonItem.LargeGlyph")));
            this.helpButtonItem.Name = "helpButtonItem";
            // 
            // optionPage
            // 
            this.optionPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.settingsGroup,
            this.helpGroup});
            this.optionPage.Name = "optionPage";
            this.optionPage.Text = "Options";
            // 
            // settingsGroup
            // 
            this.settingsGroup.ItemLinks.Add(this.settingsButtonItem);
            this.settingsGroup.Name = "settingsGroup";
            this.settingsGroup.Text = "Settings";
            // 
            // settingsButtonItem
            // 
            this.settingsButtonItem.Caption = "Settings";
            this.settingsButtonItem.Id = 3;
            this.settingsButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("settingsButtonItem.LargeGlyph")));
            this.settingsButtonItem.Name = "settingsButtonItem";
            // 
            // reportPage
            // 
            this.reportPage.Name = "reportPage";
            this.reportPage.Text = "Report";
            // 
            // viewApplicationsPageGroup
            // 
            this.viewApplicationsPageGroup.ItemLinks.Add(this.studyButtonItem);
            this.viewApplicationsPageGroup.ItemLinks.Add(this.feesButtonItem);
            this.viewApplicationsPageGroup.Name = "viewApplicationsPageGroup";
            this.viewApplicationsPageGroup.Text = "View Applications";
            // 
            // studyButtonItem
            // 
            this.studyButtonItem.Caption = "Study";
            this.studyButtonItem.Id = 1;
            this.studyButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("studyButtonItem.LargeGlyph")));
            this.studyButtonItem.Name = "studyButtonItem";
            // 
            // feesButtonItem
            // 
            this.feesButtonItem.Caption = "Fees";
            this.feesButtonItem.Id = 2;
            this.feesButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("feesButtonItem.LargeGlyph")));
            this.feesButtonItem.Name = "feesButtonItem";
            // 
            // applicationPage
            // 
            this.applicationPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.viewApplicationsPageGroup});
            this.applicationPage.Name = "applicationPage";
            this.applicationPage.Text = "Application";
            // 
            // registerPageGroup
            // 
            this.registerPageGroup.ItemLinks.Add(this.registerButtonItem);
            this.registerPageGroup.Name = "registerPageGroup";
            this.registerPageGroup.Text = "Register";
            // 
            // registerButtonItem
            // 
            this.registerButtonItem.Caption = "Register";
            this.registerButtonItem.Id = 6;
            this.registerButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("registerButtonItem.LargeGlyph")));
            this.registerButtonItem.Name = "registerButtonItem";
            // 
            // loginPageGroup
            // 
            this.loginPageGroup.ItemLinks.Add(this.loginButtonItem);
            this.loginPageGroup.Name = "loginPageGroup";
            this.loginPageGroup.Text = "Login";
            // 
            // loginButtonItem
            // 
            this.loginButtonItem.Caption = "Login";
            this.loginButtonItem.Id = 5;
            this.loginButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("loginButtonItem.LargeGlyph")));
            this.loginButtonItem.Name = "loginButtonItem";
            // 
            // homePage
            // 
            this.homePage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.loginPageGroup,
            this.registerPageGroup});
            this.homePage.Name = "homePage";
            this.homePage.Text = "Home";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ApplicationButtonText = null;
            // 
            // 
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.ExpandCollapseItem.Name = "";
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.studyButtonItem,
            this.feesButtonItem,
            this.settingsButtonItem,
            this.helpButtonItem,
            this.loginButtonItem,
            this.registerButtonItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 7;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.homePage,
            this.applicationPage,
            this.reportPage,
            this.optionPage});
            this.ribbonControl1.SelectedPage = this.homePage;
            this.ribbonControl1.Size = new System.Drawing.Size(635, 147);
            // 
            // application
            // 
            this.application.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.studyApplication,
            this.jobApplication});
            this.application.Name = "application";
            this.application.Text = "Application";
            // 
            // studyApplication
            // 
            this.studyApplication.ItemLinks.Add(this.barButtonItem1);
            this.studyApplication.Name = "studyApplication";
            this.studyApplication.Text = "Study Application";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = -1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // jobApplication
            // 
            this.jobApplication.ItemLinks.Add(this.barButtonItem2);
            this.jobApplication.Name = "jobApplication";
            this.jobApplication.Text = "Job Application";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Id = -1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // apply
            // 
            this.apply.Id = -1;
            this.apply.Name = "apply";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 352);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonPageGroup helpGroup;
        private DevExpress.XtraBars.BarButtonItem helpButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPage optionPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup settingsGroup;
        private DevExpress.XtraBars.BarButtonItem settingsButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPage reportPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup viewApplicationsPageGroup;
        private DevExpress.XtraBars.BarButtonItem studyButtonItem;
        private DevExpress.XtraBars.BarButtonItem feesButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPage applicationPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup registerPageGroup;
        private DevExpress.XtraBars.BarButtonItem registerButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup loginPageGroup;
        private DevExpress.XtraBars.BarButtonItem loginButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPage homePage;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage application;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup studyApplication;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup jobApplication;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem apply;
    }
}

