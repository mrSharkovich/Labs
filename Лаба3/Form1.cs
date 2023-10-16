using System;
using System.Windows.Forms;

namespace Лаба3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int n;                // вводим переменные
            double x, sum1, sum2;
            n = Convert.ToInt32(textBox1.Text);//конвертируем в нужный тип
            x = Convert.ToDouble(textBox2.Text);
            sum1 = 0;//сумма положительных (нечетных)
            sum2 = 0;//сумма отрицальных (четных)
            for (var i = 1; i < n + 1; i += 2)//
            {
                sum1 = (sum1 + (Math.Pow(x, i) / i));//к сумме прибавляем новое слагаемое

            }
            for (var i = 2; i < n + 1; i += 2)//
            {
                sum2 = (sum2 - (Math.Pow(x, i) / i));//от суммы вычитает новое слагаемое
            }
            none.Items.Add(sum1 + sum2);//выводи их сумму
        }
    }
}
