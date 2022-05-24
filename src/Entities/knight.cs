namespace abstraindo_um_jogo_de_rpg.src.Entities
{
    public class knight : Hero
    {
        public knight(string Name, int level, string HeroType)
        {
            this.Name = Name;
            this.level = level;
            this.HeroType = HeroType;
        }  
         public override string Attack()
        {
            return this.Name + " Atacou com a espada legendaria =]==>";
        }
    }
}