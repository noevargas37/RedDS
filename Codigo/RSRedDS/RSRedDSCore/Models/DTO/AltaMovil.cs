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
    public class AltaMovilIN
    {
        private string token;
        private string codigoRed;
        [DataMember]
        public string Token { get => token; set => token = value; }
        [DataMember]
        public string CodigoRed { get => codigoRed; set => codigoRed = value; }
    }

    [DataContract]
    public class AltaMovilOUT : ErrorBase
    {
        public AltaMovilOUT() : base() { }
        public AltaMovilOUT(ErrorModel Error) : base(Error) { }
        public AltaMovilOUT(Exception Exception) : base(Exception) { }
    }
}
