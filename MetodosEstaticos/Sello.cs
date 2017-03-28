using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosEstaticos
{
    class Sello
    {
        //Atributos
        public static string mensaje;
        public static ConsoleColor color;

        //Metodo
        public static string Imprimir()
        {
            return Sello.armarMensaje();
        }

        public static void Borrar()
        {
            Sello.mensaje = "";
        }

        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = Sello.color;
            Console.WriteLine(Sello.Imprimir());

        }

        private static string armarMensaje()
        {
            string retorno = "";
            retorno = Sello.mensaje;
        }

    }
}
