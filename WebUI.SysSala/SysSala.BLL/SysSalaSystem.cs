using SysSala.DAL;
using SysSala.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSala.BLL
{
   public class SysSalaSystem
    {
        public static void CargaInicial()
        {
            using (var db = new DataContex())
            {
                Pavilhao lpavilhao = new Pavilhao();
                lpavilhao.Descricao = "Paf";

                Departamento lDepartamento = new Departamento();
                lDepartamento.Cursos.Add(new Curso
                {
                    Descricao = "Bacharel em Sistema de Informação",
                    Departamento = lDepartamento


                });

                lDepartamento.Cursos.Add(new Curso
                {
                    Descricao = "Ciências da Computação",
                    Departamento = lDepartamento


                });

                Disciplina lDisciplina = new Disciplina();
                lDisciplina.Descricao = "Laboratorio de Sistemas Web";
                lDisciplina.CargaHoraria = 68;

                Disciplina lDisciplina1 = new Disciplina();
                lDisciplina1.Descricao = "Sistemas Multimidia";
                lDisciplina1.CargaHoraria = 68;

                Professor lProfessor = new Professor();
                lProfessor.Matricula = "0121219";
                lProfessor.Nome = "Patricio Santos";
                lProfessor.Sexo = ESexo.Masculino;

                Turma lturma = new Turma();
                lturma.Codigo = "001";
                lturma.Descricao = "Lab Web";
                lturma.Disciplina = lDisciplina;
                lturma.Professor = lProfessor;

                Turma lturma1 = new Turma();
                lturma1.Codigo = "002";
                lturma1.Descricao = "Lab Web 2";
                lturma1.Disciplina = lDisciplina;
                lturma1.Professor = lProfessor;

                Turma lturma3 = new Turma();
                lturma3.Codigo = "003";
                lturma3.Descricao = "Lab Web 3";
                lturma3.Disciplina = lDisciplina;
                lturma3.Professor = lProfessor;

                Turma lturma4 = new Turma();
                lturma4.Codigo = "005";
                lturma4.Descricao = "Sistemas MultiMudia";
                lturma4.Disciplina = lDisciplina1;
                lturma4.Professor = lProfessor;

                lProfessor.Turmas.Add(lturma);
                lProfessor.Turmas.Add(lturma1);
                lProfessor.Turmas.Add(lturma4);
                lProfessor.Turmas.Add(lturma3);


                HorarioAula lHorarioAula = new HorarioAula();
                lHorarioAula.DiaSemana = EDiaSemana.SegundaFeira;
                lHorarioAula.HoraInicio = new DateTime(2015, 11, 10, 16, 30, 0);
                lHorarioAula.HoraFim = new DateTime(2015, 11, 10, 18, 30, 0);

                HorarioAula lHorarioAula2 = new HorarioAula();
                lHorarioAula.DiaSemana = EDiaSemana.SegundaFeira;
                lHorarioAula.HoraInicio = new DateTime(2015, 11, 10, 14, 30, 0);
                lHorarioAula.HoraFim = new DateTime(2015, 11, 10, 16, 30, 0);

                HorarioAula lHorarioAula3 = new HorarioAula();
                lHorarioAula.DiaSemana = EDiaSemana.SegundaFeira;
                lHorarioAula.HoraInicio = new DateTime(2015, 11, 10, 10, 30, 0);
                lHorarioAula.HoraFim = new DateTime(2015, 11, 10, 12, 30, 0);

                HorarioAula lHorarioAula4 = new HorarioAula();
                lHorarioAula.DiaSemana = EDiaSemana.SegundaFeira;
                lHorarioAula.HoraInicio = new DateTime(2015, 11, 10, 8, 30, 0);
                lHorarioAula.HoraFim = new DateTime(2015, 11, 10, 10, 30, 0);

                Usuario lUsuario = new Usuario();
                lUsuario.Email = "teste@syssala.com";
                lUsuario.Senha = "123456";
                lUsuario.Pessoa = lProfessor;


                Item litem = new Item();
                litem.Nome = "Ar Condicionado";
                litem.Marca = "Eletrolux";
                litem.Modelo = "EcoTurbo 12000";

                Item litem2 = new Item();
                litem2.Nome = "Cadeira";
                litem2.Marca = "MillaComercio";
                litem2.Modelo = "Aluno";

                Item litem3 = new Item();
                litem3.Nome = "Cadeira";
                litem3.Marca = "MillaComercio";
                litem3.Modelo = "Professor";


                Recurso lRecurso = new Recurso();
                lRecurso.Item = litem;
                lRecurso.Quantidade = 2;

                Recurso lRecurso1 = new Recurso();
                lRecurso1.Item = litem2;
                lRecurso1.Quantidade = 40;

                Recurso lRecurso2 = new Recurso();
                lRecurso2.Item = litem3;
                lRecurso2.Quantidade = 1;

                Sala lSala = new Sala();
                lSala.Recursos.Add(lRecurso);
                lSala.Recursos.Add(lRecurso1);
                lSala.Recursos.Add(lRecurso2);
                lSala.TipoSala = ETipoSala.Aula;
                lSala.Descricao = "210";
                lSala.Localizacao = ELolizacao.PrimeiroAndar;

                Sala lSala1 = new Sala()
                {
                    Descricao = "211",
                    Disponivel = true,
                    Localizacao = ELolizacao.SegundoAndar,
                    Predio = lpavilhao,
                    TipoSala = ETipoSala.Aula,
                    
                };


                lSala1.Recursos.Add(new Recurso()
                {
                    Sala = lSala1,
                    Quantidade = 1,
                    Item = new Item() { Marca = "Eletrolux", Nome = "ArCondicionado", Modelo = "Super" }

                });


                lSala1.Recursos.Add(new Recurso()
                {
                    Sala = lSala1,
                    Quantidade = 40,
                    Item = new Item() { Marca = "Cadeiras New", Nome = "Cadeira", Modelo = "Super" }

                });


                


                lpavilhao.Salas.Add(lSala);
                lSala.Predio = lpavilhao;
                lRecurso.Sala = lRecurso1.Sala = lRecurso2.Sala = lSala;




                SolicitacaoReservaSala lSolicitacao = new SolicitacaoReservaSala();
                lSolicitacao.HorarioAula = lHorarioAula;
                lSolicitacao.Sala = lSala;
                lSolicitacao.Turma = lturma;
                lSolicitacao.StatusSolicitacao = EStatusSolicitacaoReserva.Aprovada;
                lSolicitacao.Solicitante = lUsuario;
                lSolicitacao.PeriodoInicial = new DateTime(2015, 4, 01);
                lSolicitacao.PeriodoFim = new DateTime(2015, 8, 01);

                SolicitacaoReservaSala lSolicitacao1 = new SolicitacaoReservaSala()
                {
                    HorarioAula = lHorarioAula2,
                    Sala = lSala1,
                    Turma = lturma1,
                    StatusSolicitacao = EStatusSolicitacaoReserva.Aprovada,
                    Solicitante = lUsuario,
                    PeriodoInicial = new DateTime(2015, 4, 01),
                    PeriodoFim = new DateTime(2015, 8, 01),
                };



                SolicitacaoReservaSala lSolicitacao2 = new SolicitacaoReservaSala()
                {
                    HorarioAula = lHorarioAula3,
                    Sala = lSala,
                    Turma = lturma3,
                    StatusSolicitacao = EStatusSolicitacaoReserva.Aprovada,
                    Solicitante = lUsuario,
                    PeriodoInicial = new DateTime(2015, 4, 01),
                    PeriodoFim = new DateTime(2015, 8, 01),
                };


                ReservaSala lReserva = new ReservaSala()
                {
                    HorarioAula = lHorarioAula2,
                    Sala = lSala1,
                    Turma = lturma1,                    
                    PeriodoInicial = new DateTime(2015, 4, 01),
                    PeriodoFim = new DateTime(2015, 8, 01),
                };


                ReservaSala lReserva2 = new ReservaSala()
                {
                    HorarioAula = lHorarioAula,
                    Sala = lSala,
                    Turma = lturma,
                    PeriodoInicial = new DateTime(2015, 4, 01),
                    PeriodoFim = new DateTime(2015, 8, 01),
                };


                ReservaSala lReserva3 = new ReservaSala()
                {
                    HorarioAula = lHorarioAula3,
                    Sala = lSala1,
                    Turma = lturma4,
                    PeriodoInicial = new DateTime(2015, 4, 01),
                    PeriodoFim = new DateTime(2015, 8, 01),
                };


                db.Set<Sala>().Add(lSala);
                db.Set<Sala>().Add(lSala1);
                db.Set<Professor>().Add(lProfessor);
                db.Set<ReservaSala>().Add(lReserva);
                db.Set<ReservaSala>().Add(lReserva2);
                db.Set<ReservaSala>().Add(lReserva3);

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

        public static void Horarios()
        {
            using (var db = new DataContex())
            {
                HorarioAula lHorarioAula = new HorarioAula();
                lHorarioAula.DiaSemana = EDiaSemana.SegundaFeira;
                lHorarioAula.HoraInicio = new DateTime(2015, 11, 10, 16, 30, 0);
                lHorarioAula.HoraFim = new DateTime(2015, 11, 10, 18, 30, 0);

                HorarioAula lHorarioAula2 = new HorarioAula();
                lHorarioAula.DiaSemana = EDiaSemana.SegundaFeira;
                lHorarioAula.HoraInicio = new DateTime(2015, 11, 10, 14, 30, 0);
                lHorarioAula.HoraFim = new DateTime(2015, 11, 10, 16, 30, 0);

                HorarioAula lHorarioAula3 = new HorarioAula();
                lHorarioAula.DiaSemana = EDiaSemana.SegundaFeira;
                lHorarioAula.HoraInicio = new DateTime(2015, 11, 10, 10, 30, 0);
                lHorarioAula.HoraFim = new DateTime(2015, 11, 10, 12, 30, 0);

                HorarioAula lHorarioAula4 = new HorarioAula();
                lHorarioAula.DiaSemana = EDiaSemana.SegundaFeira;
                lHorarioAula.HoraInicio = new DateTime(2015, 11, 10, 8, 30, 0);
                lHorarioAula.HoraFim = new DateTime(2015, 11, 10, 10, 30, 0);

                db.Set<HorarioAula>().Add(lHorarioAula);
                db.Set<HorarioAula>().Add(lHorarioAula2);
                db.Set<HorarioAula>().Add(lHorarioAula3);
                db.Set<HorarioAula>().Add(lHorarioAula4);

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
