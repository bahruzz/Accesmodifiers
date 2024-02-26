
using Homepractice.Helpers.Constans;
using Homepractice.Models;
using Homepractice.Services;
using System.Security.Cryptography.X509Certificates;

namespace Homepractice.Controllers
{
    internal class Employeecontroller
    {
        private readonly EmployeeService employeeService;

        public Employeecontroller()
        {
            employeeService = new EmployeeService();
        }
        public void GetAll()
        {
            
       


        var result = employeeService.GetAll();

            foreach (var item in result)
            {
                Console.WriteLine(item.name + " " + item.surName);
            }
        }


        public void GetAllByAge()
        {
            
            var employee = employeeService.GetAll();
            var result = employeeService.GetAllByAge(employee, 30);

            foreach (var item in result)
            
            {
                Console.WriteLine(item.name + " " + item.surName + " " + item.age);
            }
        }

        public void GetCountByAge()
        {
            Console.WriteLine("Add first age");
            int firstAge=int.Parse(Console.ReadLine());
            Console.WriteLine("Add last age");
            int lastAge=int.Parse(Console.ReadLine());

            int count=employeeService.GetCountByAge(employeeService.GetAll() ,firstAge,lastAge);
            Console.WriteLine(count);
        }

        public void GetSumOfAge()
        {
            int sumOfAge=employeeService.SumOfAges(employeeService.GetAll());
            Console.WriteLine(sumOfAge);
        }

        public void GetByCheckedEmail()
        {
            Console.WriteLine("Add your text");
            string str=Console.ReadLine();
            Employee[] employee =employeeService.GetAll();
            Employee[] checkedEmployee = employeeService.GetByCheckedEmail(employee, str);
            if (checkedEmployee.Count() == 0)
            {
                Console.WriteLine(ResponseMessages.NotFound);
                return;
            }
            foreach (var item in checkedEmployee)
            {
                Console.WriteLine(item.name+ " " + item.surName + " " + item.email);
            }
        }








    }
}
