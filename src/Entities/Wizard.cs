namespace abstraindo_um_jogo_de_rpg.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int level, string HeroType)
        {
            this.Name = Name;
            this.level = level;
            this.HeroType = HeroType;
        }
        public override string Attack()
        {
            return this.Name + " Lanço Magia";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " Lanço Magia super efetiva com bunus de ataque " + Bonus;
            }
            else
            {
                return this.Name + " Lanço uma magia com força fraca com bonis de " + Bonus;
            }


        }
    }
}