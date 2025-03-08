using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Howemork4
{
    public class Manager : ISalary, Output2
    {
        public int WorkDays => _workDays;
        private static readonly int _workDays = 3;
        public string FIO { get; set; }

        public int ManagerSalary => _managerSalary;
        private static readonly int _managerSalary = _workDays * 1000;

        public string CalculateSalary() => $"Зарплата менеджера: {_managerSalary}";

        public string Print() => $"ФИО: {FIO}, Кол-во рабочих дней: {_workDays}, Зарплата: {CalculateSalary()}";
    }
}
