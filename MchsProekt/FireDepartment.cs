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
    public partial class FireDepartment : Form
    {
        public FireDepartment()
        {
            InitializeComponent();
        }

        private void FireDepartment_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mchsProektDataSet.Пожарная_часть". При необходимости она может быть перемещена или удалена.
            this.пожарная_частьTableAdapter.Fill(this.mchsProektDataSet.Пожарная_часть);

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            пожарная_частьTableAdapter.Update(this.mchsProektDataSet.Пожарная_часть);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int kod = 0;
            try
            {
                kod = Convert.ToInt32(textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Нельзя сконвертировать {textBox1.Text} в число");
            }

            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MchsProekt;Integrated Security=True");
                connection.Open();
              

                SqlCommand cmd = new SqlCommand(@"DELETE FROM [Пожарная часть] WHERE [Код пожарной части] = '" + kod + "'", connection);
       

                SqlConnection connection1 = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MchsProekt;Integrated Security=True");
                connection1.Open();
                SqlCommand cmd1 = new SqlCommand(@"SELECT * FROM [Пожарная часть] WHERE [Код пожарной части] = '" + kod + "'", connection1);
                var reader = cmd1.ExecuteReader();
                if (reader.HasRows)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Удаление выполнено успешно");
                
                }
                else
                {
                    MessageBox.Show("Пожарная часть не найдена");
                }
            connection1.Close();


            this.пожарная_частьTableAdapter.Fill(this.mchsProektDataSet.Пожарная_часть);
           
        }

        private void button2_Click(object sender, EventArgs e)
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

            SqlCommand cmd = new SqlCommand(@"SELECT * FROM [Пожарная часть] WHERE [Код пожарной части] ='" + kod2 + "'", connection);

            SqlConnection connection1 = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MchsProekt;Integrated Security=True");
            connection1.Open();
            SqlCommand cmd1 = new SqlCommand(@"SELECT * FROM [Пожарная часть] WHERE [Код пожарной части] ='" + kod2 + "'", connection1);
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
                MessageBox.Show("Пожарная часть не найдена");
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
