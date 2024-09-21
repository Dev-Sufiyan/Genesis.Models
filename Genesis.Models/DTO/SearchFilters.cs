using Genesis.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genesis.Models.DTO
{
    public class SearchFilters
    {
        public string Field { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
        public ComparisonOperator Comparator { get; set; }

        public bool Validate(out string validationMessage)
        {
            validationMessage = string.Empty;

            if (string.IsNullOrEmpty(Field))
            {
                validationMessage = "Field cannot be null or empty.";
                return false;
            }

            if (string.IsNullOrEmpty(Value))
            {
                validationMessage = "Value cannot be null or empty.";
                return false;
            }

            if (!Enum.IsDefined(typeof(ComparisonOperator), Comparator))
            {
                validationMessage = "Invalid comparison operator.";
                return false;
            }

            return true;
        }
    }
}
