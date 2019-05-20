using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.SOLID.LSP
{
    public    class Square : Rectangle
    {

        public override void SetHeight(double value)
        {
            base.SetHeight(value);
            base.SetWidth(value);
        }

        public override void SetWidth(double value)
        {
            base.SetHeight(value);
            base.SetWidth(value);
        }
    }
}
