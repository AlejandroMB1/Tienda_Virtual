using System;
using System.Collections.Generic;
using System.Text;
using Tienda_virtual.Models;
using Tienda_virtual.Propagacion;

namespace Tienda_virtual.Models
{
    public class EstadoPedidoModel : NotificationObjectModel
    {
        #region Properties
        public long ID { get; set; }

        private String estado;
        public PedidoModel Pedido { get; set; }
        #endregion Properties

        #region Initialize
        public EstadoPedidoModel() { }
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
