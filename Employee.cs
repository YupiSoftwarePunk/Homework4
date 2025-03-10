using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Howemork4
{
    public struct Employee
    {

        public string Surname { get; set; }
        public string Name { get; set; }
        public string Secondname { get; set; }
        public string Job { get; set; }
        public int HireYear { get; set; }

        public string Info() => $"Имя: {Name}, Фамилия: {Surname}, Отчество: {Secondname}, Должность: {Job}, Год принятия на работу: {HireYear}";

        public string EmployeeExperience(int year) => $"Стаж работника: {year - HireYear}";


        public Employee(string surname, string name, string secondname, string job, int hireYear)
        {
            Surname = surname;
            Name = name;
            Secondname = secondname;
            Job = job;
            HireYear = hireYear;
        }
    }
}
