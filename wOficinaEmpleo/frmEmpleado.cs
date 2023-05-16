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
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
        }



        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (txtNumeroDocumento.Text != "")
            {
                if (cboTipoDocumento.SelectedIndex != -1)
                {
                    if (txtNombre.Text != "")
                    {
                        if (txtApellido.Text != "")
                        {
                            if (cboNivelEstudio.SelectedIndex != -1)
                            {
                                if (txtTituloObtenido.Text != "")
                                {
                                    try
                                    {


                                        SqlConnection conexion = new SqlConnection("server=LAPTOP-J6U1P8U7;database=dboEmpresa;integrated security=true");
                                        conexion.Open();

                                        DateTime datFechaNacimiento = datFechaDeNacimiento.Value.Date;
                                        clsEmpleado empleado = new clsEmpleado(Convert.ToInt32(txtNumeroDocumento.Text), cboTipoDocumento.Text, txtNombre.Text,
                                            txtApellido.Text, datFechaNacimiento, cboNivelEstudio.Text, txtTituloObtenido.Text);
                                        empleado.insertarDato();
                                        MessageBox.Show("Dato ingresado");

                                        dtgEmpleado.DataSource = empleado;
                                    }
                                    catch (Exception)
                                    {

                                        MessageBox.Show("Digita correctamente el número de la cédula");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Por favor ingrese el Titulo Obtenido");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Por favor ingrese su Nivel de Estudio");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Por favor ingrese su apellido");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor ingrese su nombre");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor ingrese su Tipo de documento");
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese su número de documento");
            }



        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection conexion = new SqlConnection("server=LAPTOP-J6U1P8U7;database=dboEmpresa;integrated security=true");
                conexion.Open();
                clsEmpleado empleado = new clsEmpleado();
                dtgEmpleado.DataSource = empleado.consultarDato();

            }
            catch (Exception)
            {

                MessageBox.Show("Error al consultar el dato");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)

        {
            try
            {
                DateTime datFechaNacimiento = datFechaDeNacimiento.Value.Date;
                SqlConnection conexion = new SqlConnection("server=LAPTOP-J6U1P8U7;database=dboEmpresa;integrated security=true");
                conexion.Open();
                clsEmpleado empleado = new clsEmpleado(Convert.ToInt32(txtNumeroDocumento.Text), cboTipoDocumento.Text, txtNombre.Text,
                    txtApellido.Text, datFechaNacimiento, cboNivelEstudio.Text, txtTituloObtenido.Text);
                empleado.modificarDato();
                MessageBox.Show("Datos modificados");
                dtgEmpleado.DataSource = empleado.consultarDato();
            }
            catch (Exception)
            {

                MessageBox.Show("Error al modificar el dato");
            }
        }

        private void dtgEmpleado_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                txtNumeroDocumento.Text = dtgEmpleado.SelectedRows[0].Cells[0].Value.ToString();
                cboTipoDocumento.Text = dtgEmpleado.SelectedRows[0].Cells[1].Value.ToString();
                txtNombre.Text = dtgEmpleado.SelectedRows[0].Cells[2].Value.ToString();
                txtApellido.Text = dtgEmpleado.SelectedRows[0].Cells[3].Value.ToString();
                datFechaDeNacimiento.Text = dtgEmpleado.SelectedRows[0].Cells[4].Value.ToString();
                cboNivelEstudio.Text = dtgEmpleado.SelectedRows[0].Cells[5].Value.ToString();
                txtTituloObtenido.Text = dtgEmpleado.SelectedRows[0].Cells[6].Value.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Por favor seleccione desde el cuadro de la izquierda al lado del empleado que desea");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("server=LAPTOP-J6U1P8U7;database=dboEmpresa;integrated security=true");
                conexion.Open();
                clsEmpleado empleado = new clsEmpleado();
                empleado.eliminarDato(Convert.ToInt32(txtNumeroDocumento.Text));
                dtgEmpleado.DataSource = empleado.consultarDato();

            }
            catch (Exception)
            {

                MessageBox.Show("Error al eliminar el dato");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            txtNumeroDocumento.Text = "";
            cboTipoDocumento.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            cboNivelEstudio.Text = "";
            txtTituloObtenido.Text = "";


        }
    }
}


