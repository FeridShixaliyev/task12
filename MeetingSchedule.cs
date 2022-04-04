using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp41
{
    class MeetingSchedule
    {
        List<Meeting> meetings = new List<Meeting>();
        
        
        public string SetMeeting(string name,DateTime fromdate,DateTime todate,DateTime meetdate)//meetdate yoxlanacag vaxtdi
        {
            if (meetdate > fromdate && meetdate < todate)
            {
                throw new Exception("bu araliqda meeting var!!");
            }
            else
            {
                string Names= meetings.Add(name);
            }
        }
        public int FindMeetingsCount(DateTime meet,DateTime fromDate)
        {
            int count = 0;
            if (meet < fromDate)
            {
                count++;
            }
            return count;
        }
        public bool IsExistsMeetingByName(string str)
        {
            if (!string.IsNullOrWhiteSpace(str))
            {
                if (str == meetings.Name)
                {
                    return true;
                }
            }
            return false;
        }
        public List<string> GetExistMeetings(string name)
        {
            List<string> findname=new List<string>();
            if (!string.IsNullOrWhiteSpace(name))
            {
                if (name == meetings.Name)
                {
                    findname.Add(name);
                }
            }
            return null;
        }
    }
}
