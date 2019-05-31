namespace CourseWork
{
   partial class FMain
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
         this.bAdd = new System.Windows.Forms.Button();
         this.BoxOutput = new System.Windows.Forms.RichTextBox();
         this.bFind = new System.Windows.Forms.Button();
         this.bDelete = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // bAdd
         // 
         this.bAdd.Location = new System.Drawing.Point(325, 83);
         this.bAdd.Name = "bAdd";
         this.bAdd.Size = new System.Drawing.Size(140, 46);
         this.bAdd.TabIndex = 0;
         this.bAdd.Text = "Добавить";
         this.bAdd.UseVisualStyleBackColor = true;
         this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
         // 
         // BoxOutput
         // 
         this.BoxOutput.Location = new System.Drawing.Point(12, 12);
         this.BoxOutput.Name = "BoxOutput";
         this.BoxOutput.Size = new System.Drawing.Size(307, 336);
         this.BoxOutput.TabIndex = 6;
         this.BoxOutput.Text = "";
         // 
         // bFind
         // 
         this.bFind.Location = new System.Drawing.Point(471, 83);
         this.bFind.Name = "bFind";
         this.bFind.Size = new System.Drawing.Size(140, 46);
         this.bFind.TabIndex = 1;
         this.bFind.Text = "Найти";
         this.bFind.UseVisualStyleBackColor = true;
         this.bFind.Click += new System.EventHandler(this.bFind_Click);
         // 
         // bDelete
         // 
         this.bDelete.Location = new System.Drawing.Point(399, 135);
         this.bDelete.Name = "bDelete";
         this.bDelete.Size = new System.Drawing.Size(140, 46);
         this.bDelete.TabIndex = 3;
         this.bDelete.Text = "Удалить";
         this.bDelete.UseVisualStyleBackColor = true;
         this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
         // 
         // FMain
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(622, 360);
         this.Controls.Add(this.bFind);
         this.Controls.Add(this.BoxOutput);
         this.Controls.Add(this.bDelete);
         this.Controls.Add(this.bAdd);
         this.Location = new System.Drawing.Point(1, 1);
         this.Name = "FMain";
         this.Text = "Мои знакомые";
         this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FMain_FormClosed);
         this.Load += new System.EventHandler(this.Fmain_Load);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button bAdd;
      private System.Windows.Forms.RichTextBox BoxOutput;
      private System.Windows.Forms.Button bFind;
      private System.Windows.Forms.Button bDelete;
   }
}

