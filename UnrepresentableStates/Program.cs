// See https://aka.ms/new-console-template for more information
using UnrepresentableStates;

Console.WriteLine("Hello, World!");
var conn1 = new Connection
{
    State = Connection.ConnectionState.Connecting,
    WhenDisconnected = DateTime.UtcNow
}; // so this is not a very good idea...

/* The below gives an error as the compiler itself detects that this
 * state is NOT internally consistent
var conn2 = new BetterConnection
{
    State = new Connecting { WhenInitiated = DateTime.UtcNow },
    WhenDisconnected = DateTime.UtcNow
};  */