using System;
using System.Collections.Generic;
using System.Text;
using Tienda_virtual.Models;
using Tienda_virtual.Propagacion;

namespace Tienda_virtual.Models
{
    public class ProductoModel : NotificationObjectModel
    {
        #region Properties
        public long ID { get; set; }
        private Double precio;
        private String nombre;
        private Double tamano;
        private String fechaVencimiento;
        private UbicacionModel ubicacion;
        private EstadoProductoModel estado;
        public QRModel QR { get; set; }
        private PedidoModel pedido;
        #endregion Properties

        #region Initialize
        public ProductoModel(EstadoProductoModel estado, QRModel QR, UbicacionModel ubicacion) 
        {
            this.estado = estado;
            this.QR = QR;
            this.ubicacion = ubicacion;
        }
        #endregion Initialize

        #region Getters/Setters
        public Double Precio
        {
            get { return precio; }
            set
            {
                precio = value;
                OnPropertyChanged();
            }
        }
        public string Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;
                OnPropertyChanged();
            }
        }
        public Double Tamano
        {
            get { return tamano; }
            set
            {
                tamano = value;
                OnPropertyChanged();
            }
        }
        public String FechaVencimiento
        {
            get { return fechaVencimiento; }
            set
            {
                fechaVencimiento = value;
                OnPropertyChanged();
            }
        }

        public UbicacionModel Ubicacion
        {
            get { return ubicacion; }
            set
            {
                ubicacion = value;
                OnPropertyChanged();
            }
        }
        public EstadoProductoModel Estado
        {
            get { return estado; }
            set
            {
                estado = value;
                OnPropertyChanged();
            }
        }
        public PedidoModel Pedido
        {
            get { return pedido; }
            set
            {
                pedido = value;
                OnPropertyChanged();
            }
        }
        #endregion Getters/Setters
    }
}
