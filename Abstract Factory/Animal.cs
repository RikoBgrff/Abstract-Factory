using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class Animal : AbstractFactory
    {
        public override GrassEater CreateGrassEater()
        {
            return new GrassEating();
        }

        public override MeatEater CreateMeatEater()
        {
            return new MeatEating();
        }
    }
}
