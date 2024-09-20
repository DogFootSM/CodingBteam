namespace Example_009
{
    internal class Program
    {
        /// <summary>
        /// 날짜 : 2024-09-12
        /// 문제 : 카드뭉치
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/159994
        /// </summary>
        static void Main(string[] args)
        {

            string[] cards1 = ["i", "water", "drink"];
            string[] cards2 = ["want", "to"];
            string[] goal = ["i", "want", "to", "drink", "water"];

            string answer = "";
            bool isCheck = true;

            int cards1Index = 0;
            int cards2Index = 0;
            int goalIndex = 0;

            while (goalIndex < goal.Length && isCheck)
            {
                // cards1Index < cards1.Length && cards1[cards1Index] == goal[goalIndex] 조건의 순서 중요
                // && 연산일 때 앞의 조건이 false면 뒤에 조건은 실행하지 않음 
                if (cards1Index < cards1.Length && cards1[cards1Index] == goal[goalIndex])
                {
                    isCheck = true;
                    cards1Index++;
                    goalIndex++;
                } 
                else if (cards2Index < cards2.Length && cards2[cards2Index] == goal[goalIndex])
                {
                    isCheck = true;
                    cards2Index++;
                    goalIndex++;
                }
                else
                {
                    isCheck = false;
                    break;
                } 
            }

            answer = isCheck ? "Yes" : "No";
            Console.WriteLine(answer);

        }
    }
}
