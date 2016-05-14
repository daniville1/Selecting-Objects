using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Seleccion_OpenGL
{
    class Cone
    {
        public double radio;
        public double altura;
        public bool visible;
        public double posX, posY, posZ;

        public Cone(double radio, double altura, bool visible)
        {
            this.radio = radio;
            this.altura = altura;
            this.visible = visible;
            posX = posY = posZ = 0;
        }
    }
}
