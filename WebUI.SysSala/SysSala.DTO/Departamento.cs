using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSala.DTO
{
   public class Departamento
    {
        public Departamento()
        {
            Cursos = new List<Curso>();
            Professores = new List<Professor>();
        }
        public virtual IList<Curso> Cursos { get; protected set; }
        public virtual IList<Professor> Professores { get; protected set; }
        public int DepartamentoID { get; set; }
    }
}
