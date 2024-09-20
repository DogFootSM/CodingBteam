using System.Text;

namespace Programmers_12930
{
    public class Solution
    {
        public string solution(string s)
        {
            StringBuilder sb = new StringBuilder();

            // 우선 모든 문자열을 대문자로 만든다.
            s = s.ToUpper();

            // 문자열을 공백기준으로 나눈다.
            string[] words = s.Split(' ');

            foreach (string word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    // 짝수번째는 대문자 그대로, 홀수번째는 소문자로 바꿔 저장
                    // ascii 코드 상 대문자에 32를 더해주면 소문자다
                    sb.Append(i % 2 == 0 ? word[i] : (char)(word[i] + 32));
                }
                // 한 단어가 완성되고 나면 공백 추가
                sb.Append(' ');
            }
            // 마지막 공백은 제거
            sb.Remove(sb.Length - 1, 1);

            return sb.ToString();
        }
    }
}
