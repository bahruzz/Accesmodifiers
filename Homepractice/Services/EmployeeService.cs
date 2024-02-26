

using Homepractice.Models;

namespace Homepractice.Services
{
    internal class EmployeeService:Employee
    {
        public Employee[] GetAll()
        {
            Employee employee1 = new()
            {
                id = 1,
                name = "Employee1",
                surName = "Employee1",
                adress = "Baki1",
                email = "Employee1@gmail.com",
                age = 30
            };
            Employee employee2 = new()
            {
                id = 2,
                name = "Employee2",
                surName = "Employee2",
                adress = "Baki2",
                email = "Employee2@gmail.com",
                age = 34
            };
            Employee employee3 = new()
            {
                id = 3,
                name = "Employee3",
                surName = "Employee3",
                adress = "Baki3",
                email = "Employee3@gmail.com",
                age = 23
            };
            Employee employee4 = new()
            {
                id = 4,
                name = "Employee4",
                surName = "Employee4",
                adress = "Baki4",
                email = "Employee4@gmail.com",
                age = 41
            };
            Employee employee5 = new()
            {
                id = 5,
                name = "Employee5",
                surName = "Employee5",
                adress = "Baki5",
                email = "Employee5@gmail.com",
                age = 51
            };
            Employee employee6 = new()
            {
                id = 6,
                name = "Employee6",
                surName = "Employee6",
                adress = "Baki6",
                email = "Employee6@gmail.com",
                age = 59
            };
            Employee employee7 = new()
            {
                id = 7,
                name = "Employee7",
                surName = "Employee7",
                adress = "Baki7",
                email = "Employee7@gmail.com",
                age = 65

            };
            Employee[] employee = { employee1, employee2, employee3, employee4, employee5, employee6, employee7 };
            return employee;
        }

        public Employee[] GetAllByAge(Employee[] employee,int age)
        {
            
            return employee.Where(m=>m.age>age).ToArray();
        }

        public int GetCountByAge(Employee[] employee,int firstAge,int lastAge)
        {
            return employee.Where(m => m.age > firstAge && m.age < lastAge).Count();
        } 
        

        public int SumOfAges(Employee[] employee)
        {
            return employee.Sum(m => m.age);
        }



        public Employee[] GetByCheckedEmail(Employee[] employee,string str)
        {
            return employee.Where(m => m.email.StartsWith(str)).ToArray();
        }








    }




    
}
