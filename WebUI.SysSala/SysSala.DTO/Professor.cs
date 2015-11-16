using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSala.DTO
{
   public class Professor: Pessoa
    {
        public string Matricula { get; set; }
        public IList<Turma> Turmas { get; set; }

        public Professor()
        {
            Turmas = new List<Turma>();
        }

    }
}
