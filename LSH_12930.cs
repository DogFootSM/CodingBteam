using System;
using System.Diagnostics;
using System.Text;

namespace BProgrammers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string s = "try hello world";

            Console.WriteLine(Lessons12930(s));            

        }

        static string Lessons12930(string s)
        {
            string answer = "";
            StringBuilder stBD = new StringBuilder();

            // 1. 문장을 어절단위로 분리해서 배열에 넣음
            string[] words = s.Split(" ");

            // 2. 배열 길이만큼 음절단위로 분리하는 작업을 수행함
            for (int i = 0; i < words.Length; i++)
            {
                // 2-2. 문제발생: 음절단위로 분리에 실패함
                string[] syllable = words[i].Split("");

                // 3. 음절의 index가 0이나 짝수면 대문자로, 홀수면 소문자로 변환해서 answer에 더해주기
                for (int j = 0; j < syllable.Length; j++)
                {
                    // 3-2. 문제 발생으로 인해 어절의 index를 모두 0으로 인식해서 단어가 전부 대문자로 변환됨
                    if (j == 0 || j % 2 == 0)
                    {
                        answer += syllable[j].ToUpper();
                        //stBD.Append(syllable[j].ToUpper());
                    }
                    else
                    {
                        answer += syllable[j].ToLower();
                        //stBD.Append(syllable[j].ToLower());
                    }

                }

                // 4. 어절 사이에는 띄어쓰기 추가하기
                answer += " ";

            }

            // 5. 더해진 조각들을 반환
            //answer = stBD.ToString();
            return answer;
            // 5-2. 문제 발생으로 인해 "TRY HELLO WORLD "이 변환됨

        }


    }
}
