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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Open Input form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void input_Click(object sender, EventArgs e)
        {
            Input input = new Input();
            input.Show();
        }

        /// <summary>
        /// Open GeneratoreFeatures form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void generate_Click(object sender, EventArgs e)
        {
            GeneratorFeatures generator = new GeneratorFeatures();
            generator.Show();
        }
    }
}
