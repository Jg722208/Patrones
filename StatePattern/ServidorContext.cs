using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class ServidorContext
    {
        private Estado_Servidor state;

        public Estado_Servidor State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }

        public void AtenderSolicitud()
        {
            state.Respuesta();
        }
    }
}
