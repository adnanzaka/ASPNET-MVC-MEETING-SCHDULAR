using AutoMapper;
using DataAccess;
using MeetingBLL.Models;
using System.Collections.Generic;

namespace BusinessLogic
{
   public class MeetingBLL
    {
        public List<Meeting> GetMeetingByMonth(int MonthNo)
        {
            return new MeetingInfo().GetMeetingByMonth(MonthNo).MapDTO();
        //    List<Meeting> lstMeeting = new List<Meeting>();
       
            //try
            //{
            //    var list = new MeetingInfo().GetMeetingByMonth(MonthNo);
              
            //    foreach (DataAccess.DataSource.Meeting meeting in list)
            //    {
            //        var meetingObj = new Meeting()
            //        {
            //            MeetingId = meeting.MeetingId,
            //            Month = meeting.Month,
            //            Date = meeting.Date,
            //            Title = meeting.Title,
            //            Description = meeting.Description,
            //            Organizer = meeting.Organizer
            //        };
            //        lstMeeting.Add(meetingObj);
            //    }
            //}
            //catch (System.Exception)
            //{ 
            //}
            
            //return lstMeeting;
        }
        public List<MeetingDetail> GetMeetingDetail(int MeetingId)
        {
           return new MeetingInfo().GetMeetingDetail(MeetingId).MapDTO();
            //var list = new MeetingInfo().GetMeetingDetail(MeetingId);
            //List<MeetingDetail> lstMeeting = new List<MeetingDetail>();
            //foreach (DataAccess.DataSource.MeetingDetail meeting in list)
            //{
            //    var meetingObj = new MeetingDetail()
            //    {
            //        MeetingId = meeting.MeetingId,
            //         Attendee=meeting.Attendee
            //    };
            //    lstMeeting.Add(meetingObj);
            //}
            //return lstMeeting;

        }

       
    }

    
}
