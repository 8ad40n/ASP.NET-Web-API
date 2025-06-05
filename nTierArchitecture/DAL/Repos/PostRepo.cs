using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    class PostRepo : Repo, IRepo<Post, int, Post>
    {
        public Post Create(Post obj)
        {
            throw new NotImplementedException();
        }

        public Post Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Post> Read()
        {
            throw new NotImplementedException();
        }

        public Post Read(int id)
        {
            throw new NotImplementedException();
        }

        public Post Update(Post obj)
        {
            throw new NotImplementedException();
        }
    }
}
