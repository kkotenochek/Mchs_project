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
    public partial class WorkerContract : Form
    {
        public WorkerContract()
        {
            InitializeComponent();
        }

        private void Worker_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mchsProektDataSet.Контракт_сотрудника". При необходимости она может быть перемещена или удалена.
            this.контракт_сотрудникаTableAdapter.Fill(this.mchsProektDataSet.Контракт_сотрудника);

            this.сотрудникTableAdapter.Fill(this.mchsProektDataSet.Сотрудник);

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            контракт_сотрудникаTableAdapter.Update(mchsProektDataSet.Контракт_сотрудника);
        }

        private void btnclose_Click(object sender, EventArgs e)
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
