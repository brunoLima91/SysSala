using SysSala.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebUI.SysSala.SysSala.Professores
{
    public partial class MinhasReservas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["UsuarioId"] == null)
            {
                Response.Redirect("~/",true);
            }
            if (!IsPostBack)
            {
                PopularGrid();
            }

     
        }

        private void PopularGrid()
        {
            var lReservasAux = ReservaSalaBLL.Listar().ToList();

            if ( !String.IsNullOrEmpty(Session["UsuarioId"].ToString()))
            {
                gdvReservas.DataSource = lReservasAux.Where(x => x.Turma.Professor.Id == Convert.ToInt32(Session["UsuarioId"]));
            }else
            {
                gdvReservas.DataSource = lReservasAux;
            }
            
            gdvReservas.DataBind();
        }
    }
}