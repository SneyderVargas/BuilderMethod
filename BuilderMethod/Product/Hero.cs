namespace BuilderMethod.Product
{
    public class Hero
    {
        public string Race { get; set; }
        public string Armor { get; set; }
        public string Weapon { get; set; }
        public string[] Skills { get; set; }

        public string toString ()
        {
            return $"Hero: race: {this.Race}";
        }
    }
}
