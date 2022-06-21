using System;
using System.Collections.Generic;
using System.Text;

namespace l3
{
    abstract class Bird
    {
        public string Fly()
        {
            return "It can fly";
        }

        public abstract string Sing();

        public abstract string LayEggs();

        public abstract string Hatch();

        public override int GetHashCode()
        {
            return Hatch().GetHashCode() ^ LayEggs().GetHashCode() ^ Sing().GetHashCode();
        }

        public override string ToString()
        {
            return Hatch() + "\n" + LayEggs() + "\n" + Sing() + "\n"+Fly();
        }

    }
}
