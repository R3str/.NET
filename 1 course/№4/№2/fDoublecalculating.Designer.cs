namespace _2
{
    partial class fDoublecalculating
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
         this.quadro = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.trapezium = new System.Windows.Forms.TextBox();
         this.button1 = new System.Windows.Forms.Button();
         this.label3 = new System.Windows.Forms.Label();
         this.richTextBox1 = new System.Windows.Forms.RichTextBox();
         this.label4 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.areaQ = new System.Windows.Forms.TextBox();
         this.areaT = new System.Windows.Forms.TextBox();
         this.button2 = new System.Windows.Forms.Button();
         this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
         this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
         this.button3 = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // quadro
         // 
         this.quadro.Location = new System.Drawing.Point(140, 6);
         this.quadro.Name = "quadro";
         this.quadro.Size = new System.Drawing.Size(50, 20);
         this.quadro.TabIndex = 0;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(12, 9);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(128, 13);
         this.label1.TabIndex = 11;
         this.label1.Text = "Имя четырехугольника:";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(266, 9);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(82, 13);
         this.label2.TabIndex = 10;
         this.label2.Text = "Имя трапеции:";
         // 
         // trapezium
         // 
         this.trapezium.Location = new System.Drawing.Point(348, 6);
         this.trapezium.Name = "trapezium";
         this.trapezium.Size = new System.Drawing.Size(50, 20);
         this.trapezium.TabIndex = 2;
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(168, 39);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(75, 23);
         this.button1.TabIndex = 4;
         this.button1.Text = "Добавить";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(2, 90);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(43, 13);
         this.label3.TabIndex = 12;
         this.label3.Text = "Вывод:";
         // 
         // richTextBox1
         // 
         this.richTextBox1.Location = new System.Drawing.Point(5, 106);
         this.richTextBox1.Name = "richTextBox1";
         this.richTextBox1.Size = new System.Drawing.Size(422, 215);
         this.richTextBox1.TabIndex = 6;
         this.richTextBox1.Text = "";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(12, 39);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(57, 13);
         this.label4.TabIndex = 7;
         this.label4.Text = "Площадь:";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(266, 39);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(57, 13);
         this.label5.TabIndex = 8;
         this.label5.Text = "Площадь:";
         // 
         // areaQ
         // 
         this.areaQ.Location = new System.Drawing.Point(69, 36);
         this.areaQ.Name = "areaQ";
         this.areaQ.Size = new System.Drawing.Size(30, 20);
         this.areaQ.TabIndex = 1;
         // 
         // areaT
         // 
         this.areaT.Location = new System.Drawing.Point(323, 36);
         this.areaT.Name = "areaT";
         this.areaT.Size = new System.Drawing.Size(30, 20);
         this.areaT.TabIndex = 3;
         // 
         // button2
         // 
         this.button2.Location = new System.Drawing.Point(168, 68);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(75, 23);
         this.button2.TabIndex = 5;
         this.button2.Text = "Расчитать";
         this.button2.UseVisualStyleBackColor = true;
         this.button2.Click += new System.EventHandler(this.button2_Click);
         // 
         // openFileDialog1
         // 
         this.openFileDialog1.FileName = "openFileDialog1";
         // 
         // button3
         // 
         this.button3.Location = new System.Drawing.Point(348, 77);
         this.button3.Name = "button3";
         this.button3.Size = new System.Drawing.Size(72, 23);
         this.button3.TabIndex = 13;
         this.button3.Text = "Сохранить";
         this.button3.UseVisualStyleBackColor = true;
         this.button3.Click += new System.EventHandler(this.button3_Click);
         // 
         // fDoublecalculating
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(432, 333);
         this.Controls.Add(this.button3);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.areaT);
         this.Controls.Add(this.areaQ);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.richTextBox1);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.trapezium);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.quadro);
         this.Name = "fDoublecalculating";
         this.Text = "Общие расчеты";
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox quadro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox trapezium;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox areaQ;
        private System.Windows.Forms.TextBox areaT;
        private System.Windows.Forms.Button button2;
      private System.Windows.Forms.OpenFileDialog openFileDialog1;
      private System.Windows.Forms.SaveFileDialog saveFileDialog1;
      private System.Windows.Forms.Button button3;
   }
}