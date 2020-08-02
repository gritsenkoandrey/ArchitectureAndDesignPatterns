namespace Interface_Segregation_Principle_3
{
    class Photograph
    {
        //public void TakePhoto(Phone phone)
        //{
        //    phone.TakePhoto();
        //}

        public void TakePhoto(IPhoto photo)
        {
            photo.TakePhoto();
        }
    }
}