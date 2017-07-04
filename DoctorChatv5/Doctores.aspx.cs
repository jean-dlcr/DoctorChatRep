using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DoctorChatv5;
using System.Data;
using Pagination;

namespace DoctorChatv5
{
    public partial class Doctores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataView dv = sqlAll.Select(DataSourceSelectArguments.Empty) as DataView;
            DataTable dt = dv.ToTable() as DataTable;
            Doctor refDoc;

            if (!IsPostBack)
            {
                List<Doctor> lst = new List<Doctor>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    refDoc = new Doctor(int.Parse(dt.Rows[i][0].ToString()),
                                        dt.Rows[i][1].ToString(),
                                        dt.Rows[i][2].ToString(),
                                        dt.Rows[i][3].ToString(),
                                        dt.Rows[i][4].ToString(),
                                        dt.Rows[i][5].ToString(),
                                        dt.Rows[i][6].ToString(),
                                        dt.Rows[i][7].ToString(),
                                        dt.Rows[i][8].ToString());
                    lst.Add(refDoc);
                }

                int ItemPerPage = 4;
                rptDoc.DataSource = lst.ToPaging(Request.QueryString["page"], ItemPerPage);
                rptDoc.DataBind();

                rpPaging.DataSource = GetListPage.GetList(lst.Count, Request.QueryString["page"], ItemPerPage);
                rpPaging.DataBind();
            }

            rptDoc.ItemCommand += new RepeaterCommandEventHandler(rptDoc_ItemCommand);
        }

        protected void rptDoc_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "btnDoctor")
            {
                string idDoctor = ((LinkButton)e.CommandSource).CommandArgument;
                Response.Redirect("doctor.aspx?id=" + idDoctor);
            }
        }


        protected void btnPageChange_Click(object sender, EventArgs e)
        {
            var btn = (LinkButton)sender;
            var item = (RepeaterItem)btn.NamingContainer;
            var iPage = (item.FindControl("hdValue") as HiddenField).Value;
            string url = HttpContext.Current.Request.Url.AbsoluteUri;
            if (url.IndexOf("?") > 0)
            {
                url = url.Substring(0, url.IndexOf("?"));
            }
            Response.Redirect(url + "?page=" + iPage);
        }

        protected void rpPaging_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            RepeaterItem item = e.Item;
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                var btn = (LinkButton)item.FindControl("btnPageChange");
                var hdValue = (HiddenField)item.FindControl("hdValue");
                if (hdValue.Value == "-1")
                {
                    btn.Text = "...";
                    btn.Enabled = false;
                }
            }
        }
    }
}