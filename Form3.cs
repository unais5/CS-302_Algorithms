using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void Form3_Load(object sender, EventArgs e)
        {
           
            switch (global.algo) {

                case 1:
                    textBox1.Text = "ALGORITHM: Longest Common Subsequence";
                    string data1 = global.Data[2 * global.subset];
                    string data2 = global.Data[2 * global.subset + 1];
                    textBox2.Text = "1."+ data1;
                    textBox2.AppendText(Environment.NewLine);
                    textBox2.AppendText("2. " + data2);

                    LCS lcs = new LCS(data1, data2);
                    int count = lcs.FindLCS();
                    textBox3.Text = "Total Matches: " + count;
                    textBox3.AppendText(Environment.NewLine);
                    textBox3.AppendText("Subsequence: " + global.lcs);
                    global.lcs = null;
                    break;
                case 2:
                    textBox1.Text = "ALGORITHM: Shortest Common Supersequence";
                    string X = global.Data[2 * global.subset];
                    string Y = global.Data[2 * global.subset + 1];
                    textBox2.Text = "1." + X;
                    textBox2.AppendText(Environment.NewLine);
                    textBox2.AppendText("2. " + Y);
                    
                    GFG gfg = new GFG();
                    string a = gfg.printShortestSuperSeq(X, Y);
                    textBox3.AppendText("length: " + a.Length);
                   
                    textBox3.AppendText(Environment.NewLine);
                    textBox3.AppendText("Sequence: " + a);

                    break;
                case 3:
                    textBox1.Text = "ALGORITHM: Levenshtein Distance";
                    string x = global.Data[2 * global.subset];
                    string y = global.Data[2 * global.subset + 1];
                    textBox2.Text = "1." + x;
                    textBox2.AppendText(Environment.NewLine);
                    textBox2.AppendText("2. " + y);
                   
                    textBox3.AppendText("Distance: " + StringDistance.LevenshteinDistance(x, y));

                    break;
                case 4:

                    textBox1.Text = "ALGORITHM: Longest Increasing Subsequence";
                  
                    string data = global.Data1[ global.subset];
                    textBox2.Text = data;
                    string[] num = data.Split();
                    int[] numm = new int[num.Length];
                    for (int i = 0; i < num.Length; i++)
                    {
                        numm[i] = int.Parse(num[i]);
                    }
                    textBox3.Text= "length:"+longestIncreasingSubsequence.Printseq(numm);
                    textBox3.AppendText(Environment.NewLine);
                    textBox3.AppendText("LIS: " + global.lis);
                    break;
                case 5:
                    textBox1.Text = "ALGORITHM: Matrix Chain Multiplication";
                    string dat = global.Data1[global.subset];
                    textBox2.Text = dat;
                    string[] n1 = dat.Split();
                    int[] nu = new int[n1.Length];
                    for (int i = 0; i < n1.Length; i++)
                    {
                        nu[i] = int.Parse(n1[i]);
                    }
                    int len = nu.Length;
                   /* int[] ar = { 40, 20, 30, 10, 30 };
                    int n2 = ar.Length;
                    MCM.matrixChainOrder(ar, n2);*/
                    MCM.matrixChainOrder(nu, len);
                    textBox3.Text = "Cost: " + global.mcmcost;
                    textBox3.AppendText(Environment.NewLine);
                   // textBox3.AppendText("Order of multiplication: " + global.mcm);
                    break;
                case 6:
                    textBox1.Text = "ALGORITHM: 0/1 Knapsack";

                    
                    string[] arr = global.Data1[global.subset].Split(',');
                    textBox2.Text = global.Data1[global.subset];
                    int[] w = new int[arr.Length];
                    int[] v = new int[arr.Length];
                    for (int i =0; i<arr.Length; i++)
                    {
                        string[] barr=arr[i].Split();
                        v[i] = int.Parse(barr[0]);
                        w[i] = int.Parse(barr[1]);
                    }
                    int W = 241;
                    int n = v.Length;

                    string res=knapsack.printknapSack(W, w, v, n);
                    textBox3.Text = "total value: " + global.knapsack;
                    textBox3.AppendText(Environment.NewLine);
                    textBox3.AppendText("Weights selected: " + res);
                    break;
                case 7:
                    textBox1.Text = "ALGORITHM: Partition Problem";
                    string data4 = global.Data1[global.subset];
                    textBox2.Text = data4;
                    string[] n3 = data4.Split();
                    int[] nu1 = new int[n3.Length];
                    for (int i = 0; i < n3.Length; i++)
                    {
                        nu1[i] = int.Parse(n3[i]);
                    }
                    int len1 = nu1.Length;



                    if (PP.findPartiion(nu1, len1) == true)
                      textBox3.Text= "Can be divided into two subsets of equal sum";
                    else
                        textBox3.Text = ("Can not be divided into " +
                                           "two subsets of equal sum");
                    break;
                case 8:
                    textBox1.Text = "ALGORITHM: Rod Cutting Problem";
                    string[] array = global.Data1[global.subset].Split(',');
                    textBox2.Text = global.Data1[global.subset];
                    int[] lengths = new int[array.Length];
                    int[] price = new int[array.Length];
                    for (int i = 0; i < array.Length; i++)
                    {
                        string[] barray = array[i].Split();
                        price[i] = int.Parse(barray[0]);
                        lengths[i] = int.Parse(barray[1]);
                    }
                    //int rl = 309;
                    int nn = price.Length;
                    textBox3.Text = "Maximum Obtainable Value is " + rodcutting.cutRod(price, nn);

                    break;
                case 9:
                    textBox1.Text = "ALGORITHM: Coin Change Problem";
                    string data5 = global.Data1[global.subset];
                    textBox2.Text = data5;
                    string[] n4 = data5.Split();
                    int[] nu2 = new int[n4.Length];
                    for (int i = 0; i < n4.Length; i++)
                    {
                        nu2[i] = int.Parse(n4[i]);
                    }
                    int m = nu2.Length;
                    int V = 309;
                    int coins= coin.minCoins(nu2, m, V);

                   
                    textBox3.Text = "Minimum number of coins required to get desired change is " + coins;

                    break;
                case 10:
                    textBox1.Text = "ALGORITHM: Word Break Problem";
                    textBox2.Text = global.Data1[ global.subset];




                    string theString = "MustafaUnais";
                    List<string> theWordList = global.Data1[global.subset].Split(',').ToList();

                    TheWordBreaker wordBreaker = new TheWordBreaker();

                    if (wordBreaker.DoesStringContainAnyProvidedWords(theString, theWordList))
                    {
                        textBox3.Text = "The following words were found in the provided string: ";
                        textBox3.AppendText(Environment.NewLine);
                        textBox3.AppendText( global.result);
                    }
                    else
                    {
                        textBox3.Text = "Unable to find any of the given words in the string provided.";
                        
                    }
                   
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
