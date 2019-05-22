using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calender
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            string result = solution(1, 7);
            Console.WriteLine(result);
        }
        static public string solution(int a, int b)
        {
           
            int allday=0;
            int j = 0;
            string answer = "";
            string[] day = {  "FRI", "SAT", "SUN", "MON", "TUE", "WED", "THU" };
            int[] monthDay = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (a == 1)
            {
                allday = b;
            }
            else
            {
                for (int i = 1; i < a; i++)
                {
                    allday += monthDay[i - 1];
                }
                allday += b;
            }
            if (allday % 7 == 0)
                j = 6;
            else
            {
                j = (allday % 7) - 1;
            }
            answer = day[j];

            return answer;
        }
    }
}
