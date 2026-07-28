namespace Store_Online.Shared.Models
{
    public class PaginationModel
    {
        public int CurrentPage { get; set; } = 1;

        public int PageSize { get; set; } = 25;

        public int TotalRecords { get; set; }

        public int TotalPages =>
            TotalRecords == 0
                ? 1
                : (int)Math.Ceiling((double)TotalRecords / PageSize);

        public int StartRecord =>
            TotalRecords == 0
                ? 0
                : ((CurrentPage - 1) * PageSize) + 1;

        public int EndRecord =>
            Math.Min(CurrentPage * PageSize, TotalRecords);
    }
}