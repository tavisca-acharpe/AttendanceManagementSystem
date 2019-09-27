using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AttendanceManagementSysytem.Model
{
    public class AttendanceRegister
    {
        public static List<Attendance> attendanceList =new  List<Attendance>();      
        public void AddAttendance(Attendance attendance)
        {
            attendanceList.Add(attendance);
        }
        public List<Attendance> ShowAttendanceList()
        {
            return attendanceList;
        }
    }
}
