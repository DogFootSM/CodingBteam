namespace Example_011
{
    internal class Program
    {
        /// <summary>
        /// 날짜 : 2024-09-13
        /// 문제 : 과일 장수
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/135808
        /// </summary>
        static void Main(string[] args)
        {
            //1점 ~ K점
            //최고점 k
            //한 상자에 사과 M개
            //상자 중 가장 낮은 점수가 p
            //한 상자 가격 : p * m > 가장 낮은 점수 x 사과 개수
 
            //최종 결과 : p(가장 낮은 점수) * M (사과 개수)  > 상자 수 만큼 반복
            //m개를 담을 상자를 못만들 때까지

            int k = 4;
            int m = 3;
            int[] score = [4, 1, 2, 2, 4, 4, 4, 4, 1, 2, 4, 2]; 
            int answer = 0; 

            int box = score.Length / m;
 
            Array.Sort(score);
            Array.Reverse(score);

            Queue<int> queue = new Queue<int>();
            foreach (int a in score)
            {
                queue.Enqueue(a);
            }

            for (int i = 0; i < box; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (k > queue.Peek())
                    {
                        k = queue.Dequeue();
                    }
                    else
                    {
                        queue.Dequeue();
                    }
                }
                answer += (k * m);
            }


            //for (int i = m - 1; i < score.Length; i += m)
            //{ 
            //    answer += score[i] * m;
            //} 

        }
    }
}
