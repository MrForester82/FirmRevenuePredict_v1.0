using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Прогноз_результатов_деятельности_фирмы
{
    public partial class Form3 : Form
    {
        private List<Point> sourceCoord;
        private List<Point> calculatedCoord;

        public Form3()
        {
            InitializeComponent();
        }

        public Form3(List<Point> sourceCoord, List<Point>  calculatedCoord)
        {
            InitializeComponent();

            this.sourceCoord = sourceCoord;
            this.calculatedCoord = calculatedCoord;
        }
        
        private void Form3_Load(object sender, EventArgs e)
        {
            //Организация масштабирования по оси X
            chart1.ChartAreas[0].AxisX.ScaleView.Zoom(0, sourceCoord.Count);
            chart1.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart1.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;

            //Организация масштабирования по оси Y
            chart1.ChartAreas[0].AxisY.ScaleView.Zoom(Math.Min(sourceCoord.Min(x => x.Y), calculatedCoord.Min(x => x.Y)), Math.Max(sourceCoord.Max(x => x.Y), calculatedCoord.Max(x => x.Y)));
            chart1.ChartAreas[0].CursorY.IsUserEnabled = true;
            chart1.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            chart1.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = true;

            for (int i = 0; i < sourceCoord.Count; i++)
            {
                chart1.Series[0].Points.AddXY(sourceCoord[i].X, sourceCoord[i].Y);
            }

            for (int i = 0; i < calculatedCoord.Count; i++)
            {
                chart1.Series[1].Points.AddXY(calculatedCoord[i].X, calculatedCoord[i].Y);
            } 
        }
    }
}
