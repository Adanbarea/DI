using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            String salir="hola";

            while (!salir.Equals("si")|| !salir.Equals("Si") || !salir.Equals("SI") || !salir.Equals("sI"))
            {
                Console.WriteLine("Hola mundo");
                Console.ReadLine();
                Console.Beep(1000, 3000);
                Console.WriteLine("Escribe true si quieres salir");
                salir=Console.ReadLine();
                Console.BackgroundColor = (ConsoleColor)15;
            }
        }
    }
}
