namespace CourseWork
{
   partial class FAdd2
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
         this.bOK = new System.Windows.Forms.Button();
         this.textFio = new System.Windows.Forms.TextBox();
         this.textBirthday = new System.Windows.Forms.TextBox();
         this.textStreet = new System.Windows.Forms.TextBox();
         this.textHouse = new System.Windows.Forms.TextBox();
         this.textTelephone = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // bOK
         // 
         this.bOK.Location = new System.Drawing.Point(244, 83);
         this.bOK.Name = "bOK";
         this.bOK.Size = new System.Drawing.Size(140, 46);
         this.bOK.TabIndex = 5;
         this.bOK.Text = "Принять";
         this.bOK.UseVisualStyleBackColor = true;
         this.bOK.Click += new System.EventHandler(this.bOK_Click);
         // 
         // textFio
         // 
         this.textFio.Location = new System.Drawing.Point(110, 37);
         this.textFio.Name = "textFio";
         this.textFio.Size = new System.Drawing.Size(100, 20);
         this.textFio.TabIndex = 0;
         // 
         // textBirthday
         // 
         this.textBirthday.Location = new System.Drawing.Point(110, 67);
         this.textBirthday.Name = "textBirthday";
         this.textBirthday.Size = new System.Drawing.Size(100, 20);
         this.textBirthday.TabIndex = 1;
         // 
         // textStreet
         // 
         this.textStreet.Location = new System.Drawing.Point(110, 97);
         this.textStreet.Name = "textStreet";
         this.textStreet.Size = new System.Drawing.Size(100, 20);
         this.textStreet.TabIndex = 2;
         // 
         // textHouse
         // 
         this.textHouse.Location = new System.Drawing.Point(110, 127);
         this.textHouse.Name = "textHouse";
         this.textHouse.Size = new System.Drawing.Size(100, 20);
         this.textHouse.TabIndex = 3;
         // 
         // textTelephone
         // 
         this.textTelephone.Location = new System.Drawing.Point(110, 157);
         this.textTelephone.Name = "textTelephone";
         this.textTelephone.Size = new System.Drawing.Size(100, 20);
         this.textTelephone.TabIndex = 4;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(12, 40);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(37, 13);
         this.label1.TabIndex = 6;
         this.label1.Text = "ФИО:";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(12, 70);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(89, 13);
         this.label2.TabIndex = 7;
         this.label2.Text = "Дата рождения:";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(12, 100);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(42, 13);
         this.label3.TabIndex = 8;
         this.label3.Text = "Улица:";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(12, 130);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(33, 13);
         this.label4.TabIndex = 9;
         this.label4.Text = "Дом:";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(12, 160);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(96, 13);
         this.label5.TabIndex = 10;
         this.label5.Text = "Номер телефона:";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(65, 9);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(74, 13);
         this.label6.TabIndex = 11;
         this.label6.Text = "Знакомый №";
         // 
         // FAdd2
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(416, 204);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.textTelephone);
         this.Controls.Add(this.textHouse);
         this.Controls.Add(this.textStreet);
         this.Controls.Add(this.textBirthday);
         this.Controls.Add(this.textFio);
         this.Controls.Add(this.bOK);
         this.Location = new System.Drawing.Point(1, 1);
         this.Name = "FAdd2";
         this.Text = "Добавить знакомого";
         this.Load += new System.EventHandler(this.FAdd2_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button bOK;
      private System.Windows.Forms.TextBox textFio;
      private System.Windows.Forms.TextBox textBirthday;
      private System.Windows.Forms.TextBox textStreet;
      private System.Windows.Forms.TextBox textHouse;
      private System.Windows.Forms.TextBox textTelephone;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label6;
   }
}