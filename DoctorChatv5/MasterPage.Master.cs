using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using System.Web.Caching;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DoctorChatv5
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
       
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                
                string cad = "";
                cad = Request.QueryString["logIn"];
                if (cad == "true")
                {
                    Prender1();
                    
                }
            }

        }



        //OBTENER TXTBOX

        public String GetTxt_correo
        {
            get
            {
                return txtCorreoReg.Text;
            }
        }
        //##############################

        public String getTxt_clave
        {
            get
            {
                return txtPassReg.Text;

            }
        }
        //##############################
        public String getTxt_confClave
        {
            get
            {
                return txtConfirmarPassReg.Text;
            }
        }
        //###############################

        protected void NavISbtn_Click(object sender, EventArgs e)
        {
            Prender1();
        }

        protected void NavRegbtn_Click(object sender, EventArgs e)
        {
            Limpiar();
            Apagartodo();
            Prender2();

        }

        protected void LnkBtnReg_Click(object sender, EventArgs e)
        {
            Apagartodo();
            Prender2();
        }

        protected void LnkBtnIniAhora_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(GetTxt_correo + getTxt_clave + getTxt_confClave))
            {
                Limpiar();
            }

            Apagartodo();
            Prender1();
        }

        protected void LnkBtnCerrar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Apagartodo();
        }



        protected void LnkSgt_Click(object sender, EventArgs e)
        {
            string cad = "";
            string insert = "";
            if (String.IsNullOrEmpty(GetTxt_correo) || String.IsNullOrEmpty(getTxt_clave) || String.IsNullOrEmpty(getTxt_confClave))
            { cad = "*Rellene los campos para continuar."; }
            
            else if (!getTxt_clave.Equals(getTxt_confClave))
            {
                cad = "La contraseña no coincide con su confirmación";
            }
            else if (!String.IsNullOrEmpty(GetTxt_correo) && !String.IsNullOrEmpty(getTxt_clave) && !String.IsNullOrEmpty(getTxt_confClave)) {
                if (!GetTxt_correo.Contains('@'))
                {
                    cad = "* Correo inválido";
                }

                else if (getTxt_clave.Equals(getTxt_confClave))
                {
                    insert = "','" + GetTxt_correo + "','" + getTxt_clave + "','";
                    Session["cadena"] = insert;

                    Response.Redirect("Registro.aspx?reg=true");
                }
            }
            
            Apagartodo();
            lblMsggError.Text = cad;
            Prender2();
        }

        public void Limpiar()
        {

            txtCorreoReg.Text = "";
            txtPassReg.Text = "";
            txtConfirmarPassReg.Text = "";
            lblMsggError.Text = "";
        }

        public void Prender1()
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "prender", "ShowPopup();", true);

        }

        public void Prender2()
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "prender", "ShowPopupD();", true);

        }
        public void Apagartodo()
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "apagar", "Apagar();", true);
        }



        protected void LbtnIniciar_Click(object sender, EventArgs e)
        {
            string cad = "";
            if (String.IsNullOrEmpty(txtDNI.Text) || String.IsNullOrEmpty(txtClave.Text)) {
               cad = "* Rellene los campos para continuar";

            }
            else { 

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand();
            DataTable tabla = new DataTable();
            try
            {
                adapter.SelectCommand.Connection = con;
                adapter.SelectCommand.CommandText = "select Dni,Nombre,Pass from Persona where Dni =" + int.Parse(txtDNI.Text) + "";
                adapter.Fill(tabla);

                if (tabla.Rows.Count == 1)
                {
                    if (!tabla.Rows[0][2].ToString().Equals(txtClave.Text))
                    {
                        cad = "* Contraseña incorrecta";
                    }
                    else { Response.Redirect("Bienvenido.aspx?st=1"); }
                }
                else {cad = "* Usuario no existe. Regístrese para continuar"; }
            }
            catch (Exception ex)
            {

            }
            }
            
            Apagartodo();
            lblError.Text = cad;
            Prender1();
        }

        //public static explicit operator MasterPage(Page v)
        //{
        //    throw new NotImplementedException();
        //}
        }




}
