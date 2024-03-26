using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MchsProekt
{
    public partial class Worker : Form
    {
        public Worker()
        {
            InitializeComponent();
        }

        private void Worker_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mchsProektDataSet.Пол_сотрудника". При необходимости она может быть перемещена или удалена.
            this.пол_сотрудникаTableAdapter.Fill(this.mchsProektDataSet.Пол_сотрудника);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mchsProektDataSet.Сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this.mchsProektDataSet.Сотрудник);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            WorkerEditForm form = new WorkerEditForm(сотрудникBindingSource.Position);
            form.ShowDialog();
            this.сотрудникTableAdapter.Fill(this.mchsProektDataSet.Сотрудник);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WorkerEditForm form = new WorkerEditForm();
            form.ShowDialog();
            this.сотрудникTableAdapter.Fill(this.mchsProektDataSet.Сотрудник);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            сотрудникBindingSource.RemoveCurrent();
            сотрудникTableAdapter.Update(mchsProektDataSet.Сотрудник);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int kod2 = 0;
            try
            {
                kod2 = Convert.ToInt32(textBox2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Нельзя сконвертировать {textBox2.Text} в число");
            }
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MchsProekt;Integrated Security=True");
            connection.Open();
            SqlCommand cmd = new SqlCommand(@"SELECT * FROM Сотрудник WHERE [Табельный номер] ='" + kod2 + "'", connection);

            SqlConnection connection1 = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MchsProekt;Integrated Security=True");
            connection1.Open();
            SqlCommand cmd1 = new SqlCommand(@"SELECT * FROM Сотрудник WHERE [Табельный номер] ='" + kod2 + "'", connection1);
            var reader2 = cmd1.ExecuteReader();
            if (reader2.HasRows)
            {
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;

            }
            else
            {
                MessageBox.Show("Cотрудник не найден");
            }
            connection1.Close();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Данные введены неверно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            e.ThrowException = false;
        }
    }
}
