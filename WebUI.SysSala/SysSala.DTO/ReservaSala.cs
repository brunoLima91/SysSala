using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSala.DTO
{
   public class ReservaSala
    {
        public Sala Sala { get; set; }
        public Professor Professor { get; set; }
        public Disciplina Disciplina { get; set; }
        public DateTime PeriodoInicial { get; set; }
        public DateTime PeriodoFim { get; set; }
        public HorarioAula MyProperty { get; set; }


    }
}
