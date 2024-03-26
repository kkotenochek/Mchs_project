using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MchsProekt
{
    public partial class Shift : Form
    {

        public Shift()
        {
            InitializeComponent();
            dataGridView1.DataError += new DataGridViewDataErrorEventHandler(dataGridView1_DataError);

        }

        private void Shift_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mchsProektDataSet.Караул_1". При необходимости она может быть перемещена или удалена.
            this.караул_1TableAdapter.Fill(this.mchsProektDataSet.Караул_1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mchsProektDataSet.Караул". При необходимости она может быть перемещена или удалена.
            //this.караул_1TableAdapter.Fill(this.mchsProektDataSet.Караул_1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mchsProektDataSet.Дежурная_смена". При необходимости она может быть перемещена или удалена.
            this.дежурная_сменаTableAdapter.Fill(this.mchsProektDataSet.Дежурная_смена);

            this.dataGridView1.Columns[1].DefaultCellStyle.Format = "dd.MM.yyyy";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            дежурная_сменаTableAdapter.Update(this.mchsProektDataSet.Дежурная_смена);
        }

        internal void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Данные введены неверно");
            e.ThrowException = false;
        }
    }
}
