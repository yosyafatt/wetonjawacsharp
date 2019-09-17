using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WetonJawa
{
    class Program
    {      

        public static void Main(string[] args)
        {            
            String[] input;
            Random ran = new Random();
            DateTime yourdate, partnerdate;
            String yourjawadate, partnerjawadate;
            int yourweton = 0, partnerweton = 0, totalweton = 0;

            String[,] neptuMasehi =
            {
                {"Sunday", "5"},
                {"Monday", "4"},
                {"Tuesday", "3"},
                {"Wednesday", "7"},
                {"Thursday", "8"},
                {"Friday", "6"},
                {"Saturday", "9"},
            };

            String[,] neptuJawa =
            {
                {"Wage", "4"},
                {"Kliwon", "8"},
                {"Legi", "5"},
                {"Pahing", "9"},
                {"Pon", "7"},
            };

            Console.WriteLine("========== W E T O N  J A W A ==========");
            Console.WriteLine();

            // Minta tanggal lahirmu dan pasangan
            
            Console.Write("Masukkan tanggal lahirmu (contoh: 27/6/1998): ");
            input = (Console.ReadLine()).Split('/');
            yourdate = new DateTime(int.Parse(input[2]), int.Parse(input[1]), int.Parse(input[0]));
            yourjawadate = neptuJawa[ran.Next(5), 0];
            for (int i = 0; i < neptuJawa.Length / 2; i++)
            {
                if (neptuJawa[i, 0] == yourjawadate)
                {
                    yourweton = int.Parse(neptuJawa[i, 1]);
                    break;
                }
            }

            Console.Write("Masukkan tanggal pasanganmu (contoh: 27/6/1998): ");
            input = (Console.ReadLine()).Split('/');
            partnerdate = new DateTime(int.Parse(input[2]), int.Parse(input[1]), int.Parse(input[0]));
            partnerjawadate = neptuJawa[ran.Next(5), 0];
            for (int i = 0; i < neptuJawa.Length/2; i++)
            {
                if (neptuJawa[i,0] == partnerjawadate)
                {
                    partnerweton = int.Parse(neptuJawa[i, 1]);
                    break;
                }
            }

            Console.WriteLine("Weton anda           : {0} {1} = {2}", yourdate.DayOfWeek, yourjawadate, (int.Parse(neptuMasehi[(int)yourdate.DayOfWeek,1]) + yourweton));
            Console.WriteLine("Weton pasangan anda  : {0} {1} = {2}", partnerdate.DayOfWeek, partnerjawadate, (int.Parse(neptuMasehi[(int)partnerdate.DayOfWeek, 1]) + partnerweton));
            totalweton = (int.Parse(neptuMasehi[(int)yourdate.DayOfWeek, 1]) + yourweton) + (int.Parse(neptuMasehi[(int)partnerdate.DayOfWeek, 1]) + partnerweton);

            switch (totalweton)
            {
                case 1: case 9: case 17: case 25: case 33:
                    Console.WriteLine("Hasil weton {0} adalah PEGAT", totalweton);
                    break;
                case 2: case 10: case 18: case 26: case 34:
                    Console.WriteLine("Hasil weton {0} adalah RATU", totalweton);
                    break;
                case 3: case 11: case 19: case 27: case 35:
                    Console.WriteLine("Hasil weton {0} adalah JODOH", totalweton);
                    break;
                case 4: case 12: case 20: case 28: 
                    Console.WriteLine("Hasil weton {0} adalah TOPO", totalweton);
                    break;
                case 5: case 13: case 21: case 29:
                    Console.WriteLine("Hasil weton {0} adalah TINARI", totalweton);
                    break;
                case 6: case 14: case 22: case 30:
                    Console.WriteLine("Hasil weton {0} adalah PADU", totalweton);
                    break;
                case 7: case 15: case 23: case 31:
                    Console.WriteLine("Hasil weton {0} adalah SUJANAN", totalweton);
                    break;
                case 8: case 16: case 24: case 32:
                    Console.WriteLine("Hasil weton {0} adalah PESTHI", totalweton);
                    break;
            }            
            Console.ReadLine();
        }
    }
}
