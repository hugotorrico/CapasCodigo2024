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

        public string Registrar(string Nombre)
        {
            string result = string.Empty;

            DRol datos = new DRol();

            //Buscar si existe otro rol igual
            List<Role> roles = datos.Listar(Nombre);

            if (roles.Count==0)            
                datos.Registrar(Nombre, true);            
            else            
                result = "El rol ya existe";
            

            return result;
        }
    }
}
