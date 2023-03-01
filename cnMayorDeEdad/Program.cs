using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnMayorDeEdad
{
    /// <summary>
    /// Nombre: Paola Ruiz Osorio 
    /// Fecha: 25/12/2023
    /// Descripción: Validar si la persona es Mayor de edad y en caso de derlo pedir apellidos y correo electronico
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor escriba su primer nombre y segundo nombre en caso de tenerlo");
            String Nombre =Console.ReadLine();
            //Llamar metodo
            ComprobarEdad(Nombre);
            
            Console.ReadKey();
        }
        //Metodo para validar la edad
        public static void ComprobarEdad(String Nombre)
        {
            Console.WriteLine("Por favor ingrese su edad");
            int Edad = Convert.ToInt16( Console.ReadLine());

            //Condicional para comprobar si es mayor de edad y continuar el proceso 
            if (Edad > 0 && Edad<=18)
            {
                Console.WriteLine("Hola " +Nombre+" eres menor de edad,Muchas gracias");
            }
            else if (Edad > 18)
            {
                Console.WriteLine("Hola " + Nombre + " ingresa tus apeliidos");
                String Apellidos = Console.ReadLine();
                Console.WriteLine("Ingresa tu correo");
                String CorreoElectronico = Console.ReadLine();
                Console.WriteLine(Nombre + " tus datos han sido agregados con exito");
            }
            else 
            {
                Console.WriteLine("Por favor ingrese una edad correcta");
            }

        }

    }
}
