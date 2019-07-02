using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Program
    {

        static void Main(string[] args)
        {
            Random rnd = new Random();

            int silahSec, avciHasar = 0;
            int rakipSec = zarAt(3);
            string rakipAd = " ";
            int atak = 0, hasar = 0;
            int rakipCan = 0,

            rakipZirh = 0, rakipHasar = 0;
            int avciCan = 25, avciZırh = 14;
            do
            {
                Console.WriteLine("Silah Seçimi");
                Console.WriteLine("_______________");
                Console.WriteLine("[1]Bıçak(d4)");
                Console.WriteLine("[2]Kılıç(d8)");
                Console.WriteLine("[3]Ok - Yay(d6)");
                Console.WriteLine("[4]Balta(d10)");
                Console.WriteLine("[5]Balyoz(d12)");

                Console.WriteLine("Silah Seçiniz : [1][2][3][4][5]");
                silahSec = Convert.ToInt16(Console.ReadLine());
            }
            while (silahSec < 0 ||silahSec > 6);

            switch (silahSec)
            {
                case 1: avciHasar = 4; break;
                case 2: avciHasar = 8; break;
                case 3: avciHasar = 6; break;
                case 4: avciHasar = 10; break;
                case 5: avciHasar = 12; break;
                default: avciHasar = 1; break;
            }
            switch (rakipSec)
            {
                case 1:rakipAd ="Kurt"; rakipCan = 10; rakipZirh = 11; rakipHasar = 4; break;
                case 2:rakipAd ="Domuz"; rakipCan = 14; rakipZirh = 16;rakipHasar = 3; break;
                case 3: rakipAd = "Ayı"; rakipCan = 25; rakipZirh = 14;rakipHasar = 6; break;
                default: break;
            }
            Console.WriteLine(rakipAd);
            do
            {
                {
                    Console.WriteLine("Avcı saldırıyor");
                }
                atak = zarAt(20);

                hasar = AvcıSaldir(atak, rakipZirh, avciHasar);
                rakipCan -= hasar;
                Console.WriteLine("Atak = {0} Hasar = {1} Rakip Can = {2} ", atak, hasar, rakipCan);

                Console.ReadLine();
                if (rakipCan <= 0)
                {
                    Console.WriteLine("Avcı kazandı");
                    Console.ReadLine();
                }
                else
                {
                    {

                        Console.WriteLine("Rakip saldırıyor");

                    }

                    atak = zarAt(20);


                    hasar = rakipSaldir(atak, avciZırh, rakipHasar);
                    avciCan -= hasar;
                    Console.WriteLine("Atak = {0} Hasar = {1} Avcı Can: {2}", atak, hasar, avciCan);

                    Console.ReadLine();
                    
                    if (avciCan <= 0)
                    {
                        Console.WriteLine("Rakip kazandı");
                        Console.ReadLine();
                        
                    }
                }
            }
            while (avciCan > 0 && rakipCan > 0);
        }
        public static int AvcıSaldir(int atak, int zirh, int hasar)
        {
            int x;
            // atak = zarAt(20);
            if (atak > zirh)
            {
                x = zarAt(hasar);
            }
            else x = 0;
            return x;
        }
        public static int rakipSaldir(int atak, int zirh, int hasar)
        {
            int x;
            //atak = zarAt(20);
            if (atak > zirh)
            {
                x = zarAt(hasar);
            }
            else x = 0;
            return x;
        }
        public static int zarAt(int a)
        {
            Random rnd = new Random();
            int x = rnd.Next(1, a +1);
            return x;
        }


    }
}
