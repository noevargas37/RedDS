using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RSRedDSCore.Models.Base.Persona
{
    [DataContract]
    public class Localizadores
    {
        private string telefono;
        private string correoElectronico;

        [DataMember]
        public string Telefono { get => telefono; set => telefono = value; }
        [DataMember]
        public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }
    }
}
