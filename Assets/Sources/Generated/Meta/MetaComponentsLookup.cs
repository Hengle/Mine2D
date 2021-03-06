//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentLookupGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public static class MetaComponentsLookup {

    public const int CollisionService = 0;
    public const int GridService = 1;
    public const int GridEditorService = 2;
    public const int Id = 3;
    public const int InputController = 4;
    public const int InputService = 5;
    public const int SelectionService = 6;
    public const int TickService = 7;
    public const int TimeService = 8;
    public const int ViewService = 9;

    public const int TotalComponents = 10;

    public static readonly string[] componentNames = {
        "CollisionService",
        "GridService",
        "GridEditorService",
        "Id",
        "InputController",
        "InputService",
        "SelectionService",
        "TickService",
        "TimeService",
        "ViewService"
    };

    public static readonly System.Type[] componentTypes = {
        typeof(svanderweele.Core.Pieces.Collision.Services.CollisionServiceComponent),
        typeof(svanderweele.Core.Pieces.Grid.Core.Service.GridServiceComponent),
        typeof(svanderweele.Core.Pieces.GridEditor.Service.Core.GridEditorServiceComponent),
        typeof(svanderweele.Core.Pieces.Id.IdComponent),
        typeof(svanderweele.Core.Pieces.Input.Controller.InputControllerComponent),
        typeof(svanderweele.Core.Pieces.Input.Service.InputServiceComponent),
        typeof(svanderweele.Core.Pieces.Selection.Services.SelectionServiceComponent),
        typeof(svanderweele.Core.Pieces.Tick.Services.TickServiceComponent),
        typeof(svanderweele.Core.Pieces.Time.TimeServiceComponent),
        typeof(svanderweele.Core.Pieces.View.ViewServiceComponent)
    };
}
