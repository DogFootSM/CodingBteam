namespace Q135808
{
    public class Program
    {
        /// <summary>
        /// Q135808
        /// 과일장수
        /// https://school.programmers.co.kr/learn/courses/30/lessons/135808
        /// </summary>
        public class Solution
        {

            public int solution(int k, int m, int[] score)
            {                
                //score 내림차순 정렬
                //스택 앞에서부터 넣음
                //맨위 꺼내서 점수 봄
                //점수*개수*상자개수 ? //안됨 상자개수때문에 최대이득 아님 // 아니다 상자는 하나만 파나? 아니네
                // m : 사과가 한 상자에 몇개 담길지 
                // k : 한 사과의 최대 점수
                // [4, 1, 2, 2, 4, 4, 4, 4, 1, 2, 4, 2]
                /*
                 *  [1, 1, 2]	1 x 3 = 3
                    [2, 2, 2]	2 x 3 = 6
                    [4, 4, 4]	4 x 3 = 12
                    [4, 4, 4]   4 x 3 = 12
                 */

                //k는 왜 필요한거지?

                int boxNum = score.Length / m; //사과박스의 총 개수
                Array.Sort(score);
                Array.Reverse(score);

                //int minPrice = score[0];
                int totalPrice = 0;

                for (int i = 0; i < boxNum * m; i += m)
                {
                    int minPrice = score[i + m-1];
                    totalPrice += minPrice * m;
                }
                return totalPrice;

                //정렬을 했으니 반복문을 복잡하게 생각할 필요 없음
                // 
                //for (int i = 0; i <= boxNum*m; i+=m)
                //{
                //    minPrice = score[i];
                //    for (int j = 1; j <= m; j++)
                //    {
                //        if (score[j] < minPrice)
                //        {
                //            minPrice = score[j];
                //        }
                //    }
                //    totalPrice += minPrice * m;
                //}
            }
        }
    }
}
