using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homepractice.Models
{
    internal class Car
    {
        private string name;
        public string colar;
        protected int speed;

        private Car()
        {
            Console.WriteLine("Resad bey");
        }
        public Car(int a):this() 
        {
            
        }

    }
}
