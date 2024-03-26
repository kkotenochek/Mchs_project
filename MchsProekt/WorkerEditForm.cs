using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MchsProekt
{
    public partial class WorkerEditForm : Form
    {
        public WorkerEditForm()
        {
            InitializeComponent();
           
            this.пол_сотрудникаTableAdapter.Fill(this.mchsProektDataSet.Пол_сотрудника);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mchsProektDataSet.Сотрудник". При необходимости она может быть перемещена или удалена.
            //this.сотрудникTableAdapter.Fill(this.mchsProektDataSet.Сотрудник);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mchsProektDataSet.Пожарная_часть". При необходимости она может быть перемещена или удалена.
            this.пожарная_частьTableAdapter.Fill(this.mchsProektDataSet.Пожарная_часть);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mchsProektDataSet.Караул". При необходимости она может быть перемещена или удалена.
            this.караул_1TableAdapter.Fill(this.mchsProektDataSet.Караул_1);

            сотрудникBindingSource.AddNew();
        }

        public WorkerEditForm(int index)
        {
            InitializeComponent();
            this.сотрудникTableAdapter.Fill(mchsProektDataSet.Сотрудник);
           
            this.пол_сотрудникаTableAdapter.Fill(mchsProektDataSet.Пол_сотрудника);
           
            сотрудникBindingSource.Position = index;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            сотрудникBindingSource.EndEdit();
            сотрудникTableAdapter.Update(mchsProektDataSet.Сотрудник);
          
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void фамилияTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (фамилияTextBox.Text == string.Empty)
            {
                MessageBox.Show("Пустая строка");
            }
        }

        private void имяTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (имяTextBox.Text == string.Empty)
            {
                MessageBox.Show("Пустая строка");
            }
        }

        private void адрес_регистрацииTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (адрес_регистрацииTextBox.Text == string.Empty)
            {
                MessageBox.Show("Пустая строка");
            }
        }

        private void адрес_фактического_проживанияTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (адрес_фактического_проживанияTextBox.Text == string.Empty)
            {
                MessageBox.Show("Пустая строка");
            }
        }

        private void серия_паспортаTextBox_Validating(object sender, CancelEventArgs e)
        {
            int kod2 = 0;
            try
            {
                kod2 = Convert.ToInt32(серия_паспортаTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Недопустимый ввод {серия_паспортаTextBox.Text} для серии паспорта");
                серия_паспортаTextBox.Clear();
            }
            if (серия_паспортаTextBox.Text == string.Empty)
            {
                MessageBox.Show("Пустая строка");
            }
            if(серия_паспортаTextBox.Text.Length > 4)
            {
                MessageBox.Show("Серия паспорта не более 4 цифр");
                серия_паспортаTextBox.Clear();
            }
        }

        private void номер_паспортаTextBox_Validating(object sender, CancelEventArgs e)
        {
            int kod2 = 0;
            try
            {
                kod2 = Convert.ToInt32(номер_паспортаTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Недопустимый ввод {номер_паспортаTextBox.Text} для номера паспорта");
               номер_паспортаTextBox.Clear();
            }
            if (номер_паспортаTextBox.Text == string.Empty)
            {
                MessageBox.Show("Пустая строка");
            }
            if (номер_паспортаTextBox.Text.Length > 6)
            {
                MessageBox.Show("Номер паспорта не более 6 цифр");
                номер_паспортаTextBox.Clear();
            }
        }

        private void код_пожарной_частиComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (код_пожарной_частиComboBox.Text == string.Empty)
            {
                MessageBox.Show("Пустая строка");
            }
        }

        private void WorkerEditForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mchsProektDataSet.Караул_1". При необходимости она может быть перемещена или удалена.
            this.караул_1TableAdapter.Fill(this.mchsProektDataSet.Караул_1);

        }








       
    }
}
