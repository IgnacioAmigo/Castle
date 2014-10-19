using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonoCastle.Runtimes
{
    class Level:IObject
    {
        EntityManager LevelEntities;
        Character Player;
        bool DrawGUI;

        public void Init()
        {
            DrawGUI = true;
            Player = new Character();
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
