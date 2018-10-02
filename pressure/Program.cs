using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pressure
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    static class Pressure
    {

        public static int DoubleInteger(int num)
        {
            return num * 2;
        }

        public static bool IsNumberEven(int num)
        {
            if(num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string FileExtension(string str)
        {
            string[] strArr = str.Split('.');
            return strArr[strArr.Length-1];
        }

        public static string LongestString(string[] strArray)
        {
            int longest = 0;
            string longestString = "";
            for(int i = 0; i < strArray.Length; i++)
            {
                string aString = strArray[i];
                if(aString.Length > longest)
                {
                    longest = aString.Length;
                    longestString = aString;
                }
            }
            return longestString;
        }

        public static int SumAllInts(IEnumerable<int[]> nums)
        {
            int aNum = 0;
            foreach(int[] set in nums)
            {
                aNum += set.Sum();
            }
            return aNum;
        }
    }
}
