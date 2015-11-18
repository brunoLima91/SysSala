using SysSala.DAL;
using SysSala.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSala.BLL
{
    public class SolicitacaoReservaBLL
    {
        public static bool realizarSolicitacao(int TurmaId, int ProfessorId, int HorarioId, DateTime dtInicio, DateTime dtFim, out string lMensagens, List<Sala> pSalas, int UsuarioId)
        {
            lMensagens = "";
            var lReservas = ReservaSalaBLL.Listar();
            bool reserved = false;



            foreach (var item in pSalas)
            {
                if (lReservas.Count(x => x.Sala.Id == item.Id
                && x.HorarioAula.Id == HorarioId && x.PeriodoInicial >= dtInicio && x.PeriodoFim <= dtInicio) > 0)
                {

                }
                else
                {

                    // Sala pode ser reservada

                    
                    IncluirSolicitacao(item,UsuarioId,HorarioId,dtInicio,dtFim,TurmaId);
                    reserved = true;
                    lMensagens = "Solicitação Realizada para a Sala " +item.Descricao +"";
                    break;

                   

                }




            }

              return reserved;
        }

        public static void IncluirSolicitacao(Sala pSala, int UsuarioId,int HorarioId, DateTime dtInicio, DateTime dtFim, int TurmaId)
        {
            using (var db = new DataContex())
            {

                SolicitacaoReservaSala lSolicitacao = new SolicitacaoReservaSala();
                lSolicitacao.Sala = pSala;
                lSolicitacao.PeriodoInicial = dtInicio;
                lSolicitacao.PeriodoFim = dtFim;
                lSolicitacao.Solicitante = UsuarioBLL.BuscarPorId(UsuarioId);
                lSolicitacao.StatusSolicitacao = EStatusSolicitacaoReserva.Aguardando;
                lSolicitacao.HorarioAula = HorarioAulaBLL.BuscarPorId(HorarioId);
                lSolicitacao.Turma = TurmaBLL.BuscarId(TurmaId);
                db.Set<SolicitacaoReservaSala>().Add(lSolicitacao);
                
                try
                {
                    db.SaveChanges();
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
                {
                    Exception raise = dbEx;
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            string message = string.Format("{0}:{1}",
                                validationErrors.Entry.Entity.ToString(),
                                validationError.ErrorMessage);
                            // raise a new exception nesting
                            // the current instance as InnerException
                            raise = new InvalidOperationException(message, raise);
                        }
                    }
                    throw raise;
                }
            }
        }
    }
}
