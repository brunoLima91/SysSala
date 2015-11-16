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
    public class UsuarioMapping : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMapping()
        {
            ToTable("tbUsuario", "glo");
            HasKey(x => x.Id)
                .Property(x => x.Id)
                .HasColumnName("usu_int_id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Email)
                .IsRequired();

            Property(x => x.Senha)
                .IsRequired();

            Property(x => x.TipoUsuario)
                .IsRequired();

            HasRequired(x => x.Pessoa);

            
        }
    }
}