using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac1
{
    class Program
    {
        static void Main(string[] args)
        {
            var conStr = @"Data Source=.\SBD\MSSQL; Initial Catalog=SKSasha; Integrated Security=True;";

            DataTable parentTable = new DataTable();
            DataTable childTable = new DataTable();
            DataColumn childColumn = childTable.Columns.Add("ChildColumn", typeof(int));
            DataColumn parentColumn = parentTable.Columns.Add("ParentColumn", typeof(int));
            parentTable.Cons

        }
    }
}
