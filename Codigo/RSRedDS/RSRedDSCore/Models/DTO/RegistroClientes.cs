using RSRedDSCore.Models.Base;
using RSRedDSCore.Models.Base.Persona;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RSRedDSCore.Models.DTO
{
    [DataContract]
    public class RegistroClientesIN
    {
        private CredencialesAcceso credenciales;
        private Persona cliente;

        [DataMember]
        public CredencialesAcceso Credenciales { get => credenciales; set => credenciales = value; }
        [DataMember]
        public Persona Cliente { get => cliente; set => cliente = value; }
    }

    [DataContract]
    public class RegistroClientesOUT:ErrorBase
    {
        public RegistroClientesOUT() : base() { }
        public RegistroClientesOUT(ErrorModel Error) : base(Error) { }

        public RegistroClientesOUT(Exception Exception) : base(Exception) { }
    }
}
