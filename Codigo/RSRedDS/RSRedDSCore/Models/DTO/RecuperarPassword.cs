using RSRedDSCore.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSRedDSCore.Models.DTO
{
    public class RecuperarPasswordIN
    {
        private string correoElectronico;

        public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }
    }

    public class RecuperarPasswordOUT : ErrorBase
    {
        public RecuperarPasswordOUT() : base() { }
        public RecuperarPasswordOUT(ErrorModel Error) : base(Error) { }
        public RecuperarPasswordOUT(Exception Exception) : base(Exception) { }
    }
}
