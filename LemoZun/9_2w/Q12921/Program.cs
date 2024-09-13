namespace Q12921
{
    public class Program
    {
        /// <summary>
        /// Q12921
        /// 소수찾기
        /// https://school.programmers.co.kr/learn/courses/30/lessons/12921
        /// </summary>
        public class Solution
        {

            // 에라토스테네스의 체로 소수를 구할 수 있다
            // 일일히 그 수가 소수인지 구하려면 너무 많은 연산이 필요함
            // https://ko.wikipedia.org/wiki/%EC%97%90%EB%9D%BC%ED%86%A0%EC%8A%A4%ED%85%8C%EB%84%A4%EC%8A%A4%EC%9D%98_%EC%B2%B4
            // 해당 숫자가 소수인지 구하는것이 아니라 범위를 구하는것이기 때문에 이 알고리즘을 사용하면 편리할거같다
            // 인덱스를 해당 수로 하면 되니 저번처럼 굳이 딕셔너리 할 필요는 없음
            // 처음부터 순회하며 범위 안에 그 수의 배수들을 모두 지우는 방식

            public int solution(int n)
            {

                bool[] CheckingPrimeNum = new bool[n+1]; //인덱스는 0부터 시작하니까 해당하는 수까지 구하려면 +1을 해줘야함
                Array.Fill(CheckingPrimeNum, true); // 전부 true로 채움
                CheckingPrimeNum[0] = false;
                CheckingPrimeNum[1] = false; // 0과 1을 빼줌

                //for(int i = 2; i<CheckingPrimeNum.Length; i++) 배열의 길이까지 순회할 필요 없이 n의 제곱근까지 순회하면 됨

                for(int i = 2; i<= (int)Math.Sqrt(n); i++ )
                {
                    if (CheckingPrimeNum[i])
                    { 
                        //for(int j = 2; i*j<n; j++) // 2부터 곱해서 i와 j를 곱한 수가 판정할 n보다 클때까지 
                        //{
                        //    CheckingPrimeNum[i * j] = false;
                        //}
                        for(int j = i*i; j<=n; j +=i ) // 좀더 효율적으로 바꿈 
                        {
                            CheckingPrimeNum[j] = false;
                        }

                    }
                }

                return Array.FindAll(CheckingPrimeNum, t => t).Length; //  t => t t가 참이면 t를 반환
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
