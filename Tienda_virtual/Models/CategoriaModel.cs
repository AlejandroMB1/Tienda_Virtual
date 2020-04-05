using System;
using System.Collections.Generic;
using System.Text;
using Tienda_virtual.Propagacion;
using Tienda_virtual.Models;

namespace Tienda_virtual.Models
{
    public class CategoriaModel : NotificationObjectModel
    {
        #region Properties
        public long ID { get; set; }
        public String Categoria { get; set; }
        public QRModel QR { get; set; }
        #endregion Properties
        #region Initialize
        public CategoriaModel() { }
        #endregion Initialize
    }
}
