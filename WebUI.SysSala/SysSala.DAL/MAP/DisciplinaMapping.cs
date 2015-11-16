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
   public class DisciplinaMapping : EntityTypeConfiguration<Disciplina>
    {
        public DisciplinaMapping()
        {
            ToTable("tbDisciplina", "glo");
            HasKey(x => x.Id)
                .Property(x => x.Id)
                .HasColumnName("dic_int_id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Descricao)
              .IsRequired();

            Property(x => x.CargaHoraria)
              .IsRequired();
        }
        
        
    }
}
