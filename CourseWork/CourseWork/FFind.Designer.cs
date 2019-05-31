namespace CourseWork
{
   partial class FFind
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
         this.bNumber = new System.Windows.Forms.Button();
         this.bFio = new System.Windows.Forms.Button();
         this.bBirthday = new System.Windows.Forms.Button();
         this.bStreet = new System.Windows.Forms.Button();
         this.bTelephone = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(12, 9);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(277, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "По какому параметру вы желаете найти знакомого?";
         // 
         // bNumber
         // 
         this.bNumber.Location = new System.Drawing.Point(78, 61);
         this.bNumber.Name = "bNumber";
         this.bNumber.Size = new System.Drawing.Size(140, 46);
         this.bNumber.TabIndex = 1;
         this.bNumber.Text = "Порядковый номер";
         this.bNumber.UseVisualStyleBackColor = true;
         this.bNumber.Click += new System.EventHandler(this.bNumber_Click);
         // 
         // bFio
         // 
         this.bFio.Location = new System.Drawing.Point(78, 113);
         this.bFio.Name = "bFio";
         this.bFio.Size = new System.Drawing.Size(140, 46);
         this.bFio.TabIndex = 2;
         this.bFio.Text = "ФИО";
         this.bFio.UseVisualStyleBackColor = true;
         this.bFio.Click += new System.EventHandler(this.bFio_Click);
         // 
         // bBirthday
         // 
         this.bBirthday.Location = new System.Drawing.Point(78, 165);
         this.bBirthday.Name = "bBirthday";
         this.bBirthday.Size = new System.Drawing.Size(140, 46);
         this.bBirthday.TabIndex = 3;
         this.bBirthday.Text = "Дата рождения";
         this.bBirthday.UseVisualStyleBackColor = true;
         this.bBirthday.Click += new System.EventHandler(this.bBirthday_Click);
         // 
         // bStreet
         // 
         this.bStreet.Location = new System.Drawing.Point(78, 217);
         this.bStreet.Name = "bStreet";
         this.bStreet.Size = new System.Drawing.Size(140, 46);
         this.bStreet.TabIndex = 4;
         this.bStreet.Text = "Домашний адрес";
         this.bStreet.UseVisualStyleBackColor = true;
         this.bStreet.Click += new System.EventHandler(this.bStreet_Click);
         // 
         // bTelephone
         // 
         this.bTelephone.Location = new System.Drawing.Point(78, 269);
         this.bTelephone.Name = "bTelephone";
         this.bTelephone.Size = new System.Drawing.Size(140, 46);
         this.bTelephone.TabIndex = 5;
         this.bTelephone.Text = "Номер телефона";
         this.bTelephone.UseVisualStyleBackColor = true;
         this.bTelephone.Click += new System.EventHandler(this.bTelephone_Click);
         // 
         // FFind
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(298, 360);
         this.Controls.Add(this.bTelephone);
         this.Controls.Add(this.bStreet);
         this.Controls.Add(this.bBirthday);
         this.Controls.Add(this.bFio);
         this.Controls.Add(this.bNumber);
         this.Controls.Add(this.label1);
         this.Name = "FFind";
         this.Text = "FFind";
         this.Load += new System.EventHandler(this.FFind_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button bNumber;
      private System.Windows.Forms.Button bFio;
      private System.Windows.Forms.Button bBirthday;
      private System.Windows.Forms.Button bStreet;
      private System.Windows.Forms.Button bTelephone;
   }
}