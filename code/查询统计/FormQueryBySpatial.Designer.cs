namespace QueryAndStatistics
{
    partial class FormQueryBySpatial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQueryBySpatial));
            this.labelDescription = new System.Windows.Forms.Label();
            this.checkedListBoxTargetLayers = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxSelectable = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSourceLayer = new System.Windows.Forms.ComboBox();
            this.checkBoxUseSelected = new System.Windows.Forms.CheckBox();
            this.labelSelectedCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxMethods = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDescription
            // 
            this.labelDescription.Location = new System.Drawing.Point(16, 13);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(601, 50);
            this.labelDescription.TabIndex = 0;
            this.labelDescription.Text = "根据空间位置选择是使用源图层中的要素与目标图层的空间关系（如覆盖、相交等），在目标图层中选择要素的操作。";
            // 
            // checkedListBoxTargetLayers
            // 
            this.checkedListBoxTargetLayers.FormattingEnabled = true;
            this.checkedListBoxTargetLayers.Location = new System.Drawing.Point(19, 106);
            this.checkedListBoxTargetLayers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkedListBoxTargetLayers.Name = "checkedListBoxTargetLayers";
            this.checkedListBoxTargetLayers.Size = new System.Drawing.Size(595, 234);
            this.checkedListBoxTargetLayers.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "目标图层：";
            // 
            // checkBoxSelectable
            // 
            this.checkBoxSelectable.AutoSize = true;
            this.checkBoxSelectable.Location = new System.Drawing.Point(23, 360);
            this.checkBoxSelectable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxSelectable.Name = "checkBoxSelectable";
            this.checkBoxSelectable.Size = new System.Drawing.Size(178, 23);
            this.checkBoxSelectable.TabIndex = 3;
            this.checkBoxSelectable.Text = "只列出可选图层";
            this.checkBoxSelectable.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 408);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "源图层：";
            // 
            // comboBoxSourceLayer
            // 
            this.comboBoxSourceLayer.FormattingEnabled = true;
            this.comboBoxSourceLayer.Location = new System.Drawing.Point(19, 434);
            this.comboBoxSourceLayer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxSourceLayer.Name = "comboBoxSourceLayer";
            this.comboBoxSourceLayer.Size = new System.Drawing.Size(595, 26);
            this.comboBoxSourceLayer.TabIndex = 5;
            // 
            // checkBoxUseSelected
            // 
            this.checkBoxUseSelected.AutoSize = true;
            this.checkBoxUseSelected.Enabled = false;
            this.checkBoxUseSelected.Location = new System.Drawing.Point(23, 474);
            this.checkBoxUseSelected.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxUseSelected.Name = "checkBoxUseSelected";
            this.checkBoxUseSelected.Size = new System.Drawing.Size(199, 23);
            this.checkBoxUseSelected.TabIndex = 6;
            this.checkBoxUseSelected.Text = "使用被选择的要素";
            this.checkBoxUseSelected.UseVisualStyleBackColor = true;
            // 
            // labelSelectedCount
            // 
            this.labelSelectedCount.AutoSize = true;
            this.labelSelectedCount.Location = new System.Drawing.Point(304, 480);
            this.labelSelectedCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSelectedCount.Name = "labelSelectedCount";
            this.labelSelectedCount.Size = new System.Drawing.Size(253, 19);
            this.labelSelectedCount.TabIndex = 7;
            this.labelSelectedCount.Text = "(当前有 0 个要素被选择)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 521);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "空间选择方法：";
            // 
            // comboBoxMethods
            // 
            this.comboBoxMethods.FormattingEnabled = true;
            this.comboBoxMethods.Items.AddRange(new object[] {
            "目标图层的要素与源图层的要素相交 (intersect)",
            "目标图层的要素位于源图层要素的一定距离范围内 (within)",
            "目标图层的要素包含源图层的要素 (contain)",
            "目标图层的要素在源图层的要素内 (within)",
            "目标图层的要素与源图层要素的边界相接 (touch)",
            "目标图层的要素被源图层要素的轮廓穿过 (cross)"});
            this.comboBoxMethods.Location = new System.Drawing.Point(19, 547);
            this.comboBoxMethods.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxMethods.Name = "comboBoxMethods";
            this.comboBoxMethods.Size = new System.Drawing.Size(595, 26);
            this.comboBoxMethods.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(23, 697);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(593, 5);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(264, 718);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 37);
            this.buttonOK.TabIndex = 33;
            this.buttonOK.Text = "确定";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(391, 718);
            this.buttonApply.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(100, 37);
            this.buttonApply.TabIndex = 34;
            this.buttonApply.Text = "应用";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(517, 718);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(100, 37);
            this.buttonClose.TabIndex = 35;
            this.buttonClose.Text = "关闭";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormQueryBySpatial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 770);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxMethods);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelSelectedCount);
            this.Controls.Add(this.checkBoxUseSelected);
            this.Controls.Add(this.comboBoxSourceLayer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxSelectable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBoxTargetLayers);
            this.Controls.Add(this.labelDescription);
            this.Font = new System.Drawing.Font("仿宋", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormQueryBySpatial";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "空间查询";
            this.Load += new System.EventHandler(this.FormQueryBySpatial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.CheckedListBox checkedListBoxTargetLayers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxSelectable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSourceLayer;
        private System.Windows.Forms.CheckBox checkBoxUseSelected;
        private System.Windows.Forms.Label labelSelectedCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxMethods;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonClose;
    }
}