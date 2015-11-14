using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSala.DTO
{
   public class Turma
    {
        public virtual string Codigo { get; set; }
        public virtual Professor Professor { get; set; }
        public virtual Disciplina Disciplina { get; set; }

    }
}
