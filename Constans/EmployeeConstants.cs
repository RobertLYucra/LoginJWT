using LoginJWT.Models;

namespace LoginJWT.Constans
{
    public class EmployeeConstants
    {
        public static List<EmployeeModel> Employees = new List<EmployeeModel>()
        {
            new EmployeeModel()
            {
                idEmployee = "EP1",
                FirstName = "Robert",
                LastName = "Lujan Yucra",
                Email = "Robert@gmail.com"
            }, new EmployeeModel()
            {
                idEmployee = "EP2",
                FirstName = "Carlos",
                LastName = "Lujan Yucra",
                Email = "Carlos@gmail.com"
            }, new EmployeeModel()
            {
                idEmployee = "EP3",
                FirstName = "Gabriel",
                LastName = "Lujan Yucra",
                Email = "Gabriel@gmail.com"
            }, new EmployeeModel()
            {
                idEmployee = "EP4",
                FirstName = "Maria",
                LastName = "Lujan Yucra",
                Email = "Maria@gmail.com"
            }, new EmployeeModel()
            {
                idEmployee = "EP5",
                FirstName = "Reyna",
                LastName = "Lujan Yucra",
                Email = "Reyna@gmail.com"
            },
        };

    }
}
