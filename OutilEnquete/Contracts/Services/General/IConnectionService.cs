using Plugin.Connectivity.Abstractions;

namespace OPS.UIWEB.Contracts.Services.General
{
    public interface IConnectionService
    {
        bool IsConnected { get; }
        event ConnectivityChangedEventHandler ConnectivityChanged;
    }
}
