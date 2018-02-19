using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.models
{
    public enum TypePerson
    {
        Warrior, 
        Mage, 
        Rogue,
        Priest,       
        Warlock,       
        Paladin,     
        Shaman,
        Druid,
        Hunter
    }

    public class Grade
    {
        public TypePerson GradePerson { get; set; }
    }
}
