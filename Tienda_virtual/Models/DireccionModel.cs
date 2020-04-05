using System;
using System.Collections.Generic;
using System.Text;
using Tienda_virtual.Models;
using Tienda_virtual.Propagacion;

namespace Tienda_virtual.Models
{
    public class DireccionModel : NotificationObjectModel
    {
        #region Properties
        public long ID { get; set; }
        public UsuarioModel Usuario { get; set; }

        private String direccion;

        private String complementos;

        private String comentarios;

        private Boolean esFavorita;

        #endregion Properties

        #region Initialize
        public DireccionModel() { }
        #endregion Initialize

        #region Getters/Setters
        public String Direccion
        {
            get { return direccion; }
            set
            {
                direccion = value;
                OnPropertyChanged();
            }
        }
        public String Complementos
        {
            get { return complementos; }
            set
            {
                complementos = value;
                OnPropertyChanged();
            }
        }
        public String Comentarios
        {
            get { return comentarios; }
            set
            {
                comentarios = value;
                OnPropertyChanged();
            }
        }
        public Boolean EsFavorita
        {
            get { return esFavorita; }
            set
            {
                esFavorita = value;
                OnPropertyChanged();
            }
        }

        #endregion Getters/Setters
    }
}
