using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.SystemUI;
using ESRI.ArcGIS.Display;

namespace QueryAndStatistics
{
    public partial class route : Form
    {
 
        public IFeatureWorkspace pFWorkspace;
        string path = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
        public route()
        {
            InitializeComponent();
        }

        private void 打开地图文档ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //使用对话框选择要打开的mxd文档
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "ArcMap Documents (*.mxd)|*.mxd";
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    axMapControl1.LoadMxFile(filePath);
                }
            }
        }

        private void 添加障碍点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ICommand pCommand;
            pCommand = new AddNetStopsTool();
            pCommand.OnCreate(axMapControl1.Object);
            axMapControl1.CurrentTool = pCommand as ITool;
            pCommand = null;
        }

        private void 添加障碍点ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ICommand pCommand;
            pCommand = new AddNetBarriesTool();
            pCommand.OnCreate(axMapControl1.Object);
            axMapControl1.CurrentTool = pCommand as ITool;
            pCommand = null;
        }

        private void 执行分析ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ICommand pCommand;
            pCommand = new ShortPathSolveCommand();
            pCommand.OnCreate(axMapControl1.Object);
            pCommand.OnClick();
            pCommand = null;

        }

        private void 清楚分析结果ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axMapControl1.CurrentTool = null;
            try
            {
                string name = NetWorkAnalysClass.getPath(path) + "\\data\\HuanbaoGeodatabase.gdb";
                //打开工作空间
                pFWorkspace = NetWorkAnalysClass.OpenWorkspace(name) as IFeatureWorkspace;
                IGraphicsContainer pGrap = this.axMapControl1.ActiveView as IGraphicsContainer;
                pGrap.DeleteAllElements();//删除所添加的图片要素
                IFeatureClass inputFClass = pFWorkspace.OpenFeatureClass("Stops");
                //删除站点要素
                if (inputFClass.FeatureCount(null) > 0)
                {
                    ITable pTable = inputFClass as ITable;
                    pTable.DeleteSearchedRows(null);
                }
                IFeatureClass barriesFClass = pFWorkspace.OpenFeatureClass("Barries");//删除障碍点要素
                if (barriesFClass.FeatureCount(null) > 0)
                {
                    ITable pTable = barriesFClass as ITable;
                    pTable.DeleteSearchedRows(null);
                }
                for (int i = 0; i < axMapControl1.LayerCount; i++)//删除分析结果
                {
                    ILayer pLayer = axMapControl1.get_Layer(i);
                    if (pLayer.Name == ShortPathSolveCommand.m_NAContext.Solver.DisplayName)
                    {
                        axMapControl1.DeleteLayer(i);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.axMapControl1.Refresh();
        }


    }
}
