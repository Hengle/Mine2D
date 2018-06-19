namespace svanderweele.Mine.Core.Services.Input
{
    public interface IInputService
    {
        void SetPressUp(int eid);
        void SetPressDown(int eid);
        void SetHoverOut(int eid);
        void SetHoverIn(int eid);

        void IsKeyDown(KeyMap map);
        void IsKeyUp(KeyMap map);
        void IsKeyPressed(KeyMap map);

        void SetBind(string action, KeyMap key);
        void RemoveBind(string action);
    }

    public enum KeyMap
    {
        W,
        A,
        S,
        D,
        Space,
        None
    }
}