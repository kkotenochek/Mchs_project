﻿
namespace MchsProekt
{
    partial class WorkerEducation
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
            this.сотрудникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mchsProektDataSet = new MchsProekt.MchsProektDataSet();
            this.образованиеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.образованиесотрудникаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.образование_сотрудникаTableAdapter = new MchsProekt.MchsProektDataSetTableAdapters.Образование_сотрудникаTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.образованиеTableAdapter = new MchsProekt.MchsProektDataSetTableAdapters.ОбразованиеTableAdapter();
            this.сотрудникTableAdapter = new MchsProekt.MchsProektDataSetTableAdapters.СотрудникTableAdapter();
            this.табельныйНомерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.кодуровняобразованияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.серияДокументаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерДокументаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеУчебногоЗаведенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mchsProektDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.образованиеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.образованиесотрудникаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.табельныйНомерDataGridViewTextBoxColumn,
            this.кодуровняобразованияDataGridViewTextBoxColumn,
            this.серияДокументаDataGridViewTextBoxColumn,
            this.номерДокументаDataGridViewTextBoxColumn,
            this.наименованиеУчебногоЗаведенияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.образованиесотрудникаBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 150);
            this.dataGridView1.TabIndex = 0;
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
            // образованиеBindingSource
            // 
            this.образованиеBindingSource.DataMember = "Образование";
            this.образованиеBindingSource.DataSource = this.mchsProektDataSet;
            // 
            // образованиесотрудникаBindingSource
            // 
            this.образованиесотрудникаBindingSource.DataMember = "Образование_сотрудника";
            this.образованиесотрудникаBindingSource.DataSource = this.mchsProektDataSet;
            // 
            // образование_сотрудникаTableAdapter
            // 
            this.образование_сотрудникаTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(13, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(122, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // образованиеTableAdapter
            // 
            this.образованиеTableAdapter.ClearBeforeFill = true;
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
            // кодуровняобразованияDataGridViewTextBoxColumn
            // 
            this.кодуровняобразованияDataGridViewTextBoxColumn.DataPropertyName = "Код_уровня_образования";
            this.кодуровняобразованияDataGridViewTextBoxColumn.DataSource = this.образованиеBindingSource;
            this.кодуровняобразованияDataGridViewTextBoxColumn.DisplayMember = "Наименование уровня образования";
            this.кодуровняобразованияDataGridViewTextBoxColumn.HeaderText = "Код_уровня_образования";
            this.кодуровняобразованияDataGridViewTextBoxColumn.Name = "кодуровняобразованияDataGridViewTextBoxColumn";
            this.кодуровняобразованияDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.кодуровняобразованияDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.кодуровняобразованияDataGridViewTextBoxColumn.ValueMember = "Код_уровня_образования";
            this.кодуровняобразованияDataGridViewTextBoxColumn.Width = 250;
            // 
            // серияДокументаDataGridViewTextBoxColumn
            // 
            this.серияДокументаDataGridViewTextBoxColumn.DataPropertyName = "Серия документа";
            this.серияДокументаDataGridViewTextBoxColumn.HeaderText = "Серия документа";
            this.серияДокументаDataGridViewTextBoxColumn.Name = "серияДокументаDataGridViewTextBoxColumn";
            // 
            // номерДокументаDataGridViewTextBoxColumn
            // 
            this.номерДокументаDataGridViewTextBoxColumn.DataPropertyName = "Номер документа";
            this.номерДокументаDataGridViewTextBoxColumn.HeaderText = "Номер документа";
            this.номерДокументаDataGridViewTextBoxColumn.Name = "номерДокументаDataGridViewTextBoxColumn";
            // 
            // наименованиеУчебногоЗаведенияDataGridViewTextBoxColumn
            // 
            this.наименованиеУчебногоЗаведенияDataGridViewTextBoxColumn.DataPropertyName = "Наименование учебного заведения";
            this.наименованиеУчебногоЗаведенияDataGridViewTextBoxColumn.HeaderText = "Наименование учебного заведения";
            this.наименованиеУчебногоЗаведенияDataGridViewTextBoxColumn.Name = "наименованиеУчебногоЗаведенияDataGridViewTextBoxColumn";
            // 
            // WorkerEducation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "WorkerEducation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Образование сотрудника";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.WorkerEducation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mchsProektDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.образованиеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.образованиесотрудникаBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MchsProektDataSet mchsProektDataSet;
        private System.Windows.Forms.BindingSource образованиесотрудникаBindingSource;
        private MchsProektDataSetTableAdapters.Образование_сотрудникаTableAdapter образование_сотрудникаTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource образованиеBindingSource;
        private MchsProektDataSetTableAdapters.ОбразованиеTableAdapter образованиеTableAdapter;
        private System.Windows.Forms.BindingSource сотрудникBindingSource;
        private MchsProektDataSetTableAdapters.СотрудникTableAdapter сотрудникTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn табельныйНомерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn кодуровняобразованияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn серияДокументаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерДокументаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеУчебногоЗаведенияDataGridViewTextBoxColumn;
    }
}