using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char sexo;
            do
            {
                Console.SetCursorPosition(0, 0);
                Console.Write("Sexo: ");
                sexo = Console.ReadKey().KeyChar;

            }
            while (sexo != 'm' && sexo != 'f' && sexo != 'M' && sexo != 'F');
            Console.WriteLine("\nOK");
        }
    }
}
