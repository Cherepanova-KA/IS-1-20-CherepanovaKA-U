using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_1_20_CherepanovaKA_U
{
    public partial class Task1 : Form
    {
        public object ListBox { get; private set; }

        public abstract class Complektation<T>
        {
            public int Price;
            public int Year_of_issue;
            public T Article;

            public Complektation(int price, int year_of_issue, T article)
            {
                this.Price = price;
                this.Year_of_issue = year_of_issue;
                this.Article = article;
            }
            public void Display()
            {
                MessageBox.Show($"цена{Price}, год выпуска{Year_of_issue}, артикул{Article}");
            }
        }
        class Harddrives<T> : Complektation<T>
        {
            public int number_of_Turns;
            public string Interface;
            public int volume;

            public Harddrives(int number_of_Turns, string Interface, int Volume, int Price, int Year_of_issue, T Article) : base(Price, Year_of_issue, Article)
            {
                this.number_of_Turns = number_of_Turns;
                this.Interface = Interface;
                this.volume = Volume;
            }
            public void newDisplay()
            {
                MessageBox.Show($"Количество Оборотов{number_of_Turns}, Интерфейс{Interface}, Объем{volume}, цена{Price}, год выпуска{Year_of_issue}, артикул{Article}");
            }
        }
        class Videoscard<T> : Complektation<T>
        {
            public int gpu_frequency;
            public string manufacturer;
            public int memory_size;

            public Videoscard(int Price, int Year_of_issue, T Atricle, int Gpu_frequency, string Manufacturer, int Memory_size) : base(Price, Year_of_issue, Atricle)
            {
                this.gpu_frequency = Gpu_frequency;
                this.manufacturer = Manufacturer;
                this.memory_size = Memory_size;
            }
            public void newDisplay()
            {
                MessageBox.Show($"цена{Price}, год выпуска{Year_of_issue}, артикул{Article},частота{gpu_frequency}, изготовитель{manufacturer}, Объем памяти{memory_size} гб");
            }


        }
        public Task1()
        {
            InitializeComponent();
        }
        private void Task1_Load(object sender, EventArgs e)
        {

        }

        private void Task1_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           TextBox();
            _ = $"Цена {textBox1.Text}";
            _ = $"Год {textBox2.Text}";
            _ = $"Артикул {textBox3.Text}";
            _ = $"Кол-во оборотов {textBox4.Text}";
            _ = $"Интерфейс {textBox5.Text}";
            _ = $"Объем {textBox6.Text}";
            Harddrives<int> i1 = new Harddrives<int>(Convert.ToInt32(textBox4.Text), textBox5.Text, Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
            i1.Display();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        }
    }
}
   
