using SchoolManagementSystemRepositoryLayer;
using SchoolManagmentSystemDomainLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystemServiceLayer
{
    public class StudentService : IStudentService
    {
        public SMSContext _smsContext;
        public StudentService(SMSContext smsContext) 
        { 
            _smsContext = smsContext;
        }
        public void AddStudent(Student student)
        {
            try
            {
                _smsContext.Add<Student>(student);
                _smsContext.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IList<Student>> GetStudentList()
        {
            IList<Student> students;

            try
            {
                await Task.Delay(1000);
                students = _smsContext.Set<Student>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return students;
        }
    }
}
