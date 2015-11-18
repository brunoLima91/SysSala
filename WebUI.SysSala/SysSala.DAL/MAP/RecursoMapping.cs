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
   public class RecursoMapping:EntityTypeConfiguration<Recurso>
    {
        public RecursoMapping()
        {
            ToTable("tbRecurso","glo");
            HasKey(x => x.Id)
                .Property(x=> x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            
            HasRequired(x => x.Item);

            HasRequired(x => x.Sala);         

            Property(x => x.Quantidade)
                .IsRequired();
                

        }
    }
}
