using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Beginner_Projects
{
    public class Stats
    {
        public int _armorClass { get; set; }
        public string armorClass = "Armor Class";
        public string armorType { get; set; }
        public int _hitpoints { get; set; }
        public string hitpoints = "Hit Points";
        public List<int> speeds { get; set; }
        // `public int` for each of the types of movement speeds the creature has
        public int _strength { get; set; }
        public string strength = "STR";
        public int _dexterity { get; set; }
        public string dexterity = "DEX";
        public int _constitution { get; set; }
        public string constitution = "CON";
        public int _intelligence { get; set; }
        public string intelligence = "INT";
        public int _wisdom { get; set; }
        public string wisdom = "WIS";
        public int _charisma { get; set; }
        public string charisma = "CHA";

        public int proficiencyBonus { get; set; }
    }
}
