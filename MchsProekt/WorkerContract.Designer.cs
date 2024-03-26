
namespace MchsProekt
{
    partial class WorkerContract
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
            this.mchsProektDataSet = new MchsProekt.MchsProektDataSet();
            this.сотрудникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникTableAdapter = new MchsProekt.MchsProektDataSetTableAdapters.СотрудникTableAdapter();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.контрактСотрудникаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.контракт_сотрудникаTableAdapter = new MchsProekt.MchsProektDataSetTableAdapters.Контракт_сотрудникаTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.контрактСотрудникаBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.номерКонтрактаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаЗаключенияКонтрактаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаОкончанияКонтрактаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.табельныйНомерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mchsProektDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.контрактСотрудникаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.контрактСотрудникаBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // mchsProektDataSet
            // 
            this.mchsProektDataSet.DataSetName = "MchsProektDataSet";
            this.mchsProektDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сотрудникBindingSource
            // 
            this.сотрудникBindingSource.DataMember = "Сотрудник";
            this.сотрудникBindingSource.DataSource = this.mchsProektDataSet;
            // 
            // сотрудникTableAdapter
            // 
            this.сотрудникTableAdapter.ClearBeforeFill = true;
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnsave.Location = new System.Drawing.Point(13, 189);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(111, 44);
            this.btnsave.TabIndex = 1;
            this.btnsave.Text = "Сохранить";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnclose.Location = new System.Drawing.Point(159, 189);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(111, 44);
            this.btnclose.TabIndex = 2;
            this.btnclose.Text = "Закрыть";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // контрактСотрудникаBindingSource
            // 
            this.контрактСотрудникаBindingSource.DataMember = "Контракт сотрудника";
            this.контрактСотрудникаBindingSource.DataSource = this.mchsProektDataSet;
            // 
            // контракт_сотрудникаTableAdapter
            // 
            this.контракт_сотрудникаTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерКонтрактаDataGridViewTextBoxColumn,
            this.датаЗаключенияКонтрактаDataGridViewTextBoxColumn,
            this.датаОкончанияКонтрактаDataGridViewTextBoxColumn,
            this.табельныйНомерDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.контрактСотрудникаBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(547, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // контрактСотрудникаBindingSource1
            // 
            this.контрактСотрудникаBindingSource1.DataMember = "Контракт сотрудника";
            this.контрактСотрудникаBindingSource1.DataSource = this.mchsProektDataSet;
            // 
            // сотрудникBindingSource1
            // 
            this.сотрудникBindingSource1.DataMember = "Сотрудник";
            this.сотрудникBindingSource1.DataSource = this.mchsProektDataSet;
            // 
            // номерКонтрактаDataGridViewTextBoxColumn
            // 
            this.номерКонтрактаDataGridViewTextBoxColumn.DataPropertyName = "Номер контракта";
            this.номерКонтрактаDataGridViewTextBoxColumn.HeaderText = "Номер контракта";
            this.номерКонтрактаDataGridViewTextBoxColumn.Name = "номерКонтрактаDataGridViewTextBoxColumn";
            this.номерКонтрактаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаЗаключенияКонтрактаDataGridViewTextBoxColumn
            // 
            this.датаЗаключенияКонтрактаDataGridViewTextBoxColumn.DataPropertyName = "Дата заключения контракта";
            this.датаЗаключенияКонтрактаDataGridViewTextBoxColumn.HeaderText = "Дата заключения контракта";
            this.датаЗаключенияКонтрактаDataGridViewTextBoxColumn.Name = "датаЗаключенияКонтрактаDataGridViewTextBoxColumn";
            // 
            // датаОкончанияКонтрактаDataGridViewTextBoxColumn
            // 
            this.датаОкончанияКонтрактаDataGridViewTextBoxColumn.DataPropertyName = "Дата окончания контракта";
            this.датаОкончанияКонтрактаDataGridViewTextBoxColumn.HeaderText = "Дата окончания контракта";
            this.датаОкончанияКонтрактаDataGridViewTextBoxColumn.Name = "датаОкончанияКонтрактаDataGridViewTextBoxColumn";
            // 
            // табельныйНомерDataGridViewTextBoxColumn
            // 
            this.табельныйНомерDataGridViewTextBoxColumn.DataPropertyName = "Табельный номер";
            this.табельныйНомерDataGridViewTextBoxColumn.DataSource = this.сотрудникBindingSource1;
            this.табельныйНомерDataGridViewTextBoxColumn.DisplayMember = "Табельный номер";
            this.табельныйНомерDataGridViewTextBoxColumn.HeaderText = "Табельный номер";
            this.табельныйНомерDataGridViewTextBoxColumn.Name = "табельныйНомерDataGridViewTextBoxColumn";
            this.табельныйНомерDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.табельныйНомерDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.табельныйНомерDataGridViewTextBoxColumn.ValueMember = "Табельный номер";
            // 
            // WorkerContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(596, 289);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnsave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "WorkerContract";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Контракт cотрудника";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Worker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mchsProektDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.контрактСотрудникаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.контрактСотрудникаBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MchsProektDataSet mchsProektDataSet;
        private System.Windows.Forms.BindingSource сотрудникBindingSource;
        private MchsProektDataSetTableAdapters.СотрудникTableAdapter сотрудникTableAdapter;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.BindingSource контрактСотрудникаBindingSource;
        private MchsProektDataSetTableAdapters.Контракт_сотрудникаTableAdapter контракт_сотрудникаTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource контрактСотрудникаBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерКонтрактаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаЗаключенияКонтрактаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаОкончанияКонтрактаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn табельныйНомерDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource сотрудникBindingSource1;
    }
}