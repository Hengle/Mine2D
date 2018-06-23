//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ActionEntity {

    static readonly svanderweele.Mine.Core.Pieces.Destroy.DestroyedComponent destroyedComponent = new svanderweele.Mine.Core.Pieces.Destroy.DestroyedComponent();

    public bool isDestroyed {
        get { return HasComponent(ActionComponentsLookup.Destroyed); }
        set {
            if (value != isDestroyed) {
                var index = ActionComponentsLookup.Destroyed;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : destroyedComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiInterfaceGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ActionEntity : IDestroyedEntity { }

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class ActionMatcher {

    static Entitas.IMatcher<ActionEntity> _matcherDestroyed;

    public static Entitas.IMatcher<ActionEntity> Destroyed {
        get {
            if (_matcherDestroyed == null) {
                var matcher = (Entitas.Matcher<ActionEntity>)Entitas.Matcher<ActionEntity>.AllOf(ActionComponentsLookup.Destroyed);
                matcher.componentNames = ActionComponentsLookup.componentNames;
                _matcherDestroyed = matcher;
            }

            return _matcherDestroyed;
        }
    }
}