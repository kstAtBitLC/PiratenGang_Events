using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiratenGang_Events {
    class Gang {
        private List<Pirat> pirats = new List<Pirat>();
        //public event Piratenhandler piratenHandler;
        public event EventHandler<EventArgs> piratenHandler;
        public event EventHandler<EventArgs> neuePiratenHandler;


        public bool Aufbruch { get; set; } = false;

        public void Add(Pirat p ) {
            pirats.Add (p);
        }

        public void AddPirats (object source, EventArgs e) {
            List<Pirat> lp = ( ( List<Pirat> ) source );
            pirats.AddRange (lp);
        }

        public void Konferieren () {
            int counter = 0;
            List<Pirat> liste = new List<Pirat> ();
            liste.Add (new Pirat () { Name="Arif"} );
            liste.Add (new Pirat () { Name="Sebi"} );

            while ( Aufbruch == false ) {

                if ( counter > 2 ) {
                    neuePiratenHandler ( liste, EventArgs.Empty );
                }                

                Console.Write ("Aufbrechen ?");
                Aufbruch = Convert.ToBoolean (Console.ReadLine());

                if ( Aufbruch == true ) {
                    piratenHandler (this, EventArgs.Empty);
                }

                counter++;
            }
        }

        public void Feiern (object source, EventArgs e) {
            List<Pirat> lp = ( ( Gang ) source ).pirats;

            foreach ( Pirat p in lp ) {
                Console.WriteLine ("Trink Kumpel: {0}", p.Name);
            }
        }

     }
}
