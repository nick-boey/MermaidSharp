namespace MermaidSharp;

public interface ISourceFile
{
    string Path { get; }
    string Content { get; }
}