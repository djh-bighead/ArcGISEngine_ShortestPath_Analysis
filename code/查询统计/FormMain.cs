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
    public partial class FormMain : Form
    {
        //定义ISelectionEnvironment接口的对象来设置选择环境
        private ISelectionEnvironment selectionEnvironment;
        IMapDocument mapDocument;
        public IFeatureWorkspace pFWorkspace;
        string path = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;

        public FormMain()
        {
            InitializeComponent();
            //窗体初始化时新建ISelectionEnvironment接口的对象，对象具有默认的选项设置值
            selectionEnvironment = new SelectionEnvironmentClass();
        }

        private void ToolStripMenuItemQueryByAttribute_Click(object sender, EventArgs e)
        {
            //新创建属性查询窗体
            FormQueryByAttribute formQueryByAttribute = new FormQueryByAttribute();
            //将当前主窗体中MapControl控件中的Map对象赋值给FormQueryByAttribute窗体的CurrentMap属性
            formQueryByAttribute.CurrentMap = axMapControl.Map;
            //显示属性查询窗体
            formQueryByAttribute.Show();
        }

        private void ToolStripMenuItemMapSelection_Click(object sender, EventArgs e)
        {
            //新创建地图选择集窗体
            FormSelection formSelection = new FormSelection();
            //将当前主窗体中MapControl控件中的Map对象赋值给FormSelection窗体的CurrentMap属性
            formSelection.CurrentMap = axMapControl.Map;
            //显示地图选择集窗体
            formSelection.Show();
        }

        private void ToolStripMenuItemQueryBySpatial_Click(object sender, EventArgs e)
        {
            //新创建空间查询窗体
            FormQueryBySpatial formQueryBySpatial = new FormQueryBySpatial();
            //将当前主窗体中MapControl控件中的Map对象赋值给FormSelection窗体的CurrentMap属性
            formQueryBySpatial.CurrentMap = axMapControl.Map;
            //显示空间查询窗体
            formQueryBySpatial.Show();
        }

        private void ToolStripMenuItemQueryByGraphics_Click(object sender, EventArgs e)
        {
            try
            {
                //首先清空地图选择集，以进行后续的选择操作
                axMapControl.Map.FeatureSelection.Clear();

                //使用IGraphicsContainer接口获取地图中的各个图形（Graphics）
                IGraphicsContainer graphicsContainer = axMapControl.Map as IGraphicsContainer;
                //重置访问图形的游标，使IGraphicsContainer接口的Next()方法定位于地图中的第一个图形
                graphicsContainer.Reset();
                //使用IElement接口操作所获取第一个图形
                IElement element = graphicsContainer.Next();
                //获取图形的几何信息
                IGeometry geometry = element.Geometry;
                //使用第一个图形的几何形状来选择地图中的要素。
                axMapControl.Map.SelectByShape(geometry, null, false);
                //进行部分刷新以显示最新的选择集
                axMapControl.ActiveView.PartialRefresh(esriViewDrawPhase.esriViewGeoSelection, null, axMapControl.ActiveView.Extent);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void ToolStripMenuItemStatistics_Click(object sender, EventArgs e)
        {
            //新创建统计窗体
            FormStatistics formStatistics = new FormStatistics();
            //将当前主窗体中MapControl控件中的Map对象赋值给FormStatistics窗体的CurrentMap属性
            formStatistics.CurrentMap = axMapControl.Map;
            //显示统计窗体
            formStatistics.Show();
        }

        private void ToolStripMenuItemOptions_Click(object sender, EventArgs e)
        {
            //新创建选择操作选项窗体
            FormOptions formOptions = new FormOptions();
            //将当前主窗体中MapControl控件中的Map对象赋值给FormOptions窗体的CurrentMap属性
            formOptions.CurrentSelectionEnvironment = selectionEnvironment;
            //显示选择操作选项窗体
            formOptions.Show();
        }

        private void ToolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            //使用对话框选择要打开的mxd文档
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "ArcMap Documents (*.mxd)|*.mxd";                
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    axMapControl.LoadMxFile(filePath);
                }
            }
        }

        private void axTOCControl_OnMouseDown(object sender, ESRI.ArcGIS.Controls.ITOCControlEvents_OnMouseDownEvent e)
        {

        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        

        private void axMapControl_OnExtentUpdated(object sender, ESRI.ArcGIS.Controls.IMapControlEvents2_OnExtentUpdatedEvent e)
        {
            IEnvelope pEnvelope = (IEnvelope)e.newEnvelope;
            IGraphicsContainer pGraphicsContainer = axMapControl2.Map as IGraphicsContainer;
            IActiveView pActiveView = pGraphicsContainer as IActiveView;
            pGraphicsContainer.DeleteAllElements();
            IRectangleElement pRectangleEle = new RectangleElementClass();
            IElement pElement = pRectangleEle as IElement;
            pElement.Geometry = pEnvelope;

            IRgbColor pColor = new RgbColorClass();
            pColor.Red = 255;
            pColor.Green = 0;
            pColor.Blue = 0;
            pColor.Transparency = 255;

            ILineSymbol pOutline = new SimpleLineSymbolClass();
            pOutline.Width = 3;
            pOutline.Color = pColor;
            pColor = new RgbColorClass();
            pColor.Red = 255;
            pColor.Green = 0;
            pColor.Blue = 0;
            pColor.Transparency = 0;

            IFillSymbol pFillSymbol = new SimpleFillSymbolClass();
            pFillSymbol.Color = pColor;
            pFillSymbol.Outline = pOutline;
            IFillShapeElement pFillShapeEle = pElement as IFillShapeElement;
            pFillShapeEle.Symbol = pFillSymbol;
            pGraphicsContainer.AddElement((IElement)pFillShapeEle, 0);
            pActiveView.PartialRefresh(esriViewDrawPhase.esriViewGraphics, null, null);

        }

        private void axMapControl_OnMapReplaced(object sender, ESRI.ArcGIS.Controls.IMapControlEvents2_OnMapReplacedEvent e)
        {
            axMapControl2.Map = new MapClass();
            if (axMapControl.LayerCount > 0)
            {
                for (int i = 0; i <= axMapControl.Map.LayerCount - 1; ++i)
                {
                    axMapControl2.AddLayer(axMapControl.get_Layer(i));
                }
                axMapControl2.Extent = axMapControl.Extent;
            }

        }

        private void axMapControl2_OnMouseDown(object sender, ESRI.ArcGIS.Controls.IMapControlEvents2_OnMouseDownEvent e)
        {
            if (axMapControl2.Map.LayerCount > 0)
            {
                if (e.button == 1)
                {
                    IPoint pPoint = new PointClass();
                    pPoint.PutCoords(e.mapX, e.mapY);
                    axMapControl.CenterAt(pPoint);
                    axMapControl.ActiveView.PartialRefresh(esriViewDrawPhase.esriViewGraphics, null, null);
                }
                else if (e.button == 2)
                {
                    IEnvelope pEnv = axMapControl2.TrackRectangle();
                    axMapControl.Extent = pEnv;
                    axMapControl.ActiveView.PartialRefresh(esriViewDrawPhase.esriViewGraphics, null, null);
                }
            }

        }

        private void axMapControl2_OnMouseMove(object sender, ESRI.ArcGIS.Controls.IMapControlEvents2_OnMouseMoveEvent e)
        {
            if (e.button == 1)
            {
                IPoint pPoint = new PointClass();
                pPoint.PutCoords(e.mapX, e.mapY);
                axMapControl.CenterAt(pPoint);
                axMapControl.ActiveView.PartialRefresh(esriViewDrawPhase.esriViewGraphics, null, null);
            }

        }

        private void 鹰眼ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (splitContainer2.Panel2Collapsed)
            {
                splitContainer2.Panel2Collapsed = false;
            }
            else
            {
                splitContainer2.Panel2Collapsed = true;
            }

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            axTOCControl.SetBuddyControl(axMapControl);
        }

        private void 属性查询ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //新创建属性查询窗体
            FormQueryByAttribute formQueryByAttribute = new FormQueryByAttribute();
            //将当前主窗体中MapControl控件中的Map对象赋值给FormQueryByAttribute窗体的CurrentMap属性
            formQueryByAttribute.CurrentMap = axMapControl.Map;
            //显示属性查询窗体
            formQueryByAttribute.Show();
        }

        private void 空间查询ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //新创建空间查询窗体
            FormQueryBySpatial formQueryBySpatial = new FormQueryBySpatial();
            //将当前主窗体中MapControl控件中的Map对象赋值给FormSelection窗体的CurrentMap属性
            formQueryBySpatial.CurrentMap = axMapControl.Map;
            //显示空间查询窗体
            formQueryBySpatial.Show();
        }

        private void 查询结果统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //新创建统计窗体
            FormStatistics formStatistics = new FormStatistics();
            //将当前主窗体中MapControl控件中的Map对象赋值给FormStatistics窗体的CurrentMap属性
            formStatistics.CurrentMap = axMapControl.Map;
            //显示统计窗体
            formStatistics.Show();
        }

        private void 设置选中效果ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //新创建选择操作选项窗体
            FormOptions formOptions = new FormOptions();
            //将当前主窗体中MapControl控件中的Map对象赋值给FormOptions窗体的CurrentMap属性
            formOptions.CurrentSelectionEnvironment = selectionEnvironment;
            //显示选择操作选项窗体
            formOptions.Show();
        }

        private void 选中要素信息显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //新创建地图选择集窗体
            FormSelection formSelection = new FormSelection();
            //将当前主窗体中MapControl控件中的Map对象赋值给FormSelection窗体的CurrentMap属性
            formSelection.CurrentMap = axMapControl.Map;
            //显示地图选择集窗体
            formSelection.Show();
        }

        private void 路径分析ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            route f = new route();
            f.Show();
        }
    }
}