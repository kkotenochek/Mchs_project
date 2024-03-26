
namespace MchsProekt
{
    partial class ВодительМашины
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
            this.водительМашиныBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mchsProektDataSet = new MchsProekt.MchsProektDataSet();
            this.водитель_машиныTableAdapter = new MchsProekt.MchsProektDataSetTableAdapters.Водитель_машиныTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.допускКПожарнойМашинеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.допуск_к_пожарной_машинеTableAdapter = new MchsProekt.MchsProektDataSetTableAdapters.Допуск_к_пожарной_машинеTableAdapter();
            this.пожарнаяЧастьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пожарная_частьTableAdapter = new MchsProekt.MchsProektDataSetTableAdapters.Пожарная_частьTableAdapter();
            this.пожарнаяМашинаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пожарная_машинаTableAdapter = new MchsProekt.MchsProektDataSetTableAdapters.Пожарная_машинаTableAdapter();
            this.номерДопускаКПожарнойМашинеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.номерПожарнойМашиныDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.водительМашиныBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mchsProektDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.допускКПожарнойМашинеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пожарнаяЧастьBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пожарнаяМашинаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерДопускаКПожарнойМашинеDataGridViewTextBoxColumn,
            this.номерПожарнойМашиныDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.водительМашиныBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(585, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // водительМашиныBindingSource
            // 
            this.водительМашиныBindingSource.DataMember = "Водитель машины";
            this.водительМашиныBindingSource.DataSource = this.mchsProektDataSet;
            // 
            // mchsProektDataSet
            // 
            this.mchsProektDataSet.DataSetName = "MchsProektDataSet";
            this.mchsProektDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // водитель_машиныTableAdapter
            // 
            this.водитель_машиныTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(13, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(134, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // пожарнаяЧастьBindingSource
            // 
            this.пожарнаяЧастьBindingSource.DataMember = "Пожарная часть";
            this.пожарнаяЧастьBindingSource.DataSource = this.mchsProektDataSet;
            // 
            // пожарная_частьTableAdapter
            // 
            this.пожарная_частьTableAdapter.ClearBeforeFill = true;
            // 
            // пожарнаяМашинаBindingSource
            // 
            this.пожарнаяМашинаBindingSource.DataMember = "Пожарная машина";
            this.пожарнаяМашинаBindingSource.DataSource = this.mchsProektDataSet;
            // 
            // пожарная_машинаTableAdapter
            // 
            this.пожарная_машинаTableAdapter.ClearBeforeFill = true;
            // 
            // номерДопускаКПожарнойМашинеDataGridViewTextBoxColumn
            // 
            this.номерДопускаКПожарнойМашинеDataGridViewTextBoxColumn.DataPropertyName = "Номер допуска к пожарной машине";
            this.номерДопускаКПожарнойМашинеDataGridViewTextBoxColumn.DataSource = this.допускКПожарнойМашинеBindingSource;
            this.номерДопускаКПожарнойМашинеDataGridViewTextBoxColumn.DisplayMember = "Номер допуска к пожарной машине";
            this.номерДопускаКПожарнойМашинеDataGridViewTextBoxColumn.HeaderText = "Номер допуска к пожарной машине";
            this.номерДопускаКПожарнойМашинеDataGridViewTextBoxColumn.Name = "номерДопускаКПожарнойМашинеDataGridViewTextBoxColumn";
            this.номерДопускаКПожарнойМашинеDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.номерДопускаКПожарнойМашинеDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.номерДопускаКПожарнойМашинеDataGridViewTextBoxColumn.ValueMember = "Номер допуска к пожарной машине";
            this.номерДопускаКПожарнойМашинеDataGridViewTextBoxColumn.Width = 200;
            // 
            // номерПожарнойМашиныDataGridViewTextBoxColumn
            // 
            this.номерПожарнойМашиныDataGridViewTextBoxColumn.DataPropertyName = "Номер пожарной машины";
            this.номерПожарнойМашиныDataGridViewTextBoxColumn.DataSource = this.пожарнаяМашинаBindingSource;
            this.номерПожарнойМашиныDataGridViewTextBoxColumn.DisplayMember = "Номер пожарной машины";
            this.номерПожарнойМашиныDataGridViewTextBoxColumn.HeaderText = "Номер пожарной машины";
            this.номерПожарнойМашиныDataGridViewTextBoxColumn.Name = "номерПожарнойМашиныDataGridViewTextBoxColumn";
            this.номерПожарнойМашиныDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.номерПожарнойМашиныDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.номерПожарнойМашиныDataGridViewTextBoxColumn.ValueMember = "Номер пожарной машины";
            this.номерПожарнойМашиныDataGridViewTextBoxColumn.Width = 200;
            // 
            // ВодительМашины
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 238);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ВодительМашины";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Водитель машины";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ВодительМашины_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.водительМашиныBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mchsProektDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.допускКПожарнойМашинеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пожарнаяЧастьBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пожарнаяМашинаBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MchsProektDataSet mchsProektDataSet;
        private System.Windows.Forms.BindingSource водительМашиныBindingSource;
        private MchsProektDataSetTableAdapters.Водитель_машиныTableAdapter водитель_машиныTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource допускКПожарнойМашинеBindingSource;
        private MchsProektDataSetTableAdapters.Допуск_к_пожарной_машинеTableAdapter допуск_к_пожарной_машинеTableAdapter;
        private System.Windows.Forms.BindingSource пожарнаяЧастьBindingSource;
        private MchsProektDataSetTableAdapters.Пожарная_частьTableAdapter пожарная_частьTableAdapter;
        private System.Windows.Forms.BindingSource пожарнаяМашинаBindingSource;
        private MchsProektDataSetTableAdapters.Пожарная_машинаTableAdapter пожарная_машинаTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn номерДопускаКПожарнойМашинеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn номерПожарнойМашиныDataGridViewTextBoxColumn;
    }
}