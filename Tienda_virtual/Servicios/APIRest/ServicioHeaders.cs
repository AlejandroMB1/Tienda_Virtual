﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Tienda_virtual.Servicios.APIRest
{
    public class ServicioHeaders
    {
        #region Properties
        public Dictionary<String, String> Headers { get; set; }
        #endregion Properties

        #region Initialize
        public ServicioHeaders()
        {
            Headers.Add("content-type", "application/json");
        }
        #endregion Initialize

        #region Metodos
        public HttpRequestMessage AgregarCabeceras(HttpRequestMessage requestMessage)
        {
            foreach(var h in Headers)
            {
                requestMessage.Headers.Add(h.Key, h.Value);
            }
            return requestMessage;
        }
        #endregion Metodos
    }
}
