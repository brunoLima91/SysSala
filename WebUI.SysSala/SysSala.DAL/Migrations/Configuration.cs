namespace SysSala.DAL.Migrations
{
    using DTO;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SysSala.DAL.DataContex>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(SysSala.DAL.DataContex context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            Item litem = new Item();
            litem.Nome = "Ar Condicionado";
            litem.Marca = "Eletrolux";
            litem.Modelo = "EcoTurbo 12000";

            Item litem2 = new Item();
            litem2.Nome = "Cadeira";
            litem2.Marca = "MillaComercio";
            litem2.Modelo = "Aluno";

            Item litem3 = new Item();
            litem3.Nome = "Cadeira";
            litem3.Marca = "MillaComercio";
            litem3.Modelo = "Professor";


            Recurso lRecurso = new Recurso();
            lRecurso.Item = litem;
            lRecurso.Quantidade = 2;

            Recurso lRecurso1 = new Recurso();
            lRecurso1.Item = litem2;
            lRecurso1.Quantidade = 40;

            Recurso lRecurso2 = new Recurso();
            lRecurso2.Item = litem3;
            lRecurso2.Quantidade = 1;

            Sala lSala = new Sala();
            lSala.Recursos.Add(lRecurso);
            lSala.Recursos.Add(lRecurso1);
            lSala.Recursos.Add(lRecurso2);
            lSala.TipoSala = ETipoSala.Aula;

           // context.Salas.Add(lSala);
            
        }
    }
}
