﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Hija: Padre
    {
        public override void showMessage()
        {
            base.showMessage();
            Console.WriteLine("Hola desde la clase hija.");
        }
    }
}
