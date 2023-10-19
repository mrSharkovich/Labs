using System;
using System.Windows.Forms;

namespace Лаба6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private int[,] ArrayGen(int size, int size1)
        {
            int[,] result = new int[size, size1];
            Random generator = new Random();

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    result[i, j] = generator.Next(1,10);
            return result;
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int size, k, t, p, sum;
            string my_str;
            size = Convert.ToInt32(textBox1.Text);
            k = Convert.ToInt32(textBox2.Text);
            t = Convert.ToInt32(textBox3.Text);
            p = Convert.ToInt32(textBox4.Text);
            int[,] a = ArrayGen(size,size);

            for (int i = 0; i < size; i++)
            {
                my_str = "";
                for (int j = 0; j < size; j++)
                { 
                    my_str = my_str + " " + a[i, j].ToString(); //вывод матрицы
                }
                listBox1.Items.Add(my_str);
            }
            listBox1.Items.Add("           ");

            for (int i = 0; i < size; i++)
                a[i, k-1] = a[i, k - 1] + (a[t-1, i] * p);

            for (int i = 0; i < size; i++)
            {
                sum = 0;
                for (int j = 0; j < size; j++)
                {
                    sum = sum + a[i, j]; //вывод cумм
                }
                listBox2.Items.Add(sum);
            }

        }
    }
}
