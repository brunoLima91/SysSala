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
   public class DepartamentoMapping : EntityTypeConfiguration<Departamento>
    {
        public DepartamentoMapping()
        {
            ToTable("tbDepartamento", "glo");
            HasKey(x => x.Id)
                .Property(x => x.Id)
                .HasColumnName("der_int_id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Descricao)
              .IsRequired();

            HasMany(x => x.Professores)
            .WithOptional()
            .Map(x => x.MapKey("der_int_id"));

            HasMany(x => x.Cursos)
            .WithOptional()
            .Map(x => x.MapKey("der_int_idCursos"));


        }
    }
}
