using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnCuadrado
{
    /// <summary>
    /// Nombre: Paola Ruiz Osorio 
    /// Fecha: 25/02/2023
    /// Descripción: Calcular superficie y perimetro de un cuadrado
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el valor del lado en cm");
            Double Lado = Convert.ToDouble(Console.ReadLine());
            //Llamar los metodos 
            Console.WriteLine("La superficie del cuadrado es de " + CalcularSuperficie(Lado) + "cm y su perimetro es de " + CalcularPerimetro(Lado) + "cm");

            Console.ReadKey();
        }
        //Creacion del metodo para saber la superficie del cuadrado
        static double CalcularSuperficie(double Lado)
        {
            double Superficie = (Lado * Lado);
            return Superficie ;
        }
        //Creacion del metodo para saber el perimetro del cuadrado
        static double  CalcularPerimetro(double Lado)
        {
            Double Perimetro = (Lado * 4);
            return Perimetro ;
        }
    }
}
