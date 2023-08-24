using com.sun.tools.javac.util;

namespace PrijavaQR.Models
{
    public class MailDataWithAttachments
    {
        // Receiver
        public List? To { get; set; }
        public List? Bcc { get; set; }
        public List? Cc { get; set; }

        // Sender
        public string? From { get; set; }
        public string? DisplayName { get; set; }
        public string? ReplyTo { get; set; }
        public string? ReplyToName { get; set; }

        // Content
        public string? Subject { get; set; }
        public string? Body { get; set; }
        public IFormFileCollection? Attachments { get; set; }

    }
}
