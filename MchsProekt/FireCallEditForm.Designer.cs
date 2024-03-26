
namespace MchsProekt
{
    partial class FireCallEditForm
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
            System.Windows.Forms.Label код_вызоваLabel;
            System.Windows.Forms.Label адрес_пожараLabel;
            System.Windows.Forms.Label дата_обращения_заявителяLabel;
            System.Windows.Forms.Label время_обращения_заявителяLabel;
            System.Windows.Forms.Label фамилия_заявителяLabel;
            System.Windows.Forms.Label имя_заявителяLabel;
            System.Windows.Forms.Label отчетство_заявителяLabel;
            System.Windows.Forms.Label номер_телефона_заявителяLabel;
            System.Windows.Forms.Label код_сменыLabel;
            this.mchsProektDataSet = new MchsProekt.MchsProektDataSet();
            this.вызов_на_пожарBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.вызов_на_пожарTableAdapter = new MchsProekt.MchsProektDataSetTableAdapters.Вызов_на_пожарTableAdapter();
            this.tableAdapterManager = new MchsProekt.MchsProektDataSetTableAdapters.TableAdapterManager();
            this.вид_объекта_пожара1TableAdapter = new MchsProekt.MchsProektDataSetTableAdapters.Вид_объекта_пожара1TableAdapter();
            this.код_вызоваTextBox = new System.Windows.Forms.TextBox();
            this.адрес_пожараTextBox = new System.Windows.Forms.TextBox();
            this.дата_обращения_заявителяMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.время_обращения_заявителяMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.видобъектапожара1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.фамилия_заявителяTextBox = new System.Windows.Forms.TextBox();
            this.имя_заявителяTextBox = new System.Windows.Forms.TextBox();
            this.отчетство_заявителяTextBox = new System.Windows.Forms.TextBox();
            this.номер_телефона_заявителяMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.код_сменыTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.видобъектапожара1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            код_вызоваLabel = new System.Windows.Forms.Label();
            адрес_пожараLabel = new System.Windows.Forms.Label();
            дата_обращения_заявителяLabel = new System.Windows.Forms.Label();
            время_обращения_заявителяLabel = new System.Windows.Forms.Label();
            фамилия_заявителяLabel = new System.Windows.Forms.Label();
            имя_заявителяLabel = new System.Windows.Forms.Label();
            отчетство_заявителяLabel = new System.Windows.Forms.Label();
            номер_телефона_заявителяLabel = new System.Windows.Forms.Label();
            код_сменыLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mchsProektDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.вызов_на_пожарBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.видобъектапожара1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.видобъектапожара1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // код_вызоваLabel
            // 
            код_вызоваLabel.AutoSize = true;
            код_вызоваLabel.Location = new System.Drawing.Point(28, 22);
            код_вызоваLabel.Name = "код_вызоваLabel";
            код_вызоваLabel.Size = new System.Drawing.Size(70, 13);
            код_вызоваLabel.TabIndex = 1;
            код_вызоваLabel.Text = "Код вызова:";
            // 
            // адрес_пожараLabel
            // 
            адрес_пожараLabel.AutoSize = true;
            адрес_пожараLabel.Location = new System.Drawing.Point(28, 48);
            адрес_пожараLabel.Name = "адрес_пожараLabel";
            адрес_пожараLabel.Size = new System.Drawing.Size(82, 13);
            адрес_пожараLabel.TabIndex = 3;
            адрес_пожараLabel.Text = "Адрес пожара:";
            // 
            // дата_обращения_заявителяLabel
            // 
            дата_обращения_заявителяLabel.AutoSize = true;
            дата_обращения_заявителяLabel.Location = new System.Drawing.Point(28, 74);
            дата_обращения_заявителяLabel.Name = "дата_обращения_заявителяLabel";
            дата_обращения_заявителяLabel.Size = new System.Drawing.Size(152, 13);
            дата_обращения_заявителяLabel.TabIndex = 5;
            дата_обращения_заявителяLabel.Text = "Дата обращения заявителя:";
            // 
            // время_обращения_заявителяLabel
            // 
            время_обращения_заявителяLabel.AutoSize = true;
            время_обращения_заявителяLabel.Location = new System.Drawing.Point(28, 100);
            время_обращения_заявителяLabel.Name = "время_обращения_заявителяLabel";
            время_обращения_заявителяLabel.Size = new System.Drawing.Size(159, 13);
            время_обращения_заявителяLabel.TabIndex = 7;
            время_обращения_заявителяLabel.Text = "Время обращения заявителя:";
            // 
            // фамилия_заявителяLabel
            // 
            фамилия_заявителяLabel.AutoSize = true;
            фамилия_заявителяLabel.Location = new System.Drawing.Point(28, 153);
            фамилия_заявителяLabel.Name = "фамилия_заявителяLabel";
            фамилия_заявителяLabel.Size = new System.Drawing.Size(115, 13);
            фамилия_заявителяLabel.TabIndex = 11;
            фамилия_заявителяLabel.Text = "Фамилия заявителя:";
            // 
            // имя_заявителяLabel
            // 
            имя_заявителяLabel.AutoSize = true;
            имя_заявителяLabel.Location = new System.Drawing.Point(28, 179);
            имя_заявителяLabel.Name = "имя_заявителяLabel";
            имя_заявителяLabel.Size = new System.Drawing.Size(88, 13);
            имя_заявителяLabel.TabIndex = 13;
            имя_заявителяLabel.Text = "Имя заявителя:";
            // 
            // отчетство_заявителяLabel
            // 
            отчетство_заявителяLabel.AutoSize = true;
            отчетство_заявителяLabel.Location = new System.Drawing.Point(28, 205);
            отчетство_заявителяLabel.Name = "отчетство_заявителяLabel";
            отчетство_заявителяLabel.Size = new System.Drawing.Size(118, 13);
            отчетство_заявителяLabel.TabIndex = 15;
            отчетство_заявителяLabel.Text = "Отчетство заявителя:";
            // 
            // номер_телефона_заявителяLabel
            // 
            номер_телефона_заявителяLabel.AutoSize = true;
            номер_телефона_заявителяLabel.Location = new System.Drawing.Point(28, 231);
            номер_телефона_заявителяLabel.Name = "номер_телефона_заявителяLabel";
            номер_телефона_заявителяLabel.Size = new System.Drawing.Size(152, 13);
            номер_телефона_заявителяLabel.TabIndex = 17;
            номер_телефона_заявителяLabel.Text = "Номер телефона заявителя:";
            // 
            // код_сменыLabel
            // 
            код_сменыLabel.AutoSize = true;
            код_сменыLabel.Location = new System.Drawing.Point(28, 257);
            код_сменыLabel.Name = "код_сменыLabel";
            код_сменыLabel.Size = new System.Drawing.Size(66, 13);
            код_сменыLabel.TabIndex = 19;
            код_сменыLabel.Text = "Код смены:";
            // 
            // mchsProektDataSet
            // 
            this.mchsProektDataSet.DataSetName = "MchsProektDataSet";
            this.mchsProektDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // вызов_на_пожарBindingSource
            // 
            this.вызов_на_пожарBindingSource.DataMember = "Вызов_на_пожар";
            this.вызов_на_пожарBindingSource.DataSource = this.mchsProektDataSet;
            // 
            // вызов_на_пожарTableAdapter
            // 
            this.вызов_на_пожарTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = MchsProekt.MchsProektDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Вид_объекта_пожара1TableAdapter = this.вид_объекта_пожара1TableAdapter;
            this.tableAdapterManager.Вид_пожарной_машиныTableAdapter = null;
            this.tableAdapterManager.Виновное_лицоTableAdapter = null;
            this.tableAdapterManager.Водитель_машиныTableAdapter = null;
            this.tableAdapterManager.Выезд_на_пожарTableAdapter = null;
            this.tableAdapterManager.Вызов_на_пожарTableAdapter = this.вызов_на_пожарTableAdapter;
            this.tableAdapterManager.Дежурная_сменаTableAdapter = null;
            this.tableAdapterManager.Должность_сотрудникаTableAdapter = null;
            this.tableAdapterManager.ДолжностьTableAdapter = null;
            this.tableAdapterManager.Допуск_к_пожарной_машинеTableAdapter = null;
            this.tableAdapterManager.Звание_сотрдуникаTableAdapter = null;
            this.tableAdapterManager.Звание_сотрудникаTableAdapter = null;
            this.tableAdapterManager.ЗваниеTableAdapter = null;
            //this.tableAdapterManager.КараулTableAdapter = null;
            this.tableAdapterManager.Контракт_сотрудникаTableAdapter = null;
            this.tableAdapterManager.Образование_сотрудникаTableAdapter = null;
            this.tableAdapterManager.ОбразованиеTableAdapter = null;
            this.tableAdapterManager.Пожарная_машинаTableAdapter = null;
            this.tableAdapterManager.Пожарная_частьTableAdapter = null;
            this.tableAdapterManager.Пол_сотрудникаTableAdapter = null;
            this.tableAdapterManager.Причина_пожараTableAdapter = null;
            this.tableAdapterManager.СотрудникTableAdapter = null;
            // 
            // вид_объекта_пожара1TableAdapter
            // 
            this.вид_объекта_пожара1TableAdapter.ClearBeforeFill = true;
            // 
            // код_вызоваTextBox
            // 
            this.код_вызоваTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вызов_на_пожарBindingSource, "Код вызова", true));
            this.код_вызоваTextBox.Location = new System.Drawing.Point(193, 19);
            this.код_вызоваTextBox.Name = "код_вызоваTextBox";
            this.код_вызоваTextBox.Size = new System.Drawing.Size(546, 20);
            this.код_вызоваTextBox.TabIndex = 2;
            // 
            // адрес_пожараTextBox
            // 
            this.адрес_пожараTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вызов_на_пожарBindingSource, "Адрес пожара", true));
            this.адрес_пожараTextBox.Location = new System.Drawing.Point(193, 45);
            this.адрес_пожараTextBox.Name = "адрес_пожараTextBox";
            this.адрес_пожараTextBox.Size = new System.Drawing.Size(546, 20);
            this.адрес_пожараTextBox.TabIndex = 4;
            // 
            // дата_обращения_заявителяMaskedTextBox
            // 
            this.дата_обращения_заявителяMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вызов_на_пожарBindingSource, "Дата обращения заявителя", true));
            this.дата_обращения_заявителяMaskedTextBox.Location = new System.Drawing.Point(193, 71);
            this.дата_обращения_заявителяMaskedTextBox.Mask = "00/00/0000";
            this.дата_обращения_заявителяMaskedTextBox.Name = "дата_обращения_заявителяMaskedTextBox";
            this.дата_обращения_заявителяMaskedTextBox.Size = new System.Drawing.Size(546, 20);
            this.дата_обращения_заявителяMaskedTextBox.TabIndex = 6;
            this.дата_обращения_заявителяMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // время_обращения_заявителяMaskedTextBox
            // 
            this.время_обращения_заявителяMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вызов_на_пожарBindingSource, "Время обращения заявителя", true));
            this.время_обращения_заявителяMaskedTextBox.Location = new System.Drawing.Point(193, 97);
            this.время_обращения_заявителяMaskedTextBox.Mask = "99:00:00";
            this.время_обращения_заявителяMaskedTextBox.Name = "время_обращения_заявителяMaskedTextBox";
            this.время_обращения_заявителяMaskedTextBox.Size = new System.Drawing.Size(546, 20);
            this.время_обращения_заявителяMaskedTextBox.TabIndex = 8;
            // 
            // видобъектапожара1BindingSource
            // 
            this.видобъектапожара1BindingSource.DataMember = "Вид_объекта_пожара1";
            this.видобъектапожара1BindingSource.DataSource = this.mchsProektDataSet;
            // 
            // фамилия_заявителяTextBox
            // 
            this.фамилия_заявителяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вызов_на_пожарBindingSource, "Фамилия заявителя", true));
            this.фамилия_заявителяTextBox.Location = new System.Drawing.Point(193, 150);
            this.фамилия_заявителяTextBox.Name = "фамилия_заявителяTextBox";
            this.фамилия_заявителяTextBox.Size = new System.Drawing.Size(546, 20);
            this.фамилия_заявителяTextBox.TabIndex = 12;
            // 
            // имя_заявителяTextBox
            // 
            this.имя_заявителяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вызов_на_пожарBindingSource, "Имя заявителя", true));
            this.имя_заявителяTextBox.Location = new System.Drawing.Point(193, 176);
            this.имя_заявителяTextBox.Name = "имя_заявителяTextBox";
            this.имя_заявителяTextBox.Size = new System.Drawing.Size(546, 20);
            this.имя_заявителяTextBox.TabIndex = 14;
            // 
            // отчетство_заявителяTextBox
            // 
            this.отчетство_заявителяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вызов_на_пожарBindingSource, "Отчетство заявителя", true));
            this.отчетство_заявителяTextBox.Location = new System.Drawing.Point(193, 202);
            this.отчетство_заявителяTextBox.Name = "отчетство_заявителяTextBox";
            this.отчетство_заявителяTextBox.Size = new System.Drawing.Size(546, 20);
            this.отчетство_заявителяTextBox.TabIndex = 16;
            // 
            // номер_телефона_заявителяMaskedTextBox
            // 
            this.номер_телефона_заявителяMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вызов_на_пожарBindingSource, "Номер телефона заявителя", true));
            this.номер_телефона_заявителяMaskedTextBox.Location = new System.Drawing.Point(193, 228);
            this.номер_телефона_заявителяMaskedTextBox.Mask = "+7 (000) 000-00-00";
            this.номер_телефона_заявителяMaskedTextBox.Name = "номер_телефона_заявителяMaskedTextBox";
            this.номер_телефона_заявителяMaskedTextBox.Size = new System.Drawing.Size(546, 20);
            this.номер_телефона_заявителяMaskedTextBox.TabIndex = 18;
            // 
            // код_сменыTextBox
            // 
            this.код_сменыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вызов_на_пожарBindingSource, "Код смены", true));
            this.код_сменыTextBox.Location = new System.Drawing.Point(193, 254);
            this.код_сменыTextBox.Name = "код_сменыTextBox";
            this.код_сменыTextBox.Size = new System.Drawing.Size(546, 20);
            this.код_сменыTextBox.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 30);
            this.button1.TabIndex = 21;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(165, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 30);
            this.button2.TabIndex = 22;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // видобъектапожара1BindingSource1
            // 
            this.видобъектапожара1BindingSource1.DataMember = "Вид_объекта_пожара1";
            this.видобъектапожара1BindingSource1.DataSource = this.mchsProektDataSet;
            // 
            // FireCallEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(код_вызоваLabel);
            this.Controls.Add(this.код_вызоваTextBox);
            this.Controls.Add(адрес_пожараLabel);
            this.Controls.Add(this.адрес_пожараTextBox);
            this.Controls.Add(дата_обращения_заявителяLabel);
            this.Controls.Add(this.дата_обращения_заявителяMaskedTextBox);
            this.Controls.Add(время_обращения_заявителяLabel);
            this.Controls.Add(this.время_обращения_заявителяMaskedTextBox);
            this.Controls.Add(фамилия_заявителяLabel);
            this.Controls.Add(this.фамилия_заявителяTextBox);
            this.Controls.Add(имя_заявителяLabel);
            this.Controls.Add(this.имя_заявителяTextBox);
            this.Controls.Add(отчетство_заявителяLabel);
            this.Controls.Add(this.отчетство_заявителяTextBox);
            this.Controls.Add(номер_телефона_заявителяLabel);
            this.Controls.Add(this.номер_телефона_заявителяMaskedTextBox);
            this.Controls.Add(код_сменыLabel);
            this.Controls.Add(this.код_сменыTextBox);
            this.Name = "FireCallEditForm";
            this.Text = "FireCallEditForm";
            ((System.ComponentModel.ISupportInitialize)(this.mchsProektDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.вызов_на_пожарBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.видобъектапожара1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.видобъектапожара1BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MchsProektDataSet mchsProektDataSet;
        private System.Windows.Forms.BindingSource вызов_на_пожарBindingSource;
        private MchsProektDataSetTableAdapters.Вызов_на_пожарTableAdapter вызов_на_пожарTableAdapter;
        private MchsProektDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox код_вызоваTextBox;
        private System.Windows.Forms.TextBox адрес_пожараTextBox;
        private System.Windows.Forms.MaskedTextBox дата_обращения_заявителяMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox время_обращения_заявителяMaskedTextBox;
        private System.Windows.Forms.TextBox фамилия_заявителяTextBox;
        private System.Windows.Forms.TextBox имя_заявителяTextBox;
        private System.Windows.Forms.TextBox отчетство_заявителяTextBox;
        private System.Windows.Forms.MaskedTextBox номер_телефона_заявителяMaskedTextBox;
        private System.Windows.Forms.TextBox код_сменыTextBox;
        private MchsProektDataSetTableAdapters.Вид_объекта_пожара1TableAdapter вид_объекта_пожара1TableAdapter;
        private System.Windows.Forms.BindingSource видобъектапожара1BindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource видобъектапожара1BindingSource1;
    }
}