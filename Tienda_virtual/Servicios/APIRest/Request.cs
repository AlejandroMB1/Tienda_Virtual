using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tienda_virtual.Models.ModelosAux;

namespace Tienda_virtual.Servicios.APIRest
{
    public abstract class Request<T>
    {
        #region Properties
        protected String Url { get; set; }
        protected String Verbo { get; set; }

        private static ServicioHeaders servicioHeaders;

        #endregion Properties
        #region Métodos
        protected static ServicioHeaders ServicioHeaders
        {
            get{
                if(servicioHeaders == null)
                {
                    servicioHeaders = new ServicioHeaders();
                }
                return servicioHeaders;
            }
        }
        public abstract Task<APIResponse> SendRequest(T objeto);
        #endregion Métodos
    }
}
