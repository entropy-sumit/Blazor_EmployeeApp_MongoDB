using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CommonLayer.Model
{
    public class EmployeeModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string EmployeeId { get; set; }
        
        public string Name { get; set; }
        
        public string ProfileImg { get; set; }
        
        public string Gender { get; set; }
        
        public string Department { get; set; }
        
        public string Notes { get; set; }
        
        public DateTime StartDate { get; set; }
        
        public string Salary { get; set; }

    }
}
