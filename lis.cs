using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class longestIncreasingSubsequence
    {
        public static int Printseq(int[] a)
        {
            int[] array = a;

            // int []array = {10, 2, 9, 3, 5, 4, 6, 8}; 
            //int []array = {10, 9, 8, 6, 5, 4}; 
            List<int> list = new List<int>();
            List<int> longestList = new List<int>();
            int currentMax;
            int highestCount = 0;
            for (int i = 0; i < array.Length; i++)
            {
                currentMax = int.MinValue;
                for (int j = i; j < array.Length; j++)
                {
                    if (array[j] > currentMax)
                    {
                        list.Add(array[j]);
                        currentMax = array[j];
                    }
                }

                // Compare previous highest subsequence 
                if (highestCount < list.Count)
                {
                    highestCount = list.Count;
                    longestList = new List<int>(list);
                }
                list.Clear();
            }
            Console.WriteLine();
            string ar=null;
            // Print list 
            Console.WriteLine("The longest subsequence");
            foreach (int itr in longestList)
            {
                Console.Write(itr + " ");
                ar += itr.ToString();
                ar += " ";
            }
            global.lis = ar;
            return highestCount;
        }
    }
}
