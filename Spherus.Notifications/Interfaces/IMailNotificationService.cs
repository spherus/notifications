using System.Threading.Tasks;

namespace Spherus.Notifications.Interfaces
{
    public interface IMailNotificationService : INotificationService
    {
        Task<ServiceResponse<INotificationResult>> Notify(MailNotificationModel model);
    }
}
