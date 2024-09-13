namespace Q81301
{
    public class Program
    {
        public class Solution
        {
            /// <summary>
            /// 숫자 문자열과 영단어
            /// Q81301
            /// https://school.programmers.co.kr/learn/courses/30/lessons/81301
            /// </summary>
            /// <param name="s"></param>
            /// <returns></returns>
            public int solution(string s)
            {
                var dic = new Dictionary<string, string>
                {
                    {"zero","0" },
                    {"one","1" },
                    {"two","2" },
                    {"three","3" },
                    {"four","4" },
                    {"five","5" },
                    {"six","6" },
                    {"seven","7" },
                    {"eight","8" },
                    {"nine","9" }
                };

                foreach(var number in dic)
                {
                    s = s.Replace(number.Key, number.Value);
                }
                return int.Parse(s);
            }
        }
    }
}
