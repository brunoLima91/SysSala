using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSala.DTO
{
   public class ReservaSala
    {
        public virtual Sala Sala { get; set; }
        public virtual Professor Professor { get; set; }
        public virtual Disciplina Disciplina { get; set; }
        public virtual DateTime PeriodoInicial { get; set; }
        public virtual DateTime PeriodoFim { get; set; }
        public virtual HorarioAula HorarioAula { get; set; }


    }
}
