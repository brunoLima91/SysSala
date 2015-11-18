using SysSala.DAL;
using SysSala.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSala.BLL
{
   public class ProfessorBLL
    {
        public static IList<Professor> Listar()
        {
            using (var db = new DataContex())
            {
                return db.Set<Professor>()
                    .Include("Turmas")
                    .Include("Turmas.Disciplina")
                .ToList();
            }
        }
    }
}
