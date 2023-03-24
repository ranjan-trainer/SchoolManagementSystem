using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagmentSystemDomainLayer.Model
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string? StudentName { get; set; }
        public int? StandardId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
    }
}
