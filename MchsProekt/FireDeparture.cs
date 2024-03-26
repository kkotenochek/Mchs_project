using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MchsProekt
{
    public partial class FireDeparture : Form
    {
        public FireDeparture()
        {
            InitializeComponent();
        }

        private void FireDeparture_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mchsProektDataSet.Вызов_на_пожар". При необходимости она может быть перемещена или удалена.
            this.вызов_на_пожарTableAdapter.Fill(this.mchsProektDataSet.Вызов_на_пожар);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mchsProektDataSet.Виновное_лицо". При необходимости она может быть перемещена или удалена.
            this.виновное_лицоTableAdapter.Fill(this.mchsProektDataSet.Виновное_лицо);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mchsProektDataSet.Причина_пожара". При необходимости она может быть перемещена или удалена.
            this.причина_пожараTableAdapter.Fill(this.mchsProektDataSet.Причина_пожара);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mchsProektDataSet.Выезд_на_пожар". При необходимости она может быть перемещена или удалена.
            this.выезд_на_пожарTableAdapter.Fill(this.mchsProektDataSet.Выезд_на_пожар);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            выезд_на_пожарTableAdapter.Update(this.mchsProektDataSet.Выезд_на_пожар);
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Данные введены неверно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            e.ThrowException = false;
        }
 
    }
}
