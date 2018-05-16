using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Encuestas
{
    class Datos:Notificable
    {
        #region Atributos
        private ObservableCollection<Encuesta> encuestas;
        private Encuesta encuestaSeleccionada;
        #endregion

        public ObservableCollection <Encuesta> Encuestas
        {
            get
            {
                return encuestas;
            }
            set
            {
                if (encuestas == value)
                {
                    return;
                }
                encuestas = value;
                OnPropertyChanged();
            }

        }
    }
}
