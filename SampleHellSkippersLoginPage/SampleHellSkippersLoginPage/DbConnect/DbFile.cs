using SampleHellSkippersLoginPage.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SampleHellSkippersLoginPage.DbConnect
{
    public class DbFile :  DbContext
    {
        public DbSet<User> user { get; set; }
    }
}