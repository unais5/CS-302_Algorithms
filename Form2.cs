using System;
using System.IO;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private Button button = new Button();
        private void Form2_Load(object sender, EventArgs e)
        {
           switch (global.dataset)
            {
                case 1:
                    button1.Visible = true;
                    button2.Visible = true;
                    button3.Visible = true;
                    button4.Visible = false;
                    button5.Visible = false;
                    button6.Visible = false;
                    button7.Visible = false;
                    button8.Visible = false;
                    button9.Visible = false;
                    button10.Visible = false;
                    using (var reader = new StreamReader(@"C:\Users\mustafa\source\repos\ConsoleApp2\ConsoleApp2\dataset1.csv"))
                    {
                        List<string> listA = new List<string>();
                        while (!reader.EndOfStream)
                        {
                            var line = reader.ReadLine();
                            var values = line.Split(';');

                            listA.Add(values[0]);

                        }
                        string[] data = new string[listA.Count];
                        for (int i = 0; i < listA.Count; i++)
                        {
                            data[i] = listA[i];
                            Button folderButton = new Button();
                            folderButton.Width = 150;
                            folderButton.Height = 70;
                            folderButton.ForeColor = Color.AntiqueWhite;
                            folderButton.Text = "Data Set " + "1." + (i+1) ;
                            folderButton.Tag = i;
                            folderButton.Enter += myBtn_GotFocus;
                            folderButton.Leave += myBtn_LostFocus;
                            //This will work and add button to your Form.
                            folderButton.Click += butt_clicked;
                            if (i < 10)
                            {
                                folderButton.Location = new Point(100, 70 + i * 70);
                                this.Controls.Add(folderButton);
                            }
                          
                           

                        }
                        global.Data = data;
                      
                       




    }
                    break;
                case 2:
                    button1.Visible = false;
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = true;
                    button5.Visible = true;
                    button6.Visible = false;
                    button7.Visible = true;
                    button8.Visible = false;
                    button9.Visible = true;
                    button10.Visible = false;
                    using (var reader = new StreamReader(@"C:\Users\mustafa\source\repos\ConsoleApp2\ConsoleApp2\dataset2.csv"))
                    {
                        List<string> listA = new List<string>();
                        while (!reader.EndOfStream)
                        {
                            var line = reader.ReadLine();
                            var values = line.Split(';');

                            listA.Add(values[0]);

                        }
                        string[] data = new string[listA.Count];
                        for (int i = 0; i < listA.Count; i++)
                        {
                            data[i] = listA[i];
                            Button folderButton = new Button();
                            folderButton.Width = 150;
                            folderButton.Height = 70;
                            folderButton.ForeColor = Color.AntiqueWhite;
                            folderButton.Text = "Data Set " + "2." + (i + 1);
                            folderButton.Tag = i;
                            folderButton.Location = new Point(100, 70 + i * 70);
                            folderButton.Enter += myBtn_GotFocus;
                            folderButton.Leave += myBtn_LostFocus;
                            //This will work and add button to your Form.
                            folderButton.Click += butt_clicked;
                            this.Controls.Add(folderButton);

                        }


                        global.Data1 = data;
                    }
                    
                    break;
                case 3:
                    button1.Visible = false;
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;
                    button6.Visible = true;
                    button7.Visible = false;
                    button8.Visible = true;
                    button9.Visible = false;
                    button10.Visible = false;
                    using (var reader = new StreamReader(@"C:\Users\mustafa\source\repos\ConsoleApp2\ConsoleApp2\dataset3.csv"))
                    {
                        List<string> listA = new List<string>();
                        while (!reader.EndOfStream)
                        {
                            var line = reader.ReadLine();
                            var values = line.Split(';');

                            listA.Add(values[0]);

                        }
                        string[] data = new string[listA.Count];
                        for (int i = 0; i < listA.Count; i++)
                        {
                            data[i] = listA[i];
                            Button folderButton = new Button();
                            folderButton.Width = 150;
                            folderButton.Height = 70;
                            folderButton.ForeColor = Color.AntiqueWhite;
                            folderButton.Text = "Data Set " + "3." + (i + 1);
                            folderButton.Tag = i;
                            folderButton.Location = new Point(100, 70 + i * 70);
                            folderButton.Enter += myBtn_GotFocus;
                            folderButton.Leave += myBtn_LostFocus;
                            //This will work and add button to your Form.
                            folderButton.Click += butt_clicked;
                            this.Controls.Add(folderButton);

                        }
                        global.Data1 = data;
                    }
                    break;
                case 4:
                    button1.Visible = false;
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;
                    button6.Visible = false;
                    button7.Visible = false;
                    button8.Visible = false;
                    button9.Visible = false;
                    button10.Visible = true;
                    using (var reader = new StreamReader(@"C:\Users\mustafa\source\repos\ConsoleApp2\ConsoleApp2\dataset4.csv"))
                    {
                        List<string> listA = new List<string>();
                        while (!reader.EndOfStream)
                        {
                            var line = reader.ReadLine();
                            var values = line.Split(';');

                            listA.Add(values[0]);

                        }
                        string[] data = new string[listA.Count];
                        for (int i = 0; i < listA.Count; i++)
                        {
                            data[i] = listA[i];
                            Button folderButton = new Button();
                            folderButton.Width = 150;
                            folderButton.Height = 70;
                            folderButton.ForeColor = Color.AntiqueWhite;
                            folderButton.Text = "Data Set " + "4." + (i + 1);
                            folderButton.Tag = i;
                            folderButton.Location = new Point(100, 70 + i * 70);
                            folderButton.Enter += myBtn_GotFocus;
                            folderButton.Leave += myBtn_LostFocus;
                            //This will work and add button to your Form.
                            folderButton.Click += butt_clicked;
                            this.Controls.Add(folderButton);

                        }
                        global.Data1 = data;
                    }
                    break;
            }
        }
        private void butt_clicked (object sender, EventArgs e)
        {
            Button clicked = (Button)sender;
            clicked.Focus();
            global.subset = int.Parse(clicked.Tag.ToString());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            global.algo = 2;
            button1.BackColor = Color.Black;
            button2.BackColor = Color.Silver;
            button3.BackColor = Color.Black;
            button4.BackColor = Color.Black;
            button5.BackColor = Color.Black;
            button6.BackColor = Color.Black;
            button7.BackColor = Color.Black;
            button8.BackColor = Color.Black;
            button9.BackColor = Color.Black;
            button10.BackColor = Color.Black;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            global.algo = 1;
            button1.BackColor= Color.Silver;
            button2.BackColor = Color.Black;
            button3.BackColor = Color.Black;
            button4.BackColor = Color.Black;
            button5.BackColor = Color.Black;
            button6.BackColor = Color.Black;
            button7.BackColor = Color.Black;
            button8.BackColor = Color.Black;
            button9.BackColor = Color.Black;
            button10.BackColor = Color.Black;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            global.algo = 3;
            button1.BackColor = Color.Black;
            button2.BackColor = Color.Black;
            button3.BackColor = Color.Silver;
            button4.BackColor = Color.Black;
            button5.BackColor = Color.Black;
            button6.BackColor = Color.Black;
            button7.BackColor = Color.Black;
            button8.BackColor = Color.Black;
            button9.BackColor = Color.Black;
            button10.BackColor = Color.Black;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            global.algo = 4;
            button1.BackColor = Color.Black;
            button2.BackColor = Color.Black;
            button3.BackColor = Color.Black;
            button4.BackColor = Color.Silver;
            button5.BackColor = Color.Black;
            button6.BackColor = Color.Black;
            button7.BackColor = Color.Black;
            button8.BackColor = Color.Black;
            button9.BackColor = Color.Black;
            button10.BackColor = Color.Black;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            global.algo = 5;
            button1.BackColor = Color.Black;
            button2.BackColor = Color.Black;
            button3.BackColor = Color.Black;
            button4.BackColor = Color.Black;
            button5.BackColor = Color.Silver;
            button6.BackColor = Color.Black;
            button7.BackColor = Color.Black;
            button8.BackColor = Color.Black;
            button9.BackColor = Color.Black;
            button10.BackColor = Color.Black;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            global.algo = 6;
            button1.BackColor = Color.Black;
            button2.BackColor = Color.Black;
            button3.BackColor = Color.Black;
            button4.BackColor = Color.Black;
            button5.BackColor = Color.Black;
            button6.BackColor = Color.Silver;
            button7.BackColor = Color.Black;
            button8.BackColor = Color.Black;
            button9.BackColor = Color.Black;
            button10.BackColor = Color.Black;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            global.algo = 7;
            button1.BackColor = Color.Black;
            button2.BackColor = Color.Black;
            button3.BackColor = Color.Black;
            button4.BackColor = Color.Black;
            button5.BackColor = Color.Black;
            button6.BackColor = Color.Black;
            button7.BackColor = Color.Silver;
            button8.BackColor = Color.Black;
            button9.BackColor = Color.Black;
            button10.BackColor = Color.Black;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            global.algo = 8;
            button1.BackColor = Color.Black;
            button2.BackColor = Color.Black;
            button3.BackColor = Color.Black;
            button4.BackColor = Color.Black;
            button5.BackColor = Color.Black;
            button6.BackColor = Color.Black;
            button7.BackColor = Color.Black;
            button8.BackColor = Color.Silver;
            button9.BackColor = Color.Black;
            button10.BackColor = Color.Black;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            global.algo = 9;
            button1.BackColor = Color.Black;
            button2.BackColor = Color.Black;
            button3.BackColor = Color.Black;
            button4.BackColor = Color.Black;
            button5.BackColor = Color.Black;
            button6.BackColor = Color.Black;
            button7.BackColor = Color.Black;
            button8.BackColor = Color.Black;
            button9.BackColor = Color.Silver;
            button10.BackColor = Color.Black;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            global.algo = 10;
            button1.BackColor = Color.Black;
            button2.BackColor = Color.Black;
            button3.BackColor = Color.Black;
            button4.BackColor = Color.Black;
            button5.BackColor = Color.Black;
            button6.BackColor = Color.Black;
            button7.BackColor = Color.Black;
            button8.BackColor = Color.Black;
            button9.BackColor = Color.Black;
            button10.BackColor = Color.Silver;
        }
        private void myBtn_GotFocus(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;
            clicked.BackColor = Color.Silver;
        }

        private void myBtn_LostFocus(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;
            clicked.BackColor = Color.Black;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f = new Form3();
            f.ShowDialog();
        }
    }
}
