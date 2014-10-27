using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace MonoCastle.Runtimes
{
    public class EntityManager:IObject
    {
        public List<Entity> entities;
        internal List<Entity> Entities
        {
            get { return entities; }
            set { entities = value; }
        }

        public EntityManager()
        {
            Entities = new List<Entity>();
        }

        public void OnLoop(float frameTime)
        {
            foreach (Entity ent in Entities)
                ent.OnLoop(frameTime);
        }

        public void OnDraw()
        {
            foreach (Entity ent in Entities)
                ent.OnDraw();


        }

        public virtual void OnDrawPartial(Rectangle viewPort)
        {
            OnDraw();
        }
    }
}
