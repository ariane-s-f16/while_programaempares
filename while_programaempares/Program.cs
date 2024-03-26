using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_programaempares
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int cont = 0;
            while (cont >= 0 && cont < 101 )
            {
               
                    Console.WriteLine(cont);
                    cont+=2;
             
            }
            Console.ReadKey();
        }
    }
}
