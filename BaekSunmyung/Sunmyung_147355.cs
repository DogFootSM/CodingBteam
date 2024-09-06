using System.ComponentModel;

namespace Example_004
{
    /// <summary>
    /// 날짜 : 2024-09-05
    /// 문제 : 크기가 작은 부분 문자열
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/147355
    /// </summary>
    public class Solution
    {
        public int solution(string t, string p)
        {

            int answer = 0;
            int index = p.Length == 1 ? t.Length : (t.Length - p.Length) + 1;
            string[] arr = new string[index];
            int pIndex = p.Length;

            for (int i = 0; i < index; i++)
            {

                for (int j = i; j < i + pIndex; j++)
                {
                    arr[i] += t[j];
                }

                answer += Convert.ToInt64(arr[i]) <= Convert.ToInt64(p) ? 1 : 0;
            }

            return answer;
        }
    }
     
    internal class Program
    {
        static void Main(string[] args)
        {
            string t = "999999999999999999";
            string p = "999999999999999999";

            int index = p.Length == 1 ? t.Length : (t.Length - p.Length) + 1;
            string[] arr = new string[index];
            int pIndex = p.Length;
            int count = 0;
  
            for (int i = 0; i < index; i++)
            { 
                arr[i] = t[i..pIndex++];
                count += Convert.ToInt64(arr[i]) <= Convert.ToInt64(p) ? 1 : 0;
  
            }
        }
    }
}
