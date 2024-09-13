using System.Text;

namespace Q12930
{
    public class Program
    {
        /// <summary>
        /// Q12930
        /// 이상한 문자 만들기
        /// https://school.programmers.co.kr/learn/courses/30/lessons/12930
        /// </summary>
        public class Solution
        {
            
            public string solution(string s)
            {
                string[] word = s.Split(' '); //split으로 단어를 나눔
                List<string> words = new List<string>(); // 나눠서 대문자로 변경한 단어들을 담아줄 배열
                

                for(int i=0; i<word.Length;i++)
                {
                    StringBuilder sb = new StringBuilder(); // 완성된 단어를 담을 스트링빌더
                    for (int j=0; j < word[i].Length;j++)
                    {
                        if(j % 2 == 0)
                        {
                            sb.Append(char.ToUpper(word[i][j])); //단어의 짝수번째는 대문자로 변환
                        }
                        else
                        {
                            sb.Append(char.ToLower(word[i][j])); // 홀수번째는 소문자로 변환 
                        }
                    }
                    words.Add(sb.ToString()); // 각 단어들을 리스트에 저장                    
                }

                string answer = string.Join(" ",words);
                return answer;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
