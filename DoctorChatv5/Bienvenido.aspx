<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Bienvenido.aspx.cs" Inherits="DoctorChatv5.Bienvenido" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    BIENVENIDO <asp:Label runat="server" ID="lblUsuario"></asp:Label><br />
    <asp:LinkButton runat="server"  Text="Salir"></asp:LinkButton>
</asp:Content>
