namespace $namespace$;

#if(csharpversion == '11')
public partial class ViewNameViewModel
{
    public string Message { get; set; } = "Hello from C# Markup 2 - the concise, next-gen C# Markup for Uno!";
}
#else
public partial class ViewNameViewModel(string Message = "NJoy concise C# Markup 2 for Uno Platform");
#endif
