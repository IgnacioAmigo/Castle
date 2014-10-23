using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonoCastle.Level
{
    class Tile
    {
        private int index;
        public int Index
        {
            get { return index; }
            set { index = value; }
        }

        private bool isBlock = false;
        public bool IsBlock
        {
            get { return isBlock; }
            set { isBlock = value; }
        }

    }
}