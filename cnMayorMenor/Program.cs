using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnMayorMenor
{
    /// <summary>
    /// Nombre:Paola Ruiz Osorio
    /// Fecha: 25/02/2023
    /// Descripción: Validar cual es el número mayor y cual el menor de los tres datos ingresados
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BIENVENIDO");
            Console.WriteLine("Por favor ingrese el primer número ");
            Double Numero1= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Por favor ingrese el primer número ");
            Double Numero2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Por favor ingrese el primer número ");
            Double Numero3 = Convert.ToDouble(Console.ReadLine());

            //Llamar metodos creados
            ValidarMayor(Numero1, Numero2, Numero3);
            ValidarMenor(Numero1, Numero2, Numero3);

            Console.WriteLine("Fue un placer ayudarte");
            Console.ReadKey();
        }
        //Metodo para validar cual es el número mayor 
        static void ValidarMayor(Double Numero1, Double Numero2, Double Numero3)
        {
            if (Numero1 > Numero2 && Numero1 > Numero3)
            {
                Console.WriteLine("El numero mayor es: " + Numero1);
            }
    
            else if (Numero2 > Numero1 && Numero2 > Numero3)
            {
                Console.WriteLine("El numero mayor es: " + Numero2);
            }
            else
            {
                Console.WriteLine("El numero mayor es: " + Numero3);
            }
        }
        //Metodo para validar cual es el número menor
        static void ValidarMenor(Double Numero1, Double Numero2, Double Numero3)
        {
            if (Numero1 < Numero2 && Numero1 < Numero3)
            {
                Console.WriteLine("El numero menor es: " + Numero1);
            }

            else if (Numero2 < Numero1 && Numero2 < Numero3)
            {
                Console.WriteLine("El numero menor es: " + Numero2);
            }
            else
            {
                Console.WriteLine("El numero menor es: " + Numero3);
            }
        }


    }
}
