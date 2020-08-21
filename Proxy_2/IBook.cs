using System;


namespace Proxy_2
{
    public interface IBook : IDisposable
    {
        Page GetPage(int number);
    }
}