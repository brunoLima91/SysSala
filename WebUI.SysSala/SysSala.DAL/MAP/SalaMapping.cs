using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysSala.DTO;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace SysSala.DAL
{
    public class SalaMapping:EntityTypeConfiguration<Sala>
    {
        public SalaMapping()
        {
            ToTable("tbSala","glo");
            HasKey(x => x.Id)
                .Property(x => x.Id)
                .HasColumnName("sal_int_id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);            

            Property(x => x.Descricao)
                .HasColumnName("sal_str_descricao")                
                .IsRequired();

            Property(x => x.Disponivel)
                .HasColumnName("sal_int_disponivel")
                .IsRequired();

            Property(x => x.TipoSala)
                .HasColumnName("sal_int_tiposala")
                .IsRequired();

            HasMany(x => x.Recursos)
                .WithOptional()
                .Map(x=> x.MapKey("sal_int_id"));

            Property(x => x.Localizacao)
                .HasColumnName("sal_str_localizacao")
                .IsRequired();

            HasRequired(x => x.Predio)
                .WithMany()
                .Map(x=> x.MapKey("pre_int_id"));

        }
    }
}
