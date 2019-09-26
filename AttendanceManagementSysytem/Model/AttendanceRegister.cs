using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AttendanceManagementSysytem.Model
{
    public class AttendanceRegister
    {
        public static List<Attendance> attendanceList =new  List<Attendance>();
        
        public bool AddAttendance(Attendance attendance)
        {
            attendanceList.Add(attendance);
            return true;
        }

        public List<Attendance> ShowAttendanceList()
        {
            return attendanceList;
        }
    }
}
