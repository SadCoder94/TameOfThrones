using System;
using System.Collections.Generic;
using System.Text;

namespace TameOfThrones
{
    public class Emblem
    {
        public readonly string SPACE = "GORILLA"; 
        public readonly string LAND = "PANDA";
        public readonly string WATER = "OCTOPUS";
        public readonly string ICE = "MAMMOTH";
        public readonly string AIR = "OWL";
        public readonly string FIRE = "DRAGON";

        public Emblem()
        {

        }
    }

    enum CesarHelper
    {
        SPACE = 7,
        LAND = 5,
        WATER = 7,
        ICE = 7,
        AIR = 3,
        FIRE = 6
    }
}
