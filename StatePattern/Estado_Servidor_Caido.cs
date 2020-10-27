using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class Estado_Servidor_Caido : Estado_Servidor
    {
        public override void Respuesta()
        {
            Console.WriteLine("Error 503 : Servidor caido");
        }
    }
}
