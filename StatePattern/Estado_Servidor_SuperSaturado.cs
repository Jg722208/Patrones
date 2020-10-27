using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Estado_Servidor_SuperSaturado : Estado_Servidor
    {
        public override void Respuesta()
        {
            Task.Delay(2000);
            Console.WriteLine("El servidor está SuperSaturado y ha respondido luego de un delay de 2000");
        }
    }
}
