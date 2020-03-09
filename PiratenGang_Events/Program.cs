using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiratenGang_Events {

    //delegate void PiratenHandler ( EventArgs ea );

    class Program {
        static void Main ( string [] args ) {
            Gang g = new Gang ();
            g.Add (new Pirat () { Name="Mahmoud"} );
            g.Add (new Pirat () { Name="Jarah"} );
            g.Add (new Pirat () { Name="Khalil"} );

            g.piratenHandler += g.Feiern;
            g.neuePiratenHandler += g.AddPirats;

            g.Konferieren ();

            Console.Read ();
        }
    }
}
