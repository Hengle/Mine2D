//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public svanderweele.Mine.Game.Pieces.Grid.Components.GridTileTypeComponent gridTileType { get { return (svanderweele.Mine.Game.Pieces.Grid.Components.GridTileTypeComponent)GetComponent(GameComponentsLookup.GridTileType); } }
    public bool hasGridTileType { get { return HasComponent(GameComponentsLookup.GridTileType); } }

    public void AddGridTileType(string newType) {
        var index = GameComponentsLookup.GridTileType;
        var component = CreateComponent<svanderweele.Mine.Game.Pieces.Grid.Components.GridTileTypeComponent>(index);
        component.type = newType;
        AddComponent(index, component);
    }

    public void ReplaceGridTileType(string newType) {
        var index = GameComponentsLookup.GridTileType;
        var component = CreateComponent<svanderweele.Mine.Game.Pieces.Grid.Components.GridTileTypeComponent>(index);
        component.type = newType;
        ReplaceComponent(index, component);
    }

    public void RemoveGridTileType() {
        RemoveComponent(GameComponentsLookup.GridTileType);
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
public partial class GameEntity : IGridTileTypeEntity { }

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherGridTileType;

    public static Entitas.IMatcher<GameEntity> GridTileType {
        get {
            if (_matcherGridTileType == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.GridTileType);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherGridTileType = matcher;
            }

            return _matcherGridTileType;
        }
    }
}