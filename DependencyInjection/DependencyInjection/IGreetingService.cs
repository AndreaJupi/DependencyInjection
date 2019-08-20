using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    public interface IGreetingService
    {
        string Greeting(string name);
    }
}
