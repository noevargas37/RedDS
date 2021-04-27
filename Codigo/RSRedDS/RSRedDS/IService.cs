using RSRedDSCore.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RSRedDS
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        [WebInvoke(Method = "GET",
UriTemplate = "/Home", ResponseFormat = WebMessageFormat.Json,
BodyStyle = WebMessageBodyStyle.Wrapped)]
        ValidarServicioOUT ValidarServicio();

        [OperationContract]
        [WebInvoke(Method = "GET",
UriTemplate = "Validar/AccesoBD", ResponseFormat = WebMessageFormat.Json,
BodyStyle = WebMessageBodyStyle.Wrapped)]
        ValidarServicioOUT ValidarAccesoBD();


        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json,
  UriTemplate = "Validar/Acceso", ResponseFormat = WebMessageFormat.Json,
  BodyStyle = WebMessageBodyStyle.Wrapped)]
        ValidarAccesoOUT ValidarAcceso(ValidarAccesoIN DatosEntrada);


        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json,
  UriTemplate = "Validar/Credenciales", ResponseFormat = WebMessageFormat.Json)]
        ValidarCredencialesOUT ValidarCredenciales(ValidarCredencialesIN DatosEntrada);

      

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json,
   UriTemplate = "/TokenizarDispositivo", ResponseFormat = WebMessageFormat.Json,
   BodyStyle = WebMessageBodyStyle.Wrapped)]
        TokenizarDispositivoOUT TokenizarDispositivo(TokenizarDispositivoIN DatosEntrada);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json,
   UriTemplate = "/RegistroClientes", ResponseFormat = WebMessageFormat.Json,
   BodyStyle = WebMessageBodyStyle.Wrapped)]
        RegistroClientesOUT RegistroClientes(RegistroClientesIN DatosEntrada);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json,
   UriTemplate = "/GenerarCodigoRed", ResponseFormat = WebMessageFormat.Json,
   BodyStyle = WebMessageBodyStyle.Wrapped)]
        GenerarCodigoRedOUT GenerarCodigoRed(GenerarCodigoRedIN DatosEntrada);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json,
   UriTemplate = "/AltaMovil", ResponseFormat = WebMessageFormat.Json,
   BodyStyle = WebMessageBodyStyle.Wrapped)]
        AltaMovilOUT AltaMovil(AltaMovilIN DatosEntrada);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json,
        UriTemplate = "/RecuperarPassword", ResponseFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Wrapped)]
        RecuperarPasswordOUT RecuperarPassword(RecuperarPasswordIN DatosEntrada);

    }

}
