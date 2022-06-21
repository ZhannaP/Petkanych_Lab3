using System;
using System.Collections.Generic;
using System.Text;

namespace l3
{
    class Hen : Chicken
    {
        public override string Hatch()
        {
            
            return "Heh hatches eggs";
        }

        public override string LayEggs()
        {
            
            return "Heh does not lay eggs";
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            Hen hen = obj as Hen;

            if (hen == null) return false;

            return hen.Hatch() == Hatch() 
                && hen.LayEggs() == LayEggs() && hen.Sing() == Sing();
        }

        
    }
}
