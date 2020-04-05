using System;
using System.Collections.Generic;
using System.Text;
using Tienda_virtual.Propagacion;
using Tienda_virtual.Models;

namespace Tienda_virtual.Models
{
    public class PedidoModel : NotificationObjectModel 
    {
        #region Properties
        public long ID { get; set; }

        private Double valorTotal; 

        private EstadoPedidoModel estadoPedido;

        private List<ProductoModel> productos;

        public UsuarioModel Usuario { get; set; }
        #endregion Properties

        #region Initialize
        public PedidoModel(EstadoPedidoModel estadoPedido)
        {
            this.estadoPedido = estadoPedido;
        }
        #endregion Initialize

        #region Getters/Setters

        public Double ValorTotal
        {
            get { return valorTotal; }
            set
            {
                valorTotal = value;
                OnPropertyChanged();
            }
        }
        public EstadoPedidoModel EstadoPedido
        {
            get { return estadoPedido; }
            set
            {
                estadoPedido = value;
                OnPropertyChanged();
            }
        }

        public List<ProductoModel> Productos
        {
            get { return productos; }
            set
            {
                productos = value;
                OnPropertyChanged();
            }
        }
        #endregion Getters/Setters
    }
}
