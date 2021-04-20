namespace QueryAndStatistics
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.查询功能ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.属性查询ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.空间查询ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.查询结果统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选中要素信息显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.鹰眼ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.路径分析ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.axLicenseControl = new ESRI.ArcGIS.Controls.AxLicenseControl();
            this.axToolbarControl = new ESRI.ArcGIS.Controls.AxToolbarControl();
            this.axTOCControl = new ESRI.ArcGIS.Controls.AxTOCControl();
            this.axMapControl = new ESRI.ArcGIS.Controls.AxMapControl();
            this.axMapControl2 = new ESRI.ArcGIS.Controls.AxMapControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl2)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("仿宋", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.查询功能ToolStripMenuItem,
            this.选中要素信息显示ToolStripMenuItem,
            this.鹰眼ToolStripMenuItem,
            this.路径分析ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(11, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1093, 48);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemOpen});
            this.文件ToolStripMenuItem.Font = new System.Drawing.Font("仿宋", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.文件ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("文件ToolStripMenuItem.Image")));
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(63, 44);
            this.文件ToolStripMenuItem.Text = "文件";
            this.文件ToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.文件ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ToolStripMenuItemOpen
            // 
            this.ToolStripMenuItemOpen.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemOpen.Image")));
            this.ToolStripMenuItemOpen.Name = "ToolStripMenuItemOpen";
            this.ToolStripMenuItemOpen.Size = new System.Drawing.Size(210, 26);
            this.ToolStripMenuItemOpen.Text = "打开地图文档";
            this.ToolStripMenuItemOpen.Click += new System.EventHandler(this.ToolStripMenuItemOpen_Click);
            // 
            // 查询功能ToolStripMenuItem
            // 
            this.查询功能ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.属性查询ToolStripMenuItem1,
            this.空间查询ToolStripMenuItem1,
            this.查询结果统计ToolStripMenuItem});
            this.查询功能ToolStripMenuItem.Font = new System.Drawing.Font("仿宋", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.查询功能ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("查询功能ToolStripMenuItem.Image")));
            this.查询功能ToolStripMenuItem.Name = "查询功能ToolStripMenuItem";
            this.查询功能ToolStripMenuItem.Size = new System.Drawing.Size(105, 44);
            this.查询功能ToolStripMenuItem.Text = "查询功能";
            this.查询功能ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // 属性查询ToolStripMenuItem1
            // 
            this.属性查询ToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("属性查询ToolStripMenuItem1.Image")));
            this.属性查询ToolStripMenuItem1.Name = "属性查询ToolStripMenuItem1";
            this.属性查询ToolStripMenuItem1.Size = new System.Drawing.Size(210, 26);
            this.属性查询ToolStripMenuItem1.Text = "属性查询";
            this.属性查询ToolStripMenuItem1.Click += new System.EventHandler(this.属性查询ToolStripMenuItem1_Click);
            // 
            // 空间查询ToolStripMenuItem1
            // 
            this.空间查询ToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("空间查询ToolStripMenuItem1.Image")));
            this.空间查询ToolStripMenuItem1.Name = "空间查询ToolStripMenuItem1";
            this.空间查询ToolStripMenuItem1.Size = new System.Drawing.Size(210, 26);
            this.空间查询ToolStripMenuItem1.Text = "空间查询";
            this.空间查询ToolStripMenuItem1.Click += new System.EventHandler(this.空间查询ToolStripMenuItem1_Click);
            // 
            // 查询结果统计ToolStripMenuItem
            // 
            this.查询结果统计ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("查询结果统计ToolStripMenuItem.Image")));
            this.查询结果统计ToolStripMenuItem.Name = "查询结果统计ToolStripMenuItem";
            this.查询结果统计ToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.查询结果统计ToolStripMenuItem.Text = "查询结果统计";
            this.查询结果统计ToolStripMenuItem.Click += new System.EventHandler(this.查询结果统计ToolStripMenuItem_Click);
            // 
            // 选中要素信息显示ToolStripMenuItem
            // 
            this.选中要素信息显示ToolStripMenuItem.Font = new System.Drawing.Font("仿宋", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.选中要素信息显示ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("选中要素信息显示ToolStripMenuItem.Image")));
            this.选中要素信息显示ToolStripMenuItem.Name = "选中要素信息显示ToolStripMenuItem";
            this.选中要素信息显示ToolStripMenuItem.Size = new System.Drawing.Size(126, 44);
            this.选中要素信息显示ToolStripMenuItem.Text = "查看属性表";
            this.选中要素信息显示ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.选中要素信息显示ToolStripMenuItem.Click += new System.EventHandler(this.选中要素信息显示ToolStripMenuItem_Click);
            // 
            // 鹰眼ToolStripMenuItem
            // 
            this.鹰眼ToolStripMenuItem.Font = new System.Drawing.Font("仿宋", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.鹰眼ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("鹰眼ToolStripMenuItem.Image")));
            this.鹰眼ToolStripMenuItem.Name = "鹰眼ToolStripMenuItem";
            this.鹰眼ToolStripMenuItem.Size = new System.Drawing.Size(105, 44);
            this.鹰眼ToolStripMenuItem.Text = "鹰眼视图";
            this.鹰眼ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.鹰眼ToolStripMenuItem.Click += new System.EventHandler(this.鹰眼ToolStripMenuItem_Click);
            // 
            // 路径分析ToolStripMenuItem
            // 
            this.路径分析ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("路径分析ToolStripMenuItem.Image")));
            this.路径分析ToolStripMenuItem.Name = "路径分析ToolStripMenuItem";
            this.路径分析ToolStripMenuItem.Size = new System.Drawing.Size(105, 44);
            this.路径分析ToolStripMenuItem.Text = "路径分析";
            this.路径分析ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.路径分析ToolStripMenuItem.Click += new System.EventHandler(this.路径分析ToolStripMenuItem_Click);
            // 
            // axLicenseControl
            // 
            this.axLicenseControl.Enabled = true;
            this.axLicenseControl.Location = new System.Drawing.Point(600, 150);
            this.axLicenseControl.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.axLicenseControl.Name = "axLicenseControl";
            this.axLicenseControl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControl.OcxState")));
            this.axLicenseControl.Size = new System.Drawing.Size(32, 32);
            this.axLicenseControl.TabIndex = 1;
            // 
            // axToolbarControl
            // 
            this.axToolbarControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.axToolbarControl.Location = new System.Drawing.Point(0, 48);
            this.axToolbarControl.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.axToolbarControl.Name = "axToolbarControl";
            this.axToolbarControl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axToolbarControl.OcxState")));
            this.axToolbarControl.Size = new System.Drawing.Size(1093, 28);
            this.axToolbarControl.TabIndex = 2;
            // 
            // axTOCControl
            // 
            this.axTOCControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axTOCControl.Location = new System.Drawing.Point(0, 0);
            this.axTOCControl.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.axTOCControl.Name = "axTOCControl";
            this.axTOCControl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTOCControl.OcxState")));
            this.axTOCControl.Size = new System.Drawing.Size(382, 572);
            this.axTOCControl.TabIndex = 3;
            this.axTOCControl.OnMouseDown += new ESRI.ArcGIS.Controls.ITOCControlEvents_Ax_OnMouseDownEventHandler(this.axTOCControl_OnMouseDown);
            // 
            // axMapControl
            // 
            this.axMapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axMapControl.Location = new System.Drawing.Point(0, 0);
            this.axMapControl.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.axMapControl.Name = "axMapControl";
            this.axMapControl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl.OcxState")));
            this.axMapControl.Size = new System.Drawing.Size(705, 572);
            this.axMapControl.TabIndex = 4;
            this.axMapControl.OnExtentUpdated += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnExtentUpdatedEventHandler(this.axMapControl_OnExtentUpdated);
            this.axMapControl.OnMapReplaced += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMapReplacedEventHandler(this.axMapControl_OnMapReplaced);
            // 
            // axMapControl2
            // 
            this.axMapControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axMapControl2.Location = new System.Drawing.Point(0, 0);
            this.axMapControl2.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.axMapControl2.Name = "axMapControl2";
            this.axMapControl2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl2.OcxState")));
            this.axMapControl2.Size = new System.Drawing.Size(150, 46);
            this.axMapControl2.TabIndex = 5;
            this.axMapControl2.OnMouseDown += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseDownEventHandler(this.axMapControl2_OnMouseDown);
            this.axMapControl2.OnMouseMove += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseMoveEventHandler(this.axMapControl2_OnMouseMove);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 76);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.axMapControl);
            this.splitContainer1.Size = new System.Drawing.Size(1093, 572);
            this.splitContainer1.SplitterDistance = 382;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 6;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.axTOCControl);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.axMapControl2);
            this.splitContainer2.Panel2Collapsed = true;
            this.splitContainer2.Size = new System.Drawing.Size(382, 572);
            this.splitContainer2.SplitterDistance = 186;
            this.splitContainer2.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1093, 648);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.axToolbarControl);
            this.Controls.Add(this.axLicenseControl);
            this.Controls.Add(this.menuStrip);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("仿宋", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主界面";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl2)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl;
        private ESRI.ArcGIS.Controls.AxToolbarControl axToolbarControl;
        private ESRI.ArcGIS.Controls.AxTOCControl axTOCControl;
        private ESRI.ArcGIS.Controls.AxMapControl axMapControl;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem 鹰眼ToolStripMenuItem;
        private ESRI.ArcGIS.Controls.AxMapControl axMapControl2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStripMenuItem 查询功能ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 属性查询ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 空间查询ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 查询结果统计ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选中要素信息显示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 路径分析ToolStripMenuItem;
    }
}

