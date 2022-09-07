using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeetingBLL.Models
{
    public class MeetingDetail
    {
        public int MeetingDetailId { get; set; }
        public int MeetingId { get; set; }
        public string Attendee { get; set; }
        public virtual Meeting Meeting { get; set; }
    }
}