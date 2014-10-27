using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MonoCastle.Runtimes;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoCastle.Level;

namespace MonoCastle.Runtimes
{
    public class Level :IObject
    {
        public Level()
        {
            Init();
        }

        private EntityManager levelEntities;
        public EntityManager LevelEntities
        {
            get { return levelEntities; }
            set { levelEntities = value; }
        }

        private int screenWidth;
        public int ScreenWidth
        {
            get { return screenWidth; }
            set { screenWidth = value; }
        }

        private int screenHeight;
        public int ScreenHeight
        {
            get { return screenHeight; }
            set { screenHeight = value; }
        }

        private Character player;
        public Character Player
        {
            get { return player; }
            set { player = value; }
        }

        private bool drawGUI;
        public bool DrawGUI
        {
            get { return drawGUI; }
            set { drawGUI = value; }
        }

        private TileMap tileMap;
        public TileMap TileMap
        {
            get { return tileMap; }
            set { tileMap = value; }
        }


        public void changeScreenSize(int screenWidth, int screenHeight)
        {
            ScreenHeight = screenHeight;
            ScreenWidth = screenWidth;
        }

        public void Init()
        {
            DrawGUI = true;

            Player = new Character(new Vector2(50, 50));

            changeScreenSize(Game1.Get().screenWidth, Game1.Get().screenHeight);

            LevelEntities = new EntityManager();
            levelEntities.entities.Add(player);

            tileMap = new TileMap();
            
            tileMap.TileSet = Game1.TileSet;
            TileMap.TileWidth = 16;
            TileMap.TileHeight = 16;
            TileMap.TilesPerRow = (UInt16)(tileMap.TileSet.Bounds.Width / TileMap.TileWidth);
            
            for (int i=0; i < tileMap.TileArray.GetLength(0); i++)
                for (int j = 0; j < tileMap.TileArray.GetLength(1); j++)
                    TileMap.TileArray[i, j] = new Tile(j + i* tileMap.TilesPerRow);
        }

        public void OnLoop(float frameTime)
        {
            LevelEntities.OnLoop(frameTime);
            
            if (HasBeenWon())
                OnExit();
        }

        public bool HasBeenWon()
        {
            return false;
        }

        public void OnDraw()
        {
            LevelEntities.OnDraw();
            tileMap.OnDraw();

            if (DrawGUI)
                OnDrawGUI(); 
        }

        public void OnDrawGUI()
        {

        }

        public void OnExit()
        {

        }
    }
}
