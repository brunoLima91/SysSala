using SysSala.BLL;
using SysSala.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebUI.SysSala.SysSala.Professores
{
    public partial class SolicitarReserva : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UsuarioId"] == null)
            {
                Response.Redirect("~/", true);
            }
            if (!IsPostBack)
            {
                CarregarCombos();
            }

        }

        public void CarregarCombos()
        {
            var lUuario = UsuarioBLL.BuscarPorId(Convert.ToInt32(Session["UsuarioId"]));
            var lProfessor = ProfessorBLL.Listar().Where(x => x.Id == lUuario.Pessoa.Id).FirstOrDefault();

            ddlTurma.DataSource = lProfessor.Turmas;
            ddlTurma.DataBind();
            ddlTurma.Items.Insert(0, new ListItem("Selecione", "0"));


            ddlDia.DataSource = Enum.GetNames(typeof(EDiaSemana));
            ddlDia.DataBind();
            ddlDia.Items.Insert(0, new ListItem("Selecione", "0"));

            ddlHorarioAula.Items.Clear();
            ddlHorarioAula.Items.Insert(0, new ListItem("Selecione", "0"));
        }

        protected void ddlDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlDia.SelectedValue != "0")
            {
                EDiaSemana dia = (EDiaSemana)Enum.Parse(
                    typeof(EDiaSemana), ddlDia.SelectedValue);

                ddlHorarioAula.Items.Clear();
                ddlHorarioAula.DataSource = HorarioAulaBLL.BuscarPorDiaSemana(dia)
                    .OrderBy(x=> x.HoraInicio);
                ddlHorarioAula.DataBind();
                ddlHorarioAula.Items.Insert(0, new ListItem("Selecione", "0"));

            }
            else
                ddlHorarioAula.SelectedIndex = 0;

        }

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {
            pnlReservas.Visible = true;
            PopularGrid();
        }

        public void PopularGrid()
        {

            var lReservasAux = ReservaSalaBLL.Listar().ToList();

            if (ddlHorarioAula.SelectedValue != "0")
                lReservasAux = lReservasAux.Where(x => x.HorarioAula.Id != Convert.ToInt32(ddlHorarioAula.SelectedValue))
                    .ToList();
            
            if (ddlTurma.SelectedValue != "0")
                lReservasAux = lReservasAux.Where(x => x.Turma.Id == Convert.ToInt32(ddlTurma.SelectedValue))
                    .ToList();            

            gdvSalas.DataSource = lReservasAux.Select(x=> x.Sala)
                .ToList()
                .Distinct();
            gdvSalas.DataBind();
        }
        
    }
}