using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChatHubWPF.Models
{
    public class Message
    {
        public Message(string from, string to, string messageText, bool isRead)
        {
            From = from;
            To = to;
            MessageText = messageText;
            IsRead = isRead;
        }

        public string From { get; set; }
        public string To { get; set; }
        public string MessageText { get; set; }
        public bool IsRead { get; set; }
    }
}
