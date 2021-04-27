using RSRedDSCore.Models.DTO;
using RSRedDSCore.Utilities.BaseDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RSRedDSCore.DataBase
{
    public class BDRedDS: Servidor,IDisposable
    {
        public BDRedDS() : base("BDRedDS")
        { }

        public void ValidarConexion()
        {
            string response = string.Empty;

            try
            {
                if (!TestConnection("BDRedDS", ref response))
                {
                    throw new Exception(response);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"SQL_{ MethodBase.GetCurrentMethod().Name}: {ex.Message}");
            }
            catch (Exception exc)
            {
                throw new Exception($"{MethodBase.GetCurrentMethod().Name}: {exc.Message}");
            }
        }
        public string ValidarCredenciales(ValidarCredencialesIN DatosEntrada)
        {
            string response = string.Empty;

            try
            {
                ConnectByStoredProcedure("ref_validaCredencialesAcceso", Parametros: new List<SqlParameter>()
            {
               Parametro.Entrada("USUARIO",SqlDbType.VarChar,100,DatosEntrada.Credenciales.Usuario),
               Parametro.Entrada("PASSWORD",SqlDbType.VarChar,100,DatosEntrada.Credenciales.Password),
               Parametro.Salida("ERROR",SqlDbType.VarChar,100),
               Parametro.Salida("TOKENACCESO",SqlDbType.VarChar,100)
            });

                if (!string.IsNullOrEmpty(Parametros.DeSalida["ERROR"])) { throw new Exception(Parametros.DeSalida["ERROR"]); }
                if (!string.IsNullOrEmpty(Parametros.DeSalida["TOKENACCESO"])) { throw new Exception("No se generó identificador de la sesión"); }

                response = Parametros.DeSalida["TOKENACCESO"];
            }
            catch (SqlException ex)
            {
                throw new Exception($"SQL_{ MethodBase.GetCurrentMethod().Name}: {ex.Message}");
            }
            catch (Exception exc)
            {
                throw new Exception($"{MethodBase.GetCurrentMethod().Name}: {exc.Message}");
            }


            return response;
        }

        public void Dispose()
        {
            EndConnection();
        }

    }
}
