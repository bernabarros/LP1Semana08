using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace GameUnit
{
    public class SettlerUnit : Unit
    {
        public SettlerUnit(int movement, int health) : base(movement, health)
        {
            this.movement = 1;
            Health = 3;
        }
        public override float Cost => 5; 
        
    }
}