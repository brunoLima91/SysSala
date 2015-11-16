using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSala.DTO
{
    public class Pavilhao
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public IList<Sala> Salas { get; set; }

        public Pavilhao()
        {
            Salas = new List<Sala>();
        }
    }
}