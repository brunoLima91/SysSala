using SysSala.DAL;
using SysSala.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSala.BLL
{
   public class TurmaBLL
    {
        public static IList<Turma> Listar()
        {
            using (var db = new DataContex())
            {
                return db.Set<Turma>()
                .ToList();
            }
        }

        public static Turma BuscarId( int Id)
        {
            using (var db = new DataContex())
            {
                return db.Set<Turma>()
                    .Include("Disciplina")
                    .Include("Professor")
                .FirstOrDefault(x => x.Id == Id);
            }
        }
    }
}
