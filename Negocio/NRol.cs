using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NRol
    {
        DRol datos = new DRol();

        public string Registrar(string Nombre)
        {
            string result = string.Empty;         

            List<Role> roles = datos.Listar(Nombre);
            if (roles.Count==0)            
                datos.Registrar(Nombre, true);            
            else            
                result = "El rol ya existe";
            

            return result;
        }

        public List<Role> Listar(string Nombre)
        {
            List<Role> result = new List<Role>();
           
            result = datos.Listar(Nombre);
            return result;
        }
    }
}
