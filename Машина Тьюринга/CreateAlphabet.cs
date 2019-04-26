using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Машина_тьюринга
{
    public partial class CreateAlphabet : Form
    {
        public string[] mas; // массив, в котором будет хранится алфавит
        public CreateAlphabet()
        {
            InitializeComponent();
        }

        private void alph1_Click(object sender, EventArgs e) //формирование массива 4 разными способами (alph - объединение)
        {
            mas = new string[3];
            mas[0] = "0";
            mas[1] = "1";
            mas[2] = "E";
            Hide();
            
        }

        private void alph2_Click(object sender, EventArgs e)
        {
            mas = new string[4];
            mas[0] = "A";
            mas[1] = "B";
            mas[2] = "C";
            mas[3] = "E";
            Hide();
        }

        private void alph3_Click(object sender, EventArgs e)
        {
            mas = new string[13];
            for (int i = 0; i < 10; i++)
                mas[i] = Convert.ToString(i);
            mas[10] = "+";
            mas[11] = "-";
            mas[12] = "E";
            Hide();
        }

        private void alph_Click(object sender, EventArgs e)
        {
            try
            {
                string s = CreateMasText.Text;
                for (int i = 0; i < s.Length; i++)
                    if (s[i] == ' ')
                        s = s.Remove(i, 1);
                string [] bufMas = new string[s.Length];
                for (int i = 0; i < s.Length; i++)
                {
                    bufMas[i] = Convert.ToString(s[i]);
                    if (bufMas[i]=="E" || bufMas[i] == "Е") // проверка на наличие зарезервированного символа
                    {
                        bufMas = null;
                    }
                }
                Array.Sort(bufMas); //сортировка для удобства
                bufMas = bufMas.Distinct().ToArray(); //избавление от пробелов лишних
                mas = new string[bufMas.Length + 1];
                for (int i = 0; i < bufMas.Length; i++)
                    mas[i] = bufMas[i];
                mas[mas.Length - 1] = "E"; // добавление пустого символа в массив
                Hide();
            }
            catch
            {
                MessageBox.Show("Нельзя использовать зарезервированное значение E !", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mas = null;
                CreateMasText.Text = "";
            }
        }
        private void buttonAlphCreate_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    StreamReader sr = new StreamReader(ofd.FileName, Encoding.Default);
                    string s = sr.ReadToEnd();
                    for (int i = 0; i < s.Length; i++)
                        if (s[i] == ' ')
                            s = s.Remove(i, 1);
                    string[] bufMas = new string[s.Length];
                    for (int i = 0; i < s.Length; i++)
                        bufMas[i] = Convert.ToString(s[i]);
                    Array.Sort(bufMas);
                    bufMas = bufMas.Distinct().ToArray();
                    mas = new string[bufMas.Length + 1];
                    for (int i = 0; i < bufMas.Length; i++)
                        mas[i] = bufMas[i];
                    mas[mas.Length - 1] = "E";
                    Hide();
                    sr.Close();
                }
            }
            catch
            {
                MessageBox.Show("Ваш алфавит был введён неверно!");
                mas = null;
            }

        }
        private void back_Click(object sender, EventArgs e)
        {
            Hide();
        }

    }
}
