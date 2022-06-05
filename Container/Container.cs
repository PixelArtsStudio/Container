public class Container
{
    public static readonly Container Instance = new Container();
    Dictionary<Type, object> Links { get; set; } = new Dictionary<Type, object>();
    Container() => System.Reflection.Assembly.GetExecutingAssembly().GetTypes().ToList<Type>().FindAll(t => t.IsDefined(typeof(InjectAttribute), true)).ForEach(t => Links.Add(t, Instantiate(t)));
    object Instantiate(Type type) => Activator.CreateInstance(type, (type.GetCustomAttributes(typeof(InjectAttribute), true)[0] as InjectAttribute).Parameters);
    public void Add(object instance, Type type = null) => Links.Add(type ?? instance.GetType(), instance);
    public void Add<T>() => Add(Instantiate(typeof(T)), typeof(T));
    public object Get(Type type) => Links[type];
    public T Get<T>() => (T)Get(typeof(T));
}