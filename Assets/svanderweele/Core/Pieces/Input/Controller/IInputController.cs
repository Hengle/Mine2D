﻿using svanderweele.Mine.Game.Utils;

namespace svanderweele.Core.Pieces.Input.Controller
{
    public interface IInputController
    {
        bool IsKeyHeldDown(KeyId id);
        bool IsKeyDown(KeyId id);
        bool IsKeyUp(KeyId id);
        bool IsMouseUp();
        bool IsMouseDown();
    }
}