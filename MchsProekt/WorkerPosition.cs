using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MchsProekt
{
    public partial class WorkerPosition : Form
    {
        public WorkerPosition()
        {
            InitializeComponent();
        }

        private void WorkerPosition_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mchsProektDataSet.Сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this.mchsProektDataSet.Сотрудник);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mchsProektDataSet.Должность". При необходимости она может быть перемещена или удалена.
            this.должностьTableAdapter.Fill(this.mchsProektDataSet.Должность);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mchsProektDataSet.Должность_сотрудника". При необходимости она может быть перемещена или удалена.
            this.должность_сотрудникаTableAdapter.Fill(this.mchsProektDataSet.Должность_сотрудника);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            должность_сотрудникаTableAdapter.Update(this.mchsProektDataSet.Должность_сотрудника);
        }

        //private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        //{
        //    MessageBox.Show("Данные введены неверно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    e.ThrowException = false;
        //}
    }
}
