using System;
using System.Collections.Generic;
using System.Text;
using Tienda_virtual.Propagacion;
using Tienda_virtual.Models;

namespace Tienda_virtual.Models
{
    public class PerfilModel : NotificationObjectModel
    {
        #region Properties
        public long ID { get; set; }

        private String nombrePerfil;

        public UsuarioModel Usuario { get; set; }
        #endregion Properties
        #region Initialize
        public PerfilModel() { }
        #endregion Initialize

        #region Getters/Setters
        public String NombrePerfil
        {
            get { return nombrePerfil; }
            set
            {
                nombrePerfil = value;
                OnPropertyChanged();
            }
        }
        #endregion Getters/Setters
    }
}
