using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Fecha:14/03/2023
/// Autor:Paola Ruiz Osorio
/// Descripción: Aplicación de dibujar línea
/// </summary>
namespace wLinea
{
    public partial class frmDibujarLinea : Form
    {
        //Constante
        //public const int ANCHO = 5;
        Graphics linea;

        public frmDibujarLinea()
        {
            InitializeComponent();
            linea = CreateGraphics();
        }

        private void btnDibujarLinea_Click(object sender, EventArgs e)
        {
            try
            {
                //Conversion
                double xInicial = double.Parse(txtXInicial.Text);
                double xFinal = double.Parse(txtXFinal.Text);
                double yInicial = double.Parse(txtXInicial.Text);
                double yFinal = double.Parse(txtYFinal.Text);

                //Instanciamos la clase
                clsLinea line = new clsLinea(xInicial, xFinal, yInicial, yFinal);
                Pen pen = new Pen(Color.White);
                //Dibujo linea
                linea.DrawLine(pen, line.obtenerXInicial(), line.obtenerXFinal(), line.obtenerYInicial(), line.obtenerYFinal());
               
                 
                //Mostrar la cuenta del contador 
                txtResultado.Text = Convert.ToString(clsLinea.obtenerCuenta());
            }
            catch 
            {

                MessageBox.Show("Digite por favor un valor tipo numerico");
            }
        }
    }
}
