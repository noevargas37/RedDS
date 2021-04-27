using RSRedDSCore.DataBase;
using RSRedDSCore.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSRedDSCore.BussinesLogic
{
    public class Operaciones
    {
       
        public ValidarCredencialesOUT Autenticacion(ValidarCredencialesIN DatosEntrada)
        {
            using (BDRedDS BD=new BDRedDS())
            {
                BD.ValidarCredenciales(DatosEntrada);
            }
            return new ValidarCredencialesOUT();

        }


       public void ValidarAccesoBD()
        {
            using (BDRedDS BD = new BDRedDS())
            {
                BD.ValidarConexion();
            }
        }
    }
}
