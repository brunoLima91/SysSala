using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSala.DTO
{
    public class Sala
    {
        public int SalaId { get; set; }
        public virtual string Descricao { get; set; }
        public virtual bool Disponivel { get; set; }        
        public virtual IList<Recurso> Recursos { get; protected set; }
        public virtual ETipoSala TipoSala { get; set; }
    }
}
