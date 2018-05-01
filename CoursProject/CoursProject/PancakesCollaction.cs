using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursProject
{
    /// <summary>
    /// Abstraction for classes contains pancakes collaction (Problem and Solution)
    /// </summary>
    public abstract class PancakesCollaction
    {
        /// <summary>
        /// List of pancake
        /// </summary>
        public List<Pancake> PancakeList { get; protected set; }

        /// <summary>
        /// Basick constructor
        /// </summary>
        /// <param name="pList">List of pancake</param>
        protected PancakesCollaction(List<Pancake> pList)
        {
            PancakeList = pList;
        }
    }
}
