using GraphQLServer.Models;

namespace GraphQLServer;

public class Query
{
    public Person GetPerson() => new Person("Luke Skywalker");
}


