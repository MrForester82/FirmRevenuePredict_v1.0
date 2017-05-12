namespace Прогноз_результатов_деятельности_фирмы
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.датыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Filial1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firmDataSet = new Прогноз_результатов_деятельности_фирмы.FirmDataSet();
            this.Filial1TableAdapter = new Прогноз_результатов_деятельности_фирмы.FirmDataSetTableAdapters.филиал_1TableAdapter();
            this.btnCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Filial1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.датыDataGridViewTextBoxColumn,
            this.yDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.Filial1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(8, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(260, 246);
            this.dataGridView1.TabIndex = 0;
            // 
            // датыDataGridViewTextBoxColumn
            // 
            this.датыDataGridViewTextBoxColumn.DataPropertyName = "Даты";
            this.датыDataGridViewTextBoxColumn.HeaderText = "Даты";
            this.датыDataGridViewTextBoxColumn.Name = "датыDataGridViewTextBoxColumn";
            this.датыDataGridViewTextBoxColumn.Width = 125;
            // 
            // yDataGridViewTextBoxColumn
            // 
            this.yDataGridViewTextBoxColumn.DataPropertyName = "Y";
            this.yDataGridViewTextBoxColumn.HeaderText = "Прибыль";
            this.yDataGridViewTextBoxColumn.Name = "yDataGridViewTextBoxColumn";
            this.yDataGridViewTextBoxColumn.Width = 115;
            // 
            // Filial1BindingSource
            // 
            this.Filial1BindingSource.DataMember = "филиал_1";
            this.Filial1BindingSource.DataSource = this.firmDataSet;
            this.Filial1BindingSource.CurrentChanged += new System.EventHandler(this.филиал1BindingSource_CurrentChanged);
            // 
            // firmDataSet
            // 
            this.firmDataSet.DataSetName = "FirmDataSet";
            this.firmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Filial1TableAdapter
            // 
            this.Filial1TableAdapter.ClearBeforeFill = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(38, 273);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(202, 23);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Рассчитать прогнозные данные";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 308);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(292, 346);
            this.MinimumSize = new System.Drawing.Size(292, 346);
            this.Name = "Form1";
            this.Text = "Исходные данные";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Filial1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private FirmDataSet firmDataSet;
        private System.Windows.Forms.BindingSource Filial1BindingSource;
        private FirmDataSetTableAdapters.филиал_1TableAdapter Filial1TableAdapter;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.DataGridViewTextBoxColumn датыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yDataGridViewTextBoxColumn;
    }
}

