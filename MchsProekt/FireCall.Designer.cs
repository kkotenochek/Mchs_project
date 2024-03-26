
namespace MchsProekt
{
    partial class FireCall
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.видобъектапожара1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mchsProektDataSet = new MchsProekt.MchsProektDataSet();
            this.вызовнапожарBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.лист1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnedit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.вызовнапожарBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.видобъектапожара1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.вызов_на_пожарTableAdapter = new MchsProekt.MchsProektDataSetTableAdapters.Вызов_на_пожарTableAdapter();
            this.вид_объекта_пожара1TableAdapter = new MchsProekt.MchsProektDataSetTableAdapters.Вид_объекта_пожара1TableAdapter();
            this.вызовнапожарBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.дежурнаяСменаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.дежурная_сменаTableAdapter = new MchsProekt.MchsProektDataSetTableAdapters.Дежурная_сменаTableAdapter();
            this.кодВызоваDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресПожараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаОбращенияЗаявителяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяОбращенияЗаявителяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодВидаОбъектаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.фамилияЗаявителяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяЗаявителяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчетствоЗаявителяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерТелефонаЗаявителяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСменыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.видобъектапожара1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mchsProektDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.вызовнапожарBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.лист1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.вызовнапожарBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.видобъектапожара1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.вызовнапожарBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.дежурнаяСменаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодВызоваDataGridViewTextBoxColumn,
            this.адресПожараDataGridViewTextBoxColumn,
            this.датаОбращенияЗаявителяDataGridViewTextBoxColumn,
            this.времяОбращенияЗаявителяDataGridViewTextBoxColumn,
            this.кодВидаОбъектаDataGridViewTextBoxColumn,
            this.фамилияЗаявителяDataGridViewTextBoxColumn,
            this.имяЗаявителяDataGridViewTextBoxColumn,
            this.отчетствоЗаявителяDataGridViewTextBoxColumn,
            this.номерТелефонаЗаявителяDataGridViewTextBoxColumn,
            this.кодСменыDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.вызовнапожарBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1087, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // видобъектапожара1BindingSource1
            // 
            this.видобъектапожара1BindingSource1.DataMember = "Вид_объекта_пожара1";
            this.видобъектапожара1BindingSource1.DataSource = this.mchsProektDataSet;
            // 
            // mchsProektDataSet
            // 
            this.mchsProektDataSet.DataSetName = "MchsProektDataSet";
            this.mchsProektDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // вызовнапожарBindingSource1
            // 
            this.вызовнапожарBindingSource1.DataMember = "Вызов_на_пожар";
            this.вызовнапожарBindingSource1.DataSource = this.mchsProektDataSet;
            // 
            // btnedit
            // 
            this.btnedit.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnedit.Location = new System.Drawing.Point(17, 192);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(97, 41);
            this.btnedit.TabIndex = 2;
            this.btnedit.Text = "Сохранить";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btndelete.Location = new System.Drawing.Point(130, 192);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(97, 41);
            this.btndelete.TabIndex = 3;
            this.btndelete.Text = "Закрыть";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // вызовнапожарBindingSource
            // 
            this.вызовнапожарBindingSource.DataMember = "Вызов_на_пожар";
            this.вызовнапожарBindingSource.DataSource = this.mchsProektDataSet;
            // 
            // видобъектапожара1BindingSource
            // 
            this.видобъектапожара1BindingSource.DataMember = "Вид_объекта_пожара1";
            this.видобъектапожара1BindingSource.DataSource = this.mchsProektDataSet;
            // 
            // вызов_на_пожарTableAdapter
            // 
            this.вызов_на_пожарTableAdapter.ClearBeforeFill = true;
            // 
            // вид_объекта_пожара1TableAdapter
            // 
            this.вид_объекта_пожара1TableAdapter.ClearBeforeFill = true;
            // 
            // вызовнапожарBindingSource2
            // 
            this.вызовнапожарBindingSource2.DataMember = "Вызов_на_пожар";
            this.вызовнапожарBindingSource2.DataSource = this.mchsProektDataSet;
            // 
            // дежурнаяСменаBindingSource
            // 
            this.дежурнаяСменаBindingSource.DataMember = "Дежурная смена";
            this.дежурнаяСменаBindingSource.DataSource = this.mchsProektDataSet;
            // 
            // дежурная_сменаTableAdapter
            // 
            this.дежурная_сменаTableAdapter.ClearBeforeFill = true;
            // 
            // кодВызоваDataGridViewTextBoxColumn
            // 
            this.кодВызоваDataGridViewTextBoxColumn.DataPropertyName = "Код вызова";
            this.кодВызоваDataGridViewTextBoxColumn.HeaderText = "Код вызова";
            this.кодВызоваDataGridViewTextBoxColumn.Name = "кодВызоваDataGridViewTextBoxColumn";
            this.кодВызоваDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // адресПожараDataGridViewTextBoxColumn
            // 
            this.адресПожараDataGridViewTextBoxColumn.DataPropertyName = "Адрес пожара";
            this.адресПожараDataGridViewTextBoxColumn.HeaderText = "Адрес пожара";
            this.адресПожараDataGridViewTextBoxColumn.Name = "адресПожараDataGridViewTextBoxColumn";
            // 
            // датаОбращенияЗаявителяDataGridViewTextBoxColumn
            // 
            this.датаОбращенияЗаявителяDataGridViewTextBoxColumn.DataPropertyName = "Дата обращения заявителя";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.датаОбращенияЗаявителяDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.датаОбращенияЗаявителяDataGridViewTextBoxColumn.HeaderText = "Дата обращения заявителя";
            this.датаОбращенияЗаявителяDataGridViewTextBoxColumn.Name = "датаОбращенияЗаявителяDataGridViewTextBoxColumn";
            // 
            // времяОбращенияЗаявителяDataGridViewTextBoxColumn
            // 
            this.времяОбращенияЗаявителяDataGridViewTextBoxColumn.DataPropertyName = "Время обращения заявителя";
            dataGridViewCellStyle4.Format = "T";
            dataGridViewCellStyle4.NullValue = null;
            this.времяОбращенияЗаявителяDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.времяОбращенияЗаявителяDataGridViewTextBoxColumn.HeaderText = "Время обращения заявителя";
            this.времяОбращенияЗаявителяDataGridViewTextBoxColumn.Name = "времяОбращенияЗаявителяDataGridViewTextBoxColumn";
            // 
            // кодВидаОбъектаDataGridViewTextBoxColumn
            // 
            this.кодВидаОбъектаDataGridViewTextBoxColumn.DataPropertyName = "Код вида объекта";
            this.кодВидаОбъектаDataGridViewTextBoxColumn.DataSource = this.видобъектапожара1BindingSource1;
            this.кодВидаОбъектаDataGridViewTextBoxColumn.DisplayMember = "Вид объекта пожара";
            this.кодВидаОбъектаDataGridViewTextBoxColumn.HeaderText = "Код вида объекта";
            this.кодВидаОбъектаDataGridViewTextBoxColumn.Name = "кодВидаОбъектаDataGridViewTextBoxColumn";
            this.кодВидаОбъектаDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.кодВидаОбъектаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.кодВидаОбъектаDataGridViewTextBoxColumn.ValueMember = "Код";
            this.кодВидаОбъектаDataGridViewTextBoxColumn.Width = 350;
            // 
            // фамилияЗаявителяDataGridViewTextBoxColumn
            // 
            this.фамилияЗаявителяDataGridViewTextBoxColumn.DataPropertyName = "Фамилия заявителя";
            this.фамилияЗаявителяDataGridViewTextBoxColumn.HeaderText = "Фамилия заявителя";
            this.фамилияЗаявителяDataGridViewTextBoxColumn.Name = "фамилияЗаявителяDataGridViewTextBoxColumn";
            // 
            // имяЗаявителяDataGridViewTextBoxColumn
            // 
            this.имяЗаявителяDataGridViewTextBoxColumn.DataPropertyName = "Имя заявителя";
            this.имяЗаявителяDataGridViewTextBoxColumn.HeaderText = "Имя заявителя";
            this.имяЗаявителяDataGridViewTextBoxColumn.Name = "имяЗаявителяDataGridViewTextBoxColumn";
            // 
            // отчетствоЗаявителяDataGridViewTextBoxColumn
            // 
            this.отчетствоЗаявителяDataGridViewTextBoxColumn.DataPropertyName = "Отчетство заявителя";
            this.отчетствоЗаявителяDataGridViewTextBoxColumn.HeaderText = "Отчетство заявителя";
            this.отчетствоЗаявителяDataGridViewTextBoxColumn.Name = "отчетствоЗаявителяDataGridViewTextBoxColumn";
            // 
            // номерТелефонаЗаявителяDataGridViewTextBoxColumn
            // 
            this.номерТелефонаЗаявителяDataGridViewTextBoxColumn.DataPropertyName = "Номер телефона заявителя";
            this.номерТелефонаЗаявителяDataGridViewTextBoxColumn.HeaderText = "Номер телефона заявителя";
            this.номерТелефонаЗаявителяDataGridViewTextBoxColumn.Name = "номерТелефонаЗаявителяDataGridViewTextBoxColumn";
            // 
            // кодСменыDataGridViewTextBoxColumn
            // 
            this.кодСменыDataGridViewTextBoxColumn.DataPropertyName = "Код смены";
            this.кодСменыDataGridViewTextBoxColumn.DataSource = this.дежурнаяСменаBindingSource;
            this.кодСменыDataGridViewTextBoxColumn.DisplayMember = "Код смены";
            this.кодСменыDataGridViewTextBoxColumn.HeaderText = "Код смены";
            this.кодСменыDataGridViewTextBoxColumn.Name = "кодСменыDataGridViewTextBoxColumn";
            this.кодСменыDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.кодСменыDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.кодСменыDataGridViewTextBoxColumn.ValueMember = "Код смены";
            // 
            // FireCall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 450);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FireCall";
            this.Text = "Вызов на пожар";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FireCall_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.видобъектапожара1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mchsProektDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.вызовнапожарBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.лист1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.вызовнапожарBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.видобъектапожара1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.вызовнапожарBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.дежурнаяСменаBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MchsProektDataSet mchsProektDataSet;
        private System.Windows.Forms.BindingSource вызовнапожарBindingSource;
        private MchsProektDataSetTableAdapters.Вызов_на_пожарTableAdapter вызов_на_пожарTableAdapter;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.BindingSource вызовнапожарBindingSource1;
        private System.Windows.Forms.BindingSource лист1BindingSource;
        private System.Windows.Forms.BindingSource видобъектапожара1BindingSource;
        private MchsProektDataSetTableAdapters.Вид_объекта_пожара1TableAdapter вид_объекта_пожара1TableAdapter;
        private System.Windows.Forms.BindingSource видобъектапожара1BindingSource1;
        private System.Windows.Forms.BindingSource вызовнапожарBindingSource2;
        private System.Windows.Forms.BindingSource дежурнаяСменаBindingSource;
        private MchsProektDataSetTableAdapters.Дежурная_сменаTableAdapter дежурная_сменаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодВызоваDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресПожараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаОбращенияЗаявителяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяОбращенияЗаявителяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn кодВидаОбъектаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияЗаявителяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяЗаявителяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчетствоЗаявителяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерТелефонаЗаявителяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn кодСменыDataGridViewTextBoxColumn;
    }
}