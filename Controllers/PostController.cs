using BlogPosts.Data;
using BlogPosts.Data.Repositories;
using BlogPosts.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPosts.Controllers
{
    [Route("api/post")]
    [ApiController]
    public class PostController:ControllerBase
    {
        private readonly IPostRepository _userPostRepo;
        public PostController(IPostRepository brepo)
        {
            _userPostRepo = brepo;
        }
        [HttpGet]
        public IActionResult GetAllPosts([FromQuery] ClientParameters pageparams)
        {
            PagedList<UserPost> result = _userPostRepo.GetAllPosts(pageparams);
            
            return Ok(result);
        }
    }
}
