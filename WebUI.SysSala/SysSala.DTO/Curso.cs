using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSala.DTO
{
    public class Curso
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public Departamento Departamento { get; set; }
    }
}
