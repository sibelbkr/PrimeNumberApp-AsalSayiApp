using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace soru3
{
    class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan girilen 10 tane sayının asal olanlarını başka bir diziye ekleyen program

            int[] NumberList = new int[10];
            ArrayList PrimeNumber = new ArrayList();
            int num;
            int flag = 0;
            int prime;



            Console.WriteLine("10 ADET SAYI GİRİNİZ:\n");
            for (int i = 0; i <= 9; i++)
            {
                num = Convert.ToInt32(Console.ReadLine());
                NumberList[i] = num;
            }
            Console.WriteLine("GİRİLEN SAYILARIN LİSTESİ:\n");
            foreach (int item in NumberList)
            {
                Console.Write(" " + item);
            }

            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j < NumberList[i] - 1; j++)
                {
                    if (NumberList[i] % j == 0)
                    {
                        flag++;
                    }

                }

                if (flag == 0)
                {

                    prime = NumberList[i];
                    PrimeNumber.Add(prime);
                }

            }

            Console.WriteLine("\nDİZİMİZDEKİ ASAL SAYILAR:\n");
            foreach (int item in PrimeNumber)
            {
                Console.Write(" " + item);

            }


            Console.ReadKey();

        }
    }
}
