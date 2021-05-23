using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPosts.Data
{
    public class PagedList<T>
    {
        public int CurrentPage { get; private set; }
        public int PageSize { get; private set; }
        public int TotalPages { get; private set; }
        public int TotalCount { get; private set; }
        public List<T> Data { get; private set; }
        public bool HasNext => CurrentPage < TotalPages;
        public bool HasPrevious => CurrentPage > 1;

        public PagedList(List<T> items,int count, int pageSize,int pageNumber)
        {
            CurrentPage = pageNumber;
            PageSize = pageSize;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            TotalCount = count;
            Data = new List<T>(items);
        }

        public static PagedList<T> ToPagedList(IQueryable<T> entities, int pageSize, int pageNumber)
        {
            return new PagedList<T>(entities.Skip((pageNumber - 1) * pageSize)
                .Take(pageSize).ToList(),
                entities.Count(),
                pageSize,
                pageNumber
                );
        }
    }
}
