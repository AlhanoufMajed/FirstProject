using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMProject.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }
		public int Gender { get; set; }
		public  string Level { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string ParentMobile { get; set; }
    }
}