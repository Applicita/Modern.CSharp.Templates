namespace $namespace$;

#if(csharpversion == '11')
public partial class ViewNameViewModel
{
    public string Message { get; set; } = "NJoy concise C# Markup 2 for Uno Platform";
}
#else
public partial class ViewNameViewModel(string Message = "NJoy concise C# Markup 2 for Uno Platform");
#endif
