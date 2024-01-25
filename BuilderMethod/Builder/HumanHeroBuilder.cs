using BuilderMethod.Interface;
using BuilderMethod.Product;

namespace BuilderMethod.Builder
{
    public class HumanHeroBuilder : HeroBuilder
    {
        private Hero _hero = new Hero();

        public HumanHeroBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._hero = new Hero();
            this._hero.Race = "Human Race";
        }

        public void setArmor()
        {
            this._hero.Armor = "Human Armor";
        }

        public void setSkills()
        {
            this._hero.Skills = new string[] { "Human Skill1", "Human Skill2" };
        }

        public void setWeapon()
        {
            this._hero.Weapon = "Human Weapon";
        }

        public Hero build()
        {
            Hero result = this._hero;
            this.Reset();
            return this._hero;
        }
    }
}
