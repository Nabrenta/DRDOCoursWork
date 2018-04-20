using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CoursProject
{
    public class Generator
    {
        /// <summary>
        /// Number of problems
        /// </summary>
        private int Size;

        /// <summary>
        /// Problems size
        /// </summary>
        private int Capacity;
        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="size">Number of problems</param>
        /// <param name="capacity">Problems size</param>
        public Generator(int size, int capacity)
        {
            this.Size = size;
            this.Capacity = capacity;
        }

        public void Generate()
        {
            try
            {
                //Create stream writer
                StreamWriter sw = new StreamWriter(".\\temp\\temp.txt", false);

                //Create generator
                Random rand = new Random();

                //Current string
                string cur;

                //Generate problems

                //Write problems number
                sw.WriteLine(Size);

                //Create chousen number of problems
                for (int i = 0; i < Size; i++)
                {
                    cur = Capacity.ToString() + " " + rand.Next(0, Capacity);
                    sw.WriteLine(cur);

                    //Create chousen number of pancakes
                    for (int j = 0; j < Capacity; j++)
                    {
                        cur = (rand.Next() + rand.NextDouble()).ToString() + " " + (rand.Next() + rand.NextDouble()).ToString();
                        sw.WriteLine(cur);
                    }
                }
                sw.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
