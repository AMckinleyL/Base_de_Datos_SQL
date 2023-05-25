using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuarios
{
    public class user
    {
        //SE CREA PROPIEDAD DE ACUERDO A LOS CAMPOS DE LA TABLA
        public int idPersona { get; set; }
        public string perNombres { get; set; }
        public string perApellidos { get; set; }
        public string perGenero { get; set; }
        public string perCUI { get; set; }
        public DateTime perFecha { get; set; }
        public string perPais { get; set; }
        public string perDepartamento { get; set; }
        public string perMunicipio { get; set;}


    }
}
