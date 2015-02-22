using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace csharp00
{
    delegate double MathAction(double num);

    class UsingDelegate
    {
        private MathAction action;

        public UsingDelegate(MathAction action) {
            this.action = action;
        }

        internal double doMath(double x)
        {
            return action(x);
        }
    }
}
