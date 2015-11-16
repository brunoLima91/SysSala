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
    public class TurmaMapping : EntityTypeConfiguration<Turma>
    {
        public TurmaMapping()
        {
            ToTable("tbTurma", "glo");
            HasKey(x => x.Id)
                .Property(x => x.Id)
                .HasColumnName("tur_int_id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Codigo)
                .IsRequired();

            Property(x => x.Descricao)
                .IsRequired();

            HasRequired(x => x.Professor);

            HasRequired(x => x.Disciplina);
        }
    }
}
