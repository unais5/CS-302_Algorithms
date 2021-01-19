using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{

    public static class PP
    {

        // Returns true if arr[] can be partitioned
        // in two subsets of equal sum, otherwise false
        public static bool findPartiion(int[] arr, int n)
        {
            int sum = 0;
            int i, j;

            // Calculate sum of all elements
            for (i = 0; i < n; i++)
                sum += arr[i];
            if (sum % 2 != 0)
                return false;
            bool[] part = new bool[sum / 2 + 1];

            // Initialze the part array
            // as 0
            for (i = 0; i <= sum / 2; i++)
            {
                part[i] = false;
            }

            // Fill the partition table in 
            // bottom up manner
            for (i = 0; i < n; i++)
            {

                // The element to be included
                // in the sum cannot be
                // greater than the sum
                for (j = sum / 2; j >= arr[i]; j--)
                {

                    // Check if sum - arr[i] could be
                    // formed from a subset using elements
                    // before index i
                    if (part[j - arr[i]] == true || j == arr[i])
                        part[j] = true;
                }
            }
            return part[sum / 2];
        }

    }

}
