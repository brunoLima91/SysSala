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
    public class PavilhaoMapping : EntityTypeConfiguration<Pavilhao>
    {
        public PavilhaoMapping()
        {
            ToTable("tbPavilhao", "glo");
            HasKey(x => x.Id)
                .Property(x => x.Id)
                .HasColumnName("pav_int_id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);


            Property(x => x.Descricao)
              .IsRequired();

            HasMany(x => x.Salas)
               .WithOptional()
               .Map(x => x.MapKey("pav_int_id"));



        }
    }
}
