using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSala.DTO
{
    public class HorarioAula
    {

        public int HorarioAulaID { get; set; }
        public virtual EDiaSemana DiaSemana { get; set; }
        public virtual DateTime HoraInicio { get; set; }
        public virtual DateTime HoraFim { get; set; }
    }
}