using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Class2
    {
        static void Main(string[] args)
        {
            Genero genero = Genero.Masculino;
            switch (genero)
            {
                case Genero.Masculino:
                    Console.WriteLine("Case 1");
                    break;
                case Genero.Femenino:
                    Console.WriteLine("Case 2");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }

        }

        enum Genero
        {
            Masculino, 
            Femenino
        }
    }
}
