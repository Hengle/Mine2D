﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Entitas;
using svanderweele.Core.Pieces.Tick.Components;
using UnityEngine;

namespace svanderweele.Mine.GameEditor.Pieces.MapEditor.Systems
{
    public class UpdateAssetBayAssetsSystem : ReactiveSystem<GameEntity>
    {
        private readonly Contexts _contexts;

        public UpdateAssetBayAssetsSystem(Contexts contexts) : base(contexts.game)
        {
            _contexts = contexts;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.Tick);
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.hasTick;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var tickEntity in entities)
            {
                if (_contexts.meta.tickService.instance.IsTick(tickEntity, TickEnum.MapEditor_AssetLoading) == false)
                {
                    return;
                }

                var assetBays = _contexts.mapEditor.GetEntities(MapEditorMatcher.AssetBay);

                if (assetBays.Length == 0)
                {
                    return;
                }

                var assetBay = assetBays.Single();
                var assets = _contexts.meta.gridEditorService.service.GetAssets();

                var mapEditor = _contexts.mapEditor.GetEntityWithAssetBay(assetBay.assetBay.id);
                var mapEditorView = mapEditor.mapEditor.view;

                var views = mapEditorView.AssetBay.GetCurrentViews();

                var viewsDifference = views.Count - assets.Count;

                if (viewsDifference < 0)
                {
                    var viewsToCreate = Math.Abs(viewsDifference);
                    //Create required views
                    var newViews = mapEditorView.AssetBay.CreateViews(viewsToCreate);
                    for (var i = 0; i < viewsToCreate; i++)
                    {
                        views.Add(newViews[i]);
                    }
                }

                if (viewsDifference > 0)
                {
                    //Remove extra views 
                    //TODO : Consider pooling the extra views for performance
                    var extraViews = mapEditorView.AssetBay.GetCurrentViews();
                    for (int i = viewsDifference - 1; i >= 0; i--)
                    {
                        var entity = _contexts.mapEditor.GetEntityWithId(extraViews[i].GetEntityId());
                        entity.isDestroyed = true;
                    }
                }

                for (int i = 0; i < assets.Count; i++)
                {
                    var asset = assets[i];
                    var view = views[i];

                    MapEditorEntity entity = null;
                    if (view.GetEntityId() == -1)
                    {
                        entity = _contexts.mapEditor.CreateEntity();
                        _contexts.meta.viewService.instance.LinkAsset(_contexts, entity, view);
                        entity.AddAssetData(asset);
                    }
                    else
                    {
                        entity = _contexts.mapEditor.GetEntityWithId(view.GetEntityId());
                        entity.ReplaceAssetData(asset);                        
                    }

                }
                
            }
        }
    }
}