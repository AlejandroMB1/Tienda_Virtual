using System;
using System.Collections.Generic;
using System.Text;


namespace Tienda_virtual.Servicios.APIRest
{
    public class ElegirRequest<T>
    {
        #region Properties
        public Request<T> EstrategiaEnvio { get; set; }
   
        #endregion Properties

        #region Initialize
        public ElegirRequest() { }
        #endregion Initialize

        #region Métodos
        public void ElegirEstrategia(String verbo, String url)
        {

        }
        #endregion Métodos
    }
}
