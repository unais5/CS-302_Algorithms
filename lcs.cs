using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    
    public class LCS
    {
       
        string S1, S2;  //Strings to match
        int m, n;   //Lengths of S1 and S2
        char[,] b;  //Stores direction
        int[,] c;   //Stores count

        public LCS(string s1, string s2)
        {
            this.S1 = s1;
            this.S2 = s2;
            m = s1.Length;
            n = s2.Length;
            b = new char[m, n];
            c = new int[m + 1, n + 1];
        }

        public int FindLCS()
        {
            for (int i = 1; i <= m; i++) //1 to m
                for (int j = 1; j <= n; j++) //1 to n
                {
                    if (S1[i - 1] == S2[j - 1]) //Xm == Yn
                    {
                        c[i, j] = c[i - 1, j - 1] + 1;
                        b[i - 1, j - 1] = 'd';
                    }
                    else if (c[i - 1, j] >= c[i, j - 1])    //compare Xm-1 to Yn
                    {
                        c[i, j] = c[i - 1, j];
                        b[i - 1, j - 1] = 'u';
                    }
                    else
                    {
                        c[i, j] = c[i, j - 1];
                        b[i - 1, j - 1] = 'l';
                    }
                }

            PrintLCS(b, S1, m - 1, n - 1);
            return c[m, n];
        }

        private void PrintLCS(char[,] b, string s1, int i, int j)
        {
            if (i == -1 || j == -1) { 
               
                return;
            }

            if (b[i, j] == 'd')
            {
                PrintLCS(b, s1, i - 1, j - 1);
                global.lcs += s1[i].ToString();
            }
            else if (b[i, j] == 'u')
            {
                PrintLCS(b, s1, i - 1, j);
            }
            else
            {
                PrintLCS(b, s1, i, j - 1);
            }
        }
    }
}
