using CommonLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLAyer.Interfaces
{
    public interface IRegisterBL 
    {
        public string AddEmployee(EmployeeModel employeeModel);
        public IList<EmployeeModel> GetAllEmp();
        public EmployeeModel GetEmp(string empID);
        public string UpdateEmp(EmployeeModel emp);
        public string DeleteEmp(string empID);


    }
}
