using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace csharp00
{
    class Hello
    {
        private string greetings;

        public Hello(string greetings)
        {
            this.greetings = greetings;
        }

        public Hello() : this("Hello")
        {}

        internal object SayHello()
        {
            return SayHelloTo("World");
        }

        internal object SayHelloTo(string p)
        {
            return this.greetings + ", " + p + "!";
        }
    }
}
