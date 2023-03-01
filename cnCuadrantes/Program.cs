using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnCuadrantes
{
    /// <summary>
    /// Nombre:Paola Ruiz Osorio 
    /// Fecha: 25/02/2023
    /// Descripción: Ubicar el cuadrante en la que esta el punto en el plano
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            //Solicitar coordenadas
            Console.WriteLine("Por favor ingrese el valor de x");
            Double X = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Por favor ingrese el valor de y");
            Double Y = Convert.ToDouble(Console.ReadLine());
            //Llamar metodo
            UbicarCuadrante( X,Y);

            Console.ReadKey();
        }
        //Creacion del metodo
        public static void UbicarCuadrante(Double X , Double Y)
        {
            //Condicional de ubicacion en el plano
            if (X > 0 && Y > 0)
            {
                Console.WriteLine("El punto en el plano (" + X + " , " + Y + ")" + " está ubicado en el CUADRANTE I");
            }
            else if (X < 0 && Y > 0)
            {
                Console.WriteLine("El punto en el plano (" + X + " , " + Y + ")" + " está ubicado en el CUADRANTE II");
            }
            else if (X < 0 && Y < 0)
            {
                Console.WriteLine("El punto en el plano (" + X + " , " + Y + ")" + " está ubicado en el CUADRANTE III");
            }
            else
            {
                Console.WriteLine("El punto en el plano (" + X + " , " + Y + ")" + " está ubicado en el CUADRANTE IV");
            }

        }

    }
}
