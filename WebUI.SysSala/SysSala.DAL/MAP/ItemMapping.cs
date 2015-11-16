using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysSala.DTO;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace SysSala.DAL.MAP
{
   public class ItemMapping:EntityTypeConfiguration<Item>
    {
        public ItemMapping()
        {
            ToTable("tbItem","glo");
            HasKey(x => x.Id)
                .Property(x => x.Id)
                .HasColumnName("ite_int_id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Marca)
                .IsRequired();

            Property(x => x.Modelo)
                .IsRequired();

            Property(x => x.Nome)
                .IsRequired();
        }
    }
}
