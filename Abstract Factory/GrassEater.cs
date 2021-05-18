using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    interface GrassEater
    {
        string Name { get; set; }
        string Voice { get; set; }
        int LifeTime { get; set; }

    }
}
