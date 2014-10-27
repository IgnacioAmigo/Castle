using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MonoGame.Framework;
using Microsoft.Xna.Framework;

namespace MonoCastle.Runtimes
{
    public class Entity:IObject
    {
        public Vector2 position;

        public virtual void OnLoop(float frameTime){}
        public virtual void OnDraw(){}
    }
}
