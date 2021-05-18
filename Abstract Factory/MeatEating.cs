using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class MeatEating : MeatEater
    {
        public string Name { get; set; }
        public string Voice { get; set; }
        public int LifeTime { get; set; }
        public MeatEating()
        {
            Name = "Lion";
            Voice = "HARRR";
            LifeTime = 15;
        }
    }
}
