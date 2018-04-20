using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursProject
{
    public enum Alhorythms { GreedyAlhorythm }
    /// <summary>
    /// Static class concentrate solving alhorythms
    /// </summary>
    static class Solver
    {
        /// <summary>
        /// Comperer of pancakes acording to their outer sqear
        /// </summary>
        /// <param name="p1">First pancake</param>
        /// <param name="p2">Seckond pancake</param>
        /// <returns>If first pancake is bigger, equel or the same with seckond</returns>
        static int OutSqrCompear(Pancake p1, Pancake p2)
        {
            //If outer sqear of the first pancake is bigger
            if (p1.H * p1.R > p2.H * p2.R)
                return 1;

            //If outer sqear of the seckond pancake is bigger 
            else if (p2.H * p2.R > p1.H * p2.R)
                return -1;

            //If pancakes are equel
            else
                return 0;
        }

        /// <summary>
        /// Comperer of pancakes acording to their radius
        /// </summary>
        /// <param name="p1">First pancake</param>
        /// <param name="p2">Seckond pancake</param>
        /// <returns>If first pancake is bigger, equel or the same with seckond</returns>
        static int RadiusCompear(Pancake p1, Pancake p2)
        {
            //If radius of the first pancake is bigger
            if (p1.R > p2.R)
                return 1;

            //If radius of the seckond pancake is bigger 
            else if (p2.R > p2.R)
                return -1;

            //If pancakes are equel
            else
                return 0;
        }

        /// <summary>
        /// Finding max-radius pancake
        /// </summary>
        /// <param name="pList"></param>
        /// <returns></returns>
        static Pancake MaxRadius(List<Pancake> pList)
        {
            Pancake max = new Pancake();
            foreach (Pancake p in pList)
                if (p.R > max.R)
                    max = p;
            return max;
        }

        /// <summary>
        /// Greedy alhorytm
        /// </summary>
        /// <param name="problem">Problem to solve</param>
        /// <returns>Solution of the problem</returns>
        static public Solution Greedy(Problem problem)
        {
            //Variable for temporary saving pancake
            Pancake temp;

            //Sort pancakes
            problem.PancakeList.Sort(new Comparison<Pancake>(OutSqrCompear));
            problem.PancakeList.Reverse();

            //Solution contains pancakes with max outer sqear
            double solvByMaxOuter = 0;

            //Solution contains pancake with max top sqear
            double solvWithMaxTop = 0;

            //If m>0 (if another, problem doesn't make sens
            if (problem.M > 0)
            {
                //Finde sum of M-1 pancake with max outer sqear
                for (int i = 0; i < problem.M - 1; i++)
                    solvByMaxOuter += 2 * Math.PI * problem.PancakeList[i].H * problem.PancakeList[i].R;
                solvWithMaxTop = solvByMaxOuter;
                
                //Finde sum of M pancake with max outer sqear
                solvByMaxOuter += 2 * Math.PI * problem.PancakeList[problem.M -1].H * problem.PancakeList[problem.M - 1].R;

                //Add top sqear of first solution
                temp = MaxRadius(problem.PancakeList.GetRange(0, problem.M));
                solvByMaxOuter += Math.PI * Math.Pow(temp.R, 2);

                //If pancake with max top sqear isn't one of the pancakes with max outer sqear
                if (problem.PancakeList.IndexOf(MaxRadius(problem.PancakeList)) > problem.M - 1)
                {
                    //Temporary save that pancake 
                    temp = MaxRadius(problem.PancakeList);

                    //Add it's sqear to solution
                    solvWithMaxTop += (2 * Math.PI * temp.H * temp.R + Math.PI * Math.Pow(temp.R, 2));
                }
            
                //Finde numbers of needed pancakes

                //Identifie first m-1 pancakes
                int[] numbers = new int[problem.M];

                if (problem.M - 2 > 0)
                    Enumerable.Range(0, (problem.M - 2)).ToArray<int>().CopyTo(numbers, 0);
                else if (problem.M == 2)
                    numbers[0] = 0;

                //If we chouse solution with max-top
                if (solvWithMaxTop > solvByMaxOuter)
                    //Add it's number to list
                    numbers[problem.M - 1] = problem.PancakeList.IndexOf(MaxRadius(problem.PancakeList));
                else
                    //Add last-from-better number to list
                    numbers[problem.M - 1] = problem.M - 1;
                return SolutionConstructor(numbers, problem.PancakeList, Alhorythms.GreedyAlhorythm);                             
            }
            //If we don't need any pancake, return empty solution
            else
                return new Solution(new List<Pancake>(),Alhorythms.GreedyAlhorythm);
        }

        /// <summary>
        /// Creator of solution
        /// </summary>
        /// <param name="numbers">Numbers of pancakes we need</param>
        /// <param name="pList">List of all pancake</param>
        /// <param name="usedAlhorythm">Alhorithm used to get solution</param>
        /// <returns>Solution</returns>
        static Solution SolutionConstructor(int[] numbers, List<Pancake> pList, Alhorythms usedAlhorythm)
        {
            //Difine list of needable pancakes
            List<Pancake> resultList = new List<Pancake>();

            //Finde nidable pancakes
            for (int i = 0; i < numbers.Length; i++)
                resultList.Add(pList[numbers[i]]);

            //Sort the pancakes
            resultList.Sort(new Comparison<Pancake>(RadiusCompear));

            //Form solution
            Solution result = new Solution(resultList, usedAlhorythm);
            return result;
        }
    }
}
