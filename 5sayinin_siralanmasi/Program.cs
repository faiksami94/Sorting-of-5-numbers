using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5sayinin_siralanmasi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lutfen girmek istediginiz sayi adedini giriniz");
            int sayi_adedi=Convert.ToInt32(Console.ReadLine());
            int[] sayilar = new int[sayi_adedi]; //The amount of numbers desired to add into the calculation
            for (int a = 0; a < sayilar.Length; a++)
            {
                Console.WriteLine("Lutfen sayi giriniz");
                sayilar[a] = Convert.ToInt32(Console.ReadLine()); //the numbers entry 
            }
            int gecici;
            
            for (int i = 0;i<sayilar.Length-1;i++) 
            { // 0 
                for (int j = i; j< sayilar.Length; j++) 
                {// 0 
                    if (sayilar[i] > sayilar[j]) 
                    {//556 555 1 2 3 4 5 554
                        gecici = sayilar[j];
                        sayilar[j] = sayilar[i];
                        sayilar[i] = gecici;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Dizinin son hali"); //Final version of the series
            foreach (int t in sayilar)  // to display the final version
            {
                Console.WriteLine(t+ " ");
            }
            Console.ReadKey();
        }
    }
}
