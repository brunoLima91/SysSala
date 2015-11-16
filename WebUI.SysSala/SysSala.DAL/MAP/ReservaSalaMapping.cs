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
    public class ReservaSalaMapping : EntityTypeConfiguration<ReservaSala>
    {

        public ReservaSalaMapping()
        {
            ToTable("tbReservaSala", "glo");
            HasKey(x => x.Id)
                .Property(x => x.Id)
                .HasColumnName("res_int_id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            HasRequired(x => x.Turma);

            HasRequired(x => x.Sala);

            HasRequired(x => x.HorarioAula);


            Property(x => x.PeriodoInicial)
                .IsRequired();

            Property(x => x.PeriodoFim)
                .IsRequired();
        }
        

    }
}
