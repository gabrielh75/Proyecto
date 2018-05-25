<%@ Page Title="" Language="C#" MasterPageFile="~/Proyecto/Master1.master" AutoEventWireup="true" CodeFile="Registro.aspx.cs" Inherits="Registro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form>
        
    <div>
        <br />
        Nombre: <asp:TextBox ID="txtNombre" runat="server" style="margin-top: 50px"></asp:TextBox>
        <br />
        Apellido:
        <asp:TextBox ID="txtApellido" runat="server" style="margin-top: 27px"></asp:TextBox>
        <br />
        Año:
        <asp:TextBox ID="txtAño" runat="server" style="margin-left: 21px; margin-top: 27px"></asp:TextBox>
        <br />
        Colegio: <asp:TextBox ID="txtColegio" runat="server" style="margin-left: 3px; margin-top: 27px"></asp:TextBox>
        <br />
        Password:
        <asp:TextBox ID="txtPass" runat="server" style="margin-top: 28px" TextMode="Password"></asp:TextBox>
        <br />
        Confirmar Password:
        <asp:TextBox ID="txtConfPass" runat="server" style="margin-top: 28px" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label" ForeColor="Red" Visible="false"></asp:Label>
        <br />
        <asp:Button ID="BtnEnviar" runat="server" OnClick="BtnEnviar_Click" Text="Enviar" />
    
    </div>
    </form>
</asp:Content>

