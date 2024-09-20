namespace Programmers_159994
{
    public class Solution
    {
        public string solution(string[] cards1, string[] cards2, string[] goal)
        {
            string answer = "";

            // 결과 판정용
            bool result = true;

            // 각 카드뭉치의 현재 index
            int index1 = 0;
            int index2 = 0;

            // 목표 단어를 순회
            foreach(string word in goal)
            {
                // 1번 카드뭉치의 index번째 단어가 goal에 해당하는지 확인 
                if (index1 < cards1.Length && cards1[index1] == word)
                {
                    index1++;
                }
                // 2번 카드뭉치의 index번째 단어가 goal에 해당하는지 확인
                else if (index2 < cards2.Length && cards2[index2] == word)
                {
                    index2++;
                }
                // 두 카드뭉치를 뒤져도 goal에 해당하지 않으면 더 이상 진행 불가
                else
                {
                    result = false;
                    break;
                }
            }

            // 결과에 따라 문자열 저장
            answer = result ? "Yes" : "No";

            return answer;
        }
    }
}
