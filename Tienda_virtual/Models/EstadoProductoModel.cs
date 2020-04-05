using System;
using System.Collections.Generic;
using System.Text;
using Tienda_virtual.Models;
using Tienda_virtual.Propagacion;

namespace Tienda_virtual.Models
{
    public class EstadoProductoModel : NotificationObjectModel
    {
        #region Properties
        public long ID { get; set; }

        private String estado;
        public ProductoModel Producto { get; set; }
        #endregion Properties
        #region Initialize
        public EstadoProductoModel() { }
        #endregion Initialize

        #region Getters/Setters
        public String Estado
        {
            get { return estado; }
            set
            {
                estado = value;
                OnPropertyChanged();
            }
        }
        #endregion Getters/Setters
    }
}
