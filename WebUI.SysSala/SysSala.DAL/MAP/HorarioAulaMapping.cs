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
   public class HorarioAulaMapping : EntityTypeConfiguration<HorarioAula>
    {
        public HorarioAulaMapping()
        {
            ToTable("tbHorarioAula", "glo");
            HasKey(x => x.Id)
                .Property(x => x.Id)
                .HasColumnName("hor_int_id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.DiaSemana)
                .IsRequired();

            Property(x => x.HoraFim)
                .IsRequired();

            Property(x => x.HoraInicio)
                .IsRequired();

        }
    }
}
