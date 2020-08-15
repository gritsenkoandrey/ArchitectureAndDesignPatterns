namespace Bridge_2
{
    public abstract class Programmer
    {
        protected ILanguage language;

        public ILanguage Language
        {
            set { language = value; }
        }

        public Programmer (ILanguage language)
        {
            this.language = language;
        }

        public virtual void DoWork()
        {
            language.Build();
            language.Execute();
        }

        public abstract void EarnMoney();
    }
}