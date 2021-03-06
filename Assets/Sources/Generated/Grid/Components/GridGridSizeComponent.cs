//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GridEntity {

    public svanderweele.Core.Pieces.Grid.Core.Components.GridSizeComponent gridSize { get { return (svanderweele.Core.Pieces.Grid.Core.Components.GridSizeComponent)GetComponent(GridComponentsLookup.GridSize); } }
    public bool hasGridSize { get { return HasComponent(GridComponentsLookup.GridSize); } }

    public void AddGridSize(int newColumns, int newRows) {
        var index = GridComponentsLookup.GridSize;
        var component = CreateComponent<svanderweele.Core.Pieces.Grid.Core.Components.GridSizeComponent>(index);
        component.columns = newColumns;
        component.rows = newRows;
        AddComponent(index, component);
    }

    public void ReplaceGridSize(int newColumns, int newRows) {
        var index = GridComponentsLookup.GridSize;
        var component = CreateComponent<svanderweele.Core.Pieces.Grid.Core.Components.GridSizeComponent>(index);
        component.columns = newColumns;
        component.rows = newRows;
        ReplaceComponent(index, component);
    }

    public void RemoveGridSize() {
        RemoveComponent(GridComponentsLookup.GridSize);
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

    static Entitas.IMatcher<GridEntity> _matcherGridSize;

    public static Entitas.IMatcher<GridEntity> GridSize {
        get {
            if (_matcherGridSize == null) {
                var matcher = (Entitas.Matcher<GridEntity>)Entitas.Matcher<GridEntity>.AllOf(GridComponentsLookup.GridSize);
                matcher.componentNames = GridComponentsLookup.componentNames;
                _matcherGridSize = matcher;
            }

            return _matcherGridSize;
        }
    }
}
