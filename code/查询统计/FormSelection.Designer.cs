namespace QueryAndStatistics
{
    partial class FormSelection
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("图层");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSelection));
            this.treeViewLayers = new System.Windows.Forms.TreeView();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.labelLayerSelectionCount = new System.Windows.Forms.Label();
            this.labelMapSelectionCount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // treeViewLayers
            // 
            this.treeViewLayers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeViewLayers.Location = new System.Drawing.Point(0, 0);
            this.treeViewLayers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.treeViewLayers.Name = "treeViewLayers";
            treeNode1.Name = "Layers";
            treeNode1.Text = "图层";
            this.treeViewLayers.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeViewLayers.Size = new System.Drawing.Size(306, 452);
            this.treeViewLayers.TabIndex = 0;
            this.treeViewLayers.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(309, 0);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(951, 595);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // labelLayerSelectionCount
            // 
            this.labelLayerSelectionCount.AutoSize = true;
            this.labelLayerSelectionCount.Location = new System.Drawing.Point(983, 605);
            this.labelLayerSelectionCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLayerSelectionCount.Name = "labelLayerSelectionCount";
            this.labelLayerSelectionCount.Size = new System.Drawing.Size(273, 19);
            this.labelLayerSelectionCount.TabIndex = 2;
            this.labelLayerSelectionCount.Text = "当前图层选择了 0 个要素。";
            // 
            // labelMapSelectionCount
            // 
            this.labelMapSelectionCount.AutoSize = true;
            this.labelMapSelectionCount.Location = new System.Drawing.Point(337, 605);
            this.labelMapSelectionCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMapSelectionCount.Name = "labelMapSelectionCount";
            this.labelMapSelectionCount.Size = new System.Drawing.Size(294, 19);
            this.labelMapSelectionCount.TabIndex = 3;
            this.labelMapSelectionCount.Text = "当前地图共选择了 0 个要素。";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 527);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "导出Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 636);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelMapSelectionCount);
            this.Controls.Add(this.labelLayerSelectionCount);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.treeViewLayers);
            this.Font = new System.Drawing.Font("仿宋", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查看属性表";
            this.Load += new System.EventHandler(this.FormSelection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewLayers;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label labelLayerSelectionCount;
        private System.Windows.Forms.Label labelMapSelectionCount;
        private System.Windows.Forms.Button button1;
    }
}