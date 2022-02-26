namespace POO_jogo.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard (string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack()
        {
            return this.Name + "lançou magia";
        }

        public string Attack (int Bonus)
        {
            if ( Bonus > 6)
            {
                return this.Name + "lançou magia super efetiva com bonus de ataque de " + Bonus;
            }
            if (Bonus < 6)
            {
            return this.Name + "lançou magia com fraca bonus de ataque de " + Bonus;
            }
        }
    }
}