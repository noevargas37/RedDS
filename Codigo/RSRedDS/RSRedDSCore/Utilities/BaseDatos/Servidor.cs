using RSRedDSCore.Utilities.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSRedDSCore.Utilities.BaseDatos
{
    public class Servidor : IDisposable
    {
        #region Propiedades
        /// <summary>
        /// Indica si la consulta devolvió almenos un solo registro
        /// </summary>
        public bool DevolvioResultados { get; set; }
        /// <summary>
        /// Devuelve en todos los datos obtenidos en formato XML
        /// </summary>
        public string DatosXml { get; set; }
        /// <summary>
        /// Devuelve los parametros de salida obtenidos de la consulta
        /// </summary>
        public Parametro Parametros { get; set; }
        #endregion

        #region Variables
        private SqlCommand _command = null;
        private SqlConnection _connection = null;
        private SqlDataAdapter _dataAdapter = null;
        private DataSet _dataSet = null;
        private string cadenaConexion = string.Empty;
        #endregion

        public Servidor(string cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
        }
        /// <summary>
        /// Termina la conexion a la base de dato y elimina los objetos relacionados a esta
        /// </summary>
        public void EndConnection()
        {
            if (this._dataSet != null)
            {
                this._dataSet.Dispose();
                this._dataSet = null;
            }
            if (this._dataAdapter != null)
            {
                this._dataAdapter.Dispose();
                this._dataAdapter = null;
            }
            if (this._command != null)
            {
                this._command.Dispose();
                this._command = null;
            }
            if (this._connection != null)
            {
                if (this._connection.State == ConnectionState.Open)
                {
                    this._connection.Close();
                }
                this._connection.Dispose();
                this._connection = null;
            }
        }
        /// <summary>
        /// Ejecuta la operación hacia la base dde datos
        /// </summary>
        void Execute()
        {
            try
            {
                if (ReferenceEquals(this._dataSet, null))
                {
                    this._command.ExecuteNonQuery();
                }
                else
                {
                    this._dataAdapter.Fill(this._dataSet);
                    if ((this._dataSet.Tables?.Count == 0) || (this._dataSet.Tables?[0]?.Rows?.Count == 0))
                    {
                        DevolvioResultados = false;
                    }
                    else
                    {
                        DevolvioResultados = true;
                    }
                }
            }
            catch (SqlException exception)
            {
                throw exception;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public string GetParameterValue(string ParameterName)
        {
            string str = null;
            try
            {
                str = this._command.Parameters[ParameterName].Value.ToString();
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return str;
        }

        public void GetParametersValue(List<SqlParameter> TotalParametros)
        {
            try
            {
                Parametros = new Parametro();
                Parametros.DeSalida = new Dictionary<string, string>();

                List<SqlParameter> parametrosSalida = (from p in TotalParametros
                                                       where p.Direction == ParameterDirection.Output
                                                       select p).ToList<SqlParameter>();

                foreach (SqlParameter parametro in parametrosSalida)
                {
                    Parametros.DeSalida.Add(parametro.ParameterName, GetParameterValue(parametro.ParameterName));
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        protected internal void SetDataSetTablesNames(string[] Names)
        {
            try
            {
                int index = 0;
                while (true)
                {
                    if (index >= this._dataSet.Tables.Count)
                    {
                        break;
                    }
                    this._dataSet.Tables[index].TableName = Names[index];
                    index++;
                }
                DatosXml = this._dataSet.GetXml();
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        private void StartConnection(string Script, CommandType TipoComando, List<SqlParameter> Parametros)
        {
            try
            {
                this._connection = new SqlConnection(Settings.ConnectionString(cadenaConexion));
                this._command = new SqlCommand(Script, this._connection);

                if (!ReferenceEquals(Parametros, null))
                {
                    this._command.Parameters.AddRange(Parametros.ToArray());
                }
                this._command.CommandTimeout = 60;
                this._command.CommandType = TipoComando;
                this._dataAdapter = new SqlDataAdapter(this._command);
                this._connection.Open();

            }
            catch (SqlException exception)
            {
                throw exception;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public void ConnectByStoredProcedure(string Name, string NombreDataSet = "Default", string[] NombresTablas = null, List<SqlParameter> Parametros = null)
        {
            try
            {
                this.StartConnection(Name, CommandType.StoredProcedure, Parametros);
                this._dataSet = new DataSet(NombreDataSet);
                Execute();
                SetDataSetTablesNames(NombresTablas);
                if (!ReferenceEquals(Parametros, null)) { GetParametersValue(Parametros); }
                EndConnection();
            }
            catch (SqlException exception)
            {
                throw exception;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public void ConnectByDirectQuery(string Query, List<SqlParameter> Parametros = null, string NombreDataSet = "Default", string[] Names = null)
        {
            try
            {
                this.StartConnection(Query, CommandType.Text, Parametros);
                this._dataSet = new DataSet(NombreDataSet);
                Execute();
                EndConnection();
            }
            catch (SqlException exception)
            {
                throw exception;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        void IDisposable.Dispose()
        {
            this.EndConnection();
        }

        #region ProbarConexion
        private static void StartConnection(string Conexion)
        {
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(Settings.ConnectionString(Conexion));
                connection.Open();
                connection.Close();
            }
            catch (SqlException exception)
            {
                throw exception;
            }
            catch (Exception exception)
            {
                throw exception;
            }
            finally
            {
                if (!ReferenceEquals(connection, null))
                {
                    connection.Dispose();
                }
                connection = null;
            }
        }
        public static bool TestConnection(string Conexion, ref string DescripcionError)
        {
            bool resultado = false;
            try
            {
                StartConnection(Conexion);
                resultado = true;
            }
            catch (Exception excepcion)
            {
                DescripcionError = $"Error al probar la cadena de conexion {Conexion}: {excepcion.Message}";
            }
            return resultado;
        }
        public static bool PruebaConexion(string Conexion)
        {
            bool resultado = false;
            try
            {
                StartConnection(Conexion);
                resultado = true;
            }
            catch
            {
                resultado = false;
            }
            return resultado;
        }
        #endregion
    }
}
