using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPatterns
{
    class SpecialActionCommand : ActionCommand
    {
        public SpecialActionCommand(UnitKeeper target, Battlefield field) : base(target, field) { }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
