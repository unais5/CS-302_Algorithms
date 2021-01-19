using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{

    public class GFG
    {
        

       public String printShortestSuperSeq(String X, String Y)
        {
            int m = X.Length;
            int n = Y.Length;

           
            int[,] dp = new int[m + 1, n + 1];
            int i, j;

          
            for (i = 0; i <= m; i++)
            {
                for (j = 0; j <= n; j++)
                {

                    // Below steps follow recurrence relation 
                    if (i == 0)
                    {
                        dp[i, j] = j;
                    }
                    else if (j == 0)
                    {
                        dp[i, j] = i;
                    }
                    else if (X[i - 1] == Y[j - 1])
                    {
                        dp[i, j] = 1 + dp[i - 1, j - 1];
                    }
                    else
                    {
                        dp[i, j] = 1 + Math.Min(dp[i - 1, j], dp[i, j - 1]);
                    }
                }
            }

            
            int index = dp[m, n];

            // string to store the shortest supersequence 
            String str = "";

            // Start from the bottom right corner and one by one 
            // push characters in output string 
            i = m; j = n;
            while (i > 0 && j > 0)

            {
                // If current character in X and Y are same, then 
                // current character is part of shortest supersequence 
                if (X[i - 1] == Y[j - 1])

                {
                    // Put current character in result 
                    str += (X[i - 1]);

                    // reduce values of i, j and index 
                    i--;
                    j--;
                    index--;
                }

                // If current character in X and Y are different 
                else if (dp[i - 1, j] > dp[i, j - 1])
                {

                    // Put current character of Y in result 
                    str += (Y[j - 1]);

                    // reduce values of j and index 
                    j--;
                    index--;
                }
                else
                {

                    // Put current character of X in result 
                    str += (X[i - 1]);

                    // reduce values of i and index 
                    i--;
                    index--;
                }
            }

            // If Y reaches its end, put remaining characters 
            // of X in the result string 
            while (i > 0)
            {
                str += (X[i - 1]);
                i--;
                index--;
            }

            // If X reaches its end, put remaining characters 
            // of Y in the result string 
            while (j > 0)
            {
                str += (Y[j - 1]);
                j--;
                index--;
            }

            // reverse the string and return it 
            str = reverse(str);
            return str;
        }

        static String reverse(String input)
        {
            char[] temparray = input.ToCharArray();
            int left, right = 0;
            right = temparray.Length - 1;

            for (left = 0; left < right; left++, right--)
            {
                // Swap values of left and right 
                char temp = temparray[left];
                temparray[left] = temparray[right];
                temparray[right] = temp;
            }
            return String.Join("", temparray);
        }

    
    }



}
