using SysSala.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebUI.SysSala
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //SysSalaSystem.CargaInicial();
            SysSalaSystem.Horarios();
            //var lSalas = SalaBLL.Listar();
        }
    }
}