using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class _5_2
{
    public class Solution
    {
        List<string> strings = new List<string>();

        int x, y = 0;

        public string solution(string s)
        {
            string answer = "";

            foreach (char c in s)
            {
                if (c != (char)32)
                    answer += c;

                else
                {
                    strings.Add(answer);
                    answer = "";
                }
            }
            strings.Add(answer);
            answer = "";

            while (x < strings.Count)
            {

                while (y < strings[x].Length)
                {
                    if (strings[x][y] >= 97 && strings[x][y] <= 122)
                    {
                        if (y % 2 == 0)
                            answer += (char)(strings[x][y] - 32);

                        else
                            answer += strings[x][y];
                    }

                    if (strings[x][y] >= 65 && strings[x][y] <= 90)
                    {
                        if (y % 2 == 0)
                            answer += strings[x][y];

                        else
                            answer += (char)(strings[x][y] + 32);

                    }

                    y++;
                }

                if (x != strings.Count - 1)
                    answer += (char)32;

                x++;
                y = 0;
            }
            return answer;
        }
    }

    static void Main(string[] args)
    {
        Solution solo = new Solution();

        Console.WriteLine(solo.solution("TRY hello WORLd"));

    }
}