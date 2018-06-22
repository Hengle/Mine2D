using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace svanderweele.Mine.Core.Pieces.Id
{
    [Game, Input, Meta, Command, Grid, MapEditor]
    public class IdComponent : IComponent
    {
        [PrimaryEntityIndex]
        public int value;
    }
}