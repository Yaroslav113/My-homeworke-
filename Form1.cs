using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * TODO
 * добавить кнопку удалить из листбокс1
 * прочитать про свободные лицензии
 * 
 * 
 * */
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int a=0;
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            a++;
            Console.WriteLine(a);
            if (a == 1)
            {
                label1.Text = "что-нибудь";
            }
            else if (a == 2)
            {
                label1.Text = "";
                a = 0;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)//добавляем выбраную записи во второй листбокс
        {
            /*Console.WriteLine(listBox1.SelectedIndex);
            Console.WriteLine(listBox1.Items[listBox1.SelectedIndex]);*/
            if (listBox1.SelectedIndex >-1)
            {
                listBox2.Items.Add(listBox1.Items[listBox1.SelectedIndex]);
                //сделать проверку на то чтобы нельзя было добавлять одинаковые


            }

                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //удалить всё
            listBox2.Items.Clear();//Удаляет все из листбокс2
        }

        private void button4_Click(object sender, EventArgs e)//удаляет выбранную записи из второго лисбокса 
        {
            listBox2.Items.Remove(listBox2.Items[listBox2.SelectedIndex]);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string newItem = "";
            newItem = textBox1.Text;
            if (newItem !="") //прочитать про метод Equals
            {
            listBox1.Items.Add(newItem);

            }

            //listBox1.Items.Add(textBox1.Text.Trim());

            //сделать проверку на то чтобы нельзя добавлять пустые и те которые уже есть

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
