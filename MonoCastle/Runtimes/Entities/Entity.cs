using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MonoGame.Framework;
using Microsoft.Xna.Framework;

namespace MonoCastle.Runtimes
{
    class Entity:IObject
    {
        public Vector2 position;
        public Vector2 Position
        {
            get { return position; }
            set { position = value; }
        }

        public void OnLoop(float frameTime){}
        public void OnDraw(){}
    }
}
