using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoursProject
{
    public partial class Statistic : Form
    {
        /// <summary>
        /// Sours data for diagram
        /// </summary>
        public Dictionary<Alhorythms, Dictionary<int,double>> SoursData { get; private set; }
        public Statistic(Dictionary<Alhorythms,Dictionary<int,double>> sours)
        {
            SoursData = sours;
            InitializeComponent();
        }

        private void SpeedDiagram_Click(object sender, EventArgs e)
        {

        }

        private void Statistic_Load(object sender, EventArgs e)
        {
            foreach(KeyValuePair<Alhorythms, Dictionary<int,double>> AlhorythmData in SoursData)
            {
                SpeedDiagram.Series.Add(AlhorythmData.Key.ToString()).Label = AlhorythmData.Key.ToString();
                SpeedDiagram.Series.FindByName(AlhorythmData.Key.ToString()).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                SpeedDiagram.Series.FindByName(AlhorythmData.Key.ToString()).Points.DataBindXY(AlhorythmData.Value.Keys, AlhorythmData.Value.Values);
            }
        }
    }
}
