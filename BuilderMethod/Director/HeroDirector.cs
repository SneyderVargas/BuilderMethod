using BuilderMethod.Interface;
using BuilderMethod.Product;

namespace BuilderMethod.Director
{
    public class HeroDirector
    {
        private HeroBuilder _heroBuilder;

        public HeroBuilder Builder
        {
            set { _heroBuilder = value; }
        }
        public void createHeroBasic()
        {
            this._heroBuilder.setArmor();
        }
    }
}
