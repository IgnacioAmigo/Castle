using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using MonoCastle.Runtimes;
using Microsoft.Xna.Framework;

namespace MonoCastle.Level
{
    public class TileMap: Runtimes.IObject
    {
        private Tile[,] tileArray;
        public Tile[,] TileArray
        {
            get { return tileArray; }
            set { tileArray = value; }
        }

        public TileMap()
        {
            tileArray = new Tile[40, 25];
        }

        private Texture2D tileSet;
        public Texture2D TileSet
        {
          get { return tileSet; }
          set { tileSet = value; }
        }

        private int tileHeight;
        public int TileHeight
        {
            get { return tileHeight; }
            set { tileHeight = value; }
        }

        private int tileWidth;
        public int TileWidth
        {
            get { return tileWidth; }
            set { tileWidth = value; }
        }
        

        private UInt16 tilesPerRow;
        public UInt16 TilesPerRow
        {
            get { return tilesPerRow; }
            set { tilesPerRow = value; }
        }
      
        public void OnLoop(float frameTime) {}
        public void OnDraw() 
        {
            SpriteEntity.sprBatch.Begin();

            //for: i es la posicion fila y j es la posicion columna
            for (int i=0; i < tileArray.GetLength(0); i++)
            {
                for (int j = 0; j < tileArray.GetLength(1); j++)
                {
                    if (TileArray[i, j] != null)
                    {
                        Rectangle destinationRect = new Rectangle(j*tileWidth, i*tileHeight, tileWidth, tileHeight);
                        int posicionFila = (int) (TileArray[i,j].Index / tilesPerRow);
                        int posicionColumna =  TileArray[i,j].Index - tilesPerRow*posicionFila;
                        Rectangle sourceRect = new Rectangle(posicionColumna*tileWidth, posicionFila*tileHeight, tileWidth, tileHeight);
                        SpriteEntity.sprBatch.Draw(tileSet, destinationRect, sourceRect, Color.White);
                    }
                }
           }
            SpriteEntity.sprBatch.End();
        }

    }
}
