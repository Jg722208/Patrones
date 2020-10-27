using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Estado_Servidor_Saturado : Estado_Servidor
    {
        public override void Respuesta()
        {
            Task.Delay(1000);
            Console.WriteLine("El servidor está Saturado y ha respondido luego de un delay de 1000");
        }
    }
}
