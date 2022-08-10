﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TravelBlogProject.Models.Classes
{
    public class Context : DbContext
    {
        public DbSet<Admin> Admins{ get; set; }
        public DbSet<AdresBlog> AdresBlogs{ get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Hakkımızda> Hakkımızdas { get; set; }
        public DbSet<Iletisim> Iletisims { get; set; }
        public DbSet<Yorumlar> Yorumlars { get; set; }

    }
}