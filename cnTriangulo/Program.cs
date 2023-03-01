using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnTriangulo
{
    /// <summary>
    /// Nombre:Paola Ruiz Osorio
    /// Fecha: 25/02/2023
    /// Descripción: Nos permite validar el lado mayor del triangulo y si es un triangulo equilatero. 
    /// </summary>

    internal class Program
    {

       
        static void Main(string[] args)
        {
            //Pedir datos 
            Console.WriteLine("Ingrese el primer lado del triangulo");
            Double Lado1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo lado del triangulo");
            Double Lado2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer lado del triangulo");
            Double Lado3 = Convert.ToDouble(Console.ReadLine());

            //Llamar  metodos
            ValidarLadoMayor(Lado1, Lado2, Lado3);
            ValidarTriangulo(Lado1, Lado2, Lado3);

            Console.ReadKey();
        }
        //Metodo para validar el lado mayor 
       public static void ValidarLadoMayor(Double Lado1, Double Lado2, Double Lado3)
        {
            if (Lado1>Lado2 && Lado1>Lado3)
            {
            Console.WriteLine("El lado mayor es: "+ Lado1);
            }
            else if (Lado2>Lado1 && Lado2>Lado3)
            {
            Console.WriteLine("El lado mayor es: " + Lado2);
            }
            else 
            {
            Console.WriteLine("El lado mayor es: " + Lado3);
            }

        }
        // Metodo para saber si el triangulo es equilatero
        public static void ValidarTriangulo(Double Lado1, Double Lado2, Double Lado3)
        {
            if (Lado1== Lado2 && Lado1 == Lado3)
            {
                Console.WriteLine("El triangulo es EQUILATERO");
            }
            else
                Console.WriteLine("El triangulo NO es EQUILATERO");
        }

    }
}
