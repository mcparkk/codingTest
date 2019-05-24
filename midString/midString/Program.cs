using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midString
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "abcd";
            string b = Solution.solution(s);
            Console.WriteLine(b);
        }
    }
}
public class Solution
{
    static public string solution(string s)
    {
        string answer = "";
        int len = s.Length;
        char[] arr = s.ToCharArray();
        int i = len / 2;

        if (len % 2 != 0)
        {
            i++;
            answer = arr[i - 1].ToString();
        }
        else if (len % 2 == 0)
        {

            answer = arr[i - 1].ToString() + arr[i].ToString();
        }
        return answer;
    }
}


