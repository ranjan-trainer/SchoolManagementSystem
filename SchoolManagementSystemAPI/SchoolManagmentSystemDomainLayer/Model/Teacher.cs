using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagmentSystemDomainLayer.Model
{
    public class Teacher
    {

        [Key]
        public int TeacherId { get; set; }
        public string? TeacherName { get; set; }
        public int? StandardId { get; set; }
        public int? TeacherType { get; set; }
    }
}
