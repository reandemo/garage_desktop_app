namespace Store_Online.Shared.Helpers
{
    public static class PaginationHelper
    {
        public static List<T> GetPage<T>(
            IEnumerable<T> source,
            int currentPage,
            int pageSize)
        {
            if (source == null)
            {
                return new List<T>();
            }

            if (currentPage < 1)
            {
                currentPage = 1;
            }

            if (pageSize < 1)
            {
                pageSize = 25;
            }

            return source
                .Skip((currentPage - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }
    }
}