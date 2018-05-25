using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Proyecto_ConfirmarRegistro : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["Nombre"] != null)
        {
            lblNombre.Text = Request.Params["Nombre"];
        }
        if (Request.Params["Apellido"] != null)
        {
            lblApellido.Text = Request.Params["Apellido"];
        }
        if (Request.Params["Password"] != null)
        {
            if (Request.Params["Password"] == Request.Params["ConfirmPassword"])
            {
                txtbPass.Text = Request.Params["Password"];
            }
            else
            {
                txtbPass.Text = "Error de Password";
            }
        }
    }

    protected void BtnInicio_Click(object sender, EventArgs e)
    {
        Response.Redirect("Menu.aspx");
    }
}