using System;
using System.Collections.Generic;
using System.Text;
using Tienda_virtual.Propagacion;
using Tienda_virtual.Models;

namespace Tienda_virtual.Models
{
    public class QRModel : NotificationObjectModel
    {
        #region Properties
        public long ID { get; set; }
        public String Mensaje { get; set; }
        public String Referencia { get; set; }
        public CategoriaModel Categoria { get; set; }
        public ProductoModel Producto { get; set; }
        #endregion Properties
        #region Initialize
        public QRModel(CategoriaModel Categoria)
        {
            this.Categoria = Categoria;
        }
        #endregion Initialize

        #region Getters/Setters
     
        #endregion Getters/Setters
    }
}
