using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equazionilybrary
{
    public class Class1
    {
        
        public static int Calcfrecquenza(int eta)
        {
            
            int freq =  220 - eta;
            
            double battiti= freq*0.7;
            double battiti1 = freq * 0.9;

            double fmin = freq - battiti;

            double fmax = freq - battiti1;
        
            
            return freq;
        }

        public static string interpretaredati(int battiti)
        {
            string msg = "";
            if (battiti<60)
            {
                Console.WriteLine("bradicardia");
            }
            else
            {

                 if (battiti > 60 && battiti < 100)
                 {
                    Console.WriteLine("normale");
                 }
                 else
                {
                    Console.WriteLine("tachicardia");
                }
            }

                return msg;
        }


        
    }
}
