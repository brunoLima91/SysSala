using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSala.DTO
{
    public class Pavilhao
    {
        public int PavilhaoId { get; set; }
        public virtual string Descricao { get; set; }
        public virtual IList<Sala> Salas { get; set; }

        public Pavilhao()
        {
            Salas = new List<Sala>();
        }
    }
}