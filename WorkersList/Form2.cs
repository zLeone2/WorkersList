using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WorkersList
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string idgenerate;
        int ages;
        public string[] employeesA;
        public string[] employeesB;
        bool decitionmaking;
        
        private void btnTA_Click(object sender, EventArgs e)
        {
            
            txtboxValidation.Text = string.Empty;
            if (string.IsNullOrWhiteSpace(idgenerate) || string.IsNullOrWhiteSpace(Generatepassword()))
            {
                return;
            }
            

            switch (txtBoxCounter())
            {
                case 4:
                    txtboxValidation.Text = "Employee succesufuly added";

                    try
                    {
                        getAge(Convert.ToDateTime(txtboxDateBirth.Text));
                        EmployeeA employeeA = new EmployeeA(txtbosName.Text, txtboxLastName.Text, idgenerate, Convert.ToDateTime(txtboxDateBirth.Text), ages, txtboxGender.Text, txtboxAdress.Text, txtboxPhone.Text, txtboxEmail.Text, Generatepassword(), Convert.ToDateTime(txtboxDateHire.Text), Convert.ToDouble(txtboxSalary.Text), Convert.ToDouble(txtboxHourspr.Text));                        
                        employeesA = new string[] { employeeA.Name, employeeA.Lastname, employeeA.employeeID, employeeA.DateofBirth.ToString("dd-MM-yyyy"), employeeA.Age.ToString(), employeeA.Gender, employeeA.Adress, employeeA.Phonenumber.ToString(), employeeA.Email,employeeA.Dateofhire.ToString("dd-MM-yyyy"), employeeA.salary.ToString(), employeeA.Hoursperweek.ToString() };
                       
                        WriteTextToFile(@"C:\Users\Roberto\source\repos\WorkersList\WorkersList\ListEmployeesA.txt", employeesA);
                    }
                    catch (Exception ex)
                    {
                        txtboxValidation.Text = ex.Message;

                    }

                    break;
                case > 4:
                    txtboxValidation.Text = "Missing Information";
                    break;
                case < 4:
                    txtboxValidation.Text = "Too much Information for a Type A employee";
                    break;
            }

        }
        private void btnTB_Click(object sender, EventArgs e)
        {
            txtboxValidation.Text = string.Empty;
            if (string.IsNullOrWhiteSpace(idgenerate) || string.IsNullOrWhiteSpace(Generatepassword()))
            {
                return;
            }
            Decisionmaking();

            switch (txtBoxCounter())
            {
                case 1:

                    txtboxValidation.Text = "Employee succesufuly added";
                    try
                    {
                        getAge(Convert.ToDateTime(txtboxDateBirth.Text));
                        EmployeeB employeeB = new EmployeeB(txtbosName.Text, txtboxLastName.Text, idgenerate, Convert.ToDateTime(txtboxDateBirth.Text).Date, ages, txtboxGender.Text, txtboxAdress.Text, txtboxPhone.Text, txtboxEmail.Text, Generatepassword(), Convert.ToDateTime(txtboxDateHire.Text).Date, Convert.ToDouble(txtboxSalary.Text), Convert.ToDouble(txtboxHourspr.Text), Convert.ToDecimal(txtboxBonus.Text), Convert.ToInt32(txtboxVacation.Text), txtboxPosition.Text, decitionmaking);
                        employeesB = new string[] { employeeB.Name, employeeB.Lastname, employeeB.employeeID, employeeB.DateofBirth.ToString("dd-MM-yyyy"),  employeeB.Age.ToString(), employeeB.Gender, employeeB.Adress, employeeB.Phonenumber.ToString(), employeeB.Email, employeeB.Dateofhire.ToString("dd-MM-yyyy"), employeeB.salary.ToString(), employeeB.Hoursperweek.ToString(), employeeB.Bonus.ToString(), employeeB.Vacationdays.ToString(), employeeB.Position, employeeB.DecisionMakingAuthority.ToString()};

                        WriteTextToFile(@"C:\Users\Roberto\source\repos\WorkersList\WorkersList\ListEmployeesB.txt", employeesB);
                    }
                    catch (Exception ex)
                    {
                        txtboxValidation.Text = ex.StackTrace;

                    }
                    break;
                case > 1:
                    txtboxValidation.Text = "Missing Information";
                    break;

            }


        }

        private int txtBoxCounter()
        {
            int counter = 0;
            int emptyboxcounter = 0;

            foreach (Control control in this.Controls)
            {
                if (control is System.Windows.Forms.TextBox textBox)
                {
                    counter++;
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        emptyboxcounter++;
                    }

                }
            }
            return emptyboxcounter;

        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            Generatepassword();
        }


        string Generatepassword()
        {
            const string uppercaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string lowercaseLetters = "abcdefghijklmnopqrstuvwxyz";
            const string numbers = "0123456789";
            const string symbols = "!@#$%^&*()-_=+<>?";

            string allCharacters = uppercaseLetters + lowercaseLetters + numbers + symbols;
            StringBuilder password = new StringBuilder();

            for (int i = 0; i < 10; i++)
            {
                int index = new Random().Next(allCharacters.Length);
                password.Append(allCharacters[index]);
            }

            return password.ToString();
        }

        private void btnID_Click(object sender, EventArgs e)
        {

            idgenerate = new EmployeeA().IDCreator(txtbosName.Text, txtboxLastName.Text);
        }
        private void getAge(DateTime date)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - date.Year;

            if (date > today.AddYears(-age))
            {
                age--;
            }
            ages = age;
        }


        void WriteTextToFile(string filePath, string[] employees)
        {
            string linea = string.Join(",", employees);


            try
            {
                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    sw.WriteLine(linea);
                 
                }

            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine($"Error de permisos: {ex.Message}");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine($"Directorio no encontrado: {ex.Message}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error de E/S: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió un error: {ex.Message}");
            }

           


        }

        void Decisionmaking()
        {
            switch (txtboxPosition.Text)
            {
                case "HR":
                    decitionmaking = false;
                    break;

                case "Accounter":
                    decitionmaking = false;
                    break;

                case "Manager":
                    decitionmaking = true;
                    break;
                    default:
                    txtboxPosition.Text = "Position not recognized";
                    break;
                case "Assistent Manager":
                    decitionmaking = true;
                    break;
            }

        }


     

    }
   
}
