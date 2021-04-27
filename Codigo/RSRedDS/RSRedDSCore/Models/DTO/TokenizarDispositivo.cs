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
    public class TokenizarDispositivoIN
    {
        private DatosDispositivo datosDispositivo;
        [DataMember]
        public DatosDispositivo DatosDispositivo { get => datosDispositivo; set => datosDispositivo = value; }
    }

    [DataContract]
    public class TokenizarDispositivoOUT:ErrorBase
    {
        private string token;
        private string codigoRed;
        
        [DataMember]
        public string Token { get => token; set => token = value; }
        [DataMember]
        public string CodigoRed { get => codigoRed; set => codigoRed = value; }

        public TokenizarDispositivoOUT() : base() { }
        public TokenizarDispositivoOUT(ErrorModel Error) : base(Error) { }

        public TokenizarDispositivoOUT(Exception Exception) : base(Exception) { }
    }
}
