using CommonLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Interfaces
{
    public interface IRegisterRL
    {
        public string AddEmployee(EmployeeModel employeeModel);
        public string DeleteEmp(string empID);
        public IList<EmployeeModel> GetAllEmp();
        public EmployeeModel GetEmp(string empID);
        public string UpdateEmp(EmployeeModel emp);


    }
}
