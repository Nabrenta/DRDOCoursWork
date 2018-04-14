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
    public partial class GeneratorFeatures : Form
    {
        //Form for check and edit data
        DataOutput output;

        public GeneratorFeatures()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initialisation of generator
        /// </summary>
        /// <returns></returns>
        private Generator initializeGenerator()
        {
            //Number of problems
            int size = (int)sizeInput.Value;

            //Size of problems
            int capacity = (int)capacityInput.Value;

            //Create generator
            return new Generator(size, capacity);
        }

        /// <summary>
        /// Generate data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void go_Click(object sender, EventArgs e)
        {
            try
            {
                //Create generator
                Generator generator = initializeGenerator();

                generator.Generate();

                //if output form isn't created or destroyed
                if ((output == null) || (output.IsDisposed))
                {
                    output = new DataOutput();
                }
                output.Show();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
    }
}