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
    public partial class Aplicacion1b : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                SqlConnection cn = new SqlConnection("Data Source=DESKTOP-Q42SOJ8\\LARRYSALSA;Initial Catalog=Tienda;Integrated Security=True");
                //cn.ConnectionString = @"Data Source=DESKTOP-Q42SOJ8\LARRYSALSA;Initial Catalog=Tienda;Integrated Security=True";
                cn.Open();
                SqlDataAdapter adap = new SqlDataAdapter(" Select * from TablaVentas ", cn);

                DataSet ds = new DataSet();
                adap.Fill(ds, "TablaVentas");

                grdTablaAlmacen.DataSource = ds.Tables["TablaVentas"];
                grdTablaAlmacen.DataBind();

            }

        }
    }
}