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
    public partial class Aplicacion2a : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { 
            if (IsPostBack == false)
        {
            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-Q42SOJ8\\LARRYSALSA;Initial Catalog=Tienda;Integrated Security=True");
         cn.Open();
                SqlCommand cmd = new SqlCommand("Select * from TablaVentas", cn);

                SqlDataReader dr = cmd.ExecuteReader();

                ddlTablaTotales.DataSource = dr;

                ddlTablaTotales.DataTextField = "id_venta";
                ddlTablaTotales.DataValueField = "id_producto";

                ddlTablaTotales.DataBind();
                cn.Close();

        }
        }
    }
    }
