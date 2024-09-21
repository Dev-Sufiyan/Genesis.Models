using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genesis.Models.Enums
{
    public enum ComparisonOperator
    {
        Equal,                      // Represents equality (==)
        NotEqual,                   // Represents inequality (!=)
        GreaterThan,                // Represents greater than (>)
        GreaterThanOrEqual,         // Represents greater than or equal to (>=)
        LessThan,                   // Represents less than (<)
        LessThanOrEqual,            // Represents less than or equal to (<=)
        StartsWith,                 // Represents starts with (String.StartsWith)
        Contains,                   // Represents contains value (String.Contains)
        EndsWith,                   // Represents Ends with (String.EndsWith)
    }
}
