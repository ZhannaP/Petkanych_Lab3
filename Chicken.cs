using System;
using System.Collections.Generic;
using System.Text;

namespace l3
{
    class Chicken : Bird
    {
        public override string Sing()
        {

            return "Ko Ko Ko";
        }

        public override string Hatch()
        {

            return "Chicken does not hatch eggs";
        }

        public override string LayEggs()
        {
            return "Chicken lays eggs";
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            Chicken chick = obj as Chicken;

            if (chick == null) return false;

            return chick.Fly() == Fly() && chick.Hatch() == Hatch()
                && chick.LayEggs() == LayEggs() && chick.Sing() == Sing();
        }

        
    }
}
