namespace Exercise_047_RPG_Game.src.Entities
{
    class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack()
        {
            return this.Name + " casts magic";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " cast super-effective spell with a bonus of +" + Bonus;
            }
            else
            {
                return this.Name + " cast a weak spell with a bonus of +" + Bonus;
            }
        }
    }
}
