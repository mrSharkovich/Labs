using System;
using System.Windows.Forms;

namespace Лаба5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int[] ArrayGen(int size)//создаём функцию генератора массива случайных чисел
        {
            int[] result = new int[size];//создаём массив
            Random generator = new Random();//создаём генератор случайных чисел

            result[0] = generator.Next(10);//генерируем 1 число массива

            for (int i = 1; i < size; i++)
                result[i] = generator.Next(-10, 10);//заполняем массив
            return result;//возвращаем результат

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();//закрываем форму
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int my_size, num_min = 0;//вводим типы переменных
            string my_min = "Нет отрицательных", my_str = "";

            my_size=Convert.ToInt32(textBox1.Text);//конвертируем заданную переменную размера
            int[] a = ArrayGen(my_size);//приминяем функцию генерации массива

            for (int i = 0; i < my_size; i++)
            {
                listBox1.Items.Add(a[i]);//выводим массив
            }

            for (int i = 0; i < my_size; i++) 
            {
                if (a[i] < 0) //ищем первое отрицальтельное число
                {
                    my_min = a[i].ToString();//запоминаем число
                    num_min = i;//запоминаем расположение отрицательного числа в массиве
                    break;//останавливаем цикл
                }
            }
            for (int i = 0; i < my_size; i++)//создаём строку из удовлетворяющих нас чисел
            {
                if (a[i] < num_min)
                    my_str =my_str + " " + a[i].ToString();
            }

            textBox2.Text = my_min;//выводим значение первого отрицательного
            textBox3.Text = num_min.ToString();//выводим номер первого отрицательного
            listBox2.Items.Add(my_str);//выводим удовлетворяющие условию числа в строке
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r' || e.KeyChar == '\n')
            {
                button1_Click(sender, e);   
            }
        }
    }
}
