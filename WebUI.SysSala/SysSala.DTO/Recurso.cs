using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSala.DTO
{
   public class Recurso
    {
        public int RecursoId { get; set; }
        public virtual Item Item { get; set; }
        public virtual int Quantidade { get; set; }
        public virtual Sala Sala { get; set; }
    }
}
