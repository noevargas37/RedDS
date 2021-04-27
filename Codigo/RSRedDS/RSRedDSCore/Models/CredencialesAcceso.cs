using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RSRedDSCore.Models
{
    [DataContract]
    public class CredencialesAcceso
    {
        private string usuario;
        private string password;
        [DataMember]
        public string Usuario { get => usuario; set => usuario = value; }
        [DataMember]
        public string Password { get => password; set => password = value; }

       
    }
}
