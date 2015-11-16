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
    public class CursoMapping : EntityTypeConfiguration<Curso>
    {
        public CursoMapping()
        {
            ToTable("tbCurso", "glo");
            HasKey(x => x.Id)
                .Property(x => x.Id)
                .HasColumnName("cur_int_id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Descricao)
                .IsRequired();

            HasRequired(x => x.Departamento)
            .WithMany()
            .Map(x => x.MapKey("der_int_id"));
        }
    }
}
