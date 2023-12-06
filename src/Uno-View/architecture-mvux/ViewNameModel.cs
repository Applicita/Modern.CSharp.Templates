namespace NamespacePrefix.Presentation;

public partial record ViewNameModel(string Text = "Hello World!")
{
    public void Tap() => Console.WriteLine("Tapped!");
};
