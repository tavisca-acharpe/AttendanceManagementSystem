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
    public class AdminController : ControllerBase
    {

        [HttpGet]
        public ActionResult<IEnumerable<Attendance>> Get()
        {
            Employee employee = new Employee();
            return employee.ViewStatistics();
        }
        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
            Employee employee = new Employee();
            employee.MarkAttenadance(1, DateTime.Now);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

    }
}