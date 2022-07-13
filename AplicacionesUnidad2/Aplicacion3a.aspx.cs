using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace AplicacionesUnidad2
{
    public partial class Aplicacion3a : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)


        {
            if (IsPostBack == false)
            {
                SqlConnection cn = new SqlConnection("Data Source=DESKTOP-Q42SOJ8\\LARRYSALSA;Initial Catalog=Tienda;Integrated Security=True");
                //cn.ConnectionString = @"Data Source=DESKTOP-Q42SOJ8\LARRYSALSA;Initial Catalog=Tienda;Integrated Security=True";
                cn.Open();

                SqlCommand cmd = new SqlCommand("Select * from TablaAlmacen", cn);
                //try //boque try con todas las operaciones
                //{
                SqlDataReader dr = cmd.ExecuteReader();

                //}
                // catch (Exception ex)
                //{
                //string error = ex.Message; //acción para manejar el error
                //}
                //ddlTablaAlmacen.DataSource = dr;
                //ddlTablaAlmacen.DataBind();
                while (dr.Read())
                {

                    ddlTablaAlmacen.Items.Add(dr["id_producto"]+""+ dr["descripcion"]);

                }
                cn.Close();


                //cmd.CommandText = "Select * from TablaAlmacen";
                //cmd.Connection = cn;
            }

        }
    }
}