namespace OOAP_Lab1.UserControls
{
    partial class UC_Create
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
            this.create_prod_but = new System.Windows.Forms.Button();
            this.product_panel = new System.Windows.Forms.Panel();
            this.textBox_cost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numTextBox_index = new System.Windows.Forms.NumericUpDown();
            this.labelDone = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTextBox_index)).BeginInit();
            this.SuspendLayout();
            // 
            // create_prod_but
            // 
            this.create_prod_but.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.create_prod_but.Location = new System.Drawing.Point(218, 342);
            this.create_prod_but.Name = "create_prod_but";
            this.create_prod_but.Size = new System.Drawing.Size(545, 42);
            this.create_prod_but.TabIndex = 15;
            this.create_prod_but.Text = "Создать";
            this.create_prod_but.UseVisualStyleBackColor = false;
            this.create_prod_but.Click += new System.EventHandler(this.createProduct);
            // 
            // product_panel
            // 
            this.product_panel.Location = new System.Drawing.Point(505, 41);
            this.product_panel.Name = "product_panel";
            this.product_panel.Size = new System.Drawing.Size(424, 265);
            this.product_panel.TabIndex = 14;
            // 
            // textBox_cost
            // 
            this.textBox_cost.Location = new System.Drawing.Point(250, 149);
            this.textBox_cost.Name = "textBox_cost";
            this.textBox_cost.Size = new System.Drawing.Size(116, 22);
            this.textBox_cost.TabIndex = 13;
            this.textBox_cost.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Стоимость";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(250, 105);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(116, 22);
            this.textBox_name.TabIndex = 11;
            this.textBox_name.Text = "default";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Наименование";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Номенклатурный номер";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numTextBox_index);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox_cost);
            this.panel1.Controls.Add(this.textBox_name);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(48, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 265);
            this.panel1.TabIndex = 15;
            // 
            // numTextBox_index
            // 
            this.numTextBox_index.Location = new System.Drawing.Point(250, 61);
            this.numTextBox_index.Name = "numTextBox_index";
            this.numTextBox_index.Size = new System.Drawing.Size(116, 22);
            this.numTextBox_index.TabIndex = 14;
            // 
            // labelDone
            // 
            this.labelDone.AutoSize = true;
            this.labelDone.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelDone.Location = new System.Drawing.Point(435, 401);
            this.labelDone.Name = "labelDone";
            this.labelDone.Size = new System.Drawing.Size(112, 16);
            this.labelDone.TabIndex = 16;
            this.labelDone.Text = "Запись создана";
            this.labelDone.Visible = false;
            // 
            // UC_Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelDone);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.create_prod_but);
            this.Controls.Add(this.product_panel);
            this.Name = "UC_Create";
            this.Size = new System.Drawing.Size(998, 504);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTextBox_index)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button create_prod_but;
        private System.Windows.Forms.Panel product_panel;
        private System.Windows.Forms.TextBox textBox_cost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numTextBox_index;
        private System.Windows.Forms.Label labelDone;
    }
}
