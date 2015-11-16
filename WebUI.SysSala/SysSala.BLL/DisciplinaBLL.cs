using SysSala.DAL;
using SysSala.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSala.BLL
{
   public class DisciplinaBLL
    {
        public static IList<Disciplina> Listar()
        {
            using (var db = new DataContex())
            {
                return db.Set<Disciplina>()
                .ToList();
            }
        }
    }
}
