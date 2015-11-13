using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysSala.DTO;
using System.Data.Entity.ModelConfiguration;

namespace SysSala.DAL
{
    public class SalaMapping:EntityTypeConfiguration<Sala>
    {
        public SalaMapping()
        {
            ToTable("tbSala");
            HasKey(x => x.SalaId);

            Property(x => x.Descricao)
                .HasMaxLength(150)
                .IsRequired();

            Property(x => x.Disponivel)
                .IsRequired();

            Property(x => x.TipoSala)
                .IsRequired();

            HasMany(x => x.Recursos);
        }
    }
}
