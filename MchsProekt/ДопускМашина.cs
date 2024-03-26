using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace MchsProekt
{
    public partial class ДопускМашина : Form
    {
        public ДопускМашина()
        {
            InitializeComponent();
        }

        private void ДопускМашина_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mchsProektDataSet.Сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this.mchsProektDataSet.Сотрудник);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mchsProektDataSet.Допуск_к_пожарной_машине". При необходимости она может быть перемещена или удалена.
            this.допуск_к_пожарной_машинеTableAdapter.Fill(this.mchsProektDataSet.Допуск_к_пожарной_машине);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            допуск_к_пожарной_машинеTableAdapter.Update(this.mchsProektDataSet.Допуск_к_пожарной_машине);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            Microsoft.Office.Interop.Excel.Range xlRange;

            int xlRow;
            string strfilename;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Excel Office | *.xls; *.xlsx";
            openFileDialog1.ShowDialog();
            strfilename = openFileDialog1.FileName;

            if(strfilename != string.Empty)
            {
                xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlWorkBook = xlApp.Workbooks.Open(strfilename);
                xlWorkSheet = xlWorkBook.Worksheets["Лист1"];
                xlRange = xlWorkSheet.UsedRange;
                int i=0;
                for (xlRow =2; xlRow<= xlRange.Rows.Count; xlRow++)
                {
                    i++;
                    dataGridView1.Rows.Add(i, xlRange.Cells[xlRow, 1].Text, xlRange.Cells[xlRow, 2].Text);

                }
                xlWorkBook.Close();
                xlApp.Quit();
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Данные введены неверно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            e.ThrowException = false;
        }
    }
}
