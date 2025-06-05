using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    class CommentRepo : Repo, IRepo<Comment, int, Comment>
    {
        public Comment Create(Comment obj)
        {
            throw new NotImplementedException();
        }

        public Comment Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> Read()
        {
            throw new NotImplementedException();
        }

        public Comment Read(int id)
        {
            throw new NotImplementedException();
        }

        public Comment Update(Comment obj)
        {
            throw new NotImplementedException();
        }
    }
}
