using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonoCastle.Runtimes
{
    interface IObject
    {
         void OnLoop(float frameTime);
         void OnDraw();
    }
}
