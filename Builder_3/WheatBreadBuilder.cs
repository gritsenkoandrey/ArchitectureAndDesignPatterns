namespace Builder_3
{
    public class WheatBreadBuilder : BreadBuilder
    {
        public override void SetAdditives()
        {
            Bread.Additives = new Additives { Name = "Улучшатель хлебопекарный" };
        }

        public override void SetFlour()
        {
            Bread.Flour = new Flour { Sort = "Пшеничная мука высший сорт" };
        }

        public override void SetSalt()
        {
            Bread.Salt = new Salt();
        }
    }
}