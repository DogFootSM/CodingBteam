using System.Text;

namespace Example_008
{
    /// <summary>
    /// 날짜 : 2024-09-12
    /// 문제 : 이상한 문자 만들기
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/12930
    /// </summary>
    public class Solution
    {
        public string solution(string s)
        {
            string temp = "";
            string[] arr = s.Split(" ");


            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {   
                    //짝수, 홀수 인덱스 구분
                    if (j % 2 == 0)
                    {
                        temp += arr[i][j].ToString().ToUpper();
                    }
                    else
                    {
                        temp += arr[i][j].ToString().ToLower();
                    }
                }

                //공백을 기준으로 잘랐던 문자열 공백 재조합
                if (i != arr.Length - 1)
                {
                    temp += " ";
                }
            }
            return temp;
        }
    }
}
