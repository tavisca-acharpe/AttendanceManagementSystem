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
            List<Attendance> attendanceList = attendanceRegister.ShowAttendanceList();
           string[] val = new string[attendanceList.Count];
            int i = 0;
            foreach (var item in attendanceList)
            {
                val[i]=item.EmpId.ToString()+"  "+item.DateTime.ToString();
                i++;
            }
            return attendanceList.ToArray();
        }

        public void MarkAttenadance(int id, DateTime dateTime)
        {
            AttendanceRegister attendanceRegister = new AttendanceRegister();
            Attendance attendance = new Attendance();
            attendance.EmpId = id;
            attendance.DateTime = dateTime;
            attendanceRegister.AddAttendance(attendance);
        }

        public List<string> ViewStatisticsById(int EmpId)
        {
            List<string> ArrayDateTime = new List<string>();
            int i = 0;
            AttendanceRegister attendanceRegister = new AttendanceRegister();
            foreach (var item in attendanceRegister.ShowAttendanceList())
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
