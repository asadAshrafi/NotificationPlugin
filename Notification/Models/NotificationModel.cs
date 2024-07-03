using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationPlugin.Models
{
    public class NotificationModel
    {
        public Guid Id { get; set; }
        public string Heading { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
    }
}
