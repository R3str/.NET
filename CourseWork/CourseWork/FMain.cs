using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
   public partial class FMain : Form
   {
      static public int amount = 20;
      public struct MyFriends
      {
         public string Fio;
         public DateTime Bithday;
         public string Street;
         public string House;
         public string Telephone;

         public MyFriends(string fio, string birthday, string street, string house, string telephone)
         {
            this.Fio = fio;
            this.Bithday = Convert.ToDateTime(birthday);
            this.Street = street;
            this.House = house;
            this.Telephone = telephone;
         }
      }

      public static void Resize(MyFriends[] userAdd, int amount, int amountFinish)
      {
         for (int i = 0; i < amount; i++)
         {
            userAdd[i].Fio = FMain.user[i].Fio;
            userAdd[i].Bithday = FMain.user[i].Bithday;
            userAdd[i].Street = FMain.user[i].Street;
            userAdd[i].House = FMain.user[i].House;
            userAdd[i].Telephone = FMain.user[i].Telephone;
         }

         FMain.user = new MyFriends[amountFinish];

         for (int i = 0; i < amountFinish; i++)
         {
            FMain.user[i].Fio = userAdd[i].Fio;
            FMain.user[i].Bithday = userAdd[i].Bithday;
            FMain.user[i].Street = userAdd[i].Street;
            FMain.user[i].House = userAdd[i].House;
            FMain.user[i].Telephone = userAdd[i].Telephone;
         }
      }

      public static bool Change(int position, TextBox fio, TextBox birthday, TextBox street, TextBox house, TextBox telephone)
      {
         string Check(string mode)
         {
            int trueF = 1;
            string s = "1";
            switch (mode)
            {
               case "Fio":
                  {
                     s = Convert.ToString(fio.Text);
                     int numberOfSymbols = s.Length;

                     if (int.TryParse(s, out trueF) || s == "")
                     {
                        s = "NaN";
                        break;
                     }

                     char[] schar = new char[s.Length];
                     //Смена символов маленького регистра на большой в начале слова 
                     // (поддержка английского и русского языка)
                     for (int j = 0; j < s.Length; j++)
                     {
                        schar[j] = Convert.ToChar(s[j]);
                        if (j != 0)
                           if (schar[j - 1] == ' ')
                              if(schar[j] > 96 && schar[j] < 123 || schar[0] > 1071 && schar[0] < 1104)
                                 schar[j] -= Convert.ToChar(32);
                     }

                     if (schar[0] > 96 && schar[0] < 123 || schar[0] > 1071 && schar[0] < 1104)
                        schar[0] -= Convert.ToChar(32);
                     //Удаление старой строки и запись новой
                     s = "";
                     
                     for (int j = 0; j < numberOfSymbols; j++)
                        s += Convert.ToString(schar[j]);

                     break;
                  }

               case "Birthday":
                  {
                     s = Convert.ToString(birthday.Text);

                     if (!int.TryParse(s, out trueF))
                        if (!s.Contains('.'))
                        {
                           s = "1111.1.1";
                           break;
                        }

                     if (s.Contains("."))
                     {
                        int numberOfWord = 0;
                        string check = null;

                        for (int j = 0; j < s.Length; j++)
                        {
                           if (!int.TryParse(Convert.ToString(s[j]), out trueF))
                           {
                              if (s[j] != '.' && s[j] != '/')
                              {
                                 s = "1111.1.1";
                                 break;
                              }
                              //Проверка на корректность числа
                                 numberOfWord++;
                                 switch (numberOfWord)
                                 {
                                    case 1:
                                       {
                                          if (Convert.ToInt32(check) > Convert.ToInt32(DateTime.Now.Year))
                                             s = "1111.1.1";
                                          check = null;
                                       goto noWriteDot;
                                       }

                                    case 2:
                                       {
                                          if (Convert.ToInt32(check) > 12)
                                             s = "1111.1.1";
                                          check = null;
                                       goto noWriteDot;
                                       }
                                 }
                           }
                           check += s[j];
                        noWriteDot:

                           //Проверка последнего числа
                           if(j == (s.Length - 1))
                              if (Convert.ToInt32(check) > 31)
                                 s = "1111.1.1";
                        }
                     }
                     break;
                  }

               case "Street":
                  {
                     s = Convert.ToString(street.Text);
                     int numberOfWords = s.Length;
                     char[] schar = new char[s.Length];

                     if (int.TryParse(s, out trueF) || s == "")
                     {
                        s = "NaN";
                        break;
                     }
                     for (int j = 0; j < s.Length; j++)
                        schar[j] = Convert.ToChar(s[j]);

                     if(schar[0] > 96 && schar[0] < 123 || schar[0] > 1071 && schar[0] < 1104)
                        schar[0] -= Convert.ToChar(32);

                     s = "";
                     for (int j = 0; j < numberOfWords; j++)
                        s += schar[j];

                     break;
                  }

               case "House":
                  {
                     s = Convert.ToString(house.Text);
                     if (!int.TryParse(s, out trueF) || Convert.ToInt32(s) <= 0)
                        s = "NaN";
                     break;
                  }

               case "Telephone":
                  {
                     s = Convert.ToString(telephone.Text);

                     for (int j = 0; j < s.Length; j++)
                     {
                        if (!int.TryParse(Convert.ToString(s[j]), out trueF))
                           if (s[j] != '+' && s[j] != '-' && s[j] != ' ')
                           {
                              s = "NaN";
                              break;
                           }
                     }
                     break;
                  }
            }
            return s;
         
         }
         bool checkBool = true;

         FMain.user[position].Fio = Check("Fio");

         FMain.user[position].Bithday = Convert.ToDateTime(Check("Birthday"));

         FMain.user[position].Street = Check("Street");

         FMain.user[position].House = Check("House");

         FMain.user[position].Telephone = Check("Telephone");

         for (int i = 0; i < position; i++)
            if (FMain.user[position].Fio == FMain.user[i].Fio)
            {
               checkBool = false;
               FAdd2.reapetPosition = position;
               goto link;
            }
         fio.Clear();
         birthday.Clear();
         street.Clear();
         house.Clear();
         telephone.Clear();
         link:
         return checkBool;
      }

      public static void Output(RichTextBox BoxOutput, MyFriends[] user, int amount, string mode, string findCharacter)
      {
         switch (mode)
         {
            case "Many":
               {
                  BoxOutput.Clear();
                  for (int i = 0; i < amount; i++)
                  {
                     BoxOutput.Text +=
                        "\t№ " + (i + 1) +
                        "\nФИО: " + user[i].Fio +
                        "\nДата рождения: " + user[i].Bithday.Year + '.' + user[i].Bithday.Month + '.' + user[i].Bithday.Day +
                        "\nДомашний адрес: " + user[i].Street + ' ' + user[i].House +
                        "\nНомер телефона: " + user[i].Telephone + "\n\n";
                  }
                  break;
               }

            case "One":
               {
                  amount--;
                  BoxOutput.Text =
                     "\t№ " + (amount + 1) +
                     "\nФИО: " + user[amount].Fio +
                     "\nДата рождения: " + user[amount].Bithday.Year + '.' + user[amount].Bithday.Month + '.' + user[amount].Bithday.Day +
                     "\nДомашний адрес: " + user[amount].Street + ' ' + user[amount].House +
                     "\nНомер телефона: " + user[amount].Telephone + "\n\n";
                  break;
               }

            case "Fio":
               {
                  int arrAmountPosition = 0;
                  int trueF = 1;
                  int numberOfSymbols = findCharacter.Length;

                  if (int.TryParse(findCharacter, out trueF) || findCharacter == "")
                  {
                     findCharacter = "NaN";
                     break;
                  }

                  char[] schar = new char[findCharacter.Length];
                  //Смена символов маленького регистра на большой в начале слова 
                  // (поддержка английского и русского языка)
                  for (int j = 0; j < findCharacter.Length; j++)
                  {
                     schar[j] = Convert.ToChar(findCharacter[j]);
                     if (j != 0)
                        if (schar[j - 1] == ' ')
                           if (schar[j] > 96 && schar[j] < 123 || schar[0] > 1071 && schar[0] < 1104)
                              schar[j] -= Convert.ToChar(32);
                  }

                  if (schar[0] > 96 && schar[0] < 123 || schar[0] > 1071 && schar[0] < 1104)
                     schar[0] -= Convert.ToChar(32);
                  //Удаление старой строки и запись новой
                  findCharacter = "";

                  for (int j = 0; j < numberOfSymbols; j++)
                     findCharacter += Convert.ToString(schar[j]);
                  //////////////////////////////////////////////////////////

                  for (int j = 0; j < FMain.amount; j++)
                  {
                     if (FMain.user[j].Fio.Contains(findCharacter))
                     {
                        FFindFio.arrAmount[arrAmountPosition++] = j;
                        BoxOutput.Text +=
                           "\t№ " + (j + 1) +
                           "\nФИО: " + user[j].Fio +
                           "\nДата рождения: " + user[j].Bithday.Year + '.' + user[j].Bithday.Month + '.' + user[j].Bithday.Day +
                           "\nДомашний адрес: " + user[j].Street + ' ' + user[j].House +
                           "\nНомер телефона: " + user[j].Telephone + "\n\n";
                     }
                  }

                  break;
               }

            case "Birthday":
               {
                  int arrAmountPosition = 0;
                  string check = null;

                  for (int j = 0; j < FMain.amount; j++)
                  {
                     if(findCharacter.Length == 7)
                     check = FMain.user[j].Bithday.ToString("yyyy.MM.dd");

                     if(findCharacter.Length == 6)
                        check = FMain.user[j].Bithday.ToString("yyyy.M.dd");

                     else
                        check = FMain.user[j].Bithday.ToString("yyyy.MM.dd");
                     if (check.Contains(findCharacter))
                     {
                        FFindBirthday.arrAmount[arrAmountPosition++] = j;
                        BoxOutput.Text +=
                           "\t№ " + (j + 1) +
                           "\nФИО: " + user[j].Fio +
                           "\nДата рождения: " + user[j].Bithday.Year + '.' + user[j].Bithday.Month + '.' + user[j].Bithday.Day +
                           "\nДомашний адрес: " + user[j].Street + ' ' + user[j].House +
                           "\nНомер телефона: " + user[j].Telephone + "\n\n";
                     }
                  }
                  break;
               }

            case "Address":
               {
                  int arrAmountPosition = 0;

                  int trueF = 0;
                  int numberOfWords = findCharacter.Length;
                  char[] schar = new char[findCharacter.Length];

                  if (int.TryParse(findCharacter, out trueF))
                  {
                     findCharacter = "NaN";
                     break;
                  }
                  for (int j = 0; j < findCharacter.Length; j++)
                     schar[j] = Convert.ToChar(findCharacter[j]);

                  if (schar[0] > 96 && schar[0] < 123 || schar[0] > 1071 && schar[0] < 1104)
                     schar[0] -= Convert.ToChar(32);

                  findCharacter = "";
                  for (int j = 0; j < numberOfWords; j++)
                     findCharacter += schar[j];

                  string check = null;

                  for (int j = 0; j < FMain.amount; j++)
                  {
                     check = FMain.user[j].Street + " " + FMain.user[j].House;

                     if (check.Contains(findCharacter))
                     {
                        FFindAddress.arrAmount[arrAmountPosition++] = j;
                        BoxOutput.Text +=
                           "\t№ " + (j + 1) +
                           "\nФИО: " + user[j].Fio +
                           "\nДата рождения: " + user[j].Bithday.Year + '.' + user[j].Bithday.Month + '.' + user[j].Bithday.Day +
                           "\nДомашний адрес: " + user[j].Street + ' ' + user[j].House +
                           "\nНомер телефона: " + user[j].Telephone + "\n\n";
                     }
                  }
                  break;
               }

            case "Telephone":
               {
                  int trueF = 0;
                  int CharSpace = 0;
                  int arrAmountPosition = 0;
                  char[] findChar = new char[findCharacter.Length];
                  string findString = null;

                  if (findCharacter == "")
                  {
                     findCharacter = "NaN";
                     break;
                  }
                  // Игнорирование всех символов, кроме цифр
                  for (int j = 0; j < findCharacter.Length; j++)
                  {
                     if (!int.TryParse(Convert.ToString(findCharacter[j]), out trueF))
                     {
                        if (findCharacter[j] != '+' && findCharacter[j] != '-' && findCharacter[j] != ' ')
                        {
                           findCharacter = "NaN";
                           break;
                        }

                        else
                        {
                           CharSpace++;
                           continue;
                        }
                     }
                     findChar[j - CharSpace] = findCharacter[j];
                  }

                  for (int j = 0; j < findChar.Length; j++)
                     if(findChar[j] != '\0')
                        findString += findChar[j];

                  for (int j = 0; j < FMain.amount; j++)
                  {
                     if (FMain.user[j].Telephone.Contains(findString))
                     {
                        FFindTelephone.arrAmount[arrAmountPosition++] = j;
                        BoxOutput.Text +=
                           "\t№ " + (j + 1) +
                           "\nФИО: " + user[j].Fio +
                           "\nДата рождения: " + user[j].Bithday.Year + '.' + user[j].Bithday.Month + '.' + user[j].Bithday.Day +
                           "\nДомашний адрес: " + user[j].Street + ' ' + user[j].House +
                           "\nНомер телефона: " + user[j].Telephone + "\n\n";
                     }
                  }
                  break;
               }
         }
      }

      public static MyFriends[] user = new MyFriends[amount];

      public FMain()
      {
         InitializeComponent();
         user[0] = new MyFriends("Андрей Коваленков", "1990.02.12", "Черкышова", "12", "0965412085");
         user[1] = new MyFriends("Евгений Арустамян", "2001.03.10", "Абрикосовая", "36", "0963809044");
         user[2] = new MyFriends("Юрий Чербышев", "2000.11.05", "Дача Ковалевского", "12", "0939302821");
         user[3] = new MyFriends("Максим Юсупов", "2000.08.24", "Хрустальная", "27", "0667909300");
         user[4] = new MyFriends("Александр Дронов", "1999.05.12", "Успенская", "67", "0996711643");
         user[5] = new MyFriends("Иван Сусаренко", "1998.12.12", "Магистральная", "39", "0763284869");
         user[6] = new MyFriends("Сергей Пархоменко", "2000.01.07", "Февральская", "48", "0508726554");
         user[7] = new MyFriends("Антон Лукашенко", "2001.04.30", "Лавочная", "56", "0914847463");
         user[8] = new MyFriends("Андрей Пирин", "2001.05.27", "Чапаева", "09", "0999933119");
         user[9] = new MyFriends("Антон Кравченко", "1999.11.15", "Базарная", "39", "0398785466");
         user[10] = new MyFriends("Максим Шевченко", "2000.03.09", "Байкальский переулок", "04", "0969695070");
         user[11] = new MyFriends("Святослав Коваль", "2000.08.14", "Обильная", "41", "0925743176");
         user[12] = new MyFriends("Максим Грамарчук", "2000.10.20", "Еврейская", "99", "0501382446");
         user[13] = new MyFriends("Александр Литвин", "1998.01.17", "Улитина", "101", "0966694126");
         user[14] = new MyFriends("Ирина Кравченко", "1999.05.02", "Казанская", "76", "0632174015");
         user[15] = new MyFriends("Юлия Чикунда", "1999.05.29", "Тенистая", "111", "0392594366");
         user[16] = new MyFriends("Анастасия Руссо", "2000.07.01", "Жаботинского", "66", "0941730204");
         user[17] = new MyFriends("Юлия Тимошенко", "1998.02.23", "Зайцева", "34", "0508329990");
         user[18] = new MyFriends("Маша Лютченко", "2000.05.30", "Хрустальная", "64", "0918498706");
         user[19] = new MyFriends("Ирина Спиридонова", "2001.12.16", "Черкасская", "15", "0941016358");
      }

      public void Fmain_Load(object sender, EventArgs e)
      {
         /*FileStream fstream = File.OpenRead(@"E:\note.dat");
         StreamReader reader = new StreamReader(fstream);
         string steam;
         int count, i, z;
         count = 0;
         i = 0;
         z = 0;
         while ((steam = reader.ReadLine()) != null)
         {
            string words = null;
            string s = steam;

            for (int j = z; j < s.Length; j++)
            {
               if (s[j] == '|')
               {
                  z = j + 1;

                  if (count == 0)
                  {
                     user[i].Fio = words;
                  }

                  if (count == 1)
                  {
                     user[i].Bithday = Convert.ToDateTime(words);
                  }

                  if (count == 2)
                  {
                     user[i].Street = words;
                  }

                  if (count == 3)
                  {
                     user[i].House = words;
                  }

                  if (count == 4)
                  {
                     user[i].Telephone = words;
                     count = 0;
                     i++;
                     z = 0;
                  }
                  else
                  {
                     count++;
                  }
                  words = null;
               }
               if (s[j] != '|')
               {
                  words += s[j];
               }
            }
         }
         reader.Close();
         fstream.Close();*/
         
      Output(BoxOutput, user, amount, "Many", "0");
      }

      private void bAdd_Click(object sender, EventArgs e)
      {
         FAdd add = new FAdd(amount);


         add.ShowDialog();
         Output(BoxOutput, user, FAdd2.amountFinish, "Many", "0");
         
      }

      private void bFind_Click(object sender, EventArgs e)
      {
         FFind find = new FFind("find");

         FPassword password = new FPassword();
         password.ShowDialog();
         if (FPassword.count == -1)
            Close();
         else
         {
            find.ShowDialog();
            Output(BoxOutput, user, amount, "Many", "0");
         }
      }

      private void bDelete_Click(object sender, EventArgs e)
      {
         FFind find = new FFind("delete");

         FPassword password = new FPassword();
         password.ShowDialog();
         if (FPassword.count < 0)
            Close();
         else
         {
            find.ShowDialog();
            Output(BoxOutput, user, amount, "Many", "0");
         }
      }

      private void FMain_FormClosed(object sender, FormClosedEventArgs e)
      {
         FileStream fstream = new FileStream(@"E:\note.dat", FileMode.Create);
            StreamWriter writer = new StreamWriter(fstream);

            for (int i = 0; i < amount; i++)
               writer.Write("{0}|{1}|{2}|{3}|{4}|\n", user[i].Fio, user[i].Bithday, user[i].Street, user[i].House, user[i].Telephone);
            writer.Close();
      }
   }
}
