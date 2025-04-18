namespace OOAP_Lab1.UserControls
{
    partial class UC_Show
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.labelShowPr = new System.Windows.Forms.Label();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamePr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.ProdType,
            this.NamePr,
            this.Cost});
            this.dataGridView.Location = new System.Drawing.Point(25, 34);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(605, 416);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // labelShowPr
            // 
            this.labelShowPr.AutoSize = true;
            this.labelShowPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelShowPr.Location = new System.Drawing.Point(668, 34);
            this.labelShowPr.Name = "labelShowPr";
            this.labelShowPr.Size = new System.Drawing.Size(0, 25);
            this.labelShowPr.TabIndex = 1;
            // 
            // Index
            // 
            this.Index.HeaderText = "Номер";
            this.Index.MinimumWidth = 6;
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            this.Index.Width = 70;
            // 
            // ProdType
            // 
            this.ProdType.HeaderText = "Вид товара";
            this.ProdType.MinimumWidth = 6;
            this.ProdType.Name = "ProdType";
            this.ProdType.ReadOnly = true;
            this.ProdType.Width = 125;
            // 
            // NamePr
            // 
            this.NamePr.HeaderText = "Имя";
            this.NamePr.MinimumWidth = 6;
            this.NamePr.Name = "NamePr";
            this.NamePr.ReadOnly = true;
            this.NamePr.Width = 125;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Цена";
            this.Cost.MinimumWidth = 6;
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            this.Cost.Width = 80;
            // 
            // UC_Show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelShowPr);
            this.Controls.Add(this.dataGridView);
            this.Name = "UC_Show";
            this.Size = new System.Drawing.Size(998, 504);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.Label labelShowPr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdType;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamePr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
    }
}
