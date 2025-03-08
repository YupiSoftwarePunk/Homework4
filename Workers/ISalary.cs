using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Howemork4
{
    public interface ISalary
    {
        public string FIO { get; set; }
        static int WorkDays { get; }

        static int ManagerSalary { get; set; }

        static int DepartmentHeadSalary { get; set; }

        public string CalculateSalary();
    }
}
