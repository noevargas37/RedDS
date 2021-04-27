using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RSRedDSCore.Models.Base.Persona
{
    [DataContract]
    public class Persona
    {
        private DatosPersonales datosPersonales;
        private Domicilio domicilio;
        private Localizadores localizadores;

        [DataMember]
        public DatosPersonales DatosPersonales { get => datosPersonales; set => datosPersonales = value; }
        [DataMember]
        public Domicilio Domicilio { get => domicilio; set => domicilio = value; }
        [DataMember]
        public Localizadores Localizadores { get => localizadores; set => localizadores = value; }
    }
}
