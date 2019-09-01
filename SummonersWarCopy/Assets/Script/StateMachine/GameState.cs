using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LSJ
{
    public class GameState
    {
        protected int StateID = GameValue.InitInt;

        public virtual void Begin() { }
        public virtual void Update() { }
        public virtual void End() { }
    }
}