using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace Encuestas
{
    class Datos : Notificable
    {
        #region Atributos
        private ObservableCollection<Encuesta> encuestas;
        private Encuesta encuestaSeleccionada;
        #endregion
        public Datos()
        {
            MessagingCenter.Subscribe<ContentPage, Encuesta>(this, Mensajes.EncuestaCompleta, (sender, args)
               => {
               encuestas.Add((Encuesta)(args));
        });
        } 

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
