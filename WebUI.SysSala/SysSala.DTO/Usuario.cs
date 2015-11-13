using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSala.DTO
{
    public class Usuario
    {
        public string Email { get; set; }
        public string Senha { get; set; }
        public Pessoa Pessoa { get; set; }
        public ETipoUsuario TipoUsuario { get; set; }
    }
}
