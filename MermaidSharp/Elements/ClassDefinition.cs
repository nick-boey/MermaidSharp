namespace MermaidSharp.Elements;

public class ClassDefinition
{
    public string Name { get; set; }
    public string IsInterface { get; }
    public ClassDefinition? BaseClass { get; }

    public List<MemberDefinition> Members { get; } = [];
    public List<MethodDefinition> Methods { get; } = [];

    public string GenerateDiagramDefinition()
    {
        throw new NotImplementedException();
    }
}