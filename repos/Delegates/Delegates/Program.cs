namespace Program;

public delegate void MyDelegate(string message);
      public class DelegateET
{
    public void Method1(string message)
    {
        Console.WriteLine($"Method1 :{message}");
    }
    public void Method2(string message)
    {
        Console.WriteLine($"Method2: {message}");
    }
}

