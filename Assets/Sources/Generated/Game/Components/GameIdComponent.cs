//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public svanderweele.Mine.Game.Pieces.Id.IdComponent id { get { return (svanderweele.Mine.Game.Pieces.Id.IdComponent)GetComponent(GameComponentsLookup.Id); } }
    public bool hasId { get { return HasComponent(GameComponentsLookup.Id); } }

    public void AddId(int newValue) {
        var index = GameComponentsLookup.Id;
        var component = CreateComponent<svanderweele.Mine.Game.Pieces.Id.IdComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceId(int newValue) {
        var index = GameComponentsLookup.Id;
        var component = CreateComponent<svanderweele.Mine.Game.Pieces.Id.IdComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveId() {
        RemoveComponent(GameComponentsLookup.Id);
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
public partial class GameEntity : IIdEntity { }

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherId;

    public static Entitas.IMatcher<GameEntity> Id {
        get {
            if (_matcherId == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Id);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherId = matcher;
            }

            return _matcherId;
        }
    }
}
