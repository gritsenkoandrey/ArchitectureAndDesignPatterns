namespace Abstract_Factory_3
{
    // Фабрика создания летящего героя с арбалетом
    public class ElfFactory : HeroFactory
    {
        public override Movement CreatMovement()
        {
            return new FlyMovement();
        }

        public override Weapon CreatWeapon()
        {
            return new Arbalet();
        }
    }
}