[AttributeUsage(AttributeTargets.Class)]
public class InjectAttribute : Attribute { public object[] Parameters { get; set; } }