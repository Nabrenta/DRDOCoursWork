using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursProject
{
    /// <summary>
    /// Class define problem for solve
    /// </summary>
    public class Problem: PancakesCollaction
    {

        /// <summary>
        /// Number of pancakes we need
        /// </summary>
        public int M { get; set; }

        /// <summary>
        /// Defoult constructor
        /// </summary>
        public Problem(List<Pancake> pancakes)
        {
            PancakeList = pancakes;
        }
    }
}
