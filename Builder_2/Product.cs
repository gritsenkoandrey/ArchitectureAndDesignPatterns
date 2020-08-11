using System.Collections.Generic;


namespace Builder_2
{
    public class Product
    {
        List<object> parts = new List<object>();

        public void Add(string part)
        {
            parts.Add(part);
        }
    }
}