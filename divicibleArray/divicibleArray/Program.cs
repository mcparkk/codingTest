using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace divicibleArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 5, 9, 7, 10 };
            Console.WriteLine(Solution.solution(arr1,5));
        }
    }
    public class Solution
    {
       static public int[] solution(int[] arr, int divisor)
        {
            int[] answer = new int[100] ;
            int len = arr.Length;
            
            int j = 0;
            for (int i =0; i<len;  i++)
            {
                if(arr[i]%divisor == 0)
                {
                    
                    answer[j] = arr[i];
                    j++;
                }
            }

           
            return answer;
        }
    }
}
