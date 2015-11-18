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

            //var lReservasAux = ReservaSalaBLL.Listar().ToList();

            //if (ddlHorarioAula.SelectedValue != "0")
            //    lReservasAux = lReservasAux.Where(x => x.HorarioAula.Id != Convert.ToInt32(ddlHorarioAula.SelectedValue))
            //        .ToList();

            //if (ddlTurma.SelectedValue != "0")
            //    lReservasAux = lReservasAux.Where(x => x.Turma.Id == Convert.ToInt32(ddlTurma.SelectedValue))
            //        .ToList();            

            gdvSalas.DataSource = SalaBLL.Listar().Where(x=> x.Disponivel);
            gdvSalas.DataBind();
        }

        protected void btnSolicitar_Click(object sender, EventArgs e)
        {


            if (String.IsNullOrEmpty(txtDataInicio.Text) || (String.IsNullOrEmpty(txtDataFinal.Text)))
            {
                ErrorMessage.Visible = true;
                FailureText.Text = "Por gentileza selecione as datas de inicio e fim da reserva.";
                return;
            }


            if (ddlTurma.SelectedValue =="0")
            {
                ErrorMessage.Visible = true;
                FailureText.Text = "Por gentileza selecione uma turma.";
                return;
            }


            if (ddlDia.SelectedValue == "0")
            {
                ErrorMessage.Visible = true;
                FailureText.Text = "Por gentileza selecione uma dia.";
                return;
            }


            if (ddlHorarioAula.SelectedValue == "0")
            {
                ErrorMessage.Visible = true;
                FailureText.Text = "Por gentileza selecione uma Hora.";
                return;
            }

            IList<Sala> lSalas = new List<Sala>();
            foreach (GridViewRow row in gdvSalas.Rows)
            {

                CheckBox cb = (CheckBox)row.FindControl("chkbox");
                if (cb != null && cb.Checked)
                {

                    lSalas.Add(SalaBLL.BuscarPorId(Convert.ToInt32(gdvSalas.DataKeys[row.RowIndex].Value)));

                }
            }

            if (lSalas.Count == 0)
            {
                ErrorMessage.Visible = true;
                FailureText.Text = "Por gentileza selecione uma Sala";
            }

            string lretorno = "";
            var usu = UsuarioBLL.BuscarPorId(Convert.ToInt32(Session["UsuarioId"]));
            if (!SolicitacaoReservaBLL.realizarSolicitacao(Convert.ToInt32(ddlTurma.SelectedValue),
                usu.Pessoa.Id, Convert.ToInt32(ddlHorarioAula.SelectedValue),Convert.ToDateTime(txtDataInicio.Text),
                Convert.ToDateTime(txtDataFinal.Text), out lretorno,lSalas.ToList(), usu.Id))
            {
                ErrorMessage.Visible = true;
                FailureText.Text = lretorno;
            }
            else
            {
                //Reserva Realizada
            }
        }


    }
}