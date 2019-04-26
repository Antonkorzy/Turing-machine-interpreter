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
    public partial class Main : Form
    {       
        internal Code[,] tableCode = new Code[1,1]; //таблица с командами пользователя
        CreateAlphabet ca = new CreateAlphabet();
        public Main()
        {
            InitializeComponent();
        }

        //регион, отвечающий за интерфейс программы
        #region Interface
        private int NumLenta = 201; // количество элементов на ленте
        private int PosLenta = 88; // Крайняя левая позиция на ленте, для сдвига 
        private void Main_Load(object sender, EventArgs e)
        {
            EventTable.Refresh();
            Lenta.RowCount = 1;
            LentaNum.RowCount = 1;
            Lenta.ColumnCount = NumLenta;

            LentaNum.ColumnCount = NumLenta;
            for (int i = 0; i <= NumLenta - 1; i++) //генерация ленты
            {
                LentaNum[i, 0].Value = i - 100;
                LentaNum.Columns[i].Width = Lenta.Columns[i].Width = 30;
                Lenta.Rows[0].Cells[i].Value = "E";
            }
            Lenta.FirstDisplayedScrollingColumnIndex = PosLenta;
            LentaNum.FirstDisplayedScrollingColumnIndex = PosLenta;
            buttonStart.Enabled = false;
            buttonAddCol.Enabled = false;
            buttonDelCol.Enabled = false;
            buttonStep.Enabled = false;
            СохранитьToolStripMenuItem.Enabled = false;
        }
        private void Main_Resize(object sender, EventArgs e)
        {
            //if (Lenta.FirstDisplayedScrollingColumnIndex > 12)
            //{
                Lenta.FirstDisplayedScrollingColumnIndex = midLenta - 12;
                LentaNum.FirstDisplayedScrollingColumnIndex = midLenta - 12;
            //}
        }

        //регион, относящийся к ленте
        #region Lenta_code
        private void Right_Click(object sender, EventArgs e)  // сдвиг ленты вправо
        {
            if (Lenta.FirstDisplayedScrollingColumnIndex < NumLenta - 1)
            {
                Lenta.FirstDisplayedScrollingColumnIndex++;
                LentaNum.FirstDisplayedScrollingColumnIndex++;
                PosLenta = Lenta.FirstDisplayedScrollingColumnIndex;
                midLenta++;
            }
        }
        private void Left_Click(object sender, EventArgs e) //cдвиг ленты влево
        {
            if (Lenta.FirstDisplayedScrollingColumnIndex > 0)
            {
                Lenta.FirstDisplayedScrollingColumnIndex--;
                LentaNum.FirstDisplayedScrollingColumnIndex--;
                PosLenta = Lenta.FirstDisplayedScrollingColumnIndex;
                midLenta--;
            }
        }
        private void Lenta_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) //считывание элемента ленты
        {
            Lenta.ClearSelection();

            if (ca.mas != null)
            {
                ChoseLentaElement cle = new ChoseLentaElement(this);
                cle.ShowDialog();
                Lenta.Rows[0].Cells[e.ColumnIndex].Value = cle.LentaVal;
                if (cle.LentaVal != "E")
                    Lenta.Rows[0].Cells[e.ColumnIndex].Style.Font = new Font(this.Font, FontStyle.Bold);
                else
                    Lenta.Rows[0].Cells[e.ColumnIndex].Style.Font = new Font(this.Font, FontStyle.Regular);
            }
            else
            {
                MessageBox.Show("Вы не ввели алфавит");
            }
        }


        #endregion

        //регион создания и форматирования таблицы с командами
        #region CreatingFormatting_MainTable
        private void CreateTableButton_Click(object sender, EventArgs e)
        {
            ca.ShowDialog();
            if (ca.mas != null)
            {
                EventTable.RowCount = 1;
                EventTable.ColumnCount = 1;
                EventTable.RowCount = ca.mas.GetLength(0) + 1;
                EventTable.ColumnCount = 3;
                for (int i = 0; i < ca.mas.Length; i++) // делаем подобие заголовка
                {
                    EventTable.Rows[i + 1].Cells[0].Style.BackColor = System.Drawing.Color.Gray;
                    EventTable.Rows[i + 1].Cells[0].Value = ca.mas[i];
                    EventTable.Rows[i + 1].Cells[0].ReadOnly = true;
                }
                EventTable.Rows[0].Cells[1].Style.BackColor = System.Drawing.Color.Gray;
                EventTable.Rows[0].Cells[2].Style.BackColor = System.Drawing.Color.Gray;
                EventTable.Rows[0].Cells[1].Value = "q1";
                EventTable.Rows[0].Cells[2].Value = "q2";
                EventTable.Rows[0].Cells[1].ReadOnly = true;
                EventTable.Rows[0].Cells[2].ReadOnly = true;
                EventTable.Rows[0].Cells[0].Style.BackColor = System.Drawing.Color.Gray;
                EventTable.Rows[0].Cells[0].ReadOnly = true;
                buttonStart.Enabled = true;
                buttonAddCol.Enabled = true;
                buttonDelCol.Enabled = true;
                labelYourAlphabet.Text = "Ваш алфавит: ";
                for (int i = 0; i < ca.mas.Length; i++)
                {
                    labelYourAlphabet.Text += ca.mas[i] + " ";
                }
                tableCode = new Code[ca.mas.GetLength(0) + 1, 4];
                for (int i = 0; i <= NumLenta - 1; i++)
                {
                    Lenta.Rows[0].Cells[i].Value = "E";
                }
                LastCodeColumnStep = 1;
                buttonStep.Enabled = true;
                textBoxTask.Clear();
                textBoxComment.Clear();
            }
        } //выбор алфавита и создание таблицы для команд пользователя
        private void buttonAddCol_Click(object sender, EventArgs e)
        {
            EventTable.ColumnCount++;
            EventTable.Rows[0].Cells[EventTable.ColumnCount - 1].Value = "q" + Convert.ToString(EventTable.ColumnCount - 1);
            EventTable.Rows[0].Cells[EventTable.ColumnCount - 1].Style.BackColor = System.Drawing.Color.Gray;
            EventTable.Rows[0].Cells[EventTable.ColumnCount - 1].ReadOnly = true;
            Code[,] bufTableCode = new Code[tableCode.GetLength(0), tableCode.GetLength(1) + 1];
            for (int i = 0; i < tableCode.GetLength(0); i++)
            {
                for (int j = 0; j < tableCode.GetLength(1); j++)
                {
                    bufTableCode[i, j] = tableCode[i, j];
                }
            }
            tableCode = bufTableCode;
        }
        private void buttonDelCol_Click(object sender, EventArgs e)
        {
            if (EventTable.ColumnCount > 2)
            {
                EventTable.ColumnCount--;
                Code[,] bufTableCode = new Code[tableCode.GetLength(0), tableCode.GetLength(1) - 1];
                for (int i = 0; i < bufTableCode.GetLength(0); i++)
                {
                    for (int j = 0; j < bufTableCode.GetLength(1); j++)
                    {
                        bufTableCode[i, j] = tableCode[i, j];
                    }
                }
                tableCode = bufTableCode;
            }
        }
        private void EventTable_CellEndEdit(object sender, DataGridViewCellEventArgs e) //считывание элемента таблицы в двумерный массив
        {
            try
            {
                string s = Convert.ToString(EventTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                bool flag = false;
                int j = -1;
                while ((j < ca.mas.Length) && (!flag))
                {
                    j++;
                    flag = s.StartsWith(ca.mas[j]);
                }
                if (flag)
                {
                    tableCode[e.RowIndex, e.ColumnIndex] = new Code();
                    tableCode[e.RowIndex, e.ColumnIndex].alph = ca.mas[j];
                    s = s.Remove(0, ca.mas[j].Length);
                    if (s[0] == '<' || s[0] == '>' || s[0] == '.')
                    {
                        tableCode[e.RowIndex, e.ColumnIndex].direction = s[0];
                        s = s.Remove(0, 1);
                        try
                        {
                            if ((Convert.ToInt32(s) <= tableCode.GetLength(1)+1) && (Convert.ToInt32(s) >= 1))
                            {
                                tableCode[e.RowIndex, e.ColumnIndex].q = Convert.ToInt32(s);
                            }
                            else
                            {
                                MessageBox.Show("Данные введены неверно");
                                EventTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Данные введены неверно");
                            EventTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Данные введены неверно");
                        EventTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
                    }
                }
                else
                {
                    MessageBox.Show("Данные введены неверно");
                    EventTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
                }
            }
            catch
            {
                MessageBox.Show("Данные введены неверно");
                EventTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
            }
        }
        #endregion
        
        #endregion

        //регион работы с алгоритмами интерпретатора
        #region Code_MainTable
        private int midLenta = 100;
        private int LastCodeColumnStep = 1;
        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {
                int LastCodeColumn = 1;
                while (LastCodeColumn < tableCode.GetLength(1) - 1)
                {
                    int i = 0;
                    if (Lenta.Rows[0].Cells[midLenta].Value == null)
                    {
                        i = EventTable.RowCount - 1;
                    }
                    else
                    {
                        while ((i < ca.mas.GetLength(0)) && (Convert.ToString(Lenta.Rows[0].Cells[midLenta].Value) != Convert.ToString(ca.mas[i])))
                        {
                            i++;
                        }
                    }
                    Lenta.Rows[0].Cells[midLenta].Value = tableCode[i + 1, LastCodeColumn].alph; //изменение значения на ленте
                    if (tableCode[i + 1, LastCodeColumn].alph != "E")
                    {
                        Lenta.Rows[0].Cells[midLenta].Style.Font = new Font(this.Font, FontStyle.Bold);
                    }
                    switch (tableCode[i + 1, LastCodeColumn].direction)  //сдвиг по ленте
                    {
                        case '<':
                            if (Lenta.FirstDisplayedScrollingColumnIndex > 0)
                            {
                                Lenta.FirstDisplayedScrollingColumnIndex--;
                                LentaNum.FirstDisplayedScrollingColumnIndex--;
                                PosLenta = Lenta.FirstDisplayedScrollingColumnIndex;
                                midLenta--;
                            }
                            break;
                        case '>':
                            if (Lenta.FirstDisplayedScrollingColumnIndex < NumLenta - 1)
                            {
                                Lenta.FirstDisplayedScrollingColumnIndex++;
                                LentaNum.FirstDisplayedScrollingColumnIndex++;
                                PosLenta = Lenta.FirstDisplayedScrollingColumnIndex;
                                midLenta++;
                            }
                            break;
                        case '.':
                            break;
                    }
                    LastCodeColumn = tableCode[i + 1, LastCodeColumn].q;
                    if (LastCodeColumn <= EventTable.ColumnCount - 1)
                    {
                        EventTable.Rows[i + 1].Cells[LastCodeColumn].Selected = true;                      
                    }
                }
                MessageBox.Show("Работа алгоритма завершена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Вы не ввели необходимые команды", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonStep_Click(object sender, EventArgs e)
        {
            if (LastCodeColumnStep <= EventTable.ColumnCount - 1)
            {
                try
                {
                    int i = 0;                  
                    if (Lenta.Rows[0].Cells[midLenta].Value == null)
                    {
                        i = EventTable.RowCount - 1;
                    }
                    else
                    {
                        while ((i < ca.mas.GetLength(0)) && (Convert.ToString(Lenta.Rows[0].Cells[midLenta].Value) != Convert.ToString(ca.mas[i])))
                        {
                            i++;
                        }
                    }                    
                    Lenta.Rows[0].Cells[midLenta].Value = tableCode[i + 1, LastCodeColumnStep].alph; //изменение значения на ленте
                    if (tableCode[i + 1, LastCodeColumnStep].alph != "E")
                    {
                        Lenta.Rows[0].Cells[midLenta].Style.Font = new Font(this.Font, FontStyle.Bold);
                    }
                    switch (tableCode[i + 1, LastCodeColumnStep].direction)  //сдвиг по ленте
                    {
                        case '<':
                            if (Lenta.FirstDisplayedScrollingColumnIndex > 0)
                            {
                                Lenta.FirstDisplayedScrollingColumnIndex--;
                                LentaNum.FirstDisplayedScrollingColumnIndex--;
                                PosLenta = Lenta.FirstDisplayedScrollingColumnIndex;
                                midLenta--;
                            }
                            break;
                        case '>':
                            if (Lenta.FirstDisplayedScrollingColumnIndex < NumLenta - 1)
                            {
                                Lenta.FirstDisplayedScrollingColumnIndex++;
                                LentaNum.FirstDisplayedScrollingColumnIndex++;
                                PosLenta = Lenta.FirstDisplayedScrollingColumnIndex;
                                midLenta++;
                            }
                            break;
                    }
                    LastCodeColumnStep = tableCode[i + 1, LastCodeColumnStep].q;

                    int iselect = 0;
                    if (Lenta.Rows[0].Cells[midLenta].Value == null)
                    {
                        iselect = EventTable.RowCount - 1;
                    }
                    else
                    {
                        while ((iselect < ca.mas.GetLength(0)) && (Convert.ToString(Lenta.Rows[0].Cells[midLenta].Value) != Convert.ToString(ca.mas[iselect])))
                        {
                            iselect++;
                        }
                    }


                    if (LastCodeColumnStep <= EventTable.ColumnCount - 1)
                        EventTable.Rows[iselect + 1].Cells[LastCodeColumnStep].Selected = true;



                }
                catch
                {
                    MessageBox.Show("Вы не ввели необходимые команды", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Работа алгоритма завершена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LastCodeColumnStep = 1;
            }
        }


        #endregion

        //регион работы с файлами
        #region File_Menu 
        string path;
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e) //открываем заготовленный образец (+ формируем eventTable + формируем алфавит+ записываем в текстбоксы смысл)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "TXT files (*.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i <= NumLenta - 1; i++)
                {
                    Lenta.Rows[0].Cells[i].Value = "E";
                }
                StreamReader sr = new StreamReader(ofd.FileName, Encoding.Default);
                path = ofd.FileName;
                sr.ReadLine();
                string s = sr.ReadLine();
                textBoxTask.Text = "";
                while (s != "Комментарий:")
                {
                    textBoxTask.Text += s;
                    s = sr.ReadLine(); ;
                }
                s = sr.ReadLine();
                textBoxComment.Text = "";
                while (s!= "Алфавит:")
                {
                    if (s!="")
                        textBoxComment.Text += s+ Environment.NewLine;
                    s = sr.ReadLine();
                }
                s = sr.ReadLine();           
                ca.mas = new string[s.Length];
                for (int i = 0; i < ca.mas.Length; i++)
                {
                    ca.mas[i] = Convert.ToString(s[i]);
                }             
                s = sr.ReadLine();
                s = sr.ReadLine();
                s = sr.ReadLine();
                for (int i = 0; i < s.Length; i++)//генерация значений на ленте
                {             
                        Lenta.Rows[0].Cells[midLenta + i].Value = s[i]; 
                        if (s[i] != 'E')
                            Lenta.Rows[0].Cells[midLenta + i].Style.Font = new Font(this.Font, FontStyle.Bold);                  
                }
                sr.ReadLine();
                sr.ReadLine();
                int col = 1;
                tableCode = new Code[ca.mas.Length + 1,2];
                string[] s1; 
                int colCount = 1;
                do //считывание предписаний пользователя
                {
                    s1 = sr.ReadLine().Split();
                    if (s1.Length == 1)
                        break;
                    for (int str = 1; str <= s1.Length; str++)
                    {
                        try
                        {
                            string stroka = s1[str - 1];
                            bool flag = false;
                            int j = -1;
                            while ((j < ca.mas.Length) && (!flag))
                            {
                                j++;
                                flag = stroka.StartsWith(ca.mas[j]);
                            }
                            if (flag)
                            {
                                tableCode[str, col] = new Code();
                                tableCode[str, col].alph = ca.mas[j];
                                stroka = stroka.Remove(0, ca.mas[j].Length);
                                if (stroka[0] == '<' || stroka[0] == '>' || stroka[0] == '.')
                                {
                                    tableCode[str, col].direction = stroka[0];
                                    stroka = stroka.Remove(0, 1);
                                    try
                                    {
                                        if ((Convert.ToInt32(stroka) <= tableCode.GetLength(1) + 1) && (Convert.ToInt32(stroka) >= 1))
                                        {
                                            tableCode[str, col].q = Convert.ToInt32(stroka);
                                        }
                                        else
                                        {
                                            MessageBox.Show("Данные частично введены неверно", "Ошибка!", MessageBoxButtons.OKCancel ,MessageBoxIcon.Warning);
                                            tableCode[str, col] = null;
                                        }
                                    }
                                    catch
                                    {
                                        MessageBox.Show("Данные введены неверно", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Данные введены неверно", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Данные введены неверно", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Данные частично введены неверно", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                    col++;
                    colCount++;
                    tableCode = AddColumn(tableCode);
                } while ((!sr.EndOfStream) && (s1.Length != 1));
                sr.Close(); //начало генерации таблицы основной
                EventTable.RowCount = 1;
                EventTable.ColumnCount = 1;
                EventTable.RowCount = ca.mas.GetLength(0) + 1;
                EventTable.ColumnCount = colCount;
                for (int i = 0; i < ca.mas.Length; i++) // делаем подобие заголовка
                {
                    EventTable.Rows[i + 1].Cells[0].Style.BackColor = System.Drawing.Color.Gray;
                    EventTable.Rows[i + 1].Cells[0].Value = ca.mas[i];
                    EventTable.Rows[i + 1].Cells[0].ReadOnly = true;
                }
                EventTable.Rows[0].Cells[0].Style.BackColor = System.Drawing.Color.Gray;
                EventTable.Rows[0].Cells[0].ReadOnly = true;
                for (int i = 1; i < colCount; i++)
                {
                    EventTable.Rows[0].Cells[i].Style.BackColor = System.Drawing.Color.Gray;
                    EventTable.Rows[0].Cells[i].Value = "q" + i;
                    EventTable.Rows[0].Cells[i].ReadOnly = true;
                }
                buttonStart.Enabled = true;
                buttonAddCol.Enabled = true;
                buttonDelCol.Enabled = true;
                labelYourAlphabet.Text = "Ваш алфавит: ";
                for (int i = 0; i < ca.mas.Length; i++)
                {
                    labelYourAlphabet.Text += ca.mas[i] + " ";
                }
                LastCodeColumnStep = 1;
                buttonStep.Enabled = true;
                for (int i1=1; i1< EventTable.RowCount; i1++) //вывод предписаний из внутреннего массива на экран
                {
                    for (int j1=1; j1<EventTable.ColumnCount;j1++)
                    {
                        try
                        {
                            EventTable.Rows[i1].Cells[j1].Value = Convert.ToString(tableCode[i1, j1].alph) + Convert.ToString(tableCode[i1, j1].direction) + Convert.ToString(tableCode[i1, j1].q);
                        }
                        catch
                        { }
                    }
                }                
                СохранитьToolStripMenuItem.Enabled = true;

            }
        }
        private void СохранитьToolStripMenuItem_Click(object sender, EventArgs e) // перезапись файла готового(сохранение изменений)
        {
            StreamWriter sw = new StreamWriter(File.Open(path, FileMode.Open), Encoding.Default);
            sw.WriteLine("Условие:");
            sw.WriteLine(textBoxTask.Text);
            sw.WriteLine();
            sw.WriteLine("Комментарий:");
            sw.WriteLine(textBoxComment.Text);
            sw.WriteLine("Алфавит:");
            string[] s = labelYourAlphabet.Text.Split(':');
            s[1] = s[1].Replace(" ",""); //удаление всех пробелов в строке
            sw.WriteLine(s[1]);
            sw.WriteLine();
            sw.WriteLine("Лента:");
            for (int i=0; i<NumLenta; i++)
            {
                if (Lenta.Rows[0].Cells[i].Value.ToString() != "E")
                    sw.Write(Lenta.Rows[0].Cells[i].Value);
            }
            sw.WriteLine();
            sw.WriteLine();
            sw.WriteLine("Программа(i строка - предписания для i состояния):");
            for (int col=1; col<tableCode.GetLength(1); col++)
            {
                for (int str=1; str<tableCode.GetLength(0);str++)
                {
                    try
                    {
                        sw.Write(Convert.ToString(tableCode[str, col].alph) + Convert.ToString(tableCode[str, col].direction) + Convert.ToString(tableCode[str, col].q));
                        if (str != tableCode.GetLength(0) - 1)
                            sw.Write(" ");
                    }
                    catch
                    { }
                }
                sw.WriteLine();
            }
            sw.Close();
            MessageBox.Show("Файл успешно сохранён!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e) //то же самое, что и сохранить, но с возможностью выбора файла
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "TXT files (*.txt)|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(File.Create(sfd.FileName), Encoding.Default);
                sw.WriteLine("Условие:");  //переписывание заголовков
                sw.WriteLine(textBoxTask.Text);
                sw.WriteLine();
                sw.WriteLine("Комментарий:");
                sw.WriteLine(textBoxComment.Text);
                sw.WriteLine();
                sw.WriteLine("Алфавит:");
                string[] s = labelYourAlphabet.Text.Split(':');
                s[1] = s[1].Replace(" ", ""); //удаление всех пробелов в строке
                sw.WriteLine(s[1]);
                sw.WriteLine();
                sw.WriteLine("Лента:");
                for (int i = 0; i < NumLenta; i++)
                {
                    if (Lenta.Rows[0].Cells[i].Value.ToString() != "E")
                        sw.Write(Lenta.Rows[0].Cells[i].Value);
                }
                sw.WriteLine();
                sw.WriteLine();
                sw.WriteLine("Программа(i строка - предписания для i состояния):");
                for (int col = 1; col < tableCode.GetLength(1); col++) //считывание из таблицы с предписаниями информации в файл
                {
                    for (int str = 1; str < tableCode.GetLength(0); str++)
                    {
                        try
                        {
                            sw.Write(Convert.ToString(tableCode[str, col].alph) + Convert.ToString(tableCode[str, col].direction) + Convert.ToString(tableCode[str, col].q));
                            if (str != tableCode.GetLength(0) - 1)
                                sw.Write(" ");
                        }
                        catch
                        { }
                    }
                    sw.WriteLine();
                }
                sw.Close();
            }
        } 
        private Code[,] AddColumn(Code[,] arr)
        {
            int numCol=1;
            Random rand = new Random(100);           
            int numStr = arr.GetLength(0);
            if (numStr == 0)
                numStr = 1;
            Code[,] arrMain = new Code[numStr, arr.GetLength(1) + numCol];
            for (int i = 0; i < numStr; i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arrMain[i, j] = arr[i, j];
                }
            }          
            return arrMain;
        } //функция добавления 1 пустого столбца в таблицу 

        #endregion 


    }
}
