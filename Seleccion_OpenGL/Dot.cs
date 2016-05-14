﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Seleccion_OpenGL
{
    class Dot
    {
        public Color color;
        public decimal[] dot = new decimal[4];
        public decimal[,] matrix = FactoryMatrix.getIdentity();
        public bool visible;

        public Dot()
        {
            dot[0] = 0;
            dot[1] = 0;
            dot[2] = 0;
            dot[3] = 1;
            visible = true;
        }
    }
}

