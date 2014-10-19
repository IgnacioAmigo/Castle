using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace MonoCastle.Runtimes
{
    class Level:IObject
    {
        public EntityManager levelEntities;
        internal EntityManager LevelEntities
        {
            get { return levelEntities; }
            set { levelEntities = value; }
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

        public void Init()
        {
            DrawGUI = true;
            Player = new Character(new Vector2(50, 50));
            LevelEntities = new EntityManager();
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
