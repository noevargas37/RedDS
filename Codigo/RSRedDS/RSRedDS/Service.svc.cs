using RSRedDSCore.BussinesLogic;
using RSRedDSCore.Models.DTO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RSRedDS
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service.svc o Service.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service : IService
    { 
        public ValidarServicioOUT ValidarServicio()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            ValidarServicioOUT response = null;    
            try
            {
                response = new ValidarServicioOUT();
                response.Status = "Servicio Disponible";
            }
            catch (Exception exc)
            {
                response = new ValidarServicioOUT(exc);
            }
            finally
            {
                stopwatch.Stop();
                response.TiempoEjecucion = $"{stopwatch.ElapsedMilliseconds} milisegundos";
            }
            return response;
        }
        public ValidarServicioOUT ValidarAccesoBD()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            ValidarServicioOUT response = null;
            try
            {
                new Operaciones().ValidarAccesoBD();
                response = new ValidarServicioOUT() { Status = "Servicio Disponible" };
            }
            catch (Exception exc)
            {
                response = new ValidarServicioOUT(exc);
            }
            finally
            {
                stopwatch.Stop();
                response.TiempoEjecucion = $"{stopwatch.ElapsedMilliseconds} milisegundos";
            }
            return response;
        }

        public ValidarAccesoOUT ValidarAcceso(ValidarAccesoIN DatosEntrada)
        {
            ValidarAccesoOUT response=new ValidarAccesoOUT();
            try
            {
              
            }
            catch (Exception exc)
            {
                response = new ValidarAccesoOUT(exc);
            }
            return response;
        }

        public ValidarCredencialesOUT ValidarCredenciales(ValidarCredencialesIN DatosEntrada)
        {
            ValidarCredencialesOUT response = new ValidarCredencialesOUT();
            try
            {
                response = new Operaciones().Autenticacion(DatosEntrada);
            }
            catch (Exception exc)
            {
                response = new ValidarCredencialesOUT(exc);
            }
            return response;

        }

        public TokenizarDispositivoOUT TokenizarDispositivo(TokenizarDispositivoIN DatosEntrada)
        {
            TokenizarDispositivoOUT response = new TokenizarDispositivoOUT();
            try
            {

            }
            catch (Exception exc)
            {
                response = new TokenizarDispositivoOUT(exc);
            }
            return response;
        }

        public RegistroClientesOUT RegistroClientes(RegistroClientesIN DatosEntrada)
        {
            RegistroClientesOUT response = new RegistroClientesOUT();
            try
            {

            }
            catch (Exception exc)
            {
                response = new RegistroClientesOUT(exc);
            }
            return response;

        }

        public GenerarCodigoRedOUT GenerarCodigoRed(GenerarCodigoRedIN DatosEntrada)
        {
            GenerarCodigoRedOUT response = new GenerarCodigoRedOUT();
            try
            {

            }
            catch (Exception exc)
            {
                response = new GenerarCodigoRedOUT(exc);
            }
            return response;
        }

       

        public AltaMovilOUT AltaMovil(AltaMovilIN DatosEntrada)
        {
            AltaMovilOUT response = new AltaMovilOUT();
            try
            {

            }
            catch (Exception exc)
            {
                response = new AltaMovilOUT(exc);
            }
            return response;
        }

      
        public RecuperarPasswordOUT RecuperarPassword(RecuperarPasswordIN DatosEntrada)
        {
            RecuperarPasswordOUT response = new RecuperarPasswordOUT();
            try
            {

            }
            catch (Exception exc)
            {
                response = new RecuperarPasswordOUT(exc);
            }
            return response;
        }
    }
}
