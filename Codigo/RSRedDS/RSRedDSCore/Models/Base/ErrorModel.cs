using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSRedDSCore.Models.Base
{
    public class ErrorModel
    {
        private string descripcion;
        private long numero;

        public string Descripcion { get => descripcion; set => descripcion = value; }
        public long Numero { get => numero; set => numero = value; }
    }
}
