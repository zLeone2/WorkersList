using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkersList
{
    internal class EmployeeB : EmployeeA , IWorker
    {
        public decimal Bonus { get; set; }
        public int Vacationdays { get; set; }
        public string Position { get; set; }
        public bool DecisionMakingAuthority { get; set; }    
   
        public EmployeeB(string name, string lastname, string employeeID, DateTime dateofbirth, int age, string gender, string adress, string phonenumber, string email, string password, DateTime dateofhire,double salary, double hoursperweek, decimal bonus, int vacationdays, string position, bool decisionMakingAuthority)
        : base( name, lastname, employeeID, dateofbirth, age, gender, adress, phonenumber,email, password, dateofhire,salary, hoursperweek)
        {
            Bonus = bonus;
            Vacationdays = vacationdays;
          
          
            Position = position;
            DecisionMakingAuthority = decisionMakingAuthority;
           
            
        }
    
    }
}
