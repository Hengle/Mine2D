﻿using Entitas;
using svanderweele.Mine.Core.Services.Events;
using UnityEngine;

namespace svanderweele.Mine.Game.Unity.Views.Miner
{
    public class UnityMinerView : UnityBaseGameView, ISpriteColorListener
    {
        public void OnSpriteColor(GameEntity entity, float r, float g, float b, float a)
        {
            foreach (var spriteRenderer in GetComponentsInChildren<SpriteRenderer>())
            {
                spriteRenderer.color = new Color(r, g, b, a);
            }
        }

        public override void RegisterEvents(GameEntity entity)
        {
            entity.AddSpriteColorListener(this);
        }
    }
}