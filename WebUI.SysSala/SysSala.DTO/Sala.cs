using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSala.DTO
{
    public class Sala
    {
        public int ID { get; set; }
        public string Descricao { get; set; }
        public bool Disponivel { get; set; }        
        public IList<Recurso> Recursos = new List<Recurso>();
        public ETipoSala TipoSala { get; set; }
    }
}
