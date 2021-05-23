using BlogPosts.Contexts;
using BlogPosts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPosts.Data.Repositories
{
    public class PostRepository:BaseRepository<UserPost>,IPostRepository
    {
        public PostRepository(TEST1Context dbc) : base(dbc) { }

        public PagedList<UserPost> GetAllPosts(ClientParameters pageparams)
        {
            return PagedList<UserPost>.ToPagedList(
                 FindAll().OrderBy(x=>x.Id),
                 pageparams.PageSize,
                 pageparams.PageNumber
                );
        }
    }
}
