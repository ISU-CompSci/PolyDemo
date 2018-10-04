using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParrotDemo {
    class Jet: IFlyable {


        private int _MaxPassengers;
        private int _PassengerCount;

        public Jet(int pass) {
            _MaxPassengers = pass;
        }

        public int MaxPassengers {
            get { return _MaxPassengers; }
        }

                        
        public int PassengerCount {
            get { return _PassengerCount; }
        }


        public string Flies() {
            return "Vrrrooom.";
        }

        public static string operator +(Jet j, Person p) {
            if (j.PassengerCount == j.MaxPassengers) {
                return "Get Out! " + p.FullName;
            } else {
                j._PassengerCount++;
                return "All Aboard " + p.FullName;
            }
        }
    }
}
