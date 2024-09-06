namespace Example_006
{

    /// <summary>
    /// 날짜 : 2024-09-05
    /// 문제 : 2016년
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/12901
    /// </summary>
    internal class Program
    {
        public class Solution
        {
            public string solution(int a, int b)
            {
                string answer = "";
                int[] month = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
                int[] day = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

                string[] week = { "THU", "FRI", "SAT", "SUN", "MON", "TUE", "WED" };
                int dif = 0;

                for (int i = 0; i < month.Length; i++)
                {

                    if (month[i] == a)
                    {

                        for (int j = 0; j <= i; j++)
                        {

                            if (i == j)
                            {
                                dif += b;

                            }
                            else
                            {
                                dif += day[j];
                            }
                        }
                    }
                }

                int index = dif % 7;
                answer = week[index];

                return answer;
            }
        }
    }
}
