using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSala.DTO
{
   public class Recurso
    {
        public int Id { get; set; }
        public  Item Item { get; set; }
        public  int Quantidade { get; set; }
        public  Sala Sala { get; set; }
    }
}
