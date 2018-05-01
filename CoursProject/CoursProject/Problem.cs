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
        /// Initialisation constructor
        /// </summary>
        /// <param name="pList">List of pancake</param>
        /// <param name="m">number of pancake we need</param>
        public Problem(List<Pancake> pList, int m)
            :base(pList)
        {
            M = m;
        }
    }
}
