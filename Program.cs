using System;

class Program
{
    static void Main()
    {
        // Using the Proxy to handle the request
        ISubject proxy = new Proxy();
        proxy.Request();
    }
}

// Subject interface
public interface ISubject
{
    void Request();
}

// RealSubject class
public class RealSubject : ISubject
{
    public void Request()
    {
        Console.WriteLine("RealSubject: Handling the request.");
    }
}

// Proxy class
public class Proxy : ISubject
{
    private RealSubject realSubject;

    public void Request()
    {
        // Lazy initialization of the RealSubject
        if (realSubject == null)
        {
            realSubject = new RealSubject();
        }

        // You can add additional functionality here before or after delegating the request to the RealSubject
        Console.WriteLine("Proxy: Handling the request before delegating to RealSubject.");

        // Delegating the request to the RealSubject
        realSubject.Request();

        // You can add additional functionality here after delegating the request to the RealSubject
        Console.WriteLine("Proxy: Handling the request after delegating to RealSubject.");
    }
}
