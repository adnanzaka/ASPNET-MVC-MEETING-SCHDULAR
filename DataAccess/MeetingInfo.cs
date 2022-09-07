using DataAccess.DataSource;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class MeetingInfo
    {
        public IQueryable<Meeting> GetMeetingByMonth(int MonthNo)
        {
            try
            {
                using (var context = new MeetingSchedulerEntities1())
                {                    
                    return context.Meetings.Where(s => s.Month.Equals(MonthNo));
                }
            }
            catch (System.Exception ex)
            {

                throw;
            }
           
        }
        
        public IQueryable<MeetingDetail> GetMeetingDetail(int MeetingId)
        {
            using (var context = new MeetingSchedulerEntities1())
            {
                return context.MeetingDetails.Where(s => s.MeetingId.Equals(MeetingId));
            }
        }
    }
}
