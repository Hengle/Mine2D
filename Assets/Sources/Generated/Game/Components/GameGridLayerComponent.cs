//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public svanderweele.Mine.Game.Pieces.Grid.Components.GridLayerComponent gridLayer { get { return (svanderweele.Mine.Game.Pieces.Grid.Components.GridLayerComponent)GetComponent(GameComponentsLookup.GridLayer); } }
    public bool hasGridLayer { get { return HasComponent(GameComponentsLookup.GridLayer); } }

    public void AddGridLayer(int newLayer) {
        var index = GameComponentsLookup.GridLayer;
        var component = CreateComponent<svanderweele.Mine.Game.Pieces.Grid.Components.GridLayerComponent>(index);
        component.layer = newLayer;
        AddComponent(index, component);
    }

    public void ReplaceGridLayer(int newLayer) {
        var index = GameComponentsLookup.GridLayer;
        var component = CreateComponent<svanderweele.Mine.Game.Pieces.Grid.Components.GridLayerComponent>(index);
        component.layer = newLayer;
        ReplaceComponent(index, component);
    }

    public void RemoveGridLayer() {
        RemoveComponent(GameComponentsLookup.GridLayer);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherGridLayer;

    public static Entitas.IMatcher<GameEntity> GridLayer {
        get {
            if (_matcherGridLayer == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.GridLayer);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherGridLayer = matcher;
            }

            return _matcherGridLayer;
        }
    }
}