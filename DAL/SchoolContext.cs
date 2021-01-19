using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SMProject.DAL
{
    public class SchoolContext: DbContext
    {
        public SchoolContext():base ("name=SchoolDBConnectionString")
        {
            Database.SetInitializer<SchoolContext>(new DropCreateDatabaseIfModelChanges<SchoolContext>());

        }

        public System.Data.Entity.DbSet<SMProject.Models.Student> Students { get; set; }
    }
}