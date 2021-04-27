using RSRedDSCore.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RSRedDSCore.Models.DTO
{
    [DataContract]
    public class GenerarCodigoRedIN
    {
        private string identificadorSesion;
        [DataMember]
        public string IdentificadorSesion { get => identificadorSesion; set => identificadorSesion = value; }
    }

    [DataContract]
    public class GenerarCodigoRedOUT:ErrorBase
    {
        private string codigoRed;
        public GenerarCodigoRedOUT() : base() { }
        public GenerarCodigoRedOUT(ErrorModel Error) : base(Error) { }

        public GenerarCodigoRedOUT(Exception Exception) : base(Exception) { }

        public string CodigoRed { get => codigoRed; set => codigoRed = value; }
    }
}
