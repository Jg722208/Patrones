using System;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ServidorContext oServidor = new ServidorContext();

            oServidor.State = new Estado_Servidor_Disponible();
            oServidor.AtenderSolicitud();

            oServidor.State = new Estado_Servidor_Saturado();
            oServidor.AtenderSolicitud();

            oServidor.State = new Estado_Servidor_SuperSaturado();
            oServidor.AtenderSolicitud();

            oServidor.State = new Estado_Servidor_Caido();
            oServidor.AtenderSolicitud();
            
        }
    }
}
