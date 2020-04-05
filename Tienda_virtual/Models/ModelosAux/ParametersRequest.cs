using System;
using System.Collections.Generic;
using System.Text;

namespace Tienda_virtual.Models.ModelosAux
{
    public class ParametersRequest
    {
        #region Properties
        public List<String> Parametros { get; set; }
        public List<String> QueryParametros { get; set; }
       
        #endregion Properties

        #region Initialize
        public ParametersRequest() { }
        #endregion Initialize
    }
}
