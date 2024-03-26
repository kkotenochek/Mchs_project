
namespace MchsProekt
{
    partial class FireMachine
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
            this.номерПожарнойМашиныDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодПожарнойЧастиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.пожарнаяЧастьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mchsProektDataSet = new MchsProekt.MchsProektDataSet();
            this.кодВидаПожарнойМашиныDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.видпожарноймашиныBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.пожарнаяМашинаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пожарная_машинаTableAdapter = new MchsProekt.MchsProektDataSetTableAdapters.Пожарная_машинаTableAdapter();
            this.вид_пожарной_машиныTableAdapter = new MchsProekt.MchsProektDataSetTableAdapters.Вид_пожарной_машиныTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.пожарная_частьTableAdapter = new MchsProekt.MchsProektDataSetTableAdapters.Пожарная_частьTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пожарнаяЧастьBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mchsProektDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.видпожарноймашиныBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пожарнаяМашинаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерПожарнойМашиныDataGridViewTextBoxColumn,
            this.кодПожарнойЧастиDataGridViewTextBoxColumn,
            this.кодВидаПожарнойМашиныDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.пожарнаяМашинаBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // номерПожарнойМашиныDataGridViewTextBoxColumn
            // 
            this.номерПожарнойМашиныDataGridViewTextBoxColumn.DataPropertyName = "Номер пожарной машины";
            this.номерПожарнойМашиныDataGridViewTextBoxColumn.HeaderText = "Номер пожарной машины";
            this.номерПожарнойМашиныDataGridViewTextBoxColumn.Name = "номерПожарнойМашиныDataGridViewTextBoxColumn";
            // 
            // кодПожарнойЧастиDataGridViewTextBoxColumn
            // 
            this.кодПожарнойЧастиDataGridViewTextBoxColumn.DataPropertyName = "Код пожарной части";
            this.кодПожарнойЧастиDataGridViewTextBoxColumn.DataSource = this.пожарнаяЧастьBindingSource;
            this.кодПожарнойЧастиDataGridViewTextBoxColumn.DisplayMember = "Код пожарной части";
            this.кодПожарнойЧастиDataGridViewTextBoxColumn.HeaderText = "Код пожарной части";
            this.кодПожарнойЧастиDataGridViewTextBoxColumn.Name = "кодПожарнойЧастиDataGridViewTextBoxColumn";
            this.кодПожарнойЧастиDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.кодПожарнойЧастиDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.кодПожарнойЧастиDataGridViewTextBoxColumn.ValueMember = "Код пожарной части";
            this.кодПожарнойЧастиDataGridViewTextBoxColumn.Width = 350;
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
            // кодВидаПожарнойМашиныDataGridViewTextBoxColumn
            // 
            this.кодВидаПожарнойМашиныDataGridViewTextBoxColumn.DataPropertyName = "Код вида пожарной машины";
            this.кодВидаПожарнойМашиныDataGridViewTextBoxColumn.DataSource = this.видпожарноймашиныBindingSource1;
            this.кодВидаПожарнойМашиныDataGridViewTextBoxColumn.DisplayMember = "Вид пожарной машины";
            this.кодВидаПожарнойМашиныDataGridViewTextBoxColumn.HeaderText = "Код вида пожарной машины";
            this.кодВидаПожарнойМашиныDataGridViewTextBoxColumn.Name = "кодВидаПожарнойМашиныDataGridViewTextBoxColumn";
            this.кодВидаПожарнойМашиныDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.кодВидаПожарнойМашиныDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.кодВидаПожарнойМашиныDataGridViewTextBoxColumn.ValueMember = "Код";
            this.кодВидаПожарнойМашиныDataGridViewTextBoxColumn.Width = 350;
            // 
            // видпожарноймашиныBindingSource1
            // 
            this.видпожарноймашиныBindingSource1.DataMember = "Вид_пожарной_машины";
            this.видпожарноймашиныBindingSource1.DataSource = this.mchsProektDataSet;
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
            // вид_пожарной_машиныTableAdapter
            // 
            this.вид_пожарной_машиныTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(13, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(140, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // пожарная_частьTableAdapter
            // 
            this.пожарная_частьTableAdapter.ClearBeforeFill = true;
            // 
            // FireMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 239);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FireMachine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пожарная машина";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FireMachine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пожарнаяЧастьBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mchsProektDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.видпожарноймашиныBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пожарнаяМашинаBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MchsProektDataSet mchsProektDataSet;
        private System.Windows.Forms.BindingSource пожарнаяМашинаBindingSource;
        private MchsProektDataSetTableAdapters.Пожарная_машинаTableAdapter пожарная_машинаTableAdapter;
        private MchsProektDataSetTableAdapters.Вид_пожарной_машиныTableAdapter вид_пожарной_машиныTableAdapter;
        private System.Windows.Forms.BindingSource видпожарноймашиныBindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource пожарнаяЧастьBindingSource;
        private MchsProektDataSetTableAdapters.Пожарная_частьTableAdapter пожарная_частьTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерПожарнойМашиныDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn кодПожарнойЧастиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn кодВидаПожарнойМашиныDataGridViewTextBoxColumn;
    }
}