using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace poligono
{
    class figura
    {
        protected int p;
        protected int ap;
        protected double a;

        public int P
        {
            get { return p; }
            set { p = value; }
        }
        
        public int AP
        {
            get { return ap; }
            set { ap = value; }
        }

        public double A
        {
            get { return a; }
            set { a = value; }
        }
    }
}
