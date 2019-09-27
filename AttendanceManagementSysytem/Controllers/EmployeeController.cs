using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AttendanceManagementSysytem.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Attendance_Managment_System_Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
          // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Attendance>> Get()
        {
            Employee employee = new Employee();
            return employee.ViewStatistics();
        }

        // GET api/values/5
        [HttpGet("{EmpId}")]
        public List<string> Get(int EmpId)
        {
            Employee employee = new Employee();
            return employee.ViewStatisticsById(EmpId);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] AttendanceById attendanceById)
        {
            Employee employee = new Employee();
            employee.MarkAttenadance(attendanceById.EmpId, DateTime.Now);
        }
    }
}