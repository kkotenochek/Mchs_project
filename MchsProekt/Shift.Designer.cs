
namespace MchsProekt
{
    partial class Shift
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.караулBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mchsProektDataSet = new MchsProekt.MchsProektDataSet();
            this.дежурнаяСменаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.дежурная_сменаTableAdapter = new MchsProekt.MchsProektDataSetTableAdapters.Дежурная_сменаTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.караул1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.караул_1TableAdapter = new MchsProekt.MchsProektDataSetTableAdapters.Караул_1TableAdapter();
            this.кодСменыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаИВремяНачалаСменыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаИВремяКонцаСменыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерКараулаНаСменеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.количествоЧеловекНаСменеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.караулBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mchsProektDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.дежурнаяСменаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.караул1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодСменыDataGridViewTextBoxColumn,
            this.датаИВремяНачалаСменыDataGridViewTextBoxColumn,
            this.датаИВремяКонцаСменыDataGridViewTextBoxColumn,
            this.номерКараулаНаСменеDataGridViewTextBoxColumn,
            this.количествоЧеловекНаСменеDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.дежурнаяСменаBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 362);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // караулBindingSource
            // 
            this.караулBindingSource.DataMember = "Караул";
            this.караулBindingSource.DataSource = this.mchsProektDataSet;
            // 
            // mchsProektDataSet
            // 
            this.mchsProektDataSet.DataSetName = "MchsProektDataSet";
            this.mchsProektDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(138, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // караул1BindingSource
            // 
            this.караул1BindingSource.DataMember = "Караул_1";
            this.караул1BindingSource.DataSource = this.mchsProektDataSet;
            // 
            // караул_1TableAdapter
            // 
            this.караул_1TableAdapter.ClearBeforeFill = true;
            // 
            // кодСменыDataGridViewTextBoxColumn
            // 
            this.кодСменыDataGridViewTextBoxColumn.DataPropertyName = "Код смены";
            this.кодСменыDataGridViewTextBoxColumn.HeaderText = "Код смены";
            this.кодСменыDataGridViewTextBoxColumn.Name = "кодСменыDataGridViewTextBoxColumn";
            this.кодСменыDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаИВремяНачалаСменыDataGridViewTextBoxColumn
            // 
            this.датаИВремяНачалаСменыDataGridViewTextBoxColumn.DataPropertyName = "Дата и время начала смены";
            dataGridViewCellStyle1.Format = "G";
            dataGridViewCellStyle1.NullValue = "00.00.0000 00:00:00";
            this.датаИВремяНачалаСменыDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.датаИВремяНачалаСменыDataGridViewTextBoxColumn.HeaderText = "Дата и время начала смены";
            this.датаИВремяНачалаСменыDataGridViewTextBoxColumn.Name = "датаИВремяНачалаСменыDataGridViewTextBoxColumn";
            this.датаИВремяНачалаСменыDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.датаИВремяНачалаСменыDataGridViewTextBoxColumn.ToolTipText = "Введите данные, меняя нули на цифры";
            this.датаИВремяНачалаСменыDataGridViewTextBoxColumn.Width = 150;
            // 
            // датаИВремяКонцаСменыDataGridViewTextBoxColumn
            // 
            this.датаИВремяКонцаСменыDataGridViewTextBoxColumn.DataPropertyName = "Дата и время конца смены";
            dataGridViewCellStyle2.Format = "F";
            dataGridViewCellStyle2.NullValue = "00.00.0000 00:00:00";
            this.датаИВремяКонцаСменыDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.датаИВремяКонцаСменыDataGridViewTextBoxColumn.HeaderText = "Дата и время конца смены";
            this.датаИВремяКонцаСменыDataGridViewTextBoxColumn.Name = "датаИВремяКонцаСменыDataGridViewTextBoxColumn";
            this.датаИВремяКонцаСменыDataGridViewTextBoxColumn.ToolTipText = "Введите данные, меняя нули на цифры";
            this.датаИВремяКонцаСменыDataGridViewTextBoxColumn.Width = 150;
            // 
            // номерКараулаНаСменеDataGridViewTextBoxColumn
            // 
            this.номерКараулаНаСменеDataGridViewTextBoxColumn.DataPropertyName = "Номер караула на смене";
            this.номерКараулаНаСменеDataGridViewTextBoxColumn.DataSource = this.караул1BindingSource;
            this.номерКараулаНаСменеDataGridViewTextBoxColumn.DisplayMember = "Номер караула";
            this.номерКараулаНаСменеDataGridViewTextBoxColumn.HeaderText = "Номер караула на смене";
            this.номерКараулаНаСменеDataGridViewTextBoxColumn.Name = "номерКараулаНаСменеDataGridViewTextBoxColumn";
            this.номерКараулаНаСменеDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.номерКараулаНаСменеDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.номерКараулаНаСменеDataGridViewTextBoxColumn.ValueMember = "Номер караула";
            // 
            // количествоЧеловекНаСменеDataGridViewTextBoxColumn
            // 
            this.количествоЧеловекНаСменеDataGridViewTextBoxColumn.DataPropertyName = "Количество человек на смене";
            this.количествоЧеловекНаСменеDataGridViewTextBoxColumn.HeaderText = "Количество человек на смене";
            this.количествоЧеловекНаСменеDataGridViewTextBoxColumn.Name = "количествоЧеловекНаСменеDataGridViewTextBoxColumn";
            // 
            // Shift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Shift";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дежурная смена";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Shift_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.караулBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mchsProektDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.дежурнаяСменаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.караул1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MchsProektDataSet mchsProektDataSet;
        private System.Windows.Forms.BindingSource дежурнаяСменаBindingSource;
        private MchsProektDataSetTableAdapters.Дежурная_сменаTableAdapter дежурная_сменаTableAdapter;
        private System.Windows.Forms.BindingSource караулBindingSource;
        //private MchsProektDataSetTableAdapters.КараулTableAdapter караулTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource караул1BindingSource;
        private MchsProektDataSetTableAdapters.Караул_1TableAdapter караул_1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСменыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаИВремяНачалаСменыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаИВремяКонцаСменыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn номерКараулаНаСменеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоЧеловекНаСменеDataGridViewTextBoxColumn;
    }
}