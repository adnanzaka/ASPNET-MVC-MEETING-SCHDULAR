using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeetingScheduler.Controllers
{
    public class CalendarController : Controller
    {
        // GET: Calendar
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetMeetingByMonth(int Month)
        {
            try
            {
                var meetingList=  new BusinessLogic.MeetingBLL().GetMeetingByMonth(Month); 
                return Json(meetingList, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public ActionResult GetMeetingDetail(int MeetingId)
        {
            try
            {
                var meetingList = new BusinessLogic.MeetingBLL().GetMeetingDetail(MeetingId);
                return Json(meetingList, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}