using Microsoft.VisualStudio.TestTools.UnitTesting;
using MeetingScheduler.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingScheduler.Controllers.Tests
{
    [TestClass()]
    public class CalendarControllerTests
    {
        [TestMethod()]
        public void CheckMeetingInMonthTest()
        {
           var meetingList = new BusinessLogic.MeetingBLL().GetMeetingByMonth(2);
            Assert.IsTrue(meetingList.Count > 0);
            
        }

        [TestMethod()]
        public void GetMeetingDetailTest()
        {
            var meetingList = new BusinessLogic.MeetingBLL().GetMeetingDetail(2);
            Assert.IsTrue(meetingList.Count == 2);
            //Assert.Fail();
        }
    }
}