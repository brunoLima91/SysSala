using SysSala.BLL;
using SysSala.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebUI.SysSala.SysSala.Alunos
{
    public partial class HomeAlunos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Carregar();               
            }
        }

        private void Carregar()

        {
            ddlProfessor.DataSource = ProfessorBLL.Listar().OrderBy(x=> x.Nome);
            ddlProfessor.DataBind();
            ddlProfessor.Items.Insert(0,new ListItem("Selecione", "0"));
            

            ddlDisciplina.DataSource = DisciplinaBLL.Listar().OrderBy(x=> x.Descricao);           
            ddlDisciplina.DataBind();
            ddlDisciplina.Items.Insert(0, new ListItem("Selecione", "0"));


            ddlTurma.DataSource = TurmaBLL.Listar().OrderBy(x=> x.Descricao);            
            ddlTurma.DataBind();
            ddlTurma.Items.Insert(0, new ListItem("Selecione", "0"));

            ddlProfessor.SelectedIndex = ddlTurma.SelectedIndex = ddlDisciplina.SelectedIndex = 0;
            
        }

        private void PopularGrid()
        {

           // IList<ReservaSala> lReservas = new List<ReservaSala>();

            var lReservasAux = ReservaSalaBLL.Listar().ToList();
            
            if (ddlDisciplina.SelectedValue != "0")
                lReservasAux = lReservasAux.Where(x => x.Turma.Disciplina.Id == Convert.ToInt32(ddlDisciplina.SelectedValue))
                    .ToList();

            if (ddlProfessor.SelectedValue != "0")
            
                lReservasAux = lReservasAux.Where(x => x.Turma.Professor.Id == Convert.ToInt32(ddlProfessor.SelectedValue))
                    .ToList();

            if (ddlTurma.SelectedValue != "0")
                lReservasAux = lReservasAux.Where(x => x.Turma.Id == Convert.ToInt32(ddlTurma.SelectedValue))
                    .ToList();

            


            gdvReservas.DataSource = lReservasAux;
            gdvReservas.DataBind();
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            PopularGrid();
        }
    }
}