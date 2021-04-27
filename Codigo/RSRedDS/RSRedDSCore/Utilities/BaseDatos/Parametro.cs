using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSRedDSCore.Utilities.BaseDatos
{
    public class Parametro
    {
        public Dictionary<string, string> DeSalida = new Dictionary<string, string>();
        /// <summary>
        /// Genera un parametro de entrada que se enviará un procedimiento almacenado
        /// </summary>
        /// <param name="Nombre">Nombre de parametro</param>
        /// <param name="Tipo">Tipo de dato</param>
        /// <returns></returns>
        public static SqlParameter Entrada(string Nombre, SqlDbType Tipo)
        {
            return AddParameterToCommand(Nombre, Tipo, 0, 0, "", ParameterDirection.Input);
        }
        /// <summary>
        /// Genera un parametro de salida que se enviará un procedimiento almacenado
        /// </summary>
        /// <param name="Nombre">Nombre de parametro</param>
        /// <param name="Tipo">Tipo de dato</param>
        /// <returns></returns>
        public static SqlParameter Salida(string Nombre, SqlDbType Tipo)
        {
            return AddParameterToCommand(Nombre, Tipo, 0, 0, "", ParameterDirection.Output);
        }
        //--
        /// <summary>
        /// Genera un parametro de entrada que se enviará un procedimiento almacenado
        /// </summary>
        /// <param name="Nombre">Nombre de parametro</param>
        /// <param name="Tipo">Tipo de dato</param>
        /// <param name="Tamano">Tamaño de parametro</param>
        /// <returns></returns>
        public static SqlParameter Entrada(string Nombre, SqlDbType Tipo, int Tamano)
        {
            return AddParameterToCommand(Nombre, Tipo, Tamano, 0, "", ParameterDirection.Input);
        }
        /// <summary>
        /// Genera un parametro de salida que se enviará un procedimiento almacenado
        /// </summary>
        /// <param name="Nombre">Nombre de parametro</param>
        /// <param name="Tipo">Tipo de dato</param>
        /// <param name="Tamano">Tamaño de parametro</param>
        /// <returns></returns>
        public static SqlParameter Salida(string Nombre, SqlDbType Tipo, int Tamano)
        {
            return AddParameterToCommand(Nombre, Tipo, Tamano, 0, "", ParameterDirection.Output);
        }
        //--
        /// <summary>
        /// Genera un parametro de entrada que se enviará un procedimiento almacenado
        /// </summary>
        /// <param name="Nombre">Nombre de parametro</param>
        /// <param name="Tipo">Tipo de dato</param>
        /// <param name="Valor">Valor asignado al parametro</param>
        /// <returns></returns>
        public static SqlParameter Entrada(string Nombre, SqlDbType Tipo, string Valor)
        {
            return AddParameterToCommand(Nombre, Tipo, 0, 0, Valor, ParameterDirection.Input);
        }
        /// <summary>
        /// Genera un parametro de salida que se enviará un procedimiento almacenado
        /// </summary>
        /// <param name="Nombre">Nombre de parametro</param>
        /// <param name="Tipo">Tipo de dato</param>
        /// <param name="Valor">Valor asignado al parametro</param>
        /// <returns></returns>
        public static SqlParameter Salida(string Nombre, SqlDbType Tipo, string Valor)
        {
            return AddParameterToCommand(Nombre, Tipo, 0, 0, Valor, ParameterDirection.Output);
        }
        //--
        /// <summary>
        /// Genera un parametro de entrada que se enviará un procedimiento almacenado
        /// </summary>
        /// <param name="Nombre">Nombre de parametro</param>
        /// <param name="Tipo">Tipo de dato</param>
        /// <param name="Valor">Valor asignado al parametro</param>
        /// <returns></returns>
        public static SqlParameter Entrada(string Nombre, SqlDbType Tipo, byte[] Valor)
        {
            return AddParameterToCommand(Nombre, Tipo, 0, 0, Valor, ParameterDirection.Input);
        }
        /// <summary>
        /// Genera un parametro de salida que se enviará un procedimiento almacenado
        /// </summary>
        /// <param name="Nombre">Nombre de parametro</param>
        /// <param name="Tipo">Tipo de dato</param>
        /// <param name="Valor">Valor asignado al parametro</param>
        /// <returns></returns>
        public static SqlParameter Salida(string Nombre, SqlDbType Tipo, byte[] Valor)
        {
            return AddParameterToCommand(Nombre, Tipo, 0, 0, Valor, ParameterDirection.Output);
        }
        //-
        /// <summary>
        /// Genera un parametro de entrada que se enviará un procedimiento almacenado
        /// </summary>
        /// <param name="Nombre">Nombre de parametro</param>
        /// <param name="Tipo">Tipo de dato</param>
        /// <param name="Tamano">Tamaño de parametro</param>
        /// <param name="Precision">Presicion del parametro</param>
        /// <returns></returns>
        public static SqlParameter Entrada(string Nombre, SqlDbType Tipo, int Tamano, byte Precision)
        {
            return AddParameterToCommand(Nombre, Tipo, Tamano, Precision, "", ParameterDirection.Input);
        }
        /// <summary>
        /// Genera un parametro de salida que se enviará un procedimiento almacenado
        /// </summary>
        /// <param name="Nombre">Nombre de parametro</param>
        /// <param name="Tipo">Tipo de dato</param>
        /// <param name="Tamano">Tamaño de parametro</param>
        /// <param name="Precision">Presicion del parametro</param>
        /// <returns></returns>
        public static SqlParameter Salida(string Nombre, SqlDbType Tipo, int Tamano, byte Precision)
        {
            return AddParameterToCommand(Nombre, Tipo, Tamano, Precision, "", ParameterDirection.Output);
        }
        //--
        /// <summary>
        ///  Genera un parametro de entrada que se enviará un procedimiento almacenado
        /// </summary>
        /// <param name="Nombre">Nombre de parametro</param>
        /// <param name="Tipo">Tipo de dato</param>
        /// <param name="Tamano">Tamaño de parametro</param>
        /// <param name="Valor">Valor asignado al parametro</param>
        /// <returns></returns>
        public static SqlParameter Entrada(string Nombre, SqlDbType Tipo, int Tamano, string Valor)
        {
            return AddParameterToCommand(Nombre, Tipo, Tamano, 0, Valor, ParameterDirection.Input);
        }
        /// <summary>
        ///  Genera un parametro de salida que se enviará un procedimiento almacenado
        /// </summary>
        /// <param name="Nombre">Nombre de parametro</param>
        /// <param name="Tipo">Tipo de dato</param>
        /// <param name="Tamano">Tamaño de parametro</param>
        /// <param name="Valor">Valor asignado al parametro</param>
        /// <returns></returns>
        public static SqlParameter Salida(string Nombre, SqlDbType Tipo, int Tamano, string Valor)
        {
            return AddParameterToCommand(Nombre, Tipo, Tamano, 0, Valor, ParameterDirection.Output);
        }
        //--
        /// <summary>
        /// Genera un parametro de entrada que se enviará un procedimiento almacenado
        /// </summary>
        /// <param name="Nombre">Nombre de parametro</param>
        /// <param name="Tipo">Tipo de dato</param>
        /// <param name="Tamano">Tamaño de parametro</param>
        /// <param name="Presicion">Presicion del parametro</param>
        /// <param name="Valor">Valor asignado al parametro</param>
        /// <returns></returns>
        public static SqlParameter Entrada(string Nombre, SqlDbType Tipo, int Tamano, byte Presicion, string Valor)
        {
            return AddParameterToCommand(Nombre, Tipo, Tamano, Presicion, Valor, ParameterDirection.Input);
        }
        /// <summary>
        /// Genera un parametro de salida que se enviará un procedimiento almacenado
        /// </summary>
        /// <param name="Nombre">Nombre de parametro</param>
        /// <param name="Tipo">Tipo de dato</param>
        /// <param name="Tamano">Tamaño de parametro</param>
        /// <param name="Presicion">Presicion del parametro</param>
        /// <param name="Valor">Valor asignado al parametro</param>
        /// <returns></returns>
        public static SqlParameter Salida(string Nombre, SqlDbType Tipo, int Tamano, byte Presicion, string Valor)
        {
            return AddParameterToCommand(Nombre, Tipo, Tamano, Presicion, Valor, ParameterDirection.Output);
        }

        private static SqlParameter AddParameterToCommand(string name, SqlDbType sqlDbType, int size, byte precision, string value, ParameterDirection direction)
        {
            SqlParameter parameter = null;
            try
            {
                parameter = new SqlParameter { ParameterName = name, SqlDbType = sqlDbType };

                if (!string.IsNullOrEmpty(value)) { parameter.Value = value; }
                if (size != 0) { parameter.Size = size; }
                if (precision != 0) { parameter.Precision = precision; }
                parameter.Direction = direction;
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return parameter;
        }
        private static SqlParameter AddParameterToCommand(string name, SqlDbType sqlDbType, int size, byte precision, byte[] value, ParameterDirection direction)
        {
            SqlParameter parameter = null;
            try
            {
                parameter = new SqlParameter { ParameterName = name, SqlDbType = sqlDbType };
                if (value != null) { parameter.Value = value; }
                if (size != 0) { parameter.Size = size; }
                if (precision != 0) { parameter.Precision = precision; }
                parameter.Direction = direction;

            }
            catch (Exception exception)
            {
                throw exception;
            }
            return parameter;
        }



    }
}
