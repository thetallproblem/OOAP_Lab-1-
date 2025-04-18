namespace OOAP_Lab1
{
    partial class ProdSystemForm
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
            this.buttonCreate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel_Button = new System.Windows.Forms.Panel();
            this.HardDrive_Cr = new System.Windows.Forms.Button();
            this.Processor_Cr = new System.Windows.Forms.Button();
            this.Motherboard_Cr = new System.Windows.Forms.Button();
            this.buttonShow = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel_Button.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCreate
            // 
            this.buttonCreate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCreate.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreate.Location = new System.Drawing.Point(0, 0);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(500, 51);
            this.buttonCreate.TabIndex = 3;
            this.buttonCreate.Text = "Создать товар";
            this.buttonCreate.UseVisualStyleBackColor = false;
            this.buttonCreate.Click += new System.EventHandler(this.CreateProdClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 74);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Platform LC Web Regular", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(185, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(625, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "База компьютерного интернет-магазина";
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(0, 119);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(998, 498);
            this.panelContainer.TabIndex = 7;
            // 
            // panel_Button
            // 
            this.panel_Button.Controls.Add(this.HardDrive_Cr);
            this.panel_Button.Controls.Add(this.Processor_Cr);
            this.panel_Button.Controls.Add(this.Motherboard_Cr);
            this.panel_Button.Controls.Add(this.buttonCreate);
            this.panel_Button.Location = new System.Drawing.Point(0, 71);
            this.panel_Button.Name = "panel_Button";
            this.panel_Button.Size = new System.Drawing.Size(499, 51);
            this.panel_Button.TabIndex = 6;
            // 
            // HardDrive_Cr
            // 
            this.HardDrive_Cr.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HardDrive_Cr.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HardDrive_Cr.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.HardDrive_Cr.FlatAppearance.BorderSize = 0;
            this.HardDrive_Cr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HardDrive_Cr.Location = new System.Drawing.Point(0, 140);
            this.HardDrive_Cr.Name = "HardDrive_Cr";
            this.HardDrive_Cr.Size = new System.Drawing.Size(500, 51);
            this.HardDrive_Cr.TabIndex = 6;
            this.HardDrive_Cr.Text = "Жесткий диск";
            this.HardDrive_Cr.UseVisualStyleBackColor = false;
            this.HardDrive_Cr.Click += new System.EventHandler(this.createHardDrive);
            // 
            // Processor_Cr
            // 
            this.Processor_Cr.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Processor_Cr.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Processor_Cr.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Processor_Cr.FlatAppearance.BorderSize = 0;
            this.Processor_Cr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Processor_Cr.Location = new System.Drawing.Point(0, 95);
            this.Processor_Cr.Name = "Processor_Cr";
            this.Processor_Cr.Size = new System.Drawing.Size(500, 51);
            this.Processor_Cr.TabIndex = 5;
            this.Processor_Cr.Text = "Процессор";
            this.Processor_Cr.UseVisualStyleBackColor = false;
            this.Processor_Cr.Click += new System.EventHandler(this.createProcessor);
            // 
            // Motherboard_Cr
            // 
            this.Motherboard_Cr.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Motherboard_Cr.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Motherboard_Cr.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Motherboard_Cr.FlatAppearance.BorderSize = 0;
            this.Motherboard_Cr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Motherboard_Cr.Location = new System.Drawing.Point(0, 48);
            this.Motherboard_Cr.Name = "Motherboard_Cr";
            this.Motherboard_Cr.Size = new System.Drawing.Size(500, 51);
            this.Motherboard_Cr.TabIndex = 4;
            this.Motherboard_Cr.Text = "Материнская плата";
            this.Motherboard_Cr.UseVisualStyleBackColor = false;
            this.Motherboard_Cr.Click += new System.EventHandler(this.createMotherboard);
            // 
            // buttonShow
            // 
            this.buttonShow.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShow.Location = new System.Drawing.Point(498, 71);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(500, 51);
            this.buttonShow.TabIndex = 4;
            this.buttonShow.Text = "Показать список всех товаров";
            this.buttonShow.UseVisualStyleBackColor = false;
            this.buttonShow.Click += new System.EventHandler(this.ShowProdClick);
            // 
            // ProdSystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 617);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel_Button);
            this.Controls.Add(this.panel1);
            this.Name = "ProdSystemForm";
            this.Text = "Product System";
            this.Load += new System.EventHandler(this.ProdSystemForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_Button.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panel_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button HardDrive_Cr;
        private System.Windows.Forms.Button Processor_Cr;
        private System.Windows.Forms.Button Motherboard_Cr;
        private System.Windows.Forms.Button buttonShow;
    }
}

