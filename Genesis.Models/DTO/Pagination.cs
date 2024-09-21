namespace Genesis.Models.DTO
{
    public class Pagination
    {
        public int? CurrentPage { get; set; }
        public int RecordsPerPage { get; set; } = 10;
    }
}
