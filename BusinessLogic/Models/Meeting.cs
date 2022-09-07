using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MeetingBLL.Models
{
    [DataContract]
    public class Meeting
    {
        
        public int MeetingId { get; set; }
        
        public int Month { get; set; }
         
        public System.DateTime Date { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string Organizer { get; set; }
        [DataMember]
        public virtual ICollection<MeetingDetail> MeetingDetails { get; set; }
    }
}