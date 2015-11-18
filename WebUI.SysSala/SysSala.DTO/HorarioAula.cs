using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSala.DTO
{
    public class HorarioAula
    {

        public int Id { get; set; }
        public EDiaSemana DiaSemana { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFim { get; set; }

        public string Descricao
        {
            get { return this.DiaSemana.ToString() +" - " + this.HoraInicio.ToShortTimeString()+ " - " + this.HoraFim.ToShortTimeString(); }
        }

        public string Text        {
            get { return  this.HoraInicio.ToShortTimeString() + " - " + this.HoraFim.ToShortTimeString(); }
        }
    }
}