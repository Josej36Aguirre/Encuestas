using System;
using System.Collections.Generic;
using System.Text;

namespace Encuestas
{
    public class Encuesta
    {
        #region Propiedades
        public String Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public String EquipoFavorito { get; set; }
        #endregion
       
        #region Metodo
        public override string ToString()
        {
            return $"{Nombre}|{FechaNacimiento}|{EquipoFavorito}";
        }

        
        #endregion
    }
}
