using BussinessLAyer.Interfaces;
using CommonLayer.Model;
using RepositoryLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLAyer.Services
{
    public class RegisterBL :IRegisterBL
    {
        private readonly IRegisterRL registerRL;
        public RegisterBL(IRegisterRL registerRL)
        {
            this.registerRL = registerRL;
        }
        public string AddEmployee(EmployeeModel employeeModel)
        {
            try
            {
                return registerRL.AddEmployee(employeeModel);
            }
            catch(Exception)
            {
                throw;

            }
        }


        public IList<EmployeeModel> GetAllEmp()
        {
            try
            {
                return this.registerRL.GetAllEmp();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public EmployeeModel GetEmp(string empID)
        
        {
            try
            {
                return this.registerRL.GetEmp(empID);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public string UpdateEmp(EmployeeModel emp)
        {
            try
            {
               return this.registerRL.UpdateEmp(emp);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public string DeleteEmp(string empID)
        {
            try
            {
               return this.registerRL.DeleteEmp(empID);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
