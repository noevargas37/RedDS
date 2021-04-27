using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RSRedDSCore.Models.Base.Persona
{
    [DataContract]
    public class Domicilio
    {
        private string codigoPostal;
        public string Calle;
        private string numeroInterior;
        private string numeroExterior;
        private int idColonia;

        [DataMember]
        public string CodigoPostal { get => codigoPostal; set => codigoPostal = value; }
        [DataMember]
        public string NumeroInterior { get => numeroInterior; set => numeroInterior = value; }
        [DataMember]
        public string NumeroExterior { get => numeroExterior; set => numeroExterior = value; }
        [DataMember]
        public int IdColonia { get => idColonia; set => idColonia = value; }
    }
}
