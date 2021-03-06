using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Display;

namespace QueryAndStatistics
{
    public partial class FormOptions : Form
    {
        private ISelectionEnvironment currentSelectionEnvironment;  //设置类变量来使用ISelectionEnvironment接口的选择环境对象

        private ESRI.ArcGIS.Display.IRgbColor esriColor;    //设置类变量来存储当前设置的颜色值

        public FormOptions()
        {
            InitializeComponent();
            //初始化esriColor对象
            esriColor = new ESRI.ArcGIS.Display.RgbColorClass();
        }

        /// <summary>
        /// 设置ISelectionEnvironment接口的选择环境对象，用来获取当前地图的选择环境对象
        /// </summary>
        public ISelectionEnvironment CurrentSelectionEnvironment
        {
            set
            {
                currentSelectionEnvironment = value;
            }
        }





        //设置颜色对话框被点击时触发事件，执行本函数
        private void buttonSetColor_Click(object sender, EventArgs e)
        {
            //弹出颜色选择对话框，根据选择的颜色设置当前选择环境对象的默认颜色
            if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //先修改pictureBoxColor控件的背景颜色
                pictureBoxColor.BackColor = colorDialog.Color;
                //设置esriColor对象的R、G、B值                
                esriColor.Red = colorDialog.Color.R;
                esriColor.Green = colorDialog.Color.G;
                esriColor.Blue = colorDialog.Color.B;                
            }
        }   

        //将目前修改的参数值设置到当前地图选择环境对象的相应属性值中，今后查询选择时将使用新的参数值


        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
    }
}
