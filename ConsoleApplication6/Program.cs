using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {

        public static int zarAt(int a)
        {
            Random rnd = new Random();
            int x = rnd.Next(1, a + 1);
            return x;
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();


            Console.WriteLine("Avcı Silahını Seç:\n[1]Bıçak\n[2]Kılıç\n[3]Ok-Yay\n[4]Balta\n[5]Balyoz\nSeçim: ");
            int secim, silahHasar = 0;
            secim = Convert.ToInt16(Console.ReadLine());

            if (secim == 1)
            {
                Console.WriteLine("Avcının Silahı Bıçak (d4)");
                silahHasar = zarAt(4);
            }
            else if (secim == 2)
            {
                Console.WriteLine("Avcının Silahı Kılıç (d8)");
                silahHasar = zarAt(8);
            }
            else if (secim == 3)
            {
                Console.WriteLine("Avcının Silahı Ok-Yay (d6)");
                silahHasar = zarAt(6);
            }
            else if (secim == 4)
            {
                Console.WriteLine("Avcının Silahı Balta (d10)");
                silahHasar = zarAt(10);
            }
            else if (secim == 5)
            {
                Console.WriteLine("Avcının Silahı Balyoz (d12)");
                silahHasar = zarAt(12);
            }


            int rakip = rnd.Next(1, 4);
            Console.WriteLine("Rakibiniz Belirleniyor... ");

            int avciAtak = rnd.Next(1, 21);
            int kurtAtak = rnd.Next(1, 21);
            int domuzAtak = rnd.Next(1, 21);
            int ayiAtak = rnd.Next(1, 21);
            int avciZırh = 14, avciCan = 25;
            int kurtZırh = 11, kurtCan = 10;
            int domuzZırh = 18, domuzCan = 14;
            int ayiZırh = 16, ayiCan = 25;
            int kurtHasar = zarAt(4);
            int domuzHasar = zarAt(3);
            int ayiHasar = zarAt(6);


            if (rakip == 1)
            {

                Console.WriteLine("Rakibiniz Kurttur...");
                Console.WriteLine("Avcının Atağı={0}\nAvcının Zırhı={1}\nAvcının Canı={2}\nKurtun Atağı={3}\nKurtun Zırhı={4}\nKurtun Canı={5}", avciAtak, avciZırh, avciCan, kurtAtak, kurtZırh, kurtCan);
                Console.WriteLine("Avcı ile Kurt Savaşı Başlıyor...");
                while (avciCan >= 0 && kurtCan >= 0)
                {
                    if (avciAtak > kurtZırh)
                    {
                        Console.WriteLine("Avcı Saldırıyor...");
                        Console.WriteLine("Avcı" +silahHasar+" kadar hasar verecek..");
                        kurtCan = kurtCan - silahHasar;
                        Console.WriteLine("Kurtun bu kadar canı azaldı = " + silahHasar);
                        Console.WriteLine("Kurtun yeni canı = " + kurtCan);

                        Console.ReadLine();
                        if (kurtCan <= 0)
                        {
                            Console.WriteLine("Kurt died..");
                            break;

                        }
                        else
                        {
                            Console.WriteLine("Avcı hasar vuramadı.");
                            Console.ReadLine();
                        }

                        Console.WriteLine("Kurt Saldırıyor..");
                        Console.WriteLine("Kurtun atağı = " + kurtAtak);
                        Console.WriteLine("Kurtun canı = " + kurtCan);
                        if (kurtAtak > avciZırh)
                        {

                            avciCan = avciCan - kurtHasar;
                            Console.WriteLine("Avcının bu kadar canı azaldı = " + kurtHasar);
                            Console.WriteLine("Avcının yeni canı = " + avciCan);
                            Console.ReadLine();
                            if (avciCan <= 0)
                            {
                                Console.WriteLine("Avcı died..");
                                break;
                            }
                        }
                      
                        else
                        {
                            Console.WriteLine("Kurt hasar vuramadı.");
                            Console.ReadLine();
                        }
                    }


                }
            }
            else if (rakip == 2)
            {
                Console.WriteLine("Rakibiniz Domuzdur...");
                Console.WriteLine("Avcının Atağı={0}\nAvcının Zırhı={1}\nAvcının Canı={2}\nDomuzun Atağı={3}\nDomuzun Zırhı={4}\nDomuzun Canı={5}", avciAtak, avciZırh, avciCan, domuzAtak, domuzZırh, domuzCan);
                Console.WriteLine("Avcı ile Domuzun Savaşı Başlıyor...");
                while (avciCan >= 0 && domuzCan >= 0)
                {
                    if (avciAtak > domuzZırh)
                    {
                        Console.WriteLine("Avcı Saldırıyor...");
                        Console.WriteLine("Avcı {0} kadar hasar verecek..", silahHasar);
                        domuzCan = domuzCan - silahHasar;
                        Console.WriteLine("Domuzun {0} kadar canı azaldı = " + silahHasar);
                        Console.WriteLine("Domuzun yeni canı = " + domuzCan);

                        Console.ReadLine();
                        if (domuzCan <= 0)
                        {
                            Console.WriteLine("Domuz died..");
                            break;

                        }

                    }
                  
                    else
                    {
                        Console.WriteLine("Avcı hasar vuramadı.");
                        Console.ReadLine();
                    }

                    Console.WriteLine("Domuz Saldırıyor..");
                    Console.WriteLine("Domuzun atağı = " + domuzAtak);
                    Console.WriteLine("Domuzun canı = " + domuzCan);

                    if (domuzAtak > avciZırh)
                    {
                        avciCan = avciCan - domuzHasar;
                        Console.WriteLine("Avcının bu kadar canı azaldı = " + domuzHasar);
                        Console.WriteLine("Avcının yeni canı = " + avciCan);
                        Console.ReadLine();
                        if (avciCan <= 0)
                        {
                            Console.WriteLine("Avcı died..");
                            break;

                        }
                    }
                 

                    else
                    {
                        Console.WriteLine("Domuz hasar vuramadı.");
                        Console.ReadLine();
                    }

                }
            }
            else if (rakip == 3)
            {
                Console.WriteLine("Rakibiniz Ayıdır...");
                Console.WriteLine("Avcının Atağı={0}\nAvcının Zırhı={1}\nAvcının Canı={2}\nAyının Atağı={3}\nAyının Zırhı={4}\nAyının Canı={5}", avciAtak, avciZırh, avciCan, ayiAtak, ayiZırh, ayiCan);
                Console.WriteLine("Avcı ile Ayının Savaşı Başlıyor...");
                while (avciCan >= 0 && ayiCan >= 0)
                {
                    if (avciAtak > ayiZırh)
                    {
                        Console.WriteLine("Avcı Saldırıyor...");
                        Console.WriteLine("Avcı {0} kadar hasar verecek..", silahHasar);
                        ayiCan = ayiCan - silahHasar;
                        Console.WriteLine("Ayının bu kadar canı azaldı = " + silahHasar);
                        Console.WriteLine("Ayının yeni canı = " + domuzCan);

                        Console.ReadLine();
                        if (ayiCan <= 0)
                        {
                            Console.WriteLine("Ayı died..");
                            break;

                        }
                    }
                    
                    else
                    {
                        Console.WriteLine("Avcı hasar vuramadı.");
                        Console.ReadLine();
                    }

                    Console.WriteLine("Ayı Saldırıyor..");
                    Console.WriteLine("Ayının atağı = " + ayiAtak);
                    Console.WriteLine("Ayının canı = " + ayiCan);

                    if (ayiAtak > avciZırh)
                    {

                        avciCan = avciCan - ayiHasar;
                        Console.WriteLine("Avcının bu kadar canı azaldı = " + ayiHasar);
                        Console.WriteLine("Avcının yeni canı = " + avciCan);
                        Console.ReadLine();
                        if (avciCan <= 0)
                        {
                            Console.WriteLine("Avcı died..");
                            break;

                        }
                    }
                    else
                    {
                        Console.WriteLine("Ayı hasar vuramadı.");
                        Console.ReadLine();
                    }

                }
            }
                Console.ReadLine();
            }

        }
    }


