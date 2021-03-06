﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSala.DTO
{
   public class ReservaSala
    {
        public int Id { get; set; }
        public  Sala Sala { get; set; }
        public Turma Turma { get; set; }
        public  DateTime PeriodoInicial { get; set; }
        public  DateTime PeriodoFim { get; set; }
        public  HorarioAula HorarioAula { get; set; }

        public string Periodo
        {
            get { return PeriodoInicial.ToShortDateString() + "-" + PeriodoFim.ToShortDateString(); }
        }


    }
}
