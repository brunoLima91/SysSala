using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSala.DTO
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public ESexo Sexo { get; set; }
    }
}
