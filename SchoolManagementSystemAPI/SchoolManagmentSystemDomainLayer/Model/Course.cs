using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagmentSystemDomainLayer.Model
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string? CourseName { get; set; }
        [ForeignKey(nameof(Teacher))]
        public int TeacherId { get; set; }

        public virtual Teacher Teacher { get; set; }
    }
}
