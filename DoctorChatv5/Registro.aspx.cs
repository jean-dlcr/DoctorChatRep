using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DoctorChatv5
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cad = "Acepto haber leído los ";
            chkTerminos.Text = cad + "<a href='#' class='linkTerm' data-toggle='modal' data-target='#modalTerm'>" + " términos y condiciones" + "</a>" + " .";
            string reg = Request.QueryString["reg"];
            if (!reg.Equals("true"))

                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('ya fuiste papu')", true);


            if (!IsPostBack)
            {
                List<String> lst = new List<string>();
                lst.Add("MASCULINO");
                lst.Add("FEMENINO");
                dbBoxSexo.DataSource = lst;
                dbBoxSexo.DataBind();     
                
            }
        }

        protected void lnkBtnSesion_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx?logIn=true");
           
        }

        protected void lnkBtnReg_Click(object sender, EventArgs e)
         {
            string cad = "";
            if (chkTerminos.Checked  && !String.IsNullOrEmpty(txtNombre.Text) && !String.IsNullOrEmpty(txtApellidos.Text) && !String.IsNullOrEmpty(txtDniReg.Text) && !String.IsNullOrEmpty(txtDia.Text) && !String.IsNullOrEmpty(txtAño.Text) && dpBoxMes.SelectedIndex !=0 && dbBoxSexo.SelectedIndex != 0)
            {
                cad = "'" + txtDniReg.Text + "','" + txtNombre.Text + "','" + txtApellidos.Text + Session["cadena"] + dbBoxSexo.SelectedItem.Text + "','" + txtDia.Text + "/" + dpBoxMes.SelectedItem.Text + "/" + txtAño.Text + "',' ',''";
             }

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            SqlCommand sql = new SqlCommand();
            con.Open();
            SqlTransaction tran = con.BeginTransaction();
            SqlDataAdapter adapter = new SqlDataAdapter();

            try
            {
                sql.Connection = con;
                sql.CommandText = "Insert into dbo.Persona(Dni,Nombre,Apellidos,Correo,Pass,Sexo,Nac,Dir,Telef) values( " + cad + ")";
                sql.Transaction = tran;
                sql.ExecuteNonQuery();
                tran.Commit();
                Response.Redirect("Bienvenido.aspx?logIn=successful");
                

            }
            catch (Exception ex) { tran.Rollback(); }
        }
    }
}