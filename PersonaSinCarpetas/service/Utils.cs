using PersonasUCCommand.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaSinCarpetas.service
{
    class Utils
    {
        public static List<Persona> getSamples()
            => new List<Persona> { 
                new Persona("Alex",26,"Venezuela"), 
                new Persona("Jose",22,"España"), 
                new Persona("Laura",22,"España") 
            };
    }
}
