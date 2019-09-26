using System;
using System.Collections.Generic;
using System.Text;

namespace Attendance_Managment_System_Api
{
    public interface IEmployee
    {
        int Id { get; set; }
        string Name { get; set; }
        int ManagerId { get; set; }
        void ViewStatistics(int Id);
    }

}
