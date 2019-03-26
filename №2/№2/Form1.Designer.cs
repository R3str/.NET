namespace _2
{
    partial class fMain
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
            this.bQuadro = new System.Windows.Forms.Button();
            this.bTrapezium = new System.Windows.Forms.Button();
            this.bCommon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bQuadro
            // 
            this.bQuadro.Location = new System.Drawing.Point(40, 71);
            this.bQuadro.Name = "bQuadro";
            this.bQuadro.Size = new System.Drawing.Size(155, 49);
            this.bQuadro.TabIndex = 0;
            this.bQuadro.Text = "Четырехугольник";
            this.bQuadro.UseVisualStyleBackColor = true;
            this.bQuadro.Click += new System.EventHandler(this.bQuadro_Click);
            // 
            // bTrapezium
            // 
            this.bTrapezium.Location = new System.Drawing.Point(40, 126);
            this.bTrapezium.Name = "bTrapezium";
            this.bTrapezium.Size = new System.Drawing.Size(155, 49);
            this.bTrapezium.TabIndex = 1;
            this.bTrapezium.Text = "Равнобочная трапеция";
            this.bTrapezium.UseVisualStyleBackColor = true;
            this.bTrapezium.Click += new System.EventHandler(this.bTrapezium_Click);
            // 
            // bCommon
            // 
            this.bCommon.Location = new System.Drawing.Point(40, 181);
            this.bCommon.Name = "bCommon";
            this.bCommon.Size = new System.Drawing.Size(155, 49);
            this.bCommon.TabIndex = 2;
            this.bCommon.Text = "Общий расчет";
            this.bCommon.UseVisualStyleBackColor = true;
            this.bCommon.Click += new System.EventHandler(this.bCommon_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 298);
            this.Controls.Add(this.bCommon);
            this.Controls.Add(this.bTrapezium);
            this.Controls.Add(this.bQuadro);
            this.Name = "fMain";
            this.Text = "Расчитайка";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bQuadro;
        private System.Windows.Forms.Button bTrapezium;
        private System.Windows.Forms.Button bCommon;
    }
}

