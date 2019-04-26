using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Машина_тьюринга
{
    public partial class ChoseLentaElement : Form
    {
        public string LentaVal="E"; //значение, которое передается в главную форму и отображается на ленте
        public Main main;
        public ChoseLentaElement(Main main1)
        {
            InitializeComponent();
            main = main1;
        }

        private void ChoseLentaElement_Load(object sender, EventArgs e) //меню выбора элемента, который будет записан на ленту
        {
            if (main.EventTable.ColumnCount!=1)
            {
                ChoseElTable.RowCount = 1;
                ChoseElTable.ColumnCount = main.EventTable.RowCount-1;
                for (int i = 1; i <= ChoseElTable.ColumnCount; i++)
                {
                    ChoseElTable.Rows[0].Cells[i-1].Value = main.EventTable.Rows[i].Cells[0].Value;
                }
            }
        }

        private void ChoseElTable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) //непосредственной запоминание этого элемента
        {
            LentaVal = Convert.ToString(ChoseElTable.Rows[0].Cells[e.ColumnIndex].Value);
            Close();
        }
    }
}
