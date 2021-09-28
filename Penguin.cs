using System;
using System.Collections.Generic;
using System.Text;

namespace Task6._1
{
    class Penguin : Bird
    {

        public override void Fly()
        {
            Console.WriteLine("Penguin Cannot Fly");
        }

        public override string ToString()
        {
            return "A Penguin Called " + base.Name;
        }

    }
}
