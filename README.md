# GoF_Csharp_Proxy_Pattern

The Proxy Pattern is a structural design pattern that allows one object, called the proxy, to act as an intermediary or substitute for another object, 
called the real subject. The proxy controls access to the real subject and can add additional functionality or behavior without changing the real subject's interface.

The Proxy Pattern is useful in scenarios where you want to control access to an object, especially in situations where the real subject is resource-intensive
to create or initialize, or when you need to provide additional functionality like caching, logging, security checks, etc.

```csharp
﻿using System;

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
```

## How to setup Github actions

![Csharp Github actions](https://github.com/luiscoco/GoF_Csharp-12.Proxy_Pattern/assets/32194879/df9478ea-11ab-4117-a693-96c40ee05160)


