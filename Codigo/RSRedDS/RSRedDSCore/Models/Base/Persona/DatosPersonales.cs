using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RSRedDSCore.Models.Base.Persona
{
    [DataContract]
    public class DatosPersonales
    {
        private string nombre;
        private string segundoNombre;
        private string apellidoPaterno;
        private string apellidoMaterno;

        [DataMember]
        public string Nombre { get => nombre; set => nombre = value; }
        [DataMember]
        public string SegundoNombre { get => segundoNombre; set => segundoNombre = value; }
        [DataMember]
        public string ApellidoPaterno { get => apellidoPaterno; set => apellidoPaterno = value; }
        [DataMember]
        public string ApellidoMaterno { get => apellidoMaterno; set => apellidoMaterno = value; }
    }
}
