using System;

namespace GameUnit
{
    public abstract class Unit
    {
        protected int movement;
        public virtual int Health { get; set; }
        public abstract float Cost{ get;}

        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }

        public void Move()
        {
            Console.WriteLine(movement);
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: HP={this.Health} COST={this.Cost}";
        }

    }
}
