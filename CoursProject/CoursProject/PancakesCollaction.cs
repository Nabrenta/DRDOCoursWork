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
        public List<Pancake> PancakeList { get; protected set; }
    }
}
