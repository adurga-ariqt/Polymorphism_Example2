using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Example
{
    public  class Circle:Shape
    {
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Circle drawing ");
        }
    }
}
