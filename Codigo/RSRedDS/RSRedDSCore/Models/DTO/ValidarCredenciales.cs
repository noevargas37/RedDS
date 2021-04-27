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
    public class ValidarCredencialesIN
    {
        private CredencialesAcceso credenciales;

        [DataMember]
        public CredencialesAcceso Credenciales { get => credenciales; set => credenciales = value; }

    }

    [DataContract]
    public class ValidarCredencialesOUT : ErrorBase
    {
        public ValidarCredencialesOUT() : base() { }
        public ValidarCredencialesOUT(ErrorModel Error) : base(Error) { }   

        public ValidarCredencialesOUT(Exception Exception) : base(Exception) { }

        private string urlAccesoInicial;
        private string tokenAcceso;

        [DataMember]
        public string UrlAccesoInicial { get => urlAccesoInicial; set => urlAccesoInicial = value; }
        
        [DataMember]
        public string TokenAcceso { get => tokenAcceso; set => tokenAcceso = value; }

    }
}
