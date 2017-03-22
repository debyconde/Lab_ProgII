 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosEstaticos
{
    class Comparadora
    {
        /// <summary>
        /// Este metodo retorna el mayor de los numeros ingresados por parametro
        /// </summary>
        /// <param name="num1">El primer entero</param>
        /// <param name="num2">Elsegundo entero</param>
        /// <returns>El mayor de los dos</returns>
        public static int RetornarMayor(int num1, int num2)
        {
            int retorno=0 ;


            if (num1 > num2)
                retorno = num1;
            else
                retorno = num2;



            return retorno;
        
        }


        /// <summary>
        /// este metodo retorna el medio de los numeros ingresados
        /// </summary>
        /// <param name="num1">primer numero ingresado</param>
        /// <param name="?">segundo numero ingresado</param>
        /// <param name="?">Muestra el medio</param>
        public static void MostrarElMedio(int num1,int num2,int num3)
        {

        }

 
        
    }
}
