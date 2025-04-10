using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace GameUnit
{
    public class SettlerUnit : Unit
    {
        public SettlerUnit(int movement = 1, int Health= 3) 
        : base(movement,Health)
        {}
        
        public override float Cost => 5; 
        
    }
}