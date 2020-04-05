using System;
using System.Collections.Generic;
using System.Text;

namespace Tienda_virtual.Models.ModelosAux
{
    public class APIResponse
    {
        #region Properties
        public int Code { get; set; }
        public String Response { get; set; }
        public Boolean IsSucess { get; set; }
        #endregion Properties

        #region Initialize
        public APIResponse() { }
        #endregion Initialize
    }
}
