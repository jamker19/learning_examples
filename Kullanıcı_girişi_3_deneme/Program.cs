using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kullanıcı_girişi_3_deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hak = 3;
            string kullanıcı_adı, Şifre;

            do
            {
                Console.Write("Kullanıcı adını giriniz:");
                kullanıcı_adı = Console.ReadLine();
                Console.Write("Şireyi giriniz:");
                Şifre = Console.ReadLine();
                hak--;
                if(kullanıcı_adı == "İstanbul" && Şifre == "1453") 
                {
                    Console.Write("Hoşgeldiniz.");
                    break;

                }
                if ((kullanıcı_adı != "İstanbul" || Şifre != "1453") && hak == 0)
                    Console.Write("Kullanıcı hakkınız kalmadı");
                
            } while ((kullanıcı_adı!="İstanbul" || Şifre !="1453")&&hak!=0);

            Console.ReadKey();
        }
    }
}
