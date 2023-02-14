namespace UnrepresentableStates;

internal class BetterConnection
{
    public BetterConnectionState State { get; init; } = null!;

    public string Server { get; init; } = null!;
}

internal abstract class BetterConnectionState
{ }

internal class Connecting : BetterConnectionState
{
    public DateTime WhenInitiated { get; init; }
}

internal class Connected : BetterConnectionState
{
    public record LastPingData(int Id, DateTime Time);

    public LastPingData? LastPing { get; init; }

    public string SessionId { get; init; } = null!;
}

internal class Disconnected : BetterConnectionState
{
    public DateTime WhenDisconnected { get; init; }
}