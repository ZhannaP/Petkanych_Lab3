using System;
using System.Collections.Generic;
using System.Text;

namespace l3
{
    class Cuckoo : Bird
    { 
        public override string Sing()
        {
           
            return "Ку ку ку";
        }

        public override string Hatch()
        {
            
            return "Cuckoo does not hatch eggs";
        }

        public override string LayEggs()
        {
            return "Cuckoo lays eggs";
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            Cuckoo cuckoo = obj as Cuckoo;

            if (cuckoo == null) return false;

            return cuckoo.Hatch() == Hatch()
                && cuckoo.LayEggs() == LayEggs() && cuckoo.Sing() == Sing();
        }
    }
}
