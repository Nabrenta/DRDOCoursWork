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

        /// <summary>
        /// Initialisation constructor
        /// </summary>
        /// <param name="sours">Sours data for diagram</param>
        public Statistic(Dictionary<Alhorythms,Dictionary<int,double>> sours)
        {
            SoursData = sours;
            InitializeComponent();
        }

        private void SpeedDiagram_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Define diagram
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Statistic_Load(object sender, EventArgs e)
        {
            //For each alhorythm
            foreach(KeyValuePair<Alhorythms, Dictionary<int,double>> AlhorythmData in SoursData)
            {
                //Create series
                SpeedDiagram.Series.Add(AlhorythmData.Key.ToString()).Label = AlhorythmData.Key.ToString();

                //Define diagram type
                SpeedDiagram.Series.FindByName(AlhorythmData.Key.ToString()).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                //Define data for diagram
                SpeedDiagram.Series.FindByName(AlhorythmData.Key.ToString()).Points.DataBindXY(AlhorythmData.Value.Keys, AlhorythmData.Value.Values);
            }
        }

        /// <summary>
        /// Not close form but just hide it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Statistic_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
