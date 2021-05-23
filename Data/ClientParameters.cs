using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPosts.Data
{
    public class ClientParameters
    {
        private readonly int MAX_PAGE_SIZE = 10;
        private int _pageSize = 5;
        public int PageNumber { get; set; } = 1;

        public int PageSize { 
            get { return _pageSize; }
            set { _pageSize = value > MAX_PAGE_SIZE ? MAX_PAGE_SIZE : value; }
            }
    }
}
