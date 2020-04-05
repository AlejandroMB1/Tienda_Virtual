using System;
using System.Collections.Generic;
using System.Text;

namespace Tienda_virtual.Configuracion
{
    public class ConfiguracionRest
    {
        #region Properties
        private readonly String NameSpaceRest;
        public Dictionary<String, String> VerbosConfiguracion { get; set; }
        #endregion Properties

        #region Initialize
        public ConfiguracionRest() 
        {
            NameSpaceRest = "Tienda_virtual.Servicios.APIRest";
            InicializarVerbosConfiguracion();
        }
        #endregion Initialize

        #region Métodos
        private void InicializarVerbosConfiguracion()
        {
            VerbosConfiguracion = new Dictionary<string, string>();
            VerbosConfiguracion.Add("GET", string.Concat(NameSpaceRest, "RequestParametros"));
            VerbosConfiguracion.Add("DELETE", string.Concat(NameSpaceRest, "RequestParametros"));
            VerbosConfiguracion.Add("POST", string.Concat(NameSpaceRest, "RequestBody"));
            VerbosConfiguracion.Add("PUT", string.Concat(NameSpaceRest, "RequestBody"));
        }
        #endregion Métodos
    }
}
