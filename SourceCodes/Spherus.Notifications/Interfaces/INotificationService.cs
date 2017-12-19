using System.Threading.Tasks;

namespace Spherus.Notifications.Interfaces
{
    public interface INotificationService
    {
        Task<ServiceResponse<INotificationResult>> NotifyAsync();
    }
}