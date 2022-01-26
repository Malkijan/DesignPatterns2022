using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Structural.Flyweight
{
    // Flyweight (Box) şablonunu uygulayan sınıftır.
    // UML diyagramındaki ConcreteFlyweight sınıfına denk gelmektedir.
    class BlackBox : Box
    {
        public BlackBox(int width, int height)
        {
            this.width = width;
            this.height = height;
            this.boxColor = BoxColor.Black;
        }

        public override void Draw(int locationX, int locationY)
        {
            Console.WriteLine($"{boxColor} box drawn. {locationX},{locationY}");
        }
    }
}
