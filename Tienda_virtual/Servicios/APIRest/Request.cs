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

        #endregion Properties
        #region Métodos
        public abstract Task<APIResponse> SendRequest(T objeto);
        #endregion Métodos
    }
}
