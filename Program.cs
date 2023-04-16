using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klavyeden_girilen_5_sayi_toplam
{
    internal class Program
    {
        static void Main(string[] args)
        { int n=0,toplam=0;
            for(int i=1; i<=5; i++)
            {
                Console.Write(i+".Sayıyı giriniz:");
                n=Convert.ToInt16(Console.ReadLine());
                toplam +=n; ;

            }
            Console.Write("Beş sayının toplamı:"+toplam);
            Console.ReadKey();
        }
    }
}
