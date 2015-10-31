using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSala.DTO
{
   public class Item
    {
        public int ItemId { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Modelo { get; set; }
        public virtual string Marca { get; set; }
    }
}
