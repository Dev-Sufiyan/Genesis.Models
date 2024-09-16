using Genesis.Models.Enums;

namespace Genesis.Models.DTO
{
    public class SearchParam
    {
        public string Field { get; set; }
        public string Value { get; set; }
        public ComparisonOperator Comparator { get; set; }

        public SearchParam(string field, string value, ComparisonOperator comparator)
        {
            Field = field;
            Value = value;
            Comparator = comparator;
        }
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
