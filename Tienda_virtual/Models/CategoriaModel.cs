using System;
using System.Collections.Generic;
using System.Text;
using Tienda_virtual.Propagacion;
using Tienda_virtual.Models;
using Newtonsoft.Json;

namespace Tienda_virtual.Models
{
    public class CategoriaModel : NotificationObjectModel
    {
        #region Properties
        [JsonIgnore]
        public long ID { get; set; } /*base de datos*/
        [JsonProperty("idCategoria")]
        public long IdCategoria { get; set; } /*API REST*/

        [JsonProperty("nombreCategoria")]
        public String Categoria { get; set; }

        [JsonIgnore]
        public QRModel QR { get; set; }
        #endregion Properties
        #region Initialize
        public CategoriaModel() { }
        #endregion Initialize
    }
}
