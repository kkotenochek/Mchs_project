
namespace MchsProekt
{
    partial class ДопускМашина
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
            this.номерДопускаКПожарнойМашинеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.табельныйНомерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.сотрудникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mchsProektDataSet = new MchsProekt.MchsProektDataSet();
            this.датаВыдачиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.допускКПожарнойМашинеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.допуск_к_пожарной_машинеTableAdapter = new MchsProekt.MchsProektDataSetTableAdapters.Допуск_к_пожарной_машинеTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.сотрудникTableAdapter = new MchsProekt.MchsProektDataSetTableAdapters.СотрудникTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mchsProektDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.допускКПожарнойМашинеBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерДопускаКПожарнойМашинеDataGridViewTextBoxColumn,
            this.табельныйНомерDataGridViewTextBoxColumn,
            this.датаВыдачиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.допускКПожарнойМашинеBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // номерДопускаКПожарнойМашинеDataGridViewTextBoxColumn
            // 
            this.номерДопускаКПожарнойМашинеDataGridViewTextBoxColumn.DataPropertyName = "Номер допуска к пожарной машине";
            this.номерДопускаКПожарнойМашинеDataGridViewTextBoxColumn.HeaderText = "Номер допуска к пожарной машине";
            this.номерДопускаКПожарнойМашинеDataGridViewTextBoxColumn.Name = "номерДопускаКПожарнойМашинеDataGridViewTextBoxColumn";
            // 
            // табельныйНомерDataGridViewTextBoxColumn
            // 
            this.табельныйНомерDataGridViewTextBoxColumn.DataPropertyName = "Табельный номер";
            this.табельныйНомерDataGridViewTextBoxColumn.DataSource = this.сотрудникBindingSource;
            this.табельныйНомерDataGridViewTextBoxColumn.DisplayMember = "Табельный номер";
            this.табельныйНомерDataGridViewTextBoxColumn.HeaderText = "Табельный номер";
            this.табельныйНомерDataGridViewTextBoxColumn.Name = "табельныйНомерDataGridViewTextBoxColumn";
            this.табельныйНомерDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.табельныйНомерDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.табельныйНомерDataGridViewTextBoxColumn.ValueMember = "Табельный номер";
            // 
            // сотрудникBindingSource
            // 
            this.сотрудникBindingSource.DataMember = "Сотрудник";
            this.сотрудникBindingSource.DataSource = this.mchsProektDataSet;
            // 
            // mchsProektDataSet
            // 
            this.mchsProektDataSet.DataSetName = "MchsProektDataSet";
            this.mchsProektDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // датаВыдачиDataGridViewTextBoxColumn
            // 
            this.датаВыдачиDataGridViewTextBoxColumn.DataPropertyName = "Дата выдачи";
            this.датаВыдачиDataGridViewTextBoxColumn.HeaderText = "Дата выдачи";
            this.датаВыдачиDataGridViewTextBoxColumn.Name = "датаВыдачиDataGridViewTextBoxColumn";
            // 
            // допускКПожарнойМашинеBindingSource
            // 
            this.допускКПожарнойМашинеBindingSource.DataMember = "Допуск к пожарной машине";
            this.допускКПожарнойМашинеBindingSource.DataSource = this.mchsProektDataSet;
            // 
            // допуск_к_пожарной_машинеTableAdapter
            // 
            this.допуск_к_пожарной_машинеTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(13, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(132, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // сотрудникTableAdapter
            // 
            this.сотрудникTableAdapter.ClearBeforeFill = true;
            // 
            // ДопускМашина
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 225);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ДопускМашина";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Допуск к пожарной машине";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ДопускМашина_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mchsProektDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.допускКПожарнойМашинеBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MchsProektDataSet mchsProektDataSet;
        private System.Windows.Forms.BindingSource допускКПожарнойМашинеBindingSource;
        private MchsProektDataSetTableAdapters.Допуск_к_пожарной_машинеTableAdapter допуск_к_пожарной_машинеTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource сотрудникBindingSource;
        private MchsProektDataSetTableAdapters.СотрудникTableAdapter сотрудникTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерДопускаКПожарнойМашинеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn табельныйНомерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаВыдачиDataGridViewTextBoxColumn;
    }
}