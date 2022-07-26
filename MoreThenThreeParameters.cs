using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxProblem
{
    internal class MoreThenThreeParameters
    {
        private string ConcatenateText<T1, T2>(MyEntity myEntity)
        where T1 : Supplier, new()
        where T1 : Employee, new()
        where T2 : SupplierDepartment, new()
        where T2 : EmployeeDepartment, new()
        {
            T1 p = new T1();
            T2 r = new T2();
            //Code here for myEntity treatment
            return mystring;
        }
    }
}
