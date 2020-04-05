using System;
using System.Collections.Generic;
using System.Text;
using Tienda_virtual.Models;
using Tienda_virtual.Propagacion;

namespace Tienda_virtual.Models
{
    public class TelefonoModel : NotificationObjectModel
    {
        #region Properties
        public long ID { get; set; }
        private String tipo;
        private String numero;
        public UsuarioModel Usuario { get; set; }
        #endregion Properties

        #region Initialize
        public TelefonoModel() { }
        #endregion Initialize
        #region Getters/Setters
        public String Tipo
        {
            get { return tipo; }
            set 
            {
                tipo = value;
                OnPropertyChanged();
            }
        }
        public String Numero
        {
            get { return numero; }
            set
            {
                numero = value;
                OnPropertyChanged();
            }
        }

        #endregion Getters/Setters
    }
}
