using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursProject
{
    public class Pancake
    {
        /// <summary>
        /// Height of pancake
        /// </summary>
        public double H { get; private set; }

        /// <summary>
        /// Radius of pancake
        /// </summary>
        public double R { get; private set; }

        /// <summary>
        /// Defoult constructor
        /// </summary>
        public Pancake()
        {   }

        /// <summary>
        /// Initialization constructor
        /// </summary>
        /// <param name="h">Height of pancake</param>
        /// <param name="r">Radius of pancake</param>
        public Pancake(double h, double r)
        {
            H = h;
            R = r;
        }
    }
}
