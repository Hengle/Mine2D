﻿using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace svanderweele.Mine.Game.Pieces.Sprite
{
    [Game, Event(true)]
    public class SpriteColorComponent : IComponent
    {
        public float r;
        public float g;
        public float b;
        public float a;
    }
}