namespace GameUnit
{
    public class MilitaryUnit : Unit // Heranca!!
    {
        public int AttackPower { get; }
        public override int Health{
            get{
                return base.Health + XP;
            }
        }
        public override float Cost => AttackPower + XP;


        public int XP { get; private set; }

        public MilitaryUnit(int mov, int health, int attackPower) : base(mov, health)
        {                                                        // Unit(int, int)
            AttackPower = attackPower;
            XP = 0;
        }
        public void Attack(Unit u)
        {
            XP++;
            u.Health = AttackPower;
        }
        public override string ToString()
        {
            return $"{this.GetType().Name}: HP={this.Health} COST={this.Cost}" +
            $" AP={this.AttackPower} XP={this.XP}";
        }
    }
}
