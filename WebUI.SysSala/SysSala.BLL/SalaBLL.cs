using SysSala.DAL;
using SysSala.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSala.BLL
{
    public class SalaBLL
    {
        public static IList<Sala> Listar()
        {
            DataContex db = new DataContex();

            return db.Salas
                .Include("Recursos")
                .ToList();
          
        }

        public static void Carregar()
        {
            DataContex db = new DataContex();
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

            db.Salas.Add(lSala);
            db.SaveChanges();
        }
    }
}
