//using SQLite;
//using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
using Tienda_virtual.Models;
using Tienda_virtual.Propagacion;

namespace Tienda_virtual.Models
{
    public class UsuarioModel : NotificationObjectModel
    {
        #region Properties

        public long IDUsuario { get; set; }

        private string nombre;

        public string Correo { get; set; }

        public string Usuario { get; set; }

        private List<DireccionModel> direcciones;

        private PerfilModel perfil;

        private List<PedidoModel> pedidos;

        #endregion Properties

        #region initialize
        public UsuarioModel(PerfilModel perfil)
        {
            this.perfil = perfil;
        }

        #endregion initialize

        #region Getters/Setters
        public string Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;
                OnPropertyChanged();
            }
        }
        /* relacion de 0 a mucho con direccion*/
        public List<DireccionModel> Direcciones
        {
            get { return direcciones; }
            set
            {
                direcciones = value;
                OnPropertyChanged();
            }
        }
        public PerfilModel Perfil
        {
            get { return perfil; }
            set
            {
                perfil = value;
                OnPropertyChanged();
            }
        }
        public List<PedidoModel> Pedidos
        {
            get { return pedidos; }
            set
            {
                pedidos = value;
                OnPropertyChanged();
            }
        }
        #endregion Getters/Setters
    }
}
