namespace Single_Responsibility_Principle_3
{
    class GeneralIPhoneValidator : IPhoneValidator
    {
        public bool IsValid(Phone phone)
        {
            if (string.IsNullOrEmpty(phone.Model) || phone.Price <= 0)
            {
                return false;
            }
            return true;
        }
    }
}