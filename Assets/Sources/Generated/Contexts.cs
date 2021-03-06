//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ContextsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class Contexts : Entitas.IContexts {

    public static Contexts sharedInstance {
        get {
            if (_sharedInstance == null) {
                _sharedInstance = new Contexts();
            }

            return _sharedInstance;
        }
        set { _sharedInstance = value; }
    }

    static Contexts _sharedInstance;

    public ActionContext action { get; set; }
    public FactoryContext factory { get; set; }
    public GameContext game { get; set; }
    public GridContext grid { get; set; }
    public InputContext input { get; set; }
    public MapEditorContext mapEditor { get; set; }
    public MetaContext meta { get; set; }
    public RequestContext request { get; set; }

    public Entitas.IContext[] allContexts { get { return new Entitas.IContext [] { action, factory, game, grid, input, mapEditor, meta, request }; } }

    public Contexts() {
        action = new ActionContext();
        factory = new FactoryContext();
        game = new GameContext();
        grid = new GridContext();
        input = new InputContext();
        mapEditor = new MapEditorContext();
        meta = new MetaContext();
        request = new RequestContext();

        var postConstructors = System.Linq.Enumerable.Where(
            GetType().GetMethods(),
            method => System.Attribute.IsDefined(method, typeof(Entitas.CodeGeneration.Attributes.PostConstructorAttribute))
        );

        foreach (var postConstructor in postConstructors) {
            postConstructor.Invoke(this, null);
        }
    }

    public void Reset() {
        var contexts = allContexts;
        for (int i = 0; i < contexts.Length; i++) {
            contexts[i].Reset();
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EntityIndexGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class Contexts {

    public const string AssetBay = "AssetBay";
    public const string GridLayer = "GridLayer";
    public const string GridPosition = "GridPosition";
    public const string GridTileType = "GridTileType";
    public const string Id = "Id";

    [Entitas.CodeGeneration.Attributes.PostConstructor]
    public void InitializeEntityIndices() {
        mapEditor.AddEntityIndex(new Entitas.PrimaryEntityIndex<MapEditorEntity, int>(
            AssetBay,
            mapEditor.GetGroup(MapEditorMatcher.AssetBay),
            (e, c) => ((svanderweele.Mine.GameEditor.Pieces.MapEditor.Components.AssetBayComponent)c).id));

        game.AddEntityIndex(new Entitas.EntityIndex<GameEntity, int>(
            GridLayer,
            game.GetGroup(GameMatcher.GridLayer),
            (e, c) => ((svanderweele.Core.Pieces.Grid.Core.Components.GridLayerComponent)c).layer));

        game.AddEntityIndex(new Entitas.EntityIndex<GameEntity, svanderweele.Mine.Game.Utils.Math.Vector2>(
            GridPosition,
            game.GetGroup(GameMatcher.GridPosition),
            (e, c) => ((svanderweele.Core.Pieces.Grid.Core.Components.GridPositionComponent)c).position));

        grid.AddEntityIndex(new Entitas.EntityIndex<GridEntity, string>(
            GridTileType,
            grid.GetGroup(GridMatcher.GridTileType),
            (e, c) => ((svanderweele.Core.Pieces.Grid.Core.Components.GridTileTypeComponent)c).type));
        game.AddEntityIndex(new Entitas.EntityIndex<GameEntity, string>(
            GridTileType,
            game.GetGroup(GameMatcher.GridTileType),
            (e, c) => ((svanderweele.Core.Pieces.Grid.Core.Components.GridTileTypeComponent)c).type));

        game.AddEntityIndex(new Entitas.PrimaryEntityIndex<GameEntity, int>(
            Id,
            game.GetGroup(GameMatcher.Id),
            (e, c) => ((svanderweele.Core.Pieces.Id.IdComponent)c).value));
        input.AddEntityIndex(new Entitas.PrimaryEntityIndex<InputEntity, int>(
            Id,
            input.GetGroup(InputMatcher.Id),
            (e, c) => ((svanderweele.Core.Pieces.Id.IdComponent)c).value));
        meta.AddEntityIndex(new Entitas.PrimaryEntityIndex<MetaEntity, int>(
            Id,
            meta.GetGroup(MetaMatcher.Id),
            (e, c) => ((svanderweele.Core.Pieces.Id.IdComponent)c).value));
        action.AddEntityIndex(new Entitas.PrimaryEntityIndex<ActionEntity, int>(
            Id,
            action.GetGroup(ActionMatcher.Id),
            (e, c) => ((svanderweele.Core.Pieces.Id.IdComponent)c).value));
        grid.AddEntityIndex(new Entitas.PrimaryEntityIndex<GridEntity, int>(
            Id,
            grid.GetGroup(GridMatcher.Id),
            (e, c) => ((svanderweele.Core.Pieces.Id.IdComponent)c).value));
        mapEditor.AddEntityIndex(new Entitas.PrimaryEntityIndex<MapEditorEntity, int>(
            Id,
            mapEditor.GetGroup(MapEditorMatcher.Id),
            (e, c) => ((svanderweele.Core.Pieces.Id.IdComponent)c).value));
    }
}

public static class ContextsExtensions {

    public static MapEditorEntity GetEntityWithAssetBay(this MapEditorContext context, int id) {
        return ((Entitas.PrimaryEntityIndex<MapEditorEntity, int>)context.GetEntityIndex(Contexts.AssetBay)).GetEntity(id);
    }

    public static System.Collections.Generic.HashSet<GameEntity> GetEntitiesWithGridLayer(this GameContext context, int layer) {
        return ((Entitas.EntityIndex<GameEntity, int>)context.GetEntityIndex(Contexts.GridLayer)).GetEntities(layer);
    }

    public static System.Collections.Generic.HashSet<GameEntity> GetEntitiesWithGridPosition(this GameContext context, svanderweele.Mine.Game.Utils.Math.Vector2 position) {
        return ((Entitas.EntityIndex<GameEntity, svanderweele.Mine.Game.Utils.Math.Vector2>)context.GetEntityIndex(Contexts.GridPosition)).GetEntities(position);
    }

    public static System.Collections.Generic.HashSet<GridEntity> GetEntitiesWithGridTileType(this GridContext context, string type) {
        return ((Entitas.EntityIndex<GridEntity, string>)context.GetEntityIndex(Contexts.GridTileType)).GetEntities(type);
    }

    public static System.Collections.Generic.HashSet<GameEntity> GetEntitiesWithGridTileType(this GameContext context, string type) {
        return ((Entitas.EntityIndex<GameEntity, string>)context.GetEntityIndex(Contexts.GridTileType)).GetEntities(type);
    }

    public static GameEntity GetEntityWithId(this GameContext context, int value) {
        return ((Entitas.PrimaryEntityIndex<GameEntity, int>)context.GetEntityIndex(Contexts.Id)).GetEntity(value);
    }

    public static InputEntity GetEntityWithId(this InputContext context, int value) {
        return ((Entitas.PrimaryEntityIndex<InputEntity, int>)context.GetEntityIndex(Contexts.Id)).GetEntity(value);
    }

    public static MetaEntity GetEntityWithId(this MetaContext context, int value) {
        return ((Entitas.PrimaryEntityIndex<MetaEntity, int>)context.GetEntityIndex(Contexts.Id)).GetEntity(value);
    }

    public static ActionEntity GetEntityWithId(this ActionContext context, int value) {
        return ((Entitas.PrimaryEntityIndex<ActionEntity, int>)context.GetEntityIndex(Contexts.Id)).GetEntity(value);
    }

    public static GridEntity GetEntityWithId(this GridContext context, int value) {
        return ((Entitas.PrimaryEntityIndex<GridEntity, int>)context.GetEntityIndex(Contexts.Id)).GetEntity(value);
    }

    public static MapEditorEntity GetEntityWithId(this MapEditorContext context, int value) {
        return ((Entitas.PrimaryEntityIndex<MapEditorEntity, int>)context.GetEntityIndex(Contexts.Id)).GetEntity(value);
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.VisualDebugging.CodeGeneration.Plugins.ContextObserverGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class Contexts {

#if (!ENTITAS_DISABLE_VISUAL_DEBUGGING && UNITY_EDITOR)

    [Entitas.CodeGeneration.Attributes.PostConstructor]
    public void InitializeContexObservers() {
        try {
            CreateContextObserver(action);
            CreateContextObserver(factory);
            CreateContextObserver(game);
            CreateContextObserver(grid);
            CreateContextObserver(input);
            CreateContextObserver(mapEditor);
            CreateContextObserver(meta);
            CreateContextObserver(request);
        } catch(System.Exception) {
        }
    }

    public void CreateContextObserver(Entitas.IContext context) {
        if (UnityEngine.Application.isPlaying) {
            var observer = new Entitas.VisualDebugging.Unity.ContextObserver(context);
            UnityEngine.Object.DontDestroyOnLoad(observer.gameObject);
        }
    }

#endif
}
