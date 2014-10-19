using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace MonoCastle.Runtimes
{
    class SpriteEntity:Entity
    {
        Texture2D Sprite;
        Vector2 Speed;

        public SpriteEntity(Texture2D sprite)
        {
            Speed = Vector2.Zero;
            Sprite = sprite;
        }
    }
}
