using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_exercise
{
    class User
    {
        private string login = "LeraSavchuk";
        private string name = "Lera";
        private string surname = "Savchuk";
        private int age = 18;
        private const string date = "03.10.2022";

        public void Vivod()
        {
            Console.WriteLine($"Login: {login};\nName: {name};\nSurname: {surname};\nAge: {age};\nDate: {date};");
        }
    }
}