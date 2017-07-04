<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Doctores.aspx.cs" Inherits="DoctorChatv5.Doctores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="intro-header medicos">
        <div class="container">
            <div class="row">
                <div class="intro-message col-sm-6">
                   <h1>NUESTRO EQUIPO LISTO PARA AYUDARTE</h1>
                   <h2>Contamos con doctores en línea calificados para atender las dolencias más comunes a través de video-consultas, con diagnósticos confiables</h2>
                   <h3>¡REGÍSTRATE YA!</h3>
                                
                </div>
                <div class="fondoMedico">
                <img class="equipo" src="https://neurobia.com/wp-content/uploads/2016/10/m%C3%A9dicos.jpg" alt="equipo_medico.png"/>   </div>
            </div>
        </div>
    </div>

     <div id="our-services">
        <div class="container padding-top padding-bottom">
            <div class="row section-title text-center">
                <div class="col-sm-8 col-sm-offset-2">
                    <h1>
                        <span>Nuestros</span> Médicos</h1>
                      <p>
                       Contamos con doctores en línea calificados para atender las dolencias más comunes a través de video-consultas</p>
       </div>
            </div>
            <div class="row text-center">
                <asp:SqlDataSource ID="sqlAll" runat="server" ConnectionString='<%$ ConnectionStrings:ConnectionString %>' SelectCommand="SELECT * FROM [Doctores]"></asp:SqlDataSource>
            <asp:Repeater ID="rptDoc" runat="server">
                <ItemTemplate>
                <div class="col-sm-6 col-md-3 service">
                    <div class="service-content">
                 
                     <asp:LinkButton runat="server" CommandName="btnDoctor" CommandArgument='<%#DataBinder.Eval(Container.DataItem,"id")%>'>                
                    <img src="<%#DataBinder.Eval(Container.DataItem,"foto") %>" width="200" height="300" />
                    </asp:LinkButton> 
                   
                    <label> <%#DataBinder.Eval(Container.DataItem,"nombre") %>&nbsp;<%#DataBinder.Eval(Container.DataItem,"apellidos") %></label><br /><label>CMP: <%#DataBinder.Eval(Container.DataItem,"id") %></label>
                      </div>                        
                </div>
                </ItemTemplate>
            </asp:Repeater>   

           
            <div style="text-align: center; position:absolute; bottom:0;left:0;;right:0;">
        <ul class="pagination" style="margin: auto;">
            <asp:Repeater ID="rpPaging" runat="server" OnItemDataBound="rpPaging_ItemDataBound">
                <ItemTemplate>
                    <asp:HiddenField ID="hdValue" Value='<%# Eval("CrrPage") %>' runat="server" />
                    <li class='<%# Eval("Acitve") %>'>
                        <asp:LinkButton Style="border-radius: 0" ID="btnPageChange" OnClick="btnPageChange_Click" runat="server"><%# Eval("CrrPage") %></asp:LinkButton>
                    </li>
                </ItemTemplate>
            </asp:Repeater>
        </ul>
    </div>       
           
        </div>       
    </div>
         </div>

</asp:Content>
