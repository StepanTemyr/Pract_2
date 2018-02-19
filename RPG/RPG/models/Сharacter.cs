using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.models
{

    public enum TypeSex
    {
        Male,        
        Female
    }

    public class Сharacter
    {
        public string Name { get; set; }
        public TypeSex Sex  { get; set; }
        public Grade Grade { get; set; }
        public Race Race { get; set; }

    }
}
