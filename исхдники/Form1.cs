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

namespace total
{
    public partial class Form1 : Form
    {
        char[] array = {   };                                              //цифры на поле
        int[] arrayS = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }; //состояния цифр
        int clk = 0;                                                       //количество ходов
        int trying = 3;                                                    //количество попыток
        string check = "";
        string anwsers = "";

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
           for (int i = 0; i < 16; i++)
            {
                check = check + arrayS[i];
            }
            if (check == anwsers)
            {
                button1.Enabled = false;
                MessageBox.Show("Победа!");

            }
            else { 
                check = "";
                trying--;
                label20.Text = Convert.ToString(trying);
                MessageBox.Show("Неверный ответ! Осталось попыток: " + Convert.ToString(trying));
            }
            if (trying == 0) {
                button1.Enabled = false;
                MessageBox.Show("Вы проиграли!");
            }
         }

        private void label1_Click(object sender, EventArgs e)
        {
            clk++;
            labelClk.Text = Convert.ToString(clk);
            if(label1.BackColor == Color.White) {
                label1.BackColor = Color.Black;
                label1.ForeColor = Color.White;
                arrayS[0] = 1;
                
            }
            else {
                label1.BackColor = Color.White;
                label1.ForeColor = Color.Black;
                arrayS[0] = 0;
            }
           
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
            clk++;
            labelClk.Text = Convert.ToString(clk);
            if (label2.BackColor == Color.White)
            {
                label2.BackColor = Color.Black;
                label2.ForeColor = Color.White;
                arrayS[1] = 1;
            }
            else
            {
                label2.BackColor = Color.White;
                label2.ForeColor = Color.Black;
                arrayS[1] = 0;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            clk++;
            labelClk.Text = Convert.ToString(clk);
            if (label3.BackColor == Color.White)
            {
                label3.BackColor = Color.Black;
                label3.ForeColor = Color.White;
                arrayS[2] = 1;
            }
            else
            {
                label3.BackColor = Color.White;
                label3.ForeColor = Color.Black;
                arrayS[2] = 0;

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            clk++;
            labelClk.Text = Convert.ToString(clk);
            if (label4.BackColor == Color.White)
            {
                label4.BackColor = Color.Black;
                label4.ForeColor = Color.White;
                arrayS[3] = 1;
            }
            else
            {
                label4.BackColor = Color.White;
                label4.ForeColor = Color.Black;
                arrayS[3] = 0;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            clk++;
            labelClk.Text = Convert.ToString(clk);
            if (label5.BackColor == Color.White)
            {
                label5.BackColor = Color.Black;
                label5.ForeColor = Color.White;
                arrayS[4] = 1;
            }
            else
            {
                label5.BackColor = Color.White;
                label5.ForeColor = Color.Black;
                arrayS[4] = 0;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            clk++;
            labelClk.Text = Convert.ToString(clk);
            if (label6.BackColor == Color.White)
            {
                label6.BackColor = Color.Black;
                label6.ForeColor = Color.White;
                arrayS[5] = 1;
            }
            else
            {
                label6.BackColor = Color.White;
                label6.ForeColor = Color.Black;
                arrayS[5] = 0;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            clk++;
            labelClk.Text = Convert.ToString(clk);
            if (label7.BackColor == Color.White)
            {
                label7.BackColor = Color.Black;
                label7.ForeColor = Color.White;
                arrayS[6] = 1;
            }
            else
            {
                label7.BackColor = Color.White;
                label7.ForeColor = Color.Black;
                arrayS[6] = 0;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            clk++;
            labelClk.Text = Convert.ToString(clk);
            if (label8.BackColor == Color.White)
            {
                label8.BackColor = Color.Black;
                label8.ForeColor = Color.White;
                arrayS[7] = 1;
            }
            else
            {
                label8.BackColor = Color.White;
                label8.ForeColor = Color.Black;
                arrayS[7] = 0;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            clk++;
            labelClk.Text = Convert.ToString(clk);
            if (label9.BackColor == Color.White)
            {
                label9.BackColor = Color.Black;
                label9.ForeColor = Color.White;
                arrayS[8] = 1;
            }
            else
            {
                label9.BackColor = Color.White;
                label9.ForeColor = Color.Black;
                arrayS[8] = 0;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            clk++;
            labelClk.Text = Convert.ToString(clk);
            if (label10.BackColor == Color.White)
            {
                label10.BackColor = Color.Black;
                label10.ForeColor = Color.White;
                arrayS[9] = 1;
            }
            else
            {
                label10.BackColor = Color.White;
                label10.ForeColor = Color.Black;
                arrayS[9] = 0;
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            clk++;
            labelClk.Text = Convert.ToString(clk);
            if (label11.BackColor == Color.White)
            {
                label11.BackColor = Color.Black;
                label11.ForeColor = Color.White;
                arrayS[10] = 1;
            }
            else
            {
                label11.BackColor = Color.White;
                label11.ForeColor = Color.Black;
                arrayS[10] = 0;
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            clk++;
            labelClk.Text = Convert.ToString(clk);
            if (label12.BackColor == Color.White)
            {
                label12.BackColor = Color.Black;
                label12.ForeColor = Color.White;
                arrayS[11] = 1;
            }
            else
            {
                label12.BackColor = Color.White;
                label12.ForeColor = Color.Black;
                arrayS[11] = 0;
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            clk++;
            labelClk.Text = Convert.ToString(clk);
            if (label13.BackColor == Color.White)
            {
                label13.BackColor = Color.Black;
                label13.ForeColor = Color.White;
                arrayS[12] = 1;
            }
            else
            {
                label13.BackColor = Color.White;
                label13.ForeColor = Color.Black;
                arrayS[12] = 0;
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {
            clk++;
            labelClk.Text = Convert.ToString(clk);
            if (label14.BackColor == Color.White)
            {
                label14.BackColor = Color.Black;
                label14.ForeColor = Color.White;
                arrayS[13] = 1;
            }
            else
            {
                label14.BackColor = Color.White;
                label14.ForeColor = Color.Black;
                arrayS[13] = 0;
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {
            clk++;
            labelClk.Text = Convert.ToString(clk);
            if (label15.BackColor == Color.White)
            {
                label15.BackColor = Color.Black;
                label15.ForeColor = Color.White;
                arrayS[14] = 1;
            }
            else
            {
                label15.BackColor = Color.White;
                label15.ForeColor = Color.Black;
                arrayS[14] = 0;
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {
            clk++;
            labelClk.Text = Convert.ToString(clk);
            if (label16.BackColor == Color.White)
            {
                label16.BackColor = Color.Black;
                label16.ForeColor = Color.White;
                arrayS[15] = 1;
            }
            else
            {
                label16.BackColor = Color.White;
                label16.ForeColor = Color.Black;
                arrayS[15] = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            clk = 0;                                                       //количество ходов
            trying = 3;                                                    //количество попыток
            check = "";
            anwsers = "";
            labelClk.Text = Convert.ToString(clk);
            var fileContent = string.Empty;
            var filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            { 
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {                
                    filePath = openFileDialog.FileName;
                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();
                }
            }
            if (filePath != "") {
                StreamReader fs = new StreamReader(filePath);
                string s = "";
                s = fs.ReadLine();
                array = s.ToCharArray(0, 16);
                s = fs.ReadLine();
                anwsers = s;
                fs.Close();
                List<Control> list_labels = new List<Control>();
                list_labels.Add(label1);
                list_labels.Add(label2);
                list_labels.Add(label3);
                list_labels.Add(label4);
                list_labels.Add(label5);
                list_labels.Add(label6);
                list_labels.Add(label7);
                list_labels.Add(label8);
                list_labels.Add(label9);
                list_labels.Add(label10);
                list_labels.Add(label11);
                list_labels.Add(label12);
                list_labels.Add(label13);
                list_labels.Add(label14);
                list_labels.Add(label15);
                list_labels.Add(label16);
                label20.Text = Convert.ToString(trying);
                for (int i = 0; i < 16; i++)
                {
                    list_labels[i].Text = Convert.ToString(array[i]);
                }
                button1.Enabled = true;
            }
            else MessageBox.Show("Файл не выбран!");   
        }
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Игровое поле состоит из прямоугольника (квадрата), разбитого на единичные квадратики, каждый из которых содержит одно число. \nНужно закрасить некоторые из них по определенным правилам: \n \n1)в каждой строке и столбце среди незакрашенных клеток не должно быть одинаковых цифр. \n2)закрашенные ячейки не могут иметь общих сторон. \n3)незакрашенные ячейки должны формировать связную систему (то есть с каждой из них можно дойти до любой другой, двигаясь по вертикали или горизонтали.");
        }
    }
}
