using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace MonoCastle.Runtimes
{
    public class Character:SpriteEntity
    {
        public Character(Vector2 p)
        {
            position = p;
            Sprite = Game1.PlayerSprite;
        }

        private int width;
        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        private int height;
        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        private float gravity;
        public float Gravity
        {
            get { return gravity; }
            set { gravity = value; }
        }

        private bool onGround;
        public bool OnGround
        {
            get { return onGround; }
            set { onGround = value; }
        }

        public override void OnLoop(float frametime)
        {
            KeyboardState state = Keyboard.GetState();

            int screenWidth = Game1.Get().currentLevel.ScreenWidth;
            int screenHeight = Game1.Get().currentLevel.ScreenHeight;

            //movimiento horizontal
            speed.X = 1.56f;
            if (state.IsKeyDown(Keys.Left))  position.X = position.X - speed.X; 
            if (state.IsKeyDown(Keys.Right)) position.X = position.X + speed.X;

            //mecanica del salto
            onGround = position.Y + height >= (float)screenHeight;
            if (onGround && state.IsKeyDown(Keys.Up)) speed.Y = -3.5f;

            //movimiento vertical
            gravity = 0.09f;
            speed.Y = speed.Y + gravity;
            position.Y = position.Y + speed.Y;

            //respuesta vertical del piso
            if (position.Y + height >= (float)screenHeight)
            {
                speed.Y = 0;
                gravity = 0;
                position.Y = screenHeight - height;
            }

            //colision paredes
            if (position.X < 0.0f)
            {
                speed.X = 0f;
                position.X = 0;
            }

            if (position.X + width > screenWidth)
            {
                speed.X = 0f;
                position.X = screenWidth - width;
            }

            //reset position button
            if (state.IsKeyDown(Keys.Down))
            {
                position.Y = 50f;
                speed.Y = 0;
                gravity = 0;
            }

        }

        public override void OnDraw()
        {
            width = 45;
            height = 80;
            Rectangle r = new Rectangle((int)position.X, (int)position.Y, width, height);
            sprBatch.Begin();
            sprBatch.Draw(sprite, r, Color.White);
            sprBatch.End();
        }




    }
}
