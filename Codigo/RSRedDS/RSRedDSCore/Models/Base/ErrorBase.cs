using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RSRedDSCore.Models.Base
{
    [DataContract]
    public class ErrorBase
    { 
        private ErrorModel error;

        private string tiempoEjecucion;

        [DataMember]
        public ErrorModel Error { get => error; set => error = value; }
        
        [DataMember]
        public string TiempoEjecucion { get => tiempoEjecucion; set => tiempoEjecucion = value; }


        public ErrorBase()
        {
            this.error = new ErrorModel() { Descripcion = null, Numero = 0 };
        }

        public ErrorBase(ErrorModel Error)
        {
            this.error = Error;
        }

        public ErrorBase(Exception Exception)
        {
            this.error = new ErrorModel() { Numero = 1256, Descripcion = Exception.Message };
        }
    }
}
