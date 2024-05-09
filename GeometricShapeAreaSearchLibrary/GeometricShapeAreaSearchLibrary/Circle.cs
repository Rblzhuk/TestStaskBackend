using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapeAreaSearchLibrary
{
    public class Circle : GeometricShape
    {
        private double _radius;

        public double Radius
        {
            get => _radius;
            set
            {
                value = (value >= 0 ? value : 0);

                if (_radius != value)
                {
                    _radius = value;
                }
            }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        //Я не стал создавать и использовать отдельный метод для изменения радиуса, как у треугольника, потому что, изходя из тз, я посчитал достаточным наличие публичного свойства с простой проверкой.
    }
}
