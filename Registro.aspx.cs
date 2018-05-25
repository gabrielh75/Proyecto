using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Registro : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void BtnEnviar_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.txtPass.Text == this.txtConfPass.Text)
            {
                var sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["DC"].ConnectionString);
                var strSQL = "Insert Into Estudiantes (Nombre,Apellidos,Ano,Colegio,Password) Values ('" + this.txtNombre.Text + "','" + this.txtApellido.Text + "','" + this.txtAño.Text + "','" + this.txtColegio.Text + "','" + this.txtPass.Text + "')";
                var cmd = new SqlCommand(strSQL, sqlConn);
                sqlConn.Open();
                cmd.ExecuteNonQuery();
                sqlConn.Close();
                this.txtNombre.Text = "";
                this.txtApellido.Text = "";
                this.txtAño.Text = "";
                this.txtColegio.Text = "";
                this.txtPass.Text = "";
                this.txtConfPass.Text = "";
            }
            else
            {
                this.Label1.Visible = true;
                this.Label1.Text = "Error de confirmación de contraseña";
            }

            Server.Transfer("ConfirmarRegistro.aspx?Nombre=" + txtNombre.Text + "&Apellido=" + txtApellido.Text + "&Colegio=" + txtColegio.Text + "&Password=" + txtPass.TextMode);
        }
        catch(Exception ex)
        {
            this.Label1.Visible = true;
            this.Label1.Text = ex.Message;
        }
        
    }
}