namespace Builder_3
{
    // строитель для ржаного хлеба
    public class RyeBreadBuilder : BreadBuilder
    {
        public override void SetAdditives()
        {
            // не используется
        }

        public override void SetFlour()
        {
            Bread.Flour = new Flour { Sort = "Ржаная мука 1 сорт" };
        }

        public override void SetSalt()
        {
            Bread.Salt = new Salt();
        }
    }
}