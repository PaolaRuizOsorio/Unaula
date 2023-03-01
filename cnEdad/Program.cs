using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnEdad
{
    /// <summary>
    /// Nombre: Paola Ruiz Osorio
    /// Fecha: 25/02/2023
    /// Descripción: Validar si es mayor o menor de edad
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Buenas tardes");
            //Llamar metodo 
            CargarDatos();
            Console.ReadKey();
        }
        //Creacion del metodo 
        public static void CargarDatos()
        {
            Console.WriteLine("Por favor ingrese su nombre");
            String Nombre = Console.ReadLine();
            Console.WriteLine("Por favor ingrese su edad");
            int Edad = Convert.ToInt32(Console.ReadLine());

            if (Edad<=0)
            {
                Console.WriteLine("Ingrese una edad correcta");
            }
            else if (Edad>0  && Edad<=18)
            {
                Console.WriteLine("Hola "+Nombre+" eres menor de edad");
            }
            else
            { 
                Console.WriteLine("Hola " + Nombre + " eres mayor de edad"); 
            }
        }
       


    }
}
