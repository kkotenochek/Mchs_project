
namespace MchsProekt
{
    partial class WorkerTitle
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
            this.званиеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mchsProektDataSet = new MchsProekt.MchsProektDataSet();
            this.званиеСотрудникаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.звание_сотрудникаTableAdapter = new MchsProekt.MchsProektDataSetTableAdapters.Звание_сотрудникаTableAdapter();
            this.званиеTableAdapter = new MchsProekt.MchsProektDataSetTableAdapters.ЗваниеTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.сотрудникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникTableAdapter = new MchsProekt.MchsProektDataSetTableAdapters.СотрудникTableAdapter();
            this.табельныйНомерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.кодЗванияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.датаПолученияЗванияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаОкончанияЗванияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.званиеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mchsProektDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.званиеСотрудникаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.табельныйНомерDataGridViewTextBoxColumn,
            this.кодЗванияDataGridViewTextBoxColumn,
            this.датаПолученияЗванияDataGridViewTextBoxColumn,
            this.датаОкончанияЗванияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.званиеСотрудникаBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 150);
            this.dataGridView1.TabIndex = 0;
            //this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // званиеBindingSource
            // 
            this.званиеBindingSource.DataMember = "Звание";
            this.званиеBindingSource.DataSource = this.mchsProektDataSet;
            // 
            // mchsProektDataSet
            // 
            this.mchsProektDataSet.DataSetName = "MchsProektDataSet";
            this.mchsProektDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // званиеСотрудникаBindingSource
            // 
            this.званиеСотрудникаBindingSource.DataMember = "Звание сотрудника";
            this.званиеСотрудникаBindingSource.DataSource = this.mchsProektDataSet;
            // 
            // звание_сотрудникаTableAdapter
            // 
            this.звание_сотрудникаTableAdapter.ClearBeforeFill = true;
            // 
            // званиеTableAdapter
            // 
            this.званиеTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(135, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // кодЗванияDataGridViewTextBoxColumn
            // 
            this.кодЗванияDataGridViewTextBoxColumn.DataPropertyName = "Код звания";
            this.кодЗванияDataGridViewTextBoxColumn.DataSource = this.званиеBindingSource;
            this.кодЗванияDataGridViewTextBoxColumn.DisplayMember = "Наименование звания";
            this.кодЗванияDataGridViewTextBoxColumn.HeaderText = "Код звания";
            this.кодЗванияDataGridViewTextBoxColumn.Name = "кодЗванияDataGridViewTextBoxColumn";
            this.кодЗванияDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.кодЗванияDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.кодЗванияDataGridViewTextBoxColumn.ValueMember = "Код звания";
            this.кодЗванияDataGridViewTextBoxColumn.Width = 250;
            // 
            // датаПолученияЗванияDataGridViewTextBoxColumn
            // 
            this.датаПолученияЗванияDataGridViewTextBoxColumn.DataPropertyName = "Дата получения звания";
            this.датаПолученияЗванияDataGridViewTextBoxColumn.HeaderText = "Дата получения звания";
            this.датаПолученияЗванияDataGridViewTextBoxColumn.Name = "датаПолученияЗванияDataGridViewTextBoxColumn";
            // 
            // датаОкончанияЗванияDataGridViewTextBoxColumn
            // 
            this.датаОкончанияЗванияDataGridViewTextBoxColumn.DataPropertyName = "Дата окончания звания";
            this.датаОкончанияЗванияDataGridViewTextBoxColumn.HeaderText = "Дата окончания звания";
            this.датаОкончанияЗванияDataGridViewTextBoxColumn.Name = "датаОкончанияЗванияDataGridViewTextBoxColumn";
            // 
            // WorkerTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 240);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "WorkerTitle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Звание сотрудника";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.WorkerTitle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.званиеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mchsProektDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.званиеСотрудникаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MchsProektDataSet mchsProektDataSet;
        private System.Windows.Forms.BindingSource званиеСотрудникаBindingSource;
        private MchsProektDataSetTableAdapters.Звание_сотрудникаTableAdapter звание_сотрудникаTableAdapter;
        private System.Windows.Forms.BindingSource званиеBindingSource;
        private MchsProektDataSetTableAdapters.ЗваниеTableAdapter званиеTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource сотрудникBindingSource;
        private MchsProektDataSetTableAdapters.СотрудникTableAdapter сотрудникTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn табельныйНомерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn кодЗванияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаПолученияЗванияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаОкончанияЗванияDataGridViewTextBoxColumn;
    }
}