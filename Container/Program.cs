Container.Instance.Add(new Random());
System.Console.WriteLine("Please input:");
while (true)
{
    if (Console.ReadLine() == "a")
    {
        Console.WriteLine(Container.Instance.Get<Random>().Next());
    }
}