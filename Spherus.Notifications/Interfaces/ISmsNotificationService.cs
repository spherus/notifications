using System.Threading.Tasks;

namespace Spherus.Notifications.Interfaces
{
    public interface ISmsNotificationService
    {
        Task<ServiceResponse<INotificationResult>> Notify(SmsNotificationModel model);
    }
}