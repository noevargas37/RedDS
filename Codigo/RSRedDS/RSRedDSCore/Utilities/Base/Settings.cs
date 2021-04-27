using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSRedDSCore.Utilities.Base
{

    public class Settings
    {
        public static string App(string Nombre)
        {
            string valor = string.Empty;
            try
            {
                valor = ConfigurationManager.AppSettings[Nombre];
            }
            catch
            {

                throw new Exception($"No se pudo leer el parametro {Nombre} del archivo de configuración");
            }
            return valor;
        }

        public static int AppInt(string Nombre)
        {
            return int.Parse(App(Nombre));
        }

        public static double AppDouble(string Nombre)
        {
            return double.Parse(App(Nombre));
        }

        public static float AppFloat(string Nombre)
        {
            return float.Parse(App(Nombre));
        }

        public static bool AppBool(string Nombre)
        {
            return bool.Parse(App(Nombre));
        }

        public static string ConnectionString(string Nombre)
        {
            string valor = string.Empty;
            try
            {
                //valor = Encripcion.TripleDES.Desencriptar(ConfigurationManager.ConnectionStrings[Nombre].ToString());
                valor = ConfigurationManager.ConnectionStrings[Nombre].ToString();
            }
            catch
            {

                throw new Exception($"No se pudo leer la cadena de conexion {Nombre} del archivo de configuración");
            }
            return valor;
        }
    }
}
