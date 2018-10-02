using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParrotDemo {
    class Jet: IFlyable {

        public string Flies() {
            return "Vrrrooom.";
        }

        public static string operator -(Jet a, Person b) {
            return "nope";
        }
    }
}
