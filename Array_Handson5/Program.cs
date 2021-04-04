using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Handson5
{
    class Program
    {
        static long arrayManipulation(int n, int[][] queries)
        {
            List<List<int>> q = new List<List<int>>();
            long ans = 0;
            int m = queries.GetLength(0);
            for(int i = 0; i < m; i++)
            {
                q.Add(new List<int>() { queries[i][0], queries[i][1], queries[i][2] });
            }
            q.Sort((x, y) =>
            {
                if (x[0] == y[0])
                {
                    return x[1].CompareTo(y[1]);
                }
                return x[0].CompareTo(y[0]);
            });

            return ans;
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] nm = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nm[0]);
            int m = Convert.ToInt32(nm[1]);
            int[][] queries = new int[m][];

            for (int i = 0; i < m; i++)
            {
                queries[i] = Array.ConvertAll(Console.ReadLine().Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
            }

            long result = arrayManipulation(n, queries);

            Console.WriteLine(result);
            Console.Read();
        }
    }
}
