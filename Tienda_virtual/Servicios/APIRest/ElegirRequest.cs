using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tienda_virtual.Configuracion;
using Tienda_virtual.Models.ModelosAux;

namespace Tienda_virtual.Servicios.APIRest
{
    public class ElegirRequest<T>
    {
        #region Properties
        public Request<T> EstrategiaEnvio { get; set; }
        public ConfiguracionRest ConfiguracionRest { get; set; }
   
        #endregion Properties

        #region Initialize
        public ElegirRequest()
        {
            ConfiguracionRest = new ConfiguracionRest();
        }
        #endregion Initialize

        #region Métodos
        public void ElegirEstrategia(String verbo, String url)
        {
            var diccionario = ConfiguracionRest.VerbosConfiguracion;
            String nombreClase;
            if(diccionario.TryGetValue(verbo.ToUpper(), out nombreClase))
            {
                Type tipoClase = Type.GetType(nombreClase);
                EstrategiaEnvio = (Request<T>)Activator.CreateInstance(tipoClase);
            }

        }

        public async Task<APIResponse> EjecutarEstrategia(T objeto)
        {
            var response = await EstrategiaEnvio.SendRequest(objeto);
            return response;
        }
        #endregion Métodos
    }
}
