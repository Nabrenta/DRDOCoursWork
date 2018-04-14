using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursProject
{
    class Problem
    {

        /// <summary>
        /// Number of pancakes we need
        /// </summary>
        public int M { get; set; }

        /// <summary>
        /// List of pancakes
        /// </summary>
        public List<Pancake> PancakeList { get; set; }

        /// <summary>
        /// Defoult constructor
        /// </summary>
        public Problem()
        {
            PancakeList = new List<Pancake>();
        }
    }
}
