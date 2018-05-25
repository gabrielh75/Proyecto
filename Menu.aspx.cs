using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Menu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnRegistrar_Click(object sender, EventArgs e)
    {
        Response.Redirect("Registro.aspx");
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        try
        {
            var sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["DC"].ConnectionString);
            var strSql = "Select * from Estudiantes where Nombre='" + this.txtUsername.Text + "' and Password='"+this.txtPwd+"";
            var cmd = new SqlCommand(strSql, sqlConn);
            var ds = new DataSet();
            var da = new SqlDataAdapter(cmd);

            sqlConn.Open();
            da.Fill(ds, "Estudiantes");
            sqlConn.Close();

            Response.Redirect("Principal.aspx");
        }
        catch (Exception ex)
        {
            this.Label1.Visible = true;
            this.Label1.Text = ex.Message;
        }
    }
}