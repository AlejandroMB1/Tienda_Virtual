using System;
using System.Collections.Generic;
using System.Text;
using Tienda_virtual.Models.ModelosAux;

namespace Tienda_virtual.Servicios.APIRest
{
    class RequestParametros<T> : Request<T>
    {
        public override APIResponse SendRequest(T objeto)
        {
            throw new NotImplementedException();
        }
    }
}
