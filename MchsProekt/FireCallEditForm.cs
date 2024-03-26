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
    public partial class FireCallEditForm : Form
    {
        public FireCallEditForm()
        {
            InitializeComponent();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mchsProektDataSet.Вид_объекта_пожара1". При необходимости она может быть перемещена или удалена.
            this.вид_объекта_пожара1TableAdapter.Fill(this.mchsProektDataSet.Вид_объекта_пожара1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mchsProektDataSet.Вызов_на_пожар". При необходимости она может быть перемещена или удалена.
            this.вызов_на_пожарTableAdapter.Fill(this.mchsProektDataSet.Вызов_на_пожар);

            вызов_на_пожарBindingSource.AddNew();

        }

        public FireCallEditForm(int index)
        {
            InitializeComponent();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mchsProektDataSet.Вид_объекта_пожара1". При необходимости она может быть перемещена или удалена.
            this.вид_объекта_пожара1TableAdapter.Fill(this.mchsProektDataSet.Вид_объекта_пожара1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mchsProektDataSet.Вызов_на_пожар". При необходимости она может быть перемещена или удалена.
            this.вызов_на_пожарTableAdapter.Fill(this.mchsProektDataSet.Вызов_на_пожар);
            вызов_на_пожарBindingSource.Position = index;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            вызов_на_пожарBindingSource.EndEdit();
            вызов_на_пожарTableAdapter.Update(this.mchsProektDataSet.Вызов_на_пожар);
        }
    }
}
