using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace MonoCastle.Runtimes
{
    public class SpriteEntity:Entity
    {
        public Texture2D sprite;
        public static SpriteBatch sprBatch;

        public Texture2D Sprite
        {
            get { return sprite; }
            set { sprite = value; }
        }

        public Vector2 speed;
        public Vector2 Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public SpriteEntity(Texture2D sprite)
        {
            Speed = Vector2.Zero;
            Sprite = sprite;
        }

        public SpriteEntity() { }

    }
}
