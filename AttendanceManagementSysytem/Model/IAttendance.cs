using System;
using System.Collections.Generic;
using System.Text;

namespace Attendance_Managment_System_Api
{
    interface IAttendance
    {
        string Intime { get; set; }
        string OutTime { get; set; }
        void CalculateWeekAttendance(int Id);
        void CalculateMonthAttendance(int Id);
        void CalculateYearAttendance(int Id);

    }
}
