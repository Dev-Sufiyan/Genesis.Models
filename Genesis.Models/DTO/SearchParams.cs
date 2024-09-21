using Genesis.Models.Enums;

namespace Genesis.Models.DTO
{
    public class SearchParams
    {
        public Pagination? Pagination { get; set; }
        public string OrderBy { get; set; } = string.Empty;
        public bool IsDescending { get; set; } = false;
        public List<SearchFilters>? Filters { get; set; }
        public JoinOperator JoinOperator { get; set; } = JoinOperator.JointAnd;
    }
}
