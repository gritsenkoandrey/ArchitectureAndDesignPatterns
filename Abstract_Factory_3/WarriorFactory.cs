namespace Abstract_Factory_3
{
    // Фабрика создания бегущего героя с мечом
    public class WarriorFactory : HeroFactory
    {
        public override Movement CreatMovement()
        {
            return new RunMovement();
        }

        public override Weapon CreatWeapon()
        {
            return new Sword();
        }
    }
}