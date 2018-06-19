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
    public GameContext game { get; set; }
    public InputContext input { get; set; }
    public MetaContext meta { get; set; }

    public Entitas.IContext[] allContexts { get { return new Entitas.IContext [] { action, game, input, meta }; } }

    public Contexts() {
        action = new ActionContext();
        game = new GameContext();
        input = new InputContext();
        meta = new MetaContext();

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

    public const string Action = "Action";
    public const string Id = "Id";

    [Entitas.CodeGeneration.Attributes.PostConstructor]
    public void InitializeEntityIndices() {
        action.AddEntityIndex(new Entitas.EntityIndex<ActionEntity, string>(
            Action,
            action.GetGroup(ActionMatcher.Action),
            (e, c) => ((svanderweele.Mine.Game.Services.Actions.ActionComponent)c).value));

        game.AddEntityIndex(new Entitas.PrimaryEntityIndex<GameEntity, int>(
            Id,
            game.GetGroup(GameMatcher.Id),
            (e, c) => ((svanderweele.Mine.Game.Components.Id.IdComponent)c).value));
        input.AddEntityIndex(new Entitas.PrimaryEntityIndex<InputEntity, int>(
            Id,
            input.GetGroup(InputMatcher.Id),
            (e, c) => ((svanderweele.Mine.Game.Components.Id.IdComponent)c).value));
        meta.AddEntityIndex(new Entitas.PrimaryEntityIndex<MetaEntity, int>(
            Id,
            meta.GetGroup(MetaMatcher.Id),
            (e, c) => ((svanderweele.Mine.Game.Components.Id.IdComponent)c).value));
    }
}

public static class ContextsExtensions {

    public static System.Collections.Generic.HashSet<ActionEntity> GetEntitiesWithAction(this ActionContext context, string value) {
        return ((Entitas.EntityIndex<ActionEntity, string>)context.GetEntityIndex(Contexts.Action)).GetEntities(value);
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
            CreateContextObserver(game);
            CreateContextObserver(input);
            CreateContextObserver(meta);
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
