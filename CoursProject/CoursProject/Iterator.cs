using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CoursProject
{
    /// <summary>
    /// Class for iterative testing of methods
    /// </summary>
    public static class Iterator
    {
        /// <summary>
        /// Iterating method to get 
        /// </summary>
        /// <param name="connect">Addres of file with input data</param>
        /// <param name="Method">Tested method</param>
        /// <returns>List of everage time needed for solve defined size problem</returns>
        public static Dictionary<int,double> Iterat(Func<Problem, Solution> Method, string connect)
        {
            //Create stream
            StreamReader sr = new StreamReader(connect);

            //Define size of each same-size problem block
            int sizeEach = Convert.ToInt32(sr.ReadLine());

            //Define number of problem group
            int numbOfGroups = Convert.ToInt32(sr.ReadLine());

            //Define arrey of times of work whith each group
            Dictionary<int, double> res = new Dictionary<int, double>();

            //Define temporary string
            string temp;

            //For each group of problem
            for (int i = 0; i<numbOfGroups; i++)
            {
                //For each problem
                for (int j = 0; j<sizeEach; j++)
                {
                    //Read first line of problem
                    temp = sr.ReadLine();

                    //Define problem size
                    int size = int.Parse(temp.Split()[0]);

                    //Define number of pancake needed in solution
                    int m = int.Parse(temp.Split()[1]);

                    //Init pancake list
                    List<Pancake> pList = new List<Pancake>();

                    //Complit list of pancake
                    for(int k = 0; k<size; k++)
                    {
                        temp = sr.ReadLine();
                        pList.Add(new Pancake(double.Parse(temp.Split()[0]), double.Parse(temp.Split()[1])));
                    }

                    //Define alhorythm start time
                    DateTime start = DateTime.Now;

                    //Use method
                    Method(new Problem(pList, m));

                    //Define alhorythm finish time
                    DateTime finish = DateTime.Now;

                    //Add data to result list
                    double prob;
                    if (!res.TryGetValue(size, out prob))
                        res.Add(size, (finish - start).TotalMilliseconds);
                    else
                        res[size] += (finish - start).TotalMilliseconds;
                }
            }
            return res;
        }
    }
}
