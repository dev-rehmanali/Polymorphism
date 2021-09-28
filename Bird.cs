using System;

namespace Task6._1
{
    class Bird
    {

        private string name;

        public string Name {

            get {

                return this.name;
            }
            set {

                this.name = value;
            }
        }

        public Bird() 
        {

        }

        public virtual void Fly() 
        {
            Console.WriteLine("Flap, Flap, Flap");
        }

        public override string ToString()
        {
            return "A Bird Called " + Name;
        }



    }
}
