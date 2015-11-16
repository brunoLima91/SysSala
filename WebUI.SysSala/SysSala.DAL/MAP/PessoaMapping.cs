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
    public class PessoaMapping : EntityTypeConfiguration<Pessoa>
    {
        public PessoaMapping()
        {
            ToTable("tbPessoa", "glo");
            HasKey(x => x.Id)
                .Property(x => x.Id)
                .HasColumnName("ite_int_id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
