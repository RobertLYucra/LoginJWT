using LoginJWT.Constans;
using LoginJWT.Models;
using LoginJWT.Repository.Interfaces;

namespace LoginJWT.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public List<EmployeeModel> GetAllEmployes()
        {
            return EmployeeConstants.Employees;
        }
    }
}
