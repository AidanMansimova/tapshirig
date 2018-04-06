using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {

            //1-ci tapshiriq:

            //Console.WriteLine("Adinizi daxil edin");
            //var name = Console.ReadLine();
            //Console.WriteLine("Soyadinizi daxil edin");
            //var surname = Console.ReadLine();
            //Console.WriteLine("Dostluguma xosh gelmisiniz {0} {1}", name, surname);



            //Ferq: F5-i tiklayanda errorlar etrafli gosterilmir, Start-i tiklayanda errorlar etrafli gosterilir.






            //2-ci tapshiriq:

            //for (int i = 10; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //    Thread.Sleep(1000);
            //}






            //3-cu tapshiriq:

            //Console.WriteLine("pulu daxil edin");
            //var money = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("1.Dollardan-Manata");
            //Console.WriteLine("2.Manatdan-Dollara");
            //Console.WriteLine("3.Eurodan-Manata");
            //Console.WriteLine("4.Manatdan-Euroya");
            //Console.WriteLine("5.Rubldan-Manata");
            //Console.WriteLine("6.Manatdan-Rubla");

            //var currency = Convert.ToInt32(Console.ReadLine());

            //double dollar = 1.70;
            //double eur = 2.0152;
            //double rub = 0.0291;



            //if (currency == 3)
            //{
            //    money = money * eur;
            //}
            //else if (currency == 4)
            //{
            //    money = money / eur;
            //}

            //if (currency == 5)
            //{
            //    money = money * rub;
            //}
            //else if (currency == 6)
            //{
            //    money = money / rub;
            //}


            //if (currency==1)
            //{
            //   money= money* dollar;
            //}
            //else if (currency==2)
            //{
            //    money = money / dollar;
            //}



            //Console.WriteLine(money);







            //4-cu tapsiriq:

            //Console.WriteLine("Ilk ededi daxil edin");
            //var ilkEded = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Ikinci ededi daxil erdin");
            //var ikinciEded = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Icra olunmasini istediyiniz emeliyyatin simvolunu daxil edin : ");
            //var emeliyyat = Console.ReadLine();
            //Hesabla(ilkEded, ikinciEded, emeliyyat);

            //void Hesabla(int _ilkEded, int _ikinciEded, string _emeliyyat)
            //{
            //    if (_emeliyyat == "+")
            //    {
            //        Console.WriteLine(_ilkEded+" "+_emeliyyat+" "+_ikinciEded+"="+(_ilkEded + _ikinciEded));
            //    }
            //    if (_emeliyyat == "-")
            //    {
            //        Console.WriteLine(_ilkEded + " " + _emeliyyat + " " + _ikinciEded + "=" + (_ilkEded - _ikinciEded));
            //    }
            //    if (_emeliyyat == "*")
            //    {
            //        Console.WriteLine(_ilkEded + " " + _emeliyyat + " " + _ikinciEded + "=" + (_ilkEded * _ikinciEded));
            //    }
            //    if (_emeliyyat == "/")
            //    {
            //        Console.WriteLine(_ilkEded + " " + _emeliyyat + " " + _ikinciEded + "=" + (_ilkEded / _ikinciEded));
            //    }
            //}













            //5-ci tapshiriq:
            // Console.WriteLine("Eded daxil edin");
            // int numbers = int.Parse(Console.ReadLine());
            //int j;

            // bool current = false;
            // for (int i = 2; i <= numbers; i++)
            // {
            //     for (j = 2; j < i; j++)
            //     {
            //         if (i % j == 0)
            //         {
            //             current = true;
            //         }
            //     }
            //     if (current == false)
            //     {
            //         Console.WriteLine("Sade ededler {0}", j);
            //     }
            //     else
            //     {
            //         current = false;
            //     }






            //6-ci tapshiriq:

            //int x;
            //int y;
            //Console.WriteLine("X=    ");
            //x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Y=    ");
            //y = Convert.ToInt32(Console.ReadLine());
            //x = x + y;
            //y = x - y;
            //x = x - y;
            //Console.WriteLine("X=    " + x);
            //Console.WriteLine("Y=    " + y);
            //Console.ReadKey();






            //7-ci tapshiriq:

            //Random rnd = new Random();
            //var x = rnd.Next(1, 5);
            //var eded = Convert.ToInt32(Console.ReadLine());
            //if (eded==x)
            //{
            //    Console.WriteLine("you win");
            //}
            //else
            //{
            //    Console.WriteLine("you lose");
            //}








            //8-ci tapshiriq:

            //int num, sum = 0, r;
            //Console.WriteLine("Eded daxil edin : ");

            //num = int.Parse(Console.ReadLine());
            // while ( num != 0)
            //{
            //    r = num % 10;
            //    num = num / 10;
            //    sum = sum + r;
            //}

            //Console.WriteLine("Ededin reqemleri cemi : " + sum);
            //Console.ReadLine();









        }

        }
    }

