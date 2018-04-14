using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursProject
{
    class Pancake
    {
        /// <summary>
        /// Height of pancake
        /// </summary>
        double h;

        /// <summary>
        /// Radius of pancake
        /// </summary>
        double r;

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
            this.h = h;
            this.r = r;
        }
    }
}
