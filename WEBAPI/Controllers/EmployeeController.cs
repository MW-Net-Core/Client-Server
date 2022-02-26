using Microsoft.AspNetCore.Mvc;
using WEBAPI.ViewModel;

namespace WEBAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
       
        [HttpPost]
        [Route("Add-Emp")]
        public EmployeeVM addEmployee(EmployeeVM EMPVM)
        {
            return EMPVM;
        }
        
    }
}
