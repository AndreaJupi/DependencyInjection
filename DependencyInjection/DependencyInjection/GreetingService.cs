using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Options;

namespace DependencyInjection
{
    public class GreetingServiceOptions
    {
        public string From { get; set; }
        public string To { get; set; }
    }

    public class GreetingService : IGreetingService
    {
        public GreetingService(IOptions<GreetingServiceOptions> options)
        {
            this._from = options.Value.From;
            this._to = options.Value.To;
        }

        private string _from;
        private string _to;

        public string Greeting(string name)
        {
            if (name == null) throw new ArgumentNullException(nameof(name));

            return $"Hello, {name}, greetings from {_from} to {_to}";
        }
    }
}
