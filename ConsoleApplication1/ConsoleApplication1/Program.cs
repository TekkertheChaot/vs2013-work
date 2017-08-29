using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication1
{
    class Programm
    {
        static void Main(string[] args)
        {
                  int inv = 30000;
                  byte err = 100;
                  int chkout = 0;
                  byte pincounter = 0;
                 // bool pinformat = false;
                  
                  while (inv >= 1000)
                  {
                  
                      char[] pin = new char[4];
                      string pincheck = "";
                      bool pinc = false;
                      bool success = false;
                  
                      // byte[] kn = new byte[4];
                      // string kn_t;
                      // 
                      // Console.WriteLine("Bitte geben sie ihre Kundennummer ein!");
                      // for (byte i = 0; i < 3; i++)
                      // {
                      //     kn_t += Convert.ToByte(Console.ReadKey().KeyChar);
                      // 
                      // }
                      // switch (kn_t)
                      // {
                      //     case "001":
                      // 
                      //         break;
                      // }
                      //    
                  
                      // PIN-Entgegennahme
                      Console.Write("Bitte geben sie ihre Pin ein! \nPIN: ");
                      for (byte i = 0; i < 4; i++)
                      {
                          pin[i] = Convert.ToChar(Console.ReadKey().KeyChar);
                          pincheck += Convert.ToString(pin[i]);
                      }
                      Console.ReadLine();
                      Console.Clear();
                  
                      // PIN-Wiedergabe
                      Console.Write("Ihre eingegebene PIN lautet: ");
                      for (byte i = 0; i < 4; i++)
                      {
                          Console.Write(pin[i]);
                      }
                  
                      // PIN-Check
                      if (pincheck == "0123") // Wenn richtig, dann PIN-Flag setzen und Falschcounter zuücksetzen
                      {
                          pinc = true;
                          pincounter = 0;
                      }
                      else // Wenn falsch, dann erhöhe Falschcounter!
                      {
                          pincounter++;
                          Console.WriteLine("\nPIN falsch!");
                          Thread.Sleep(1000);
                          Console.Clear();
                      }
                  
                      if (pincounter >= 3) // Falschcounter zu hoch? Dann Sperren!
                      {
                          Console.WriteLine("Konto gesperrt! (Falsche PIN)");
                          pincounter = 0;
                          Thread.Sleep(1500);
                          Console.Clear();
                      }
                  
                      while (pinc == true && success == false) //PIN-Flag gesetzt?
                      {
                          Console.Write("\nBitte geben sie den zu abhebenden Betrag an: ");
                          chkout = Convert.ToInt32(Console.ReadLine());
                          Console.Clear();
                          if ((inv - chkout) >= 0)
                          {
                              inv = inv - chkout;
                              Console.WriteLine(chkout + "€ wurden ausgegeben! \n   Schönen Tag noch!");
                              Thread.Sleep(1500);
                              Console.Clear();
                              success = true;
                          }
                          else 
                          { 
                              Console.WriteLine("Betrag zu hoch! Bitte geringeren Betrag wählen!");
                              Thread.Sleep(1500);
                              Console.Clear();
                          }
                  
                      }
                  }
                  if (inv < 1000)
                  {
                      err = 101;
                  }
                  Console.WriteLine("Dieser Automat steht ihnen momentan nicht zur Verfügung. (Servicecode: {0})", err);
                  Console.WriteLine("\n\n---------------------");
                  Console.WriteLine("--- Programmende! ---");
                  Console.WriteLine("---------------------\nPress Enter to terminate!");
                  Console.ReadLine();

            //char zchar;
            //bool charok = false;
            //
            //zchar = Convert.ToChar(Console.ReadKey().KeyChar);
            //switch (zchar)
            //{
            //    case '0':
            //        charok = true;
            //        break;
            //    case '1':
            //        charok = true;
            //        break;
            //    case '2':
            //        charok = true;
            //        break;
            //    case '3':
            //        charok = true;
            //        break;
            //    case '4':
            //        charok = true;
            //        break;
            //    case '5':
            //        charok = true;
            //        break;
            //    case '6':
            //        charok = true;
            //        break;
            //    case '7':
            //        charok = true;
            //        break;
            //    case '8':
            //        charok = true;
            //        break;
            //    case '9':
            //        charok = true;
            //        break;
            //    default:
            //        charok = false;
            //        break;
            //}
            //if (charok == true)
            //{
            //    Console.WriteLine("\nEingabe ist OK! Prozess kann fertgesetzt werden.");
            //}
            //else { Console.WriteLine("\nEingabe nicht OK!"); }
            //
            //Console.WriteLine("\n\n---------------------");
            //Console.WriteLine("--- Programmende! ---");
            //Console.WriteLine("---------------------\nPress Enter to terminate!");
            //Console.ReadLine();
        }
    }
}
