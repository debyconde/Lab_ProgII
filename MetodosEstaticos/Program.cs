using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            int ElMayor;
            string dato;

            Console.WriteLine("hola mundo");
            ElMayor= Comparadora.RetornarMayor(10, 5);
            Sello.mensaje = "Nuevo mensaje";
            dato=Sello.Imprimir();
            Sello.color = ConsoleColor.Cyan;
            Sello.ImprimirEnColor();
         
        }
    }
}
