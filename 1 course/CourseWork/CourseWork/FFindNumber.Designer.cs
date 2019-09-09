namespace CourseWork
{
   partial class FFindNumber
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
         this.label1 = new System.Windows.Forms.Label();
         this.tbNumber = new System.Windows.Forms.TextBox();
         this.bFind = new System.Windows.Forms.Button();
         this.BoxOutput = new System.Windows.Forms.RichTextBox();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(12, 9);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(247, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "Введите порядковый номер вашего знакомого";
         // 
         // tbNumber
         // 
         this.tbNumber.Location = new System.Drawing.Point(329, 6);
         this.tbNumber.Name = "tbNumber";
         this.tbNumber.Size = new System.Drawing.Size(45, 20);
         this.tbNumber.TabIndex = 1;
         // 
         // bFind
         // 
         this.bFind.Location = new System.Drawing.Point(380, 4);
         this.bFind.Name = "bFind";
         this.bFind.Size = new System.Drawing.Size(75, 23);
         this.bFind.TabIndex = 2;
         this.bFind.Text = "Найти";
         this.bFind.UseVisualStyleBackColor = true;
         this.bFind.Click += new System.EventHandler(this.bFind_Click);
         // 
         // BoxOutput
         // 
         this.BoxOutput.Location = new System.Drawing.Point(8, 40);
         this.BoxOutput.Name = "BoxOutput";
         this.BoxOutput.Size = new System.Drawing.Size(309, 308);
         this.BoxOutput.TabIndex = 3;
         this.BoxOutput.Text = "";
         // 
         // FFindNumber
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(622, 360);
         this.Controls.Add(this.BoxOutput);
         this.Controls.Add(this.bFind);
         this.Controls.Add(this.tbNumber);
         this.Controls.Add(this.label1);
         this.Name = "FFindNumber";
         this.Text = "FFind2";
         this.Load += new System.EventHandler(this.FFindNumber_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox tbNumber;
      private System.Windows.Forms.Button bFind;
      private System.Windows.Forms.RichTextBox BoxOutput;
   }
}