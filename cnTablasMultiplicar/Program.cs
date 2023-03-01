using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnTablasMultiplicar
{
    /// <summary>
    /// Nombre: Paola Ruiz Osorio
    /// Fecha: 25/02/2023
    /// Descripcion: Creacion de tablas de multiplicar
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inicializamos la variable
            int Numero = 0;
            MultiplicarNumero(Numero);
            
        }
       
        static void MultiplicarNumero(int Numero)
        {
            //Ciclo para finalizar el proceso
            while (Numero != -1)
            {
                //Ciclo para la creacion de la tabla de multiplicar 
                if (Numero != -1)
                {
                    Console.WriteLine("Ingrese el número del cual desea la tabla de multiplicar");
                    Numero = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("La Tabla de Multiplicar del " + Numero + " es:");

                    //Creacion
                    for (int i = 1; i <= 10; i++)
                    {
                        int Resultado = (Numero * i);
                        Console.WriteLine(Numero + "x" + i + "=" + Resultado);
                    }
                    Console.WriteLine("Si desea cerrar presione -1, si no ingrese el nuevo número que deses multiplicar");
                }
                
               else
                {
                    Console.ReadKey();
                }
                
            }
            
        }
    }

}
