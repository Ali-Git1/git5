using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IsPrime(10);




            //CalcAvg(70,50,60,40,70,86);

        }

        static void IsPrime(int value)
        {
            int say = 0;
            Console.WriteLine("Ededi daxil edin");
            value =Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= value; i++)
            {
                if(value%i==0)
                {
                    say++;  
                }
            }
            if(say==2)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            Console.ReadLine();
        }






        //static void CalcAvg(params int[] nums)
        //{
        //    //int sum = 0;
        //    //int average = 0;
        //    //for (int i = 0; i < nums.Length; i++)
        //    //{
        //    //    sum += nums[i];

        //    //}
        //    //average = sum / nums.Length;
        //    //Console.WriteLine(average);

        //    //if (average > 60)
        //    //{
        //    //    Console.WriteLine("Mezun oldunuz");
        //    //}
        //    //else
        //    //{
        //    //    Console.WriteLine("Mezun ola bilmediniz");
        //    //}
        //}
    }
}
