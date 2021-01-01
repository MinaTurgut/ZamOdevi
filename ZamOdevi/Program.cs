using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZamOdevi
{
    class Program
    {
        
        public static double ZamHesaplama(int cocuksay)
        {
            double maas = 2320;
            double zam;
            double sonuc;
            if (cocuksay == 1)
            { 
                zam = maas * 0.05;
                sonuc = zam + maas;
            }
            else if (cocuksay == 2)
            {
                zam = maas * 0.05;
                sonuc = zam + maas;
            }
            else if (cocuksay >= 3)
            {
                zam = maas * 0.15;
                sonuc = zam + maas;
            }
            else
            {
                sonuc = maas;
                
            }
            return sonuc;
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç cocuğunuz var?");
            string cocuksayisi = Console.ReadLine();
            double response = ZamHesaplama(int.Parse(cocuksayisi));
            Console.WriteLine("Zamlı Maaş: {0}", response);
            Console.ReadKey();
        }
    }
}
