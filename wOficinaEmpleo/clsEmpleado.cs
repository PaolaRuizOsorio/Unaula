using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace wOficinaEmpleo
{
    /// <summary>
    /// Nombre: Jhonatan Mosquera Moreno- Paola Ruiz Osorio
    /// Fecha: 16/05/2023
    /// Descripción: Aplicación de registro para personas que buscan empleo 
    /// </summary>
    internal class clsEmpleado
    {
        public string strTipoDocumento { get; set; }
        public int intNumeroDocumento { get; set; }
        public string strNombre { get; set; }
        public string strApellido { get; set; }
        public string strDia { get; set; }
        public string strMes { get; set; }
        public string strAno { get; set; }
        public DateTime datFechaNacimiento { get; set; }
        public string strNivelEstudio { get; set; }
        public string strTituloObtenido { get; set; }

        public clsEmpleado()
        {
        }

        public clsEmpleado(int intNumeroDocumento, string strTipoDocumento, string strNombre, string strApellido,DateTime datFechaNacimiento, string strNivelEstudio, string strTituloObtenido)
        {
            this.intNumeroDocumento = intNumeroDocumento;
            this.strTipoDocumento = strTipoDocumento;
            this.strNombre = strNombre;
            this.strApellido = strApellido;
            this.datFechaNacimiento = datFechaNacimiento;
            this.strNivelEstudio = strNivelEstudio;
            this.strTituloObtenido = strTituloObtenido;
        }
        public bool insertarDato()
        {
            SqlConnection conexion = new SqlConnection("server=LAPTOP-J6U1P8U7;database=dboEmpresa;integrated security=true");
            conexion.Open();
            string insertar = "insert into tblEmpleado values (@intNumeroDocumento,@strTipoDocumento,@strNombre,@strApellido," +
                "@datFechaNacimiento,@strNivelEstudio,@strTituloObtenido)";
            SqlCommand sql = new SqlCommand(insertar, conexion);
            sql.Parameters.AddWithValue("@intNumeroDocumento", this.intNumeroDocumento);
            sql.Parameters.AddWithValue("@strTipoDocumento", this.strTipoDocumento);
            sql.Parameters.AddWithValue("@strNombre", this.strNombre);
            sql.Parameters.AddWithValue("@strApellido", this.strApellido);
            sql.Parameters.AddWithValue("@datFechaNacimiento", this.datFechaNacimiento);
            sql.Parameters.AddWithValue("@strNivelEstudio", this.strNivelEstudio);
            sql.Parameters.AddWithValue("@strTituloObtenido", this.strTituloObtenido);
            sql.ExecuteNonQuery();
            return true;
        }
        public DataTable consultarDato()
        {
            SqlConnection conexion = new SqlConnection("server=LAPTOP-J6U1P8U7;database=dboEmpresa;integrated security=true");
            conexion.Open();
            DataTable dt = new DataTable();
            string consulta = "select * from tblEmpleado";
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            return dt;
        }
        public bool modificarDato()
        {

            SqlConnection conexion = new SqlConnection("server=LAPTOP-J6U1P8U7;database=dboEmpresa;integrated security=true");
            conexion.Open();
            string modificar = "update tblEmpleado set intNumeroDocumento = @intNumeroDocumento,strTipoDocumento = @strTipoDocumento," +
                "strNombre = @strNombre,strApellido = @strApellido,datFechaNacimiento = @datFechaNacimiento," +
                "strNivelEstudio = @strNivelEstudio,strTituloObtenido = @strTituloObtenido where intNumeroDocumento =@intNumeroDocumento";

            SqlCommand sql = new SqlCommand(modificar, conexion);
            sql.Parameters.AddWithValue("@intNumeroDocumento", this.intNumeroDocumento);
            sql.Parameters.AddWithValue("@strTipoDocumento", this.strTipoDocumento);
            sql.Parameters.AddWithValue("@strNombre", this.strNombre);
            sql.Parameters.AddWithValue("@strApellido", this.strApellido);
            sql.Parameters.AddWithValue("@datFechaNacimiento", this.datFechaNacimiento);
            sql.Parameters.AddWithValue("@strNivelEstudio", this.strNivelEstudio);
            sql.Parameters.AddWithValue("@strTituloObtenido", this.strTituloObtenido);
            sql.ExecuteNonQuery();
            return true;
        }

        public bool eliminarDato(int intNumeroDocumento)
        {
            SqlConnection conexion = new SqlConnection("server=LAPTOP-J6U1P8U7;database=dboEmpresa;integrated security=true");
            conexion.Open();


            this.intNumeroDocumento = intNumeroDocumento;
            string eliminar = "Delete tblEmpleado where intNumeroDocumento=@intNumeroDocumento";
            SqlCommand sql = new SqlCommand(eliminar, conexion);
            sql.Parameters.AddWithValue("@intNumeroDocumento", this.intNumeroDocumento);
            sql.ExecuteNonQuery();
            return true;
        }
        public DataTable seleccionarDato()
        {
            SqlConnection conexion = new SqlConnection("server=LAPTOP-J6U1P8U7;database=dboEmpresa;integrated security=true");
            conexion.Open();

            this.intNumeroDocumento = intNumeroDocumento;
            DataTable dt = new DataTable();
            string seleccionar = "select * from tblEmpresa where intNumeroDocumento = @intNumeroDocumento = @intNumeroDocumento";
            SqlCommand cmd = new SqlCommand(seleccionar, conexion);
            cmd.Parameters.AddWithValue("@intNumeroDocumento", this.intNumeroDocumento);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }

}
