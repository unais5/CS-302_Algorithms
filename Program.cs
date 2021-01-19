using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class global
    {
        public static int dataset;
        public static int subset;
        public static int algo;
        public static string[] Data;
        public static string[] Data1;
        public static string lcs;
        public static string lis;
        public static int knapsack;
        public static int mcmcost;
        public static string mcm;
        public static string result;

    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /* 
             
            LCS lcs = new LCS("arswqv", "aswv");
            int count = lcs.FindLCS();
            Console.WriteLine("Total Matches: " + count);
            Console.ReadLine();




            String X = "AGGTAB";
            String Y = "GXTXAYB";
            GFG gfg = new GFG();
            Console.WriteLine(gfg.printShortestSuperSeq(X, Y));




            Console.WriteLine(StringDistance.LevenshteinDistance("climax", "volmax"));
            



              int[] arr = { 10, 22, 9, 33, 21, 50, 41, 60, 80 };
           longestIncreasingSubsequence.Printseq(arr);
    


            
            int[] arr = { 40, 20, 30, 10, 30 };
            int n = arr.Length;
             MCM.matrixChainOrder(arr, n);        



            
            int[] val = { 60, 100, 120 };
            int[] wt = { 10, 20, 30 };
            int W = 50;
            int n = val.Length;

            knapsack.printknapSack(W, wt, val, n);




                  int[] arr = { 1, 3, 3, 2, 3, 2 };
            int n = 6;

            // Function call
            if (PP.findPartiion(arr, n) == true)
                Console.WriteLine("Can be divided into two " +
                                   "subsets of equal sum");
            else
                Console.WriteLine("Can not be divided into " +
                                   "two subsets of equal sum");




             int[] arr = new int[] { 1, 5, 8, 9, 10, 17, 17, 20 };
            int size = arr.Length;
            Console.WriteLine("Maximum Obtainable Value is " + rodcutting.cutRod(arr, size));




               Console.WriteLine("Enter the amount you want to change:");
            double origAmount = Convert.ToDouble(Console.ReadLine());
            double toChange = origAmount;
            double remainAmount = 0.0;
            int[] coins = new int[4];
            Coinchange.MakeChange(origAmount, remainAmount, coins);

            Console.WriteLine("The best way to change " +
            toChange + " cents is: ");
            Coinchange.ShowChange(coins);


          
               Console.WriteLine();
            Console.Write(">> Please enter a string: ");
            string theString = Console.ReadLine();

            Console.Write(">> Please enter a list of words, separated by commas: ");
            List<string> theWordList = Console.ReadLine().Split(',').ToList();

            Console.WriteLine();

            TheWordBreaker wordBreaker = new TheWordBreaker();

            if (wordBreaker.DoesStringContainAnyProvidedWords(theString, theWordList))
            {
                Console.WriteLine(wordBreaker.ResultsMessage);
            }
            else
            {
                Console.WriteLine(wordBreaker.NoResultsMessage);
            }
             */




            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
