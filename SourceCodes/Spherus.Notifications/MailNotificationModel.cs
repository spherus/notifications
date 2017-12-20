using Spherus.Notifications.Mail;
using System.Collections.Generic;

namespace Spherus.Notifications
{
    public class MailNotificationModel
    {

        public MailNotificationModel()
        {
            To = new List<Address>();
            Attachments = new List<Attachment>();
            Images = new List<Attachment>();
            Credentials = new Dictionary<string, object>();
        }

        public Address From { get; set; }

        public IList<Address> To { get; set; }

        public Address ReplyTo { get; set; }

        public string Subject { get; set; }

        public string Text { get; set; }

        public IList<Attachment> Attachments { get; set; }

        public IList<Attachment> Images { get; set; }

        public IDictionary<string, object> Credentials { get; set; }
    }
}