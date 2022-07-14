using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace AplicacionesUnidad2
{
    public partial class Aplicacion4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-Q42SOJ8\\LARRYSALSA;Initial Catalog=Tienda;Integrated Security=True");
            //cn.ConnectionString = @"Data Source=DESKTOP-Q42SOJ8\LARRYSALSA;Initial Catalog=Tienda;Integrated Security=True";
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;

            cmd.CommandText = "spInsertarTablaAlmacen";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = cmd.Parameters.Add("@id_producto", SqlDbType.Int);
            SqlParametros.Value = txtidproducto.Text;

            //SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = cmd.Parameters.Add("@descripcion", SqlDbType.VarChar);
            SqlParametros.Value = txtdescripcion.Text;

            //SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = cmd.Parameters.Add("@cantidad", SqlDbType.Int);
            //SqlParametros.Value = Convert.ToInt32(txtcantidad.Text);
            SqlParametros.Value = txtidproducto.Text;

            int i = cmd.ExecuteNonQuery(); 

            if (i==1)
            {
                txtidproducto.Text = "";
                txtdescripcion.Text = "";
                txtcantidad.Text = "";
                lblMensaje.Text = "Operacion realizada con exito";

            }



            //try //boque try con todas las operaciones
            //{
            //SqlDataReader dr = cmd.ExecuteReader(); ejecutaba el select 

        }
    }
}