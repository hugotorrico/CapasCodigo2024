using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NRol
    {

        public void Registrar(string Nombre,bool Activo)
        {
            DRol datos = new DRol();
            datos.Registrar(Nombre,Activo);
        }
    }
}
