using System.Diagnostics.CodeAnalysis;

namespace Q12901
{
    public class Program
    {
        /// <summary>
        /// 2016년
        /// Q12901 
        /// https://school.programmers.co.kr/learn/courses/30/lessons/12901
        /// </summary>
        public class Solution
        {
            // 2016.1.1 : 금
            // 1    2   3   4   5   6   7   8   9   10  11  12
            // 31   29  31  30  31  30  31  31  30  31  30  31
            public string solution(int a, int b)
            {
                int sum = 0;
                var dic = new Dictionary<int, int>()
                {
                    {1,31},{2,29},{3,31},{4,30},{5,31},{6,30},{7,31},{8,31},{9,30},{10,31},{11,30},{12,31}
                };

                for (int i = 1; i < a; i++)
                {
                    sum += dic[i];
                }
                sum += b;

                List<string> dayofweek = new List<string>
                {
                    "SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT"
                };

                int dayIndex = (sum + 5 - 1) % 7;

                return dayofweek[dayIndex];
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
