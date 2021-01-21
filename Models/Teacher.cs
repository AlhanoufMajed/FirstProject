using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SMProject.Models
{
	public class Teacher
	{
		public int Id { get; set; }
		[Required (ErrorMessage ="Enter Teacher Name")]
		[StringLength(50, ErrorMessage ="طول الاسم من ثلاثة إلى خمسين  ", MinimumLength =3)]
		[RegularExpression(@"^[\w\-. ]+$", ErrorMessage = "لايسمح باستخدام الرموز الخاصة")]

		[Display (Name= "Teacher Name")]
		public String Name { get; set; }
		[Required(ErrorMessage = "Enter Course Name")]
		public String Course { get; set; }
		[Required(ErrorMessage = "Enter number of courses")]
		[Range(1,5,ErrorMessage ="العدد تجاوز المجال المحدد من 1 إلى 5")]
		public int NumCourses { get; set; }
	}
}