//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class CommandEntity {

    public svanderweele.Mine.GameEditor.Pieces.MapEditor.Command.CreateMapEditor.CommandRequestCreateMapEditorComponent commandRequestCreateMapEditor { get { return (svanderweele.Mine.GameEditor.Pieces.MapEditor.Command.CreateMapEditor.CommandRequestCreateMapEditorComponent)GetComponent(CommandComponentsLookup.CommandRequestCreateMapEditor); } }
    public bool hasCommandRequestCreateMapEditor { get { return HasComponent(CommandComponentsLookup.CommandRequestCreateMapEditor); } }

    public void AddCommandRequestCreateMapEditor(int newGridId) {
        var index = CommandComponentsLookup.CommandRequestCreateMapEditor;
        var component = CreateComponent<svanderweele.Mine.GameEditor.Pieces.MapEditor.Command.CreateMapEditor.CommandRequestCreateMapEditorComponent>(index);
        component.gridId = newGridId;
        AddComponent(index, component);
    }

    public void ReplaceCommandRequestCreateMapEditor(int newGridId) {
        var index = CommandComponentsLookup.CommandRequestCreateMapEditor;
        var component = CreateComponent<svanderweele.Mine.GameEditor.Pieces.MapEditor.Command.CreateMapEditor.CommandRequestCreateMapEditorComponent>(index);
        component.gridId = newGridId;
        ReplaceComponent(index, component);
    }

    public void RemoveCommandRequestCreateMapEditor() {
        RemoveComponent(CommandComponentsLookup.CommandRequestCreateMapEditor);
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

    static Entitas.IMatcher<CommandEntity> _matcherCommandRequestCreateMapEditor;

    public static Entitas.IMatcher<CommandEntity> CommandRequestCreateMapEditor {
        get {
            if (_matcherCommandRequestCreateMapEditor == null) {
                var matcher = (Entitas.Matcher<CommandEntity>)Entitas.Matcher<CommandEntity>.AllOf(CommandComponentsLookup.CommandRequestCreateMapEditor);
                matcher.componentNames = CommandComponentsLookup.componentNames;
                _matcherCommandRequestCreateMapEditor = matcher;
            }

            return _matcherCommandRequestCreateMapEditor;
        }
    }
}
