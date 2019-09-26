using Attendance_Managment_System_Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AttendanceManagementSysytem.Model
{
    public class Employee : IEmployee
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int ManagerId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void ViewStatistics(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
