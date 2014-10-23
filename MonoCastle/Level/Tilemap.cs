using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;

namespace MonoCastle.Level
{
    class Tilemap: Runtimes.IObject
    {
        public Tile[,] tileArray = new Tile[40, 25];

        private Texture2D tileset;
        public Texture2D Tileset
        {
            get { return tileset; }
            set { tileset = value; }
        }

        private int lenght;
        public int Lenght
        {
            get { return lenght; }
            set { lenght = value; }
        }

        private int width;
        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public void OnLoop(float frameTime) {}
        public void OnDraw() {}

    }
}
