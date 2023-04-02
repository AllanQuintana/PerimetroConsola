using System;
using System.Net.NetworkInformation;

namespace ConPerimetro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarativa de variables
            double alto, ancho, perimetro;
            string strAlto, strAncho;
            Console.WriteLine("Ingrese el alto del rectangulo ");
            strAlto = Console.ReadLine();
            Console.WriteLine("Ingrese el ancho del rectangulo ");
            strAncho = Console.ReadLine();

            // Convertir las variables string a variables numericas
            double.TryParse(strAlto, out alto);
            double.TryParse(strAncho, out ancho);
            perimetro = 2 * (alto + ancho);
            Console.WriteLine("El perimetro es " + perimetro);
            Console.ReadKey();
        }
    }
}