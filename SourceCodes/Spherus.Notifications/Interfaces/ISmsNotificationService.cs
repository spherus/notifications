using System.Threading.Tasks;

namespace Spherus.Notifications.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface ISmsNotificationService : INotificationService
    {
        Task<ServiceResponse<INotificationResult>> NotifyAsync(SmsNotificationModel model);
    }
}