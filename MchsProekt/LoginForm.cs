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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            //создаем строку подключения к БД
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\liza_\source\repos\MchsProekt\MchsProekt\LoginsPasswords.mdf;Integrated Security=True");

            //Создаем команду для проверки связки Логин+Пароль
            //Логи и пароль берем из полей ввода на форме авторизации

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Login WHERE UserName='" + txtLogin.Text + "' AND Password='" + txtPass.Text+ "'", connection);
            //Заполняем данные из БД, используя Data Table
            DataTable table = new DataTable();

            //Заполняем данные в таблицу, которая будет храниться в оперативной памяти
            adapter.Fill(table);

            //Создаем массив типа Object, в который помещаем данные из первой строки (индекс у нее - 0)
            //object[] login = table.Rows[0].ItemArray;

            //Передаем первый элемент массива в строковую переменную
            //string realName = login[0].ToString();
            //Если связка Логин+Пароль верная, то запрос вернет ровно одну строку
            if (table.Rows.Count == 1)
            {
                object[] login = table.Rows[0].ItemArray;
                //Передаем первый элемент массива в строковую переменную
                string realName = login[0].ToString();
                MessageBox.Show("Авторизация выполнена успешно");
                MainForm mainform = new MainForm();
                mainform.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Логин или пароль неверные");
                txtLogin.Text = "";
                txtPass.Text = "";
                txtLogin.Focus();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
