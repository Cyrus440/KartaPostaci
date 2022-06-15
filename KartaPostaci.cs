using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Runtime.Serialization;

namespace KartaPostaci
{
    public class KartaPostaci
    {
        public string name;
        public string race;
        public string profession;
        public int strength;
        public int agility;
        public int perception;
        public int stealth;

        public KartaPostaci()
        {
            name = "Nazwa";
            race = "Rasa";
            profession = "Profesja";
            strength = 22;
            agility = 22;
            perception = 5;
            stealth = 5;
        }
    }
}
