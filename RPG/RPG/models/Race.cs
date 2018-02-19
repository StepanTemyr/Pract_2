using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.models
{
    public enum TypeRace
    {
        Gnome,   
        Elf,     
        Human,   
        Dwarf,   
        Orc      
    }

    public class Race
    {
        public TypeRace RacePerson { get; set; } 
    }
    
}
