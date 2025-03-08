using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Howemork4
{
    public class Accounting : ISalary
    {
        public int WorkDays => _workDays;
        private static readonly int _workDays = 5;

        public string FIO { get; set; }

        public int DepartmentHeadSalary => _departmentHeadSalary;
        private static readonly int _departmentHeadSalary = _workDays * 2500;
        public string CalculateSalary() => $"Зарплата главы отдела: {_departmentHeadSalary}";

        public string IncomeTax(int a)
        {
            if (a == 5)
            {
                return $"Подоходный налог = {_departmentHeadSalary * 13 / 100}";
            }
            else if (a == 3)
            {
                return $"Подоходный налог = {(_workDays * 1000) * 13 / 100}";
            }
            else
            {
                return "error in IncomeTax";
            }
        }
    }
}
