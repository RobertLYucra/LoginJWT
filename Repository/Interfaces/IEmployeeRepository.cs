using LoginJWT.Models;

namespace LoginJWT.Repository.Interfaces
{
    public interface IEmployeeRepository
    {
        public List<EmployeeModel> GetAllEmployes();
    }
}
