using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class MCM
    {

        public static char name;

        // Function for printing the optimal
        // parenthesization of a matrix chain product
        public static void printParenthesis(int i, int j,
                                     int n, int[,] bracket)
        {

            // If only one matrix left in current segment
            if (i == j)
            {
                Console.Write(name++);
                global.mcm += name++.ToString();
                return;
            }

           
            global.mcm += "(";
                
            // Recursively put brackets around subexpression
            // from i to bracket[j,i].
            // Note that "*((bracket+j*n)+i)" is similar to
            // bracket[i,j]
            printParenthesis(i, bracket[j, i], n, bracket);

            // Recursively put brackets around subexpression
            // from bracket[j,i] + 1 to i.
            printParenthesis(bracket[j, i] + 1, j, n, bracket);

            
            global.mcm += ")";
        }


        public static void matrixChainOrder(int[] p, int n)
        {

            /*
            * For simplicity of the program, one extra
            * row and one extra column are
            * allocated in m[,]. 0th row and 0th 
            * column of m[,] are not used
            */
            int[,] m = new int[n, n];

            /*
            * m[i,j] = Minimum number of scalar 
            * multiplications needed to compute the
            * matrix A[i]A[i+1]...A[j] = A[i..j] 
            * where dimension of A[i] is p[i-1] x p[i]
            */

            // Cost is zero when multiplying one matrix.
            for (int L = 2; L < n; L++)
            {
                for (int i = 1; i < n - L + 1; i++)
                {
                    int j = i + L - 1;
                    m[i, j] = int.MaxValue;

                    for (int k = i; k <= j - 1; k++)
                    {

                        // q = cost/scalar multiplications
                        int q = m[i, k] + m[k + 1, j] +
                                p[i - 1] * p[k] * p[j];

                        if (q < m[i, j])
                        {
                            m[i, j] = q;

                            // Each entry m[j,ji=k shows
                            // where to split the product arr
                            // i,i+1....j for the minimum cost.
                            m[j, i] = k;
                        }
                    }
                }
            }

            // The first matrix is printed as 'A', next as 'B',
            // and so on
            name = 'A';

           
            printParenthesis(1, n - 1, n, m);
           
            global.mcmcost = m[1, n - 1];
        }

    }
}
