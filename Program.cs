using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0.conversión_de_fracciones_mixtas_a_fracciones_comunes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese una fracción mixta: "); //Este programa lee una fracción mixta del usuario como una cadena, 
            string mixedFraction = Console.ReadLine(); //

            int wholeNumber = GetWholeNumber(mixedFraction);
            int numerator = GetNumerator(mixedFraction, wholeNumber);
            int denominator = GetDenominator(mixedFraction);

            int newNumerator = wholeNumber * denominator + numerator; //luego utiliza varios métodos para separar el número entero, el numerador y el denominador de la fracción
            Console.WriteLine("La fracción común es: " + newNumerator + "/" + denominator);
            Console.ReadLine();
        }

        static int GetWholeNumber(string mixedFraction)
        {
            int indexOfSpace = mixedFraction.IndexOf(" ");
            return int.Parse(mixedFraction.Substring(0, indexOfSpace));
        }

        static int GetNumerator(string mixedFraction, int wholeNumber) //variable estatica 
        {
            int indexOfSpace = mixedFraction.IndexOf(" ");
            int indexOfSlash = mixedFraction.IndexOf("/");
            return int.Parse(mixedFraction.Substring(indexOfSpace + 1, indexOfSlash - indexOfSpace - 1));
        }

        static int GetDenominator(string mixedFraction) //variable estatica 
        {
            int indexOfSlash = mixedFraction.IndexOf("/");
            return int.Parse(mixedFraction.Substring(indexOfSlash + 1));
        }
    }
}