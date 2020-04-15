using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Tienda_virtual.Models.ModelosAux;

namespace Tienda_virtual.Servicios.APIRest
{
    public class RequestBody<T> : Request<T>
    {
        /*VERBOS POST Y PUT*/
        public RequestBody(String url, String verbo)
        {
            Url = url;
            Verbo = verbo;
        }
        public override async Task<APIResponse> SendRequest(T objeto)
        {
            APIResponse respuesta = new APIResponse()
            {
                Code = 400,
                IsSucess = false,
                Response = ""
            };
            String objetoJson = JsonConvert.SerializeObject(objeto);
            HttpContent content = new StringContent(objetoJson, Encoding.UTF8, "application/json");
            try
            {
                using (var client = new HttpClient())
                {
                    var verboHttp = (Verbo == "POST") ? HttpMethod.Post : HttpMethod.Put;
                    HttpRequestMessage requestMessage = new HttpRequestMessage(verboHttp, Url);
                    requestMessage = ServicioHeaders.AgregarCabeceras(requestMessage);
                    requestMessage.Content = content;
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
    }
}
