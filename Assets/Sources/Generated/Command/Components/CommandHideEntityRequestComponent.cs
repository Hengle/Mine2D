//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class CommandEntity {

    public svanderweele.Mine.Game.Actions.HideActor.HideEntityRequestComponent hideEntityRequest { get { return (svanderweele.Mine.Game.Actions.HideActor.HideEntityRequestComponent)GetComponent(CommandComponentsLookup.HideEntityRequest); } }
    public bool hasHideEntityRequest { get { return HasComponent(CommandComponentsLookup.HideEntityRequest); } }

    public void AddHideEntityRequest(int newEntityId, bool newVisible) {
        var index = CommandComponentsLookup.HideEntityRequest;
        var component = CreateComponent<svanderweele.Mine.Game.Actions.HideActor.HideEntityRequestComponent>(index);
        component.entityId = newEntityId;
        component.visible = newVisible;
        AddComponent(index, component);
    }

    public void ReplaceHideEntityRequest(int newEntityId, bool newVisible) {
        var index = CommandComponentsLookup.HideEntityRequest;
        var component = CreateComponent<svanderweele.Mine.Game.Actions.HideActor.HideEntityRequestComponent>(index);
        component.entityId = newEntityId;
        component.visible = newVisible;
        ReplaceComponent(index, component);
    }

    public void RemoveHideEntityRequest() {
        RemoveComponent(CommandComponentsLookup.HideEntityRequest);
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
public sealed partial class CommandMatcher {

    static Entitas.IMatcher<CommandEntity> _matcherHideEntityRequest;

    public static Entitas.IMatcher<CommandEntity> HideEntityRequest {
        get {
            if (_matcherHideEntityRequest == null) {
                var matcher = (Entitas.Matcher<CommandEntity>)Entitas.Matcher<CommandEntity>.AllOf(CommandComponentsLookup.HideEntityRequest);
                matcher.componentNames = CommandComponentsLookup.componentNames;
                _matcherHideEntityRequest = matcher;
            }

            return _matcherHideEntityRequest;
        }
    }
}