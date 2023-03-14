using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wLinea
{
    class clsLinea
    {
        //Definimos las variables
        private int xInicial;
        private int xFinal;
        private int yInicial;
        private int yFinal;

        private static int contar = 0;

        //Inicializamos las variables
        public clsLinea()
        {
            xInicial = 0;
            xFinal = 0;
            yInicial = 0;
            yFinal = 0;
        }
        //Sobrecarga de metodos
        public clsLinea(int xInicial, int xFinal, int yInicial, int yFinal)
        {
            this.xInicial = xInicial;
            this.xFinal = xFinal;
            this.yInicial = yInicial;
            this.yFinal = yFinal;
        }

        public clsLinea(double XInicial, double XFinal, double YInicial, double YFinal)
        {
            this.xInicial = (int)XInicial;
            this.xFinal = (int)XFinal;
            this.yInicial = (int)YInicial;
            this.yFinal = (int)YFinal;
        }

        //Metodos para obtener variables 
        #region 

        public int obtenerXInicial()
        {
            return xInicial;
        }

        public int obtenerXFinal()
        {
            return xFinal;
        }

        public int obtenerYInicial()
        {
            return yInicial;
        }

        public int obtenerYFinal()
        {
            return yFinal;
        }

        #endregion
        //Metodos para cambar posicion de variables 
        #region
        public void cambiarXInicial(int xInicial)
        {
            this.xInicial = xInicial;
        }

        public void cambiarXFinal(int xFinal)
        {
            this.xFinal = xFinal;
        }

        public void cambiarYInicial(int yInicial)
        {
            this.yInicial = yInicial;
        }

        public void cambiarYFinal(int yFinal)
        {
            this.yFinal = yFinal;
        }
        #endregion

        //Contar de manera incrementada las veces que creamos una línea
        public static int obtenerCuenta()
        {
            contar += 1;
            return contar;
        }
    }
}
