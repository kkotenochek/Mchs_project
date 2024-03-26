
namespace MchsProekt
{
    partial class FireDepartment
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодПожарнойЧастиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеПожарнойЧастиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресПожарнойЧастиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.штатнаяЧисленностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пожарнаяЧастьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mchsProektDataSet = new MchsProekt.MchsProektDataSet();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.пожарная_частьTableAdapter = new MchsProekt.MchsProektDataSetTableAdapters.Пожарная_частьTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пожарнаяЧастьBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mchsProektDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодПожарнойЧастиDataGridViewTextBoxColumn,
            this.наименованиеПожарнойЧастиDataGridViewTextBoxColumn,
            this.адресПожарнойЧастиDataGridViewTextBoxColumn,
            this.штатнаяЧисленностьDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.пожарнаяЧастьBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1002, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // кодПожарнойЧастиDataGridViewTextBoxColumn
            // 
            this.кодПожарнойЧастиDataGridViewTextBoxColumn.DataPropertyName = "Код пожарной части";
            this.кодПожарнойЧастиDataGridViewTextBoxColumn.HeaderText = "Код пожарной части";
            this.кодПожарнойЧастиDataGridViewTextBoxColumn.Name = "кодПожарнойЧастиDataGridViewTextBoxColumn";
            this.кодПожарнойЧастиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // наименованиеПожарнойЧастиDataGridViewTextBoxColumn
            // 
            this.наименованиеПожарнойЧастиDataGridViewTextBoxColumn.DataPropertyName = "Наименование пожарной части";
            this.наименованиеПожарнойЧастиDataGridViewTextBoxColumn.HeaderText = "Наименование пожарной части";
            this.наименованиеПожарнойЧастиDataGridViewTextBoxColumn.Name = "наименованиеПожарнойЧастиDataGridViewTextBoxColumn";
            this.наименованиеПожарнойЧастиDataGridViewTextBoxColumn.Width = 350;
            // 
            // адресПожарнойЧастиDataGridViewTextBoxColumn
            // 
            this.адресПожарнойЧастиDataGridViewTextBoxColumn.DataPropertyName = "Адрес пожарной части";
            this.адресПожарнойЧастиDataGridViewTextBoxColumn.HeaderText = "Адрес пожарной части";
            this.адресПожарнойЧастиDataGridViewTextBoxColumn.Name = "адресПожарнойЧастиDataGridViewTextBoxColumn";
            this.адресПожарнойЧастиDataGridViewTextBoxColumn.Width = 350;
            // 
            // штатнаяЧисленностьDataGridViewTextBoxColumn
            // 
            this.штатнаяЧисленностьDataGridViewTextBoxColumn.DataPropertyName = "Штатная численность";
            this.штатнаяЧисленностьDataGridViewTextBoxColumn.HeaderText = "Штатная численность";
            this.штатнаяЧисленностьDataGridViewTextBoxColumn.Name = "штатнаяЧисленностьDataGridViewTextBoxColumn";
            // 
            // пожарнаяЧастьBindingSource
            // 
            this.пожарнаяЧастьBindingSource.DataMember = "Пожарная часть";
            this.пожарнаяЧастьBindingSource.DataSource = this.mchsProektDataSet;
            // 
            // mchsProektDataSet
            // 
            this.mchsProektDataSet.DataSetName = "MchsProektDataSet";
            this.mchsProektDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnsave.Location = new System.Drawing.Point(13, 185);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(114, 39);
            this.btnsave.TabIndex = 1;
            this.btnsave.Text = "Сохранить";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnclose.Location = new System.Drawing.Point(144, 185);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(114, 39);
            this.btnclose.TabIndex = 2;
            this.btnclose.Text = "Закрыть";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(906, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 20);
            this.button1.TabIndex = 3;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(833, 204);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(67, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(602, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите код пожарной части для удаления:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(906, 241);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 20);
            this.button2.TabIndex = 6;
            this.button2.Text = "Поиск";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(602, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Введите код пожарной части для поиска:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(833, 241);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(67, 20);
            this.textBox2.TabIndex = 7;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(13, 288);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1002, 150);
            this.dataGridView2.TabIndex = 9;
            // 
            // пожарная_частьTableAdapter
            // 
            this.пожарная_частьTableAdapter.ClearBeforeFill = true;
            // 
            // FireDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FireDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пожарная часть";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FireDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пожарнаяЧастьBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mchsProektDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MchsProektDataSet mchsProektDataSet;
        private System.Windows.Forms.BindingSource пожарнаяЧастьBindingSource;
        private MchsProektDataSetTableAdapters.Пожарная_частьTableAdapter пожарная_частьTableAdapter;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПожарнойЧастиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеПожарнойЧастиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресПожарнойЧастиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn штатнаяЧисленностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}