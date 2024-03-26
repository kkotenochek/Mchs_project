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
    public partial class FireCall : Form
    {
        public FireCall()
        {
            InitializeComponent();
        }

        private void FireCall_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mchsProektDataSet.Дежурная_смена". При необходимости она может быть перемещена или удалена.
            this.дежурная_сменаTableAdapter.Fill(this.mchsProektDataSet.Дежурная_смена);
            this.вид_объекта_пожара1TableAdapter.Fill(this.mchsProektDataSet.Вид_объекта_пожара1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mchsProektDataSet.Вызов_на_пожар". При необходимости она может быть перемещена или удалена.
            this.вызов_на_пожарTableAdapter.Fill(this.mchsProektDataSet.Вызов_на_пожар);

        }

        //private void btnadd_Click(object sender, EventArgs e)
        //{
        //    FireCallEditForm form = new FireCallEditForm();
        //    form.ShowDialog();
        //    this.вызов_на_пожарTableAdapter.Fill(this.mchsProektDataSet.Вызов_на_пожар);
        //}

        private void btnedit_Click(object sender, EventArgs e)
        {
            вызов_на_пожарTableAdapter.Update(this.mchsProektDataSet.Вызов_на_пожар);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

            MessageBox.Show("Данные введены неверно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            e.ThrowException = false;

        }
    }
}
