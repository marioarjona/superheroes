using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    class SuperPoder
    {

        public string Nombre;//clase de super poder
        public string Descripción;
        public NivelPoder Nivel;

        public SuperPoder()
        {
            Nivel = NivelPoder.NivelUno; //constructor debntro de la clase sueprporder
        }
    }
}
