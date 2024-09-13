namespace Q159994
{
    public class Program
    {
        /// <summary>
        /// Q159994
        /// 카드뭉치
        /// https://school.programmers.co.kr/learn/courses/30/lessons/159994
        /// </summary>
        public class Solution
        {
            public string solution(string[] cards1, string[] cards2, string[] goal)
            {
                string answer = "";
                int card1Index = 0;
                int card2Index = 0;

                foreach (string word in goal)
                {
                    if (card1Index < cards1.Length && cards1[card1Index] == word)
                    {
                        card1Index++;
                    }
                    else if (card2Index < cards2.Length && cards2[card2Index] == word)
                    {
                        card2Index++;
                    }
                    else
                    {
                        return answer = "No";
                    }
                }

                return answer = "Yes";
            }
        }


            //    for (int i = 0; i<goal.Length;i++)
            //    {

            //        if (cards1[i] == goal[i])
            //        {
            //            cards1[i] = null;
            //            continue;
            //        }
            //        else if(cards2[i] == goal[i])
            //        {
            //            cards2[i] = null;
            //            continue;
            //        }
            //        else
            //        {
            //            return answer = "NO";
            //        }
            //    }
            //    return answer = "Yes";
            //

    }
}
