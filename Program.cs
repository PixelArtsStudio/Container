Binder binder = new Binder();
int n = 55555;
binder.Bind(typeof(Program)).To(n).To("hehehe").To(typeof(Program));
binder.Get(typeof(Program)).ToList<object>().ForEach(e => System.Console.WriteLine(e));