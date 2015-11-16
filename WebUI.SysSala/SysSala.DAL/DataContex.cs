using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using SysSala.DTO;
using SysSala.DAL.MAP;

namespace SysSala.DAL
{
    public class DataContex:DbContext
    {
        public DataContex()
            : base("DataContext")
        {
           // Database.SetInitializer(new DropCreateDatabaseAlways<DataContex>());
            //Configuration.LazyLoadingEnabled = false;
            //Configuration.ProxyCreationEnabled = false;
        }

        //public DbSet<Sala> Salas { get; set; }
        //public DbSet<Item> Itens { get; set; }
        //public DbSet<Recurso> Recursos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            //modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            //modelBuilder.Properties()
            //       .Where(p => p.Name == p.ReflectedType.Name + "Id")
            //       .Configure(p => p.IsKey());
            //modelBuilder.Properties<string>()
            //       .Configure(p => p.HasColumnType("varchar"));
            //modelBuilder.Properties<string>()
            //      .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new ItemMapping());
            modelBuilder.Configurations.Add(new RecursoMapping());
            modelBuilder.Configurations.Add(new SalaMapping());
            modelBuilder.Configurations.Add(new PavilhaoMapping());

            modelBuilder.Configurations.Add(new CursoMapping());
            modelBuilder.Configurations.Add(new DisciplinaMapping());
            modelBuilder.Configurations.Add(new TurmaMapping());

            modelBuilder.Configurations.Add(new DepartamentoMapping());
            modelBuilder.Configurations.Add(new HorarioAulaMapping());
            modelBuilder.Configurations.Add(new ReservaSalaMapping());

            modelBuilder.Configurations.Add(new SolicitacaoReservaSalaMapping());
            modelBuilder.Configurations.Add(new UsuarioMapping());

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Pessoa>().ToTable("tbPessoa", "glo");
            modelBuilder.Entity<Professor>().ToTable("tbProfessor", "glo");
            modelBuilder.RegisterEntityType(typeof(Sala));
            //modelBuilder.RegisterEntityType(typeof(Pessoa));
            base.OnModelCreating(modelBuilder);
        }
    }
}
