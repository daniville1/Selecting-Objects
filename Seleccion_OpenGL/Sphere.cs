using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Seleccion_OpenGL
{
    class Sphere
    {
        public double radio;
        public bool visible;
        public double posX, posY, posZ;

        public Sphere(double radio, bool visible)
        {
            this.radio = radio;
            this.visible = visible;
            posX = posY = posZ = 0;
        }
    }
}
