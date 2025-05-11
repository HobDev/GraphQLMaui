using System;

namespace GraphQLServer.Models;

public class Person
{
    public Person(string name)
    {
        Name = name;
    }

    public string Name { get; }
}
