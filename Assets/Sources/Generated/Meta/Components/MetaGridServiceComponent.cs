//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class MetaContext {

    public MetaEntity gridServiceEntity { get { return GetGroup(MetaMatcher.GridService).GetSingleEntity(); } }
    public GridServiceComponent gridService { get { return gridServiceEntity.gridService; } }
    public bool hasGridService { get { return gridServiceEntity != null; } }

    public MetaEntity SetGridService(IGridService newInstance) {
        if (hasGridService) {
            throw new Entitas.EntitasException("Could not set GridService!\n" + this + " already has an entity with GridServiceComponent!",
                "You should check if the context already has a gridServiceEntity before setting it or use context.ReplaceGridService().");
        }
        var entity = CreateEntity();
        entity.AddGridService(newInstance);
        return entity;
    }

    public void ReplaceGridService(IGridService newInstance) {
        var entity = gridServiceEntity;
        if (entity == null) {
            entity = SetGridService(newInstance);
        } else {
            entity.ReplaceGridService(newInstance);
        }
    }

    public void RemoveGridService() {
        gridServiceEntity.Destroy();
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class MetaEntity {

    public GridServiceComponent gridService { get { return (GridServiceComponent)GetComponent(MetaComponentsLookup.GridService); } }
    public bool hasGridService { get { return HasComponent(MetaComponentsLookup.GridService); } }

    public void AddGridService(IGridService newInstance) {
        var index = MetaComponentsLookup.GridService;
        var component = CreateComponent<GridServiceComponent>(index);
        component.instance = newInstance;
        AddComponent(index, component);
    }

    public void ReplaceGridService(IGridService newInstance) {
        var index = MetaComponentsLookup.GridService;
        var component = CreateComponent<GridServiceComponent>(index);
        component.instance = newInstance;
        ReplaceComponent(index, component);
    }

    public void RemoveGridService() {
        RemoveComponent(MetaComponentsLookup.GridService);
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
public sealed partial class MetaMatcher {

    static Entitas.IMatcher<MetaEntity> _matcherGridService;

    public static Entitas.IMatcher<MetaEntity> GridService {
        get {
            if (_matcherGridService == null) {
                var matcher = (Entitas.Matcher<MetaEntity>)Entitas.Matcher<MetaEntity>.AllOf(MetaComponentsLookup.GridService);
                matcher.componentNames = MetaComponentsLookup.componentNames;
                _matcherGridService = matcher;
            }

            return _matcherGridService;
        }
    }
}
