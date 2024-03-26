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
    public partial class ВодительМашины : Form
    {
        public ВодительМашины()
        {
            InitializeComponent();
        }

        private void ВодительМашины_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mchsProektDataSet.Пожарная_машина". При необходимости она может быть перемещена или удалена.
            this.пожарная_машинаTableAdapter.Fill(this.mchsProektDataSet.Пожарная_машина);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mchsProektDataSet.Пожарная_часть". При необходимости она может быть перемещена или удалена.
            this.пожарная_частьTableAdapter.Fill(this.mchsProektDataSet.Пожарная_часть);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mchsProektDataSet.Допуск_к_пожарной_машине". При необходимости она может быть перемещена или удалена.
            this.допуск_к_пожарной_машинеTableAdapter.Fill(this.mchsProektDataSet.Допуск_к_пожарной_машине);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mchsProektDataSet.Водитель_машины". При необходимости она может быть перемещена или удалена.
            this.водитель_машиныTableAdapter.Fill(this.mchsProektDataSet.Водитель_машины);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            водитель_машиныTableAdapter.Update(this.mchsProektDataSet.Водитель_машины);
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Данные введены неверно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            e.ThrowException = false;
        }
    }
}
