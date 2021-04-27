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
    public class ValidarAccesoIN
    {
        private string tokenAcceso;
        private string uRL;
        [DataMember]
        public string TokenAcceso { get => tokenAcceso; set => tokenAcceso = value; }
        [DataMember]
        public string URL { get => uRL; set => uRL = value; }
    }

    [DataContract]
    public class ValidarAccesoOUT:ErrorBase
    {
        public ValidarAccesoOUT() : base() { }
        public ValidarAccesoOUT(ErrorModel Error) : base(Error) { }

        public ValidarAccesoOUT(Exception Exception) : base(Exception) { }
    }
}
