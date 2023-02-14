namespace UnrepresentableStates;

internal class Connection
{
    public enum ConnectionState
    { Connecting, Connected, Disconnected };

    public ConnectionState State { get; init; }

    public string Server { get; init; } = null!; // http address

    public DateTime? LastPingTime { get; init; }

    public int? LastPingId { get; init; }

    public string? SessionId { get; set; }

    public DateTime? WhenInitiated { get; init; }

    public DateTime? WhenDisconnected { get; init; }
}