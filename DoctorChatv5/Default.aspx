<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DoctorChatv5.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      
    <!-- Landing Page -->
    <div class="intro-header">
        <div class="container">
            <div class="row">
                <div class="intro-message col-sm-6">
                   <h1>HABLA CON NUESTROS EXPERTOS</h1>
                   <h2>desde donde estés y cuando lo necesites</h2>
                   <h3>¡REGÍSTRATE YA!</h3>
                   <%--<button onclick="location ='../pages/Registro_1_2.aspx';">--%>
                    <button data-toggle="modal" data-target="#myModal2">
                       Registrarme
                   </button>                  
                </div>
                <img src="images/man_laptop.png" alt="man_laptop.png"/>                  
            </div>
        </div>
    </div>
    <!-- Start Our Services -->
    <div id="our-services">
        <div class="container padding-top padding-bottom">
            <div class="row section-title text-center">
                <div class="col-sm-8 col-sm-offset-2">
                    <h1>
                        <span>¿Cómo</span> funciona?</h1>
                      <p>
                       Recibe atención médica profesional al instante, online y desde donde quiera que estés</p>
       </div>
            </div>
            <div class="row text-center">
                <div class="col-sm-6 col-md-3 service">
                    <div class="service-content">
                        <img class="pasos" src="images/paso1.png" alt="paso1.png"/>
                        <h2>
                            Ingresa a DoctorChat</h2>
                        <p>
                            Regístrate gratis e ingresa desde una computadora o tu dispositivo móvil para poder usar nuestro servicio.</p>
                    </div>
                </div>
            
                    <div class="col-sm-6 col-md-3 service">
                    <div class="service-content">
                        <img class="pasos" src="images/paso2.png" alt="paso2.png"/>
                       <h2>
                            Descarga nuestra App</h2>
                        <p>
                            Descarga la aplicación de DoctorChat para que puedas interactuar con nuestros médicos.</p>
                    </div>
                </div>
                 <div class="col-sm-6 col-md-3 service">
                    <div class="service-content">
                        <img class="pasos" src="images/paso3.png" alt="paso3.png" />
                        <h2>
                            Habla con el médico</h2>
                        <p>
                            Una vez dentro de la aplicación podrás conversar con los doctores por video-llamada o chat.</p>
                    </div>
                </div>
                <div class="col-sm-6 col-md-3 service">
                    <div class="service-content">
                        <img class="pasos" src="images/paso4.png" alt="paso4.png"/>
                        <h2>
                            ¡Siéntente a gusto!</h2>
                        <p>
                           Recibirás una grata atención por parte de nuestro equipo médico, quienes te ayudarán a disipar tus dudas y molestias.
                        </p>
                    </div>
                </div>
                          
            </div>
        </div>       
    </div>
    <!-- /# Our Services -->
    <!-- Slider -->
    <div id="myCarousel" class="carousel slide" data-ride="carousel">
        <!-- Indicators -->
        <ol class="carousel-indicators">
            <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
            <li data-target="#myCarousel" data-slide-to="1"></li>
            <li data-target="#myCarousel" data-slide-to="2"></li>
        </ol>
        <!-- Wrapper for slides -->
        <div class="carousel-inner" role="listbox">
            <div class="item active">
                <img src="images/333.jpg" />
            </div>
            <div class="item">
                <img src="images/444.jpg" />
            </div>
            <div class="item">
                <img src="images/555.jpg" />
                <%--  <div class="carousel-caption">
                    <h2>
                        Slide Three</h2>
                    <h3>
                        Bootstrap is completely free to download and use!</h3>
                </div>--%>
            </div>
        </div>
        <!-- Left and right controls -->
        <a class="left carousel-control" href="#myCarousel" role="button" data-slide="prev">
            <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span><span class="sr-only">
                Previous</span> </a><a class="right carousel-control" href="#myCarousel" role="button"
                    data-slide="next"><span class="glyphicon glyphicon-chevron-right" aria-hidden="true">
                    </span><span class="sr-only">Next</span> </a>
    </div>
    <div class="container padding-bottom" >        
        <div class="row section-title">
            <div class="col-sm-8 col-sm-offset-2" style="width:100%; margin:0; position:relative;">
                <h1 style="text-align:center;">
                    <span>App</span> Móvil</h1>
                   <img class="appmovil" src="images/appmovil.png" alt="doctorchat_app.png"/><div class="textoApp">
                   <h2>EL PODER ESTÁ EN TUS MANOS</h2>
                   <h3>Descarga nuestra aplicación y habla con un especialista por chat o video-consulta desde tu teléfono o tablet.</h3>
                   <h4>No olvides registrarte para poder acceder a nuestros servicios</h4>
                   <a href="https://play.google.com/store/apps"><img class="googlePlay" alt="PlayStore.png" src="http://www.mandados.com.co/images/gplay2.png" /></a>
                   <a href="https://www.apple.com/itunes/"><img class="appStore" alt="AppStore.png" src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTUsIPt-LYYiK-k5CJj1DnHAcjXl6F0gs86b7goxRItJLzgnvHG" /></a>
                 </div><img class="appmovil oculto" src="images/appmovil.png" alt="doctorchat_app.png"/>
                
            </div>
        </div>
      <!--/our-clients -->
    </div>
    
    
</asp:Content>
