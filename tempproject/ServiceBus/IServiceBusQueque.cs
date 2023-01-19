namespace ProjektKPCH.ServiceBus
{
    public interface IServiceBusQueue
    {
        Task SendMessageAsync(string serviceBusMessage);
    }
}
