using System;
using System.Collections.Generic;
using System.Text;

namespace Task6._1
{
    class Duck : Bird
    {
        private double size;
        private string kind;

        public double Size{

            get { return size; }
            set { size = value; }
        }

        public string Kind
        {

            get { return kind; }
            set { kind = value; }
        }

        public override string ToString()
        {
            return "A Duck Named " + base.Name + " is a " + size + " inches " + kind;
        }

    }
}
