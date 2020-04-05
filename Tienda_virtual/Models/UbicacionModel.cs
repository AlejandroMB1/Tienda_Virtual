using System;
using System.Collections.Generic;
using System.Text;
using Tienda_virtual.Propagacion;
using Tienda_virtual.Models;

namespace Tienda_virtual.Models
{
    public class UbicacionModel : NotificationObjectModel
    {
        #region Properties
        public long ID { get; set; }

        private String lugar;
        public ProductoModel Producto { get; set; }
        #endregion Properties
        #region Initialize
        public UbicacionModel() { }
        #endregion Initialize

        #region Getters/Setters
        public String Lugar
        {
            get { return lugar; }
            set
            {
                lugar = value;
                OnPropertyChanged();
            }
        }
        #endregion Getters/Setters
    }
}
