using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Tienda_virtual.Models.ModelosAux;

namespace Tienda_virtual.Servicios.APIRest
{
    public class RequestParametros<T> : Request<T>
    {
        /*VERBOS GET Y DELETE*/
        public RequestParametros(String url, String verbo)
        {
            Url = url;
            Verbo = verbo;
        }
        #region Métodos
        public override async Task<APIResponse> SendRequest(T objeto)
        {
            APIResponse respuesta = new APIResponse()
            {
                Code = 400,
                IsSucess = false,
                Response = ""
            };
            try
            {
                using (var client = new HttpClient())
                {
                    var verboHttp = (Verbo == "GET") ? HttpMethod.Get : HttpMethod.Delete;
                    await this.ConstruirURL(objeto);
                    HttpRequestMessage requestMessage = new HttpRequestMessage(verboHttp, Url);
                    requestMessage = ServicioHeaders.AgregarCabeceras(requestMessage);
                    HttpResponseMessage HttpResponse = await client.SendAsync(requestMessage);
                    respuesta.Code = Convert.ToInt32(HttpResponse.StatusCode);
                    respuesta.IsSucess = HttpResponse.IsSuccessStatusCode;
                    respuesta.Response = await HttpResponse.Content.ReadAsStringAsync();
                }

            }
            catch (Exception)
            {
                respuesta.Response = "Error al momento de llamar al servidor";
            }
            
            return respuesta;
        }
        private async Task ConstruirURL(T parametros)
        {
            ParametersRequest Parametros = parametros as ParametersRequest;
            //3.23.25.3:8900/consultar/usuario/1
            //3.23.25.3:8900/consultar/usuario/1/ <---- se debe quitar el ult /
            if(Parametros.Parametros.Count > 0)
            {
                // condicion ? hace esto si se cumple : hace esto sino.
                Url = (Url.Substring(Url.Length - 1) == "/") ? Url.Remove(Url.Length - 1) : Url;
                //3.23.25.3:8900/consultar/usuario/1/2 agregar parametros a la Url con /:
                Parametros.Parametros.ForEach(p => Url += "/" + p);
            }

            if (Parametros.QueryParametros.Count > 0)
            {
                var queryParameters = await new FormUrlEncodedContent(Parametros.QueryParametros).ReadAsStringAsync();
                Url += queryParameters;
            }
        }
        #endregion Métodos

    }
}
