//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GridEntity {

    static readonly svanderweele.Mine.Game.Pieces.Grid.Components.GridComponent gridComponent = new svanderweele.Mine.Game.Pieces.Grid.Components.GridComponent();

    public bool isGrid {
        get { return HasComponent(GridComponentsLookup.Grid); }
        set {
            if (value != isGrid) {
                var index = GridComponentsLookup.Grid;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : gridComponent;

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
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GridMatcher {

    static Entitas.IMatcher<GridEntity> _matcherGrid;

    public static Entitas.IMatcher<GridEntity> Grid {
        get {
            if (_matcherGrid == null) {
                var matcher = (Entitas.Matcher<GridEntity>)Entitas.Matcher<GridEntity>.AllOf(GridComponentsLookup.Grid);
                matcher.componentNames = GridComponentsLookup.componentNames;
                _matcherGrid = matcher;
            }

            return _matcherGrid;
        }
    }
}
