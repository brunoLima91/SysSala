using SysSala.DAL;
using SysSala.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSala.BLL
{
    public class UsuarioBLL
    {
        public static IList<Usuario> Listar()
        {
            using (var db = new DataContex())
            {
                return db.Set<Usuario>()        
                .ToList();
            }
        }

        public static Usuario BuscarPorId(int Id)
        {
            using (var db = new DataContex())
            {
                return db.Set<Usuario>()
                    .Include("Pessoa")
                .FirstOrDefault(x => x.Id == Id);
            }
        }

        public static Usuario VerificarCrendeciais(string Email, string Password)
        {
            try
            {
                using (var db = new DataContex())
                {
                    return db.Set<Usuario>().FirstOrDefault(x => x.Email == Email && x.Senha == Password);
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
