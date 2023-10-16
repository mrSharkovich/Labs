using System;
using System.Windows.Forms;

namespace Лаба4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Factorial(int n) //Вычисление факториала
        {
            int result = 1;//первый множитель факториала
            for (int i = 1; i <= n; i++) //пока множитель не равен искомому факториалу
            {
                result = result * i;//доавляем к результату слудеющее произведение
            }
            return result;//возвращаем факториал
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();//Закрыть форму
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double x, accur, sum, active;//Вводим переменные
            Int32 k;
            x = Convert.ToDouble(textBox1.Text);
            accur = Convert.ToDouble(textBox2.Text);//Конвертируем входные данные
            k = 2;//переменная начинается с 2, тк первые 2 слагаемых, не требуют факториала
            active = Math.Pow(x, k) / Factorial(k);//действующее слагаемое (3 по формуле)
            sum = 1 + x;//начало формулы (первые 2 слагаемых)
            None.Items.Add("Ответ: " + Math.Exp(x));
            while (Math.Abs(active) > accur)//пока модуль слагаемого больше точности
            {
                k = k + 1;
                sum = sum + active;//добавляем к сумме слагаемое
                active = (Math.Pow(x, k) / Factorial(k));// считаем слагаемое
            }
            None.Items.Add("Точность: " + accur);
            None.Items.Add("Сумма: " + sum);//Выводим ответ
            

        }
    }
}
