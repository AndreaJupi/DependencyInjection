using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    public class HelloController
    {
        private readonly IGreetingService _greetingService;
        public HelloController(IGreetingService greetingService) =>
            _greetingService = greetingService;

        public string Action(string name) =>
            _greetingService.Greeting(name);
    }
}
