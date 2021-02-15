using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exception = System.Exception;

namespace Sayısal_Loto
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Register();
            }
            catch (hata exception)
            {
                Console.WriteLine(exception.Message);
                
            }
            Console.ReadLine();

        }

        private static void Register()
        {
            int[] numbers = new int[4];
            for (int i = 0; i < numbers.GetUpperBound(0); i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                if (numbers[i]%2!=0)
                {
                    throw new hata("çift değil");
                }
            }
        }
    }
}


        
    

