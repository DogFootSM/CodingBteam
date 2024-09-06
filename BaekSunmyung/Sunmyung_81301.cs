using System.Text;

namespace Example_005
{

    /// <summary>
    /// 날짜 : 2024-09-05
    /// 문제 : 숫자 문자열과 영단어
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/81301
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "1one1one1one";

            Dictionary<string, string> key = new Dictionary<string, string>();
            key.Add("zero", "0");
            key.Add("one", "1");
            key.Add("two", "2");
            key.Add("three", "3");
            key.Add("four", "4");
            key.Add("five", "5");
            key.Add("six", "6");
            key.Add("seven", "7");
            key.Add("eight", "8");
            key.Add("nine", "9");

            int answer = 0;
            string temp = "";
 
            StringBuilder sb    = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                if (int.TryParse(s[i].ToString(), out int val))
                {
                    sb.Append(val); 
                }
                else
                {
                    temp += s[i].ToString();

                    if (key.ContainsKey(temp))
                    {
                        sb.Append(key[temp]);
                        temp = "";
                    }
                } 
            }

 
            answer = Convert.ToInt32(sb.ToString());
            Console.WriteLine(answer);
        }
    }
}
