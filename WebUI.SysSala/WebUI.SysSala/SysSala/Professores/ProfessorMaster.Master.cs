using SysSala.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebUI.SysSala.SysSala.Professores
{
    public partial class ProfessorMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var usu = UsuarioBLL.BuscarPorId(Convert.ToInt32(Session["UsuarioId"]));

                if (usu != null)
                {
                    lblUsuario.Text = "Bem vindo Professor(a) " + usu.Pessoa.Nome + "";
                }
                
            }
        }
    }
}