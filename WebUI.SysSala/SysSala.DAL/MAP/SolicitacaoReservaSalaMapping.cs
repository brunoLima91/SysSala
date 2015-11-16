using SysSala.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSala.DAL.MAP
{
    public class SolicitacaoReservaSalaMapping : EntityTypeConfiguration<SolicitacaoReservaSala>
    {
        public SolicitacaoReservaSalaMapping()
        {
            ToTable("tbSolicitacaoReservaSala", "glo");
            HasKey(x => x.Id)
                .Property(x => x.Id)
                .HasColumnName("sol_int_id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            HasRequired(x => x.Turma);

            HasRequired(x => x.Sala);

            HasRequired(x => x.HorarioAula);


            Property(x => x.PeriodoInicial)
                .IsRequired();

            Property(x => x.PeriodoFim)
                .IsRequired();

            
            HasRequired(x => x.Solicitante);

            Property(x => x.StatusSolicitacao)
                .IsRequired();

        }
    }
}
