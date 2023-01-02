namespace LittleBlocks.Notifications.Messaging;

public interface IMessagingService
{
    Task SendAsync(Message message);
}
