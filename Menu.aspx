<%@ Page Title="" Language="C#" MasterPageFile="Master1.master" AutoEventWireup="true" CodeFile="Menu.aspx.cs" Inherits="Menu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id ="divheader">


    </div>
    <div id ="divleft">


    </div>

    <div id ="divcenter">
        <div>
           <center><h3><asp:Label ID="LabelHeader" runat="server" Text="Bienvenido a tu campus United Educate"></asp:Label></ </h3></center> 
        </div>
        <center>
            <form id="form1" >
                    <div id ="divUsername">
                    <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control"  placeHolder="Username"></asp:TextBox>
                    </div>
                    </br>
                    <div id ="divPwd">
                      <asp:TextBox ID="txtPwd" runat="server" TextMode="Password" CssClass="form-control" placeHolder="Password"></asp:TextBox>
                    </div>
                    <div id ="remenber">
                        <asp:CheckBox ID="ChkRemenber" runat="server" />
                        <asp:Label ID="LblMessage" runat="server" Text="Recuerdame"></asp:Label>
                    </div>
                    <br />
                    <asp:Label ID="Label1" runat="server" Text="Label" ForeColor="Red" Visible="false"></asp:Label>
                    <div id ="buttondiv">
                        <asp:Button ID="btnLogin"  CssClass="form-control" runat="server" Text="Login" OnClick="btnLogin_Click" />
                        <asp:Button ID="btnRegistrar"  CssClass="form-control" runat="server" Text="Registrar" OnClick="btnRegistrar_Click" style="margin-left: 15px" />
                    </div>
            </form>
        </center>
    </div>
    <div id ="divRight">

        
    </div>
    <div id ="divSubFooter">
        

    </div>
    <div id ="divFooter">
        <asp:Label ID="Lblfooter" runat="server" Text="Copyrigth Minedu 2017"></asp:Label>

    </div>
    </asp:Content>
