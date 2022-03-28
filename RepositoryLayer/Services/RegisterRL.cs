using CommonLayer;
using CommonLayer.Model;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using RepositoryLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace RepositoryLayer.Services
{
    public class RegisterRL : IRegisterRL
    {
        private readonly MongoClient client ;
        private readonly IMongoDatabase db ;
        public RegisterRL()
        {
            client = new MongoClient("mongodb://127.0.0.1:27017");
            db = client.GetDatabase("EmployeeBlazor");
           
        }
        public IMongoCollection<EmployeeModel> Empmodel => db.GetCollection<EmployeeModel>("EmployeeTable");

        public string AddEmployee(EmployeeModel employeeModel)
        {
            try
            {
                Empmodel.InsertOne(employeeModel);
                return "Added"; 

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
                this.Empmodel.DeleteOne(x => x.EmployeeId == empID);
                return "Deleted";
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
                return this.Empmodel.Find(FilterDefinition<EmployeeModel>.Empty).ToList();
            }
            catch(Exception)
            {
                throw;
            }
        }

        public EmployeeModel GetEmp(string empID)
        {
            try
            {
                return this.Empmodel.Find(x => x.EmployeeId == empID).FirstOrDefault();
            }
            catch(Exception)
            {
                throw;
            }
        }
        public string UpdateEmp(EmployeeModel emp)
        {
            var empWage = Empmodel.Find(x => x.EmployeeId == emp.EmployeeId).FirstOrDefault();
            if (empWage == null)
            {
                Empmodel.InsertOne(empWage);
                return "Created New";
            }
            else
            {
                Empmodel.ReplaceOne(x => x.EmployeeId == emp.EmployeeId, emp);
                return "Updated";
            }
        }
    }
}
