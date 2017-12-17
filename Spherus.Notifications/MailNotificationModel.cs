using Spherus.Notifications.Email;
using System.Collections.Generic;

namespace Spherus.Notifications
{
    public class MailNotificationModel
    {
        public EmailAddress From { get; set; }

        public IList<EmailAddress> To { get; set; }

        public IList<EmailAddress> Bcc { get; set; }

        public EmailAddress ReplyTo { get; set; }

        public string Subject { get; set; }

        public string Text { get; set; }

        public IList<EmailAttachment> Attachments { get; set; }
    }
}