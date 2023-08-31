using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Reto #6
 * INVIRTIENDO CADENAS
 * Fecha publicación enunciado: 07/02/22
 * Fecha publicación resolución: 14/02/22
 * Dificultad: FÁCIL
 *
 * Enunciado: Crea un programa que invierta el orden de una cadena de texto sin usar funciones propias del lenguaje que lo hagan de forma automática.
 * - Si le pasamos "Hola mundo" nos retornaría "odnum aloH"
 */

namespace InvirtiendoCadenas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(InvertirCadena1("Hola me llamo juan.1"));
            Console.WriteLine(InvertirCadena2("Hola me llamo juan.2"));
            Console.WriteLine(InvertirCadena3("Hola me llamo juan.3"));
            Console.WriteLine(InvertirCadena4("Hola me llamo juan.4"));
        }

        static string InvertirCadena1(string cadena)
        {
            char[] chars = cadena.ToCharArray();                    
            string cadenaInvertida = "";            

            for(int i = (chars.Length - 1); i >= 0; i--) 
            {
                cadenaInvertida += chars[i];                
            }

            return cadenaInvertida;
        }

        //Otra forma
        static string InvertirCadena2(string cadena)
        {
            char[] chars = cadena.ToCharArray().Reverse().ToArray();            
            string cadenaInvertida = "";
            
            foreach(char c in chars) 
            {
                cadenaInvertida += c;
            }

            return cadenaInvertida;
        }

        //Otra forma
        static string InvertirCadena3(string cadena)
        {
            char[] chars = cadena.ToCharArray().Reverse().ToArray(); 
            return new string(chars);
        }

        //Otra forma
        static string InvertirCadena4(string cadena)
        {
            char[] chars = cadena.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}
