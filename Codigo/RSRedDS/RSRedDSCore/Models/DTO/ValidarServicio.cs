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
    public class ValidarServicioOUT : ErrorBase
    {
        private string status;
        public ValidarServicioOUT() : base() { }
        public ValidarServicioOUT(ErrorModel Error) : base(Error) { }

        public ValidarServicioOUT(Exception Exception) : base(Exception) { }

        [DataMember]
        public string Status { get => status; set => status = value; }
    }
}
