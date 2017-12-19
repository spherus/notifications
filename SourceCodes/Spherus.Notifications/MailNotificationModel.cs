using Spherus.Notifications.Mail;
using System.Collections.Generic;

namespace Spherus.Notifications
{
    public class MailNotificationModel
    {
        public Address From { get; set; }

        public IList<Address> To { get; set; }

        public Address ReplyTo { get; set; }

        public string Subject { get; set; }

        public string Text { get; set; }

        public IList<Attachment> Attachments { get; set; }

        public IList<Attachment> Images { get; set; }
    }
}