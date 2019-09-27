using Attendance_Managment_System_Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AttendanceManagementSysytem.Model
{
    public class Employee :IEmployee
    {

        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int ManagerId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Attendance[] ViewStatistics()
        {
            AttendanceRegister attendanceRegister = new AttendanceRegister();
            return attendanceRegister.ShowAttendanceList().ToArray();
        }

        public void MarkAttenadance(int EmpId, DateTime dateTime)
        {
            AttendanceRegister attendanceRegister = new AttendanceRegister();
            Attendance attendance = new Attendance();
            attendance.EmpId = EmpId;
            attendance.DateTime = dateTime;
            attendanceRegister.AddAttendance(attendance);
        }

        public List<string> ViewStatisticsById(int EmpId)
        {
            List<string> ArrayDateTime = new List<string>();
            int i = 0;
            AttendanceRegister attendanceRegister = new AttendanceRegister();
            List<Attendance> attendanceList = attendanceRegister.ShowAttendanceList();
            foreach (var item in attendanceList)
            {
                if (item.EmpId==EmpId)
                {
                    ArrayDateTime.Add(item.DateTime.ToString());
                    i++;
                }
            }
            return ArrayDateTime;
        }

        void IEmployee.ViewStatistics(int Id)
        {     
            throw new NotImplementedException();
        }     
    }
}
