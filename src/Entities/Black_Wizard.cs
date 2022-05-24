namespace abstraindo_um_jogo_de_rpg.src.Entities
{
    public class Black_Wizard : Hero
    {
        public Black_Wizard(string Name, int level, string HeroType)
        {
            this.Name = Name;
            this.level = level;
            this.HeroType = HeroType;
        }
         public override string Attack()
        {
            return this.Name + " hizo Magia negra y los encantro a todos";
        }
    }
}
