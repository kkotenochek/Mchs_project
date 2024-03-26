using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Application = System.Windows.Forms.Application;
using Microsoft.Office.Interop.Word;

namespace MchsProekt
{
    public partial class MainForm : Form
    {
        public object TimeOnly { get; private set; }

        public MainForm()
        {
            InitializeComponent();
        }
       
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm formabout = new AboutForm();
            formabout.ShowDialog();
        }

        private void сотрудникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkerContract form = new WorkerContract();
            form.MdiParent = this;
            form.Show();
        }

        private void сотрудникToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Worker form = new Worker();
            form.MdiParent = this;
            form.Show();
        }

        private void пожарнаяЧастьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FireDepartment form = new FireDepartment();
            form.MdiParent = this;
            form.Show();
        }

        private void вызовНаПожарToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FireCall form = new FireCall();
            form.MdiParent = this;
            form.Show();
        }

        private void дежурнаяСменаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shift form = new Shift();
            form.MdiParent = this;
            form.Show();
        }

        private void образованиеСотрудникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkerEducation form = new WorkerEducation();
            form.MdiParent = this;
            form.Show();
        }

        private void выездНаПожарToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FireDeparture form = new FireDeparture();
            form.MdiParent = this;
            form.Show();
        }

   
        private void должностьСотрудникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkerPosition form = new WorkerPosition();
            form.MdiParent = this;
            form.Show();
        }

        private void званиеСотрудникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkerTitle form = new WorkerTitle();
            form.MdiParent = this;
            form.Show();
        }

        private void пожарнаяМашинаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FireMachine form = new FireMachine();
            form.MdiParent = this;
            form.Show();
        }

        private void допускКПожарнойМашинеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ДопускМашина form = new ДопускМашина();
            form.MdiParent = this;
            form.Show();
        }

        private void водительМашиныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ВодительМашины form = new ВодительМашины();
            form.MdiParent = this;
            form.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void отчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MchsProekt;Integrated Security=True");
            connection.Open();

            SqlCommand cmd = new SqlCommand(@"select V.[Адрес пожара]
   , V.[Время обращения заявителя]
   , VOP.[Вид объекта пожара]
   , V.[Фамилия заявителя]
   , V.[Имя заявителя]
   , V.[Отчетство заявителя]
   , V.[Номер телефона заявителя]
   , VP.[Дата выезда]
   , VP.[Время поступления сообщения]
   , VP.[Время прибытия на место пожара]
   , VP.[Время подачи первого ствола]
   , VP.[Время локализации]
   , VP.[Время ликвидации]
   , VP.[Время прибытия обратно в часть]
   , VP.[Время постановки в боевой расчет]
   , VP.[Дата окончания выезда]
   , PP.[Наименование причины]
   , VL.[Наименование категории]
   , VP.[Количество погибших людей]
   , VP.[Количество погибших детей]
   , VP.[Количество погибших работников пожарной охраны]
   , VP.[Количество уничтоженных/поврежденных сооружений]
   , VP.[Количество уничтоженных жилых квартир]
   , VP.[Количество уничтоженной автотракторной и другой техники]
   , VP.[Спасено людей на пожаре]
   , VP.[Спасено материальных ценностей]
from  [MchsProekt].[dbo].[Вызов_на_пожар] as V
    left join [MchsProekt].[dbo].[Выезд на пожар] as VP 
    on V.[Код вызова] = VP.[Код вызова] 
    left join [MchsProekt].[dbo].[Вид_объекта_пожара] as VOP 
    on V.[Код вида объекта] = VOP.[Код]
  left join [MchsProekt].[dbo].[Причина пожара] as PP 
    on VP.[Код причины] = PP.[Код причины]
  left join [MchsProekt].[dbo].[Виновное лицо] as VL 
    on VP.[Код категории виновного лица] = VL.[Код категории виновного лица]", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            var word = new Word.Application();
            word.Visible = true;
            Document doc = word.Documents.Add(System.Reflection.Missing.Value);

            const int FIELDS_IN_ROW_COUNT = 26;
            var rowsCount = reader.FieldCount / FIELDS_IN_ROW_COUNT;
            var reportsCount = 0;

            while (reader.Read())
            {
                reportsCount++;

                TypeHeader(word);

                SetTextStyle(word);

                var address = reader[0];
                word.Selection.TypeText("Адрес пожара: " + address.ToString());
                word.Selection.TypeParagraph();
                var time = reader[1];
                DateTime time8 = (DateTime)time;
                time = time8.ToLongTimeString();
                word.Selection.TypeText("Время обнаружения пожара: " + time.ToString());
                word.Selection.Font.Bold = 0;
                word.Selection.TypeParagraph();
                var mesto = reader[2];
                word.Selection.TypeText("Место возникновения пожара: " + mesto.ToString());
                word.Selection.Font.Bold = 0;
                word.Selection.TypeParagraph();
                var person = reader[3];
                word.Selection.TypeText("Фамилия заявителя: " + person.ToString());
                word.Selection.Font.Bold = 0;
                word.Selection.TypeParagraph();
                var person1 = reader[4];
                word.Selection.TypeText("Имя заявителя: " + person1.ToString());
                word.Selection.Font.Bold = 0;
                word.Selection.TypeParagraph();
                var person2 = reader[5];
                word.Selection.TypeText("Отчество заявителя: " + person2.ToString());
                word.Selection.Font.Bold = 0;
                word.Selection.TypeParagraph();
                var phone = reader[6];
                word.Selection.TypeText("Номер телефона: " + phone.ToString());
                word.Selection.Font.Bold = 0;
                word.Selection.TypeParagraph();

                var data = reader[7];
                word.Selection.TypeText("Дата выезда: " + data.ToString());
                word.Selection.Font.Bold = 0;
                word.Selection.TypeParagraph();

                var time1 = reader[8];
                DateTime time9 = (DateTime)time1;
                time1 = time9.ToLongTimeString();
                word.Selection.TypeText("Время поступления сообщения: " + time1.ToString());
                word.Selection.Font.Bold = 0;
                word.Selection.TypeParagraph();

                var time2 = reader[9];
                DateTime time10 = (DateTime)time2;
                time2 = time10.ToLongTimeString();
                word.Selection.TypeText("Время прибытия на место пожара: " + time2.ToString());
                word.Selection.Font.Bold = 0;
                word.Selection.TypeParagraph();

                var time3 = reader[10];
                DateTime time11 = (DateTime)time3;
                time3 = time11.ToLongTimeString();
                word.Selection.TypeText("Время подачи первого ствола: " + time3.ToString());
                word.Selection.Font.Bold = 0;
                word.Selection.TypeParagraph();

                var time4 = reader[11];
                DateTime time12 = (DateTime)time4;
                time4 = time12.ToLongTimeString();
                word.Selection.TypeText("Время локализации: " + time4.ToString());
                word.Selection.Font.Bold = 0;
                word.Selection.TypeParagraph();

                var time5 = reader[12];
                DateTime time13 = (DateTime)time5;
                time5 = time13.ToLongTimeString();
                word.Selection.TypeText("Время ликвидации: " + time5.ToString());
                word.Selection.Font.Bold = 0;
                word.Selection.TypeParagraph();

                var time6 = reader[13];
                DateTime time14 = (DateTime)time6;
                time6 = time14.ToLongTimeString();
                word.Selection.TypeText("Время прибытия обратно в часть: " + time6.ToString());
                word.Selection.Font.Bold = 0;
                word.Selection.TypeParagraph();

                var time7 = reader[14];
                DateTime time15 = (DateTime)time7;
                time7 = time15.ToLongTimeString();
                word.Selection.TypeText("Время постановки в боевой расчет: " + time7.ToString());
                word.Selection.Font.Bold = 0;
                word.Selection.TypeParagraph();

                var data2 = reader[15];
                word.Selection.TypeText("Дата окончания выезда: " + data2.ToString());
                word.Selection.Font.Bold = 0;
                word.Selection.TypeParagraph();

                var prichina = reader[16];
                word.Selection.TypeText("Причина: " + prichina.ToString());
                word.Selection.Font.Bold = 0;
                word.Selection.TypeParagraph();

                var vinovny = reader[17];
                word.Selection.TypeText("Виновное лицо: " + vinovny.ToString());
                word.Selection.Font.Bold = 0;
                word.Selection.TypeParagraph();

                var quan1 = reader[18];
                word.Selection.TypeText("Погибло людей: всего " + quan1.ToString());
                word.Selection.Font.Bold = 0;
                word.Selection.TypeParagraph();

                var quan2 = reader[19];
                word.Selection.TypeText("Погибло детей: " + quan2.ToString());
                word.Selection.Font.Bold = 0;
                word.Selection.TypeParagraph();

                var quan3 = reader[20];
                word.Selection.TypeText("Погибло работников пожарной охраны: " + quan3.ToString());
                word.Selection.Font.Bold = 0;
                word.Selection.TypeParagraph();

                var quan4 = reader[21];
                word.Selection.TypeText("Количество уничтоженных/поврежденных сооружений: " + quan4.ToString() + " ед.");
                word.Selection.Font.Bold = 0;
                word.Selection.TypeParagraph();

                var quan5 = reader[22];
                word.Selection.TypeText("Количество уничтоженных жилых квартир: " + quan5.ToString() + " ед.");
                word.Selection.Font.Bold = 0;
                word.Selection.TypeParagraph();

                var quan6 = reader[23];
                word.Selection.TypeText("Количество уничтоженной автотракторной и другой техники: " + quan6.ToString() + " ед.");
                word.Selection.Font.Bold = 0;
                word.Selection.TypeParagraph();

                var quan7 = reader[24];
                word.Selection.TypeText("Спасено людей на пожаре: " + quan7.ToString() + " чел.");
                word.Selection.Font.Bold = 0;
                word.Selection.TypeParagraph();

                var quan8 = reader[25];
                word.Selection.TypeText("Спасено материальных ценностей: " + quan8.ToString() + " руб.");
                word.Selection.Font.Bold = 0;
                word.Selection.TypeParagraph();
                if (reportsCount < rowsCount)
                {
                    word.Selection.InsertBreak(WdBreakType.wdPageBreak);

                }
            }
        }

        private void просмотрИзExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Downloads d = new Downloads();
            d.Show();
        }

        private void TypeHeader(Word.Application word)
        {
            SetHeaderStyle(word);
            word.Selection.TypeText("Донесение о пожаре №_____________");
            word.Selection.TypeParagraph();
            word.Selection.TypeText("Составил: ____________________________________________________________________________________________________________________");
            word.Selection.TypeParagraph();
        }

        private void SetHeaderStyle(Word.Application word)
        {
            word.Selection.Font.Size = 16;
            word.Selection.Font.Bold = 3;
            word.Selection.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
        }

        private void SetTextStyle(Word.Application word)
        {
            word.Selection.Font.Size = 13;
            word.Selection.Font.Bold = 0;
            word.Selection.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
        }
    }
}
