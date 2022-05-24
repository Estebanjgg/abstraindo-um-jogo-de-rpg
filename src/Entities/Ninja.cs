namespace abstraindo_um_jogo_de_rpg.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int level, string HeroType)
        {
            this.Name = Name;
            this.level = level;
            this.HeroType = HeroType;
        }  
         public override string Attack()
        {
            return this.Name + " atacou con uma churiken enorme ";
        }
        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " Lanço um monton de shuriken con espadas " + Bonus;
            }
            else
            {
                return this.Name + " se canso u se escondio " + Bonus;
            }


        }
        
    }
}