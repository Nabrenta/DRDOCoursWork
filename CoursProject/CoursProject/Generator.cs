using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CoursProject
{
    /// <summary>
    /// Generator of problem
    /// </summary>
    public class Generator
    {
        /// <summary>
        /// Size of the problem from the first group
        /// </summary>
        private int minSize;

        /// <summary>
        /// Size of the problem from the last group
        /// </summary>
        private int maxSize;

        /// <summary>
        /// Step betveen group size
        /// </summary>
        private int step;

        /// <summary>
        /// Number of problem from each group
        /// </summary>
        private int eachNumber;

        /// <summary>
        /// Initialization constructor
        /// </summary>
        /// <param name="minSize">Size of the problem from the first group</param>
        /// <param name="maxSize">Size of the problem from the last group</param>
        /// <param name="step">Step betveen group size</param>
        /// <param name="eachNumber">Number of problem from each group</param>
        public Generator(int minSize, int maxSize, int step, int eachNumber)
        {
            this.minSize = minSize;
            this.maxSize = maxSize;
            this.step = step;
            this.eachNumber = eachNumber;
        }

        /// <summary>
        /// Generate data
        /// </summary>
        /// <param name="address">Address of output file</param>
        public void Generate(string address)
        {
            try
            {
                //Create stream writer
                StreamWriter sw = new StreamWriter(address, false);

                //Create generator
                Random rand = new Random();

                //Current string
                string cur;

                //Generate problems

                //Write number of problem with each size
                sw.WriteLine(eachNumber);

                sw.WriteLine((int)((maxSize - minSize) / step + 1));

                //For each group of problems
                for (int i = minSize; i <= maxSize; i+=step)
                {

                    //For each problem
                    for (int j = 0; j<eachNumber; j++)
                    {

                        cur = i.ToString() + " " + rand.Next() % i;
                        sw.WriteLine(cur);

                        //For each pancake
                        for (int k = 0; k<i; k++)
                        {
                            cur = rand.NextDouble().ToString() + " " + rand.NextDouble();
                            sw.WriteLine(cur);
                        }
                    }
                }

                sw.Close();
                sw.Dispose();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
