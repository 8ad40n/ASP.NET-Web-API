﻿using DAL.Interfaces;
using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<User, string, User> UserData()
        {
            return new UserRepo();
        }
        public static IRepo<Post, int, Post> PostData()
        {
            return new PostRepo();
        }
        public static IRepo<Comment, int, Comment> CommentData()
        {
            return new CommentRepo();
        }
    }
}
