using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CoursProject
{
    public partial class Input : Form
    {
        /// <summary>
        /// Form of count result
        /// </summary>
        Result res;

        /// <summary>
        /// Regular expression express double
        /// </summary>
        string doubleNumber;

        public Input()
        {
            InitializeComponent();

            //Regular expression express double
            doubleNumber = @"^[0-9]*[.,]?[0-9]+$";
        }

        /// <summary>
        /// Create problem object from given data
        /// </summary>
        /// <returns>Created problem</returns>
        private Problem createProblem()
        {
            //List of pancakes we have
            List<Pancake> pancakesList = new List<Pancake>();
            
            //Define pancakes we have
            for (int i = 0; i < PancakesCollaction.RowCount; i++)
                pancakesList.Add(new Pancake(Convert.ToDouble(PancakesCollaction.Rows[i].Cells[0].Value), Convert.ToDouble(PancakesCollaction.Rows[i].Cells[1].Value)));

            //Define problem object
            Problem forSolve = new Problem(pancakesList, (int)mInput.Value);

            return forSolve;
        }

        /// <summary>
        /// Start count
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void go_Click(object sender, EventArgs e)
        {
            //If we need more pancakes than we have
            if (PancakesCollaction.RowCount < mInput.Value)
                MessageBox.Show("Кількість млинців, що необхідно обрати, не може бути більшою за кількість млинців, що є в наявності!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else
            {
                Problem problem = createProblem();

                //if form wasn't created or was cloused
                if ((res == null) || res.IsDisposed)
                {
                    //create form
                    res = new Result(Solver.Greedy(problem));
                }
                res.Show();
            }
        }

        /// <summary>
        /// Adding pancake
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void add_Click(object sender, EventArgs e)
        {
            //Flag difine if height and radius inserted
            bool OK = true;
            //If hieght of pancake is blank
            if (height.Text == "")
            {
                MessageBox.Show("Вкажіть висоту млинця!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                OK = false;
            }
            //If radius of pancake is blank
            if (radius.Text == "")
            {
                MessageBox.Show("Вкажіть радіус млинця!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                OK = false;
            }
            if (OK)
                PancakesCollaction.Rows.Add(new object[] { Convert.ToDouble(height.Text), Convert.ToDouble(radius.Text) });

            //Empty text lines
            height.Text = "";
            radius.Text = "";
        }

        //Checking if entered line is correct
        private void height_Leave(object sender, EventArgs e)
        {
            //If line is'nt number or blank
            if (!(Regex.IsMatch(height.Text, doubleNumber)||(height.Text == "")))
            {
                height.Clear();
                MessageBox.Show("Введено недопустимі дані", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        //Checking if entered line is correct
        private void radius_Leave(object sender, EventArgs e)
        {
            //If line is'nt number or blank
            if (!(Regex.IsMatch(radius.Text, doubleNumber) || (radius.Text == "")))
            {
                radius.Clear();
                MessageBox.Show("Введено недопустимі дані", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        /// <summary>
        /// Check edited data
        /// </summary>
        /// <param name="sender">PancakesCollaction</param>
        /// <param name="e">Chenged cell</param>
        private void PancakesCollaction_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //If changed value isn't number
            if (!Regex.IsMatch(e.FormattedValue.ToString(), doubleNumber))
            {
                ((DataGridView)sender).CancelEdit();
                MessageBox.Show("Введено недопустимі дані", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        /// <summary>
        /// Reset input information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reset_Click(object sender, EventArgs e)
        {
            //Empty text lines
            height.Text = "";
            radius.Text = "";

            //Empty pancake collaction
            PancakesCollaction.Rows.Clear();

            //Reset number of pancake we need
            mInput.Value = 0;
        }

        /// <summary>
        /// Numeration of rows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Added row</param>
        private void PancakesCollaction_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //Define numerations of rows
            PancakesCollaction.Rows[e.RowIndex].HeaderCell.Value = (e.RowIndex + 1).ToString();
        }

        /// <summary>
        /// Refresh numeration if row removed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Remuved row</param>
        private void PancakesCollaction_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            //for each row after removed one
            for (int i = e.RowIndex; i < PancakesCollaction.RowCount; i++)
            {
                //Decrement row number
                string header = (Convert.ToInt32(PancakesCollaction.Rows[i].HeaderCell.Value) - 1).ToString();
                PancakesCollaction.Rows[i].HeaderCell.Value = header;
            }
        }
    }
}