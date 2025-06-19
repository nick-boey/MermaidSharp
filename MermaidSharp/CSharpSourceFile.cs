using MermaidSharp.Elements;

namespace MermaidSharp;

public class CSharpSourceFile
{
    private string _path;

    public List<ClassDefinition> ClassDefinitions { get; }
}