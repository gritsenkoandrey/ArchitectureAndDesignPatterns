namespace Abstract_Factory_3
{
    // класс абстрактной фабрики
    public abstract class HeroFactory
    {
        public abstract Movement CreatMovement();
        public abstract Weapon CreatWeapon();
    }
}