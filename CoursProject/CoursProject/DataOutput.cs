using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CoursProject
{
    public partial class DataOutput : Form
    {
        StreamReader sr;

        /// <summary>
        /// Childe form (for output statistic)
        /// </summary>
        Statistic statistic;

        /// <summary>
        /// Addres of sours file
        /// </summary>
        string Sours;

        public DataOutput(string sours)
        {
            this.Sours = sours;
            InitializeComponent();
        }

        /// <summary>
        /// Count
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void go_Click(object sender, EventArgs e)
        {
            Dictionary<int, double> res = Iterator.Iterat(Solver.Greedy, Sours);
            Dictionary<Alhorythms, Dictionary<int, double>> soursData = new Dictionary<Alhorythms, Dictionary<int, double>>();
            soursData.Add(Alhorythms.GreedyAlhorythm, res);
            if ((statistic == null)||(statistic.IsDisposed))
                statistic = new Statistic(soursData);
            statistic.Show();
        }

        /// <summary>
        /// Initialize form content
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataOutput_Load(object sender, EventArgs e)
        {
            try
            {
                //Read data from file
                sr = new StreamReader(Sours);
                content.Text = sr.ReadToEnd();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
            }
        }
    }
}