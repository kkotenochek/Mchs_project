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
    public partial class FireMachine : Form
    {
        public FireMachine()
        {
            InitializeComponent();
        }

        private void FireMachine_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mchsProektDataSet.Пожарная_часть". При необходимости она может быть перемещена или удалена.
            this.пожарная_частьTableAdapter.Fill(this.mchsProektDataSet.Пожарная_часть);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mchsProektDataSet.Вид_пожарной_машины". При необходимости она может быть перемещена или удалена.
            this.вид_пожарной_машиныTableAdapter.Fill(this.mchsProektDataSet.Вид_пожарной_машины);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mchsProektDataSet.Пожарная_машина". При необходимости она может быть перемещена или удалена.
            this.пожарная_машинаTableAdapter.Fill(this.mchsProektDataSet.Пожарная_машина);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            пожарная_машинаTableAdapter.Update(this.mchsProektDataSet.Пожарная_машина);
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Данные введены неверно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            e.ThrowException = false;
        }
    }
}
