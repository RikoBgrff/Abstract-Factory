using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class GrassEating : GrassEater
    {
        public string Name { get; set; }
        public string Voice { get; set; }
        public int LifeTime { get; set; }
        public GrassEating()
        {
            Name = "Cow";
            Voice = "Mooow";
            LifeTime = 22;
        }
    }
}
