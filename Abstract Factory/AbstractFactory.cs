﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    abstract class AbstractFactory
    {
        public abstract MeatEater CreateMeatEater();
        public abstract GrassEater CreateGrassEater();

    }
}
