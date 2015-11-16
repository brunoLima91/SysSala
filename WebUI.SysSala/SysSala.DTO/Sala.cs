using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSala.DTO
{
    public class Sala
    {
        public Sala()
        {
            Recursos = new List<Recurso>();
            
        }
        public int Id { get; set; }
        public  string Descricao { get; set; }
        public  bool Disponivel { get; set; }        
        public virtual  IList<Recurso> Recursos { get; protected set; }
        public virtual  ETipoSala TipoSala { get; set; }
        public  ELolizacao Localizacao{ get; set; }
        public virtual  Pavilhao Predio { get; set; }

        public string LocalizacaoDesc
        {
            get { return this.Predio.Descricao + " - " + this.Localizacao.ToString(); }
        }

        public string Text
        {
            get { return this.Descricao + "-" + LocalizacaoDesc; }
        }
    }
}
