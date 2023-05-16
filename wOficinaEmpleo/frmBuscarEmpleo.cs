using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace wOficinaEmpleo
{
    /// <summary>
    /// Nombre: Jhonatan Mosquera Moreno- Paola Ruiz Osorio
    /// Fecha: 16/05/2023
    /// Descripción: Aplicación de registro para personas que buscan empleo 
    /// </summary>
    public partial class frmBuscarEmpleo : Form
    {
        public frmBuscarEmpleo()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=LAPTOP-J6U1P8U7;database=dboEmpresa;integrated security=true");
            conexion.Open();
            if (txtConsulta.Text == "")
            {
                string query = "select * from tblEmpleo";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dtgBuscarEmpleo.DataSource = tabla;

            }
            else
            {
                string query = "select *  from tblEmpleo where intCodigo = '" + txtConsulta.Text + "'";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dtgBuscarEmpleo.DataSource = tabla;
            }
            if (txtConsulta.Text != "1" && txtConsulta.Text != "2" && txtConsulta.Text != "3" && txtConsulta.Text != "4" && txtConsulta.Text != "5" && txtConsulta.Text != "6")
            {
                MessageBox.Show("El empleo no está registrado, los empleos que tenemos disponibles en el momento se encuentran en la lista");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtConsulta.Text = "";
        }
    }
}
