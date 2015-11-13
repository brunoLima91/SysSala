using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysSala.DTO;
using System.Data.Entity.ModelConfiguration;

namespace SysSala.DAL.MAP
{
   public class ItemMapping:EntityTypeConfiguration<Item>
    {
        public ItemMapping()
        {
            ToTable("tbItem");
            HasKey(x => x.ItemId);

            Property(x => x.Marca)
                .IsRequired();

            Property(x => x.Modelo)
                .IsRequired();

            Property(x => x.Nome)
                .IsRequired();
        }
    }
}
