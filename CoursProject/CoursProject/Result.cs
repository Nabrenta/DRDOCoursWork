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
    public partial class Result : Form
    {
        /// <summary>
        /// Sollution to express
        /// </summary>
        Solution ExpressedSolution;

        /// <summary>
        /// Initialisation constructor
        /// </summary>
        /// <param name="expressed">Solution to express</param>
        public Result(Solution expressed)
        {
            ExpressedSolution = expressed;
            InitializeComponent();
        }

        /// <summary>
        /// Loading form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Result_Load(object sender, EventArgs e)
        {
            //Define name of form
            this.Text = ExpressedSolution.SoursAlhorythm.ToString();

            //Fill data grid view
            foreach(Pancake p in ExpressedSolution.PancakeList)
                dataGridView1.Rows.Add(new object[] { p.H, p.R });

            //Output result
            optFunckResult.Text = ExpressedSolution.Result.ToString();
        }

        /// <summary>
        /// Closing form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
