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
    //TODO: control situation if min is bigger then max
    //TODO: control situation if some values are 0
    public partial class GeneratorFeatures : Form
    {
        //Form for check and edit data
        DataOutput output;

        /// <summary>
        /// Addres where file with generated problem have to be plased
        /// </summary>
        string ProblemFileAddress = @".\temp\input.txt";

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
            try
            {
                if (sizeMin.Value > sizeMax.Value)
                { throw new Exception("Мінімальна розмірність не може бути меншою за максимальну!"); }
                else if (sizeMin.Value == 0)
                { throw new Exception("Неможливо створити задачу нульової розмірості!"); }
                else if (step.Value == 0)
                { throw new Exception("Крок не може бути меньше одиниці"); }
                else
                //Create generator
                { return new Generator((int)sizeMin.Value, (int)sizeMax.Value, (int)step.Value, (int)eachNumber.Value); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return null;
            }
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

                if (generator != null)
                {
                    generator.Generate(ProblemFileAddress);

                    //if output form isn't created or destroyed
                    if ((output == null) || (output.IsDisposed))
                    {
                        output = new DataOutput(ProblemFileAddress);
                    }
                    output.Show();
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
    }
}