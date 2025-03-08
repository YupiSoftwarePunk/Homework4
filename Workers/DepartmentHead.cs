using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Howemork4
{
    public class DepartmentHead : ISalary, Output2
    {
        public int WorkDays => _workDays;
        private static readonly int _workDays = 5;

        public string FIO { get; set; }

        public int DepartmentHeadSalary => _departmentHeadSalary;
        private static readonly int _departmentHeadSalary = _workDays * 2500;

        public string CalculateSalary() => $"Зарплата главы отдела: {_departmentHeadSalary}";

        public string Print() => $"ФИО: {FIO}, Кол-во рабочих дней: {_workDays}, Зарплата: {CalculateSalary()}";
    }
}
