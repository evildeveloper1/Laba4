using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingOrganism
{
    class LivingOrganism
    {
        public double Energy { get; set; }
        public int Age { get; set; }
        public double Size { get; set; }

        public LivingOrganism(double energy, int age, double size)
        {
            Energy = energy;
            Age = age;
            Size = size;
        }
    }
}