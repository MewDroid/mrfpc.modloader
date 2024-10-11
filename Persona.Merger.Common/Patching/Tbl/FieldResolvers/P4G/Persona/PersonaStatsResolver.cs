using Sewer56.StructuredDiff.Interfaces;

namespace Persona.Merger.Patching.Tbl.FieldResolvers.P4G.Persona;

public struct PersonaStatsResolver : IEncoderFieldResolver
{
    public bool Resolve(nuint offset, out int moveBy, out int length)
    {
        // All data can be assumed as individual bytes.
        moveBy = 0;
        length = 1;
        return false;
    }
}