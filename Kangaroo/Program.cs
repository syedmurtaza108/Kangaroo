//Solved it in 9 minutes

using System;

namespace Kangaroo
{
    class Program
    {
        static string kangaroo(int x1, int v1, int x2, int v2)
        {
            string ans = "NO";
            int j = x2;
            for(int i = x1; i<= 100000000; i+=v1, j+= v2)
            {
                if (i == j)
                {
                    ans = "YES";
                    break;
                }
            }
            return ans;
        }

        static void Main(String[] args)
        {
            string[] tokens_x1 = Console.ReadLine().Split(' ');
            int x1 = Convert.ToInt32(tokens_x1[0]);
            int v1 = Convert.ToInt32(tokens_x1[1]);
            int x2 = Convert.ToInt32(tokens_x1[2]);
            int v2 = Convert.ToInt32(tokens_x1[3]);
            string result = kangaroo(x1, v1, x2, v2);
            Console.WriteLine(result);
        }
    }
}
