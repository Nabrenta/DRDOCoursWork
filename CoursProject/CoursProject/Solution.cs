using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursProject
{
    /// <summary>
    /// Class define problem solution
    /// </summary>
    class Solution: PancakesCollaction
    {
        /// <summary>
        /// Max sqear of pancakes piramid
        /// </summary>
        public double Result { get; private set; }

        /// <summary>
        /// Initialisation constructor
        /// </summary>
        /// <param name="pancakes">List of pancakes</param>
        public Solution (List<Pancake> pancakes)
        {
            //Initialize list of pancakes
            PancakeList = pancakes;

            //Finde the result
            Result = findeResult();
        }

        /// <summary>
        /// Finding result of problem solving
        /// </summary>
        /// <returns>Result</returns>
        private double findeResult()
        {
            //Pancake with the biggest radius
            Pancake max = PancakeList[0];

            //Result
            double result = 0.0;

            //In list of pancake
            foreach (Pancake p in PancakeList)
            {
                //Add outer sqear
                result += 2 * Math.PI * p.R * p.H;

                //Define if radius of current pancake is bigger than preveous
                if (p.R > max.R)
                    max = p;
            }

            //Add top sqear of the biggest radius pancake
            result += Math.PI * Math.Pow(max.R, 2);
            return result;
        }
    }
}
