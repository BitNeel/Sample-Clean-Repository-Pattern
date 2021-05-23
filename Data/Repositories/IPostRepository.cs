using BlogPosts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPosts.Data.Repositories
{
    public interface IPostRepository
    {
        PagedList<UserPost> GetAllPosts(ClientParameters pageparams);
    }
}
