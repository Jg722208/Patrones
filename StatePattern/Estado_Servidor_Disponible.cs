using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    class Estado_Servidor_Disponible : Estado_Servidor
    {
        public override void Respuesta()
        {
            Console.WriteLine("El Servidor está disponible");
        }
    }
}
