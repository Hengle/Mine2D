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
    public svanderweele.Mine.Game.Pieces.Grid.Service.GridServiceComponent gridService { get { return gridServiceEntity.gridService; } }
    public bool hasGridService { get { return gridServiceEntity != null; } }

    public MetaEntity SetGridService(svanderweele.Mine.Game.Pieces.Grid.Service.IGridService newService) {
        if (hasGridService) {
            throw new Entitas.EntitasException("Could not set GridService!\n" + this + " already has an entity with svanderweele.Mine.Game.Pieces.Grid.Service.GridServiceComponent!",
                "You should check if the context already has a gridServiceEntity before setting it or use context.ReplaceGridService().");
        }
        var entity = CreateEntity();
        entity.AddGridService(newService);
        return entity;
    }

    public void ReplaceGridService(svanderweele.Mine.Game.Pieces.Grid.Service.IGridService newService) {
        var entity = gridServiceEntity;
        if (entity == null) {
            entity = SetGridService(newService);
        } else {
            entity.ReplaceGridService(newService);
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

    public svanderweele.Mine.Game.Pieces.Grid.Service.GridServiceComponent gridService { get { return (svanderweele.Mine.Game.Pieces.Grid.Service.GridServiceComponent)GetComponent(MetaComponentsLookup.GridService); } }
    public bool hasGridService { get { return HasComponent(MetaComponentsLookup.GridService); } }

    public void AddGridService(svanderweele.Mine.Game.Pieces.Grid.Service.IGridService newService) {
        var index = MetaComponentsLookup.GridService;
        var component = CreateComponent<svanderweele.Mine.Game.Pieces.Grid.Service.GridServiceComponent>(index);
        component.service = newService;
        AddComponent(index, component);
    }

    public void ReplaceGridService(svanderweele.Mine.Game.Pieces.Grid.Service.IGridService newService) {
        var index = MetaComponentsLookup.GridService;
        var component = CreateComponent<svanderweele.Mine.Game.Pieces.Grid.Service.GridServiceComponent>(index);
        component.service = newService;
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