public class Link
{
    public object K { get; set; }
    public object[] V { get; set; }
    public Action<Link> Register;
    public Link Bind(object key) { K = key; return this; }
    public Link To(object value) { V = V == null ? new object[1] { value } : V.Append(value).ToArray(); Register(this); return this; }
}