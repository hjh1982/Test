using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace engine
{
    public class Wave
    {
        public int ID;
        public SubWave[] SubWaves = new SubWave[1];
        public float Interval;
    }
}
