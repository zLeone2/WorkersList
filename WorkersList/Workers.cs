using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WorkersList
{

    public interface IWorker
    {
        
        double salary { get; set; }
        string employeeID { get; set; }
      
        string IDCreator(string name, string lastname); // A method that simulates the work the employee does
    }

    class EmployeeA : IWorker

    {
        public double salary { get; set; }
       public  string employeeID { get; set; }
        public string IDCreator(string name, string lastname)
        {
            char letterN = char.ToUpper(name[0]);
            char letterLN = char.ToUpper(lastname[0]);
            return $"{letterN} {letterLN}"+ new Random().Next(1000, 10000).ToString() + "A";
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string lastname;
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
        

        private string password;

  
        public string Password
        {
            set { password = value; }
        }

        private int age;
        public int Age
        {
            get { return age; }
            
        }


        private string gender;
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }



        private string adress;
        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }


        private string phonenumber;
        public string Phonenumber
        {
            get { return phonenumber; }
            set { phonenumber = value; }
        }


        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }



        private DateTime dateofbirth;
        public DateTime DateofBirth
        {
            get { return dateofbirth; }
            set { dateofbirth = value; }
        }


        private DateTime dateofhire;
        public DateTime Dateofhire
        {
            get { return dateofhire; }
            set { dateofhire = value; }
        }

        private double hoursperweek;
        public double Hoursperweek
        {
            get { return hoursperweek; }
            set { hoursperweek = value; }
        }
        public EmployeeA(string name,string lastname, string employeeID, DateTime dateofbirth, int age, string gender,string adress, string phonenumber,string email, string password, DateTime dateofhire, double salary, double hoursperweek)
        {
            Name = name;
            
            Lastname = lastname;
          
            Password = password;

            this.employeeID = employeeID;

            this.salary = salary;

            this.age = age;
            Gender = gender;
           
            Adress = adress;
          
            Phonenumber = phonenumber;
           
                    
            Email = email;
          
            this.dateofbirth = dateofbirth;
           
            Dateofhire = dateofhire;    
            
            Hoursperweek = hoursperweek;
        }
        public EmployeeA()
        {

        }

    }
}
