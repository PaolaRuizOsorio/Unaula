using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnTemperatura
{
    /// <summary>
    /// Nombre:Paola Ruiz Osorio
    /// Fecha: 25/02/2023
    /// Descripción:Conversion de temperaturas entre Farenheit y Celsius
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor ingrese la temperatura");
            double Temperatura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Marque el tipo de temperatura que ingreso");
            Console.WriteLine("Para Celsius marque 1");
            Console.WriteLine("Para Farenheit marque 2");
            
            int Dato = Convert.ToInt32(Console.ReadLine());
            // Escoger el tipo de grados registrados, y en su debido caso hacer la conversion invocando los metodos
            switch (Dato)
            {
                case 1:
                    Console.WriteLine("La temperatura convertida a Farenheit es de : " + ValidarFarenheit(Temperatura)+" °");
                        break;
                case 2:
                    Console.WriteLine("La temperatura convertida a Celsius es de : " + ValidarCelsius(Temperatura)+" °");
                        break;
            
            }
            Console.ReadKey();
        }
        //Metodo cambio de Celsius a Farenheit
        static double ValidarCelsius(Double Temperatura)

        {
            Double Celsius;
            Celsius = (Temperatura - 32) / 1.8;
            return Celsius;
        }
        //Metodo cambio de Farenheit a Celsius 
        static double ValidarFarenheit(Double Temperatura)
        {
            Double Farenheit;
            Farenheit = (Temperatura * 1.8) + 32;
            return Farenheit;
        }
    }
}
