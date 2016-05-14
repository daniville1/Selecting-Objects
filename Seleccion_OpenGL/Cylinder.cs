using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Seleccion_OpenGL
{
    class Cylinder
    {
        public double radio;
        public double altura;
        public bool visible;
        public double posX, posY, posZ;

        public Cylinder(double radio, double altura, bool visible)
        {
            this.radio = radio;
            this.altura = altura;
            this.visible = visible;
            posX = posY = posZ = 0;
        }
    }
}
